
# Run WebFunctions from Workbooks

## Run Web Functions from a Workbook

There are two ways you can run Web Functions from a Workbook.

1. Use the **Execute Web Function** action. Recommended for most purposes.
2. Use the generic **Web Api** action if you need to run a Web Function that is a different Solution than the Workbook.

### Use the Execute Web Function action

The recommended way to run a Web Function is to use the **Execute Web Function** action from the Workbook Actions list as shown in the image below.  
<br/>
You need to do the following:

1. Drag and drop the action from the toolbox into the Actions list
2. Specify the name of the Web Function to run. In addition, you can also specify query parameters and a payload.

Use `Execute(...)` to specify the name of the Web Function to run. `Execute(...)` returns a response handle that you can use to get the value returned from the Web Function (see example below).

[Optional] Use `SetData(...)` to specify a payload. Then, in the Web Function implementation, use the `GetRequestBodyAsync` method to get the object.

[Optional] Use `SetQueryString(..)` to specify a query string. Then, in the Web Function implementation, use the `GetRequestQueryString` method to get the value.
<br/>

** Example**

![Run Web Function using the Execute Web Function action](https://profitbasedocs.blob.core.windows.net/images/Run_WebFunction_From_Workbook.png)

```javascript
SetData({ "CustomerId": "1234", "Name": "Hypotesia" });
SetQueryString("api_key=secret");
_response = Execute("UpdateCustomer");

// Use _response.Data to access the value returned from the Web Function in subsequent Workbook component actions.
```

#### Web Function implementation

The sample implementation below shows how to use the `GetRequestBodyAsync` and `GetRequestQueryString` methods to read the data and query string sent from the Workbook.

```csharp
namespace Custom.WebFunctions
{
    public record RequestMessage(string CustomerId, string Name);

    public sealed class MyWebFunction : WebFunction
    {
        public async Task<IActionResult> Run(HttpRequest request)
        {
            var apiKey = GetRequestQueryString(request, "api_key");
            // TODO: Use the api key to do authorization

        	var requestMessage = await GetRequestBodyAsync<RequestMessage>(request);

        	await this.SqlCommandService.ExecuteNonQueryAsync("UPDATE Customers SET Name = @name WHERE CustomerID = @customerId",
        		new SqlParameter("@name", requestMessage.Name),
        		new SqlParameter("@customerId", requestMessage.CustomerId));

            return await Task.FromResult(Ok("ello"));
        }
    }
}

```

<br/>
<br/>

### Use the generic Web Api action

If you need to run Web Functions that are in different Solutions than the Workbook, use the generic **WebApi Action**, paired with `HttpGet(…)`, `HttpPost(…)`, `HttpPut(…)`, `HttpPatch(…)` or `HttpDelete(…)` methods to configure the request.

All the Http methods returns a response handle that you can use to obtain any data returned from a Web Function once the WebApi action has completed. The response handle has a Data property that contains the actual data returned from the Web Function, for example a string, a business object, an array of objects and so on.

![pic](https://profitbasedocs.blob.core.windows.net/images/api.png)

<br/>

## Endpoints

<br/>

`api/solutions/{solutionId}/webfunctions/{web function name}`

Use this endpoint if you need to run a Web Function that is in a different Solution than the Workbook.

**Example**

```javascript
HttpPut("api/solutions/" + SYS.SolutionId + "/webfunctions/My_Web_Function1", {
  CustomerID: _selectedCustomer.ID,
  Name: Input_CustomerName.Value,
});
```

<br/>

`api/webfunctions/{web function name}`

You can use this endpoint if you have only one solution, or you know that no other web functions with the same name exists.

**Example**

```javascript
_responseHandle = HttpGet(
  "api/webfunctions/My_Web_Function2?customerId=" + _selectedCustomer.ID
);
```

<br/>

---

**Example**

This example shows how to call a Web Function from a Workbook by issuing a HTTP Put request.  
First, you need to invoke a WebApi Action. The WebApi Action is an action available on the Workbook Object itself.

In the WebApi Action instructions list, call the HttpPut method to configure the request with the url and payload.

**In the WebApi Action instructions list:**

```javascript
HttpPut("api/webfunctions/My_Web_Function1", {
  CustomerID: _selectedCustomer.ID,
  Name: Input_CustomerName.Value,
});
```

<br/>

**Example**

This example shows how to call a Web Function from a Workbook and read the data returned from the request.

Calling HttpGet(…) returns a handle that you can use obtain the data returned from the Web Function once the WebApi action completes. The response handle has a Data property that contains the data returned by the Web Function.

**In the WebApi Action instructions list:**

```javascript
_responseHandle = HttpGet(
  "api/webfunctions/My_Web_Function2?customerId=" + _selectedCustomer.ID
);
```

Once the WebApi action completes, the data returned by the Web Function is available from the Data property of the response handle.

So if the Web Function returns a customer object with a CustomerName property, you can get the customer name by simply accessing that property.

```javascript
ShowToastNotification("Customer Name", _responseHandle.Data.CustomerName);
```
