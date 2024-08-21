# HTTP request

Executes an HTTP request. Use this action to call an HTTP API to run an operation and/or get data.

![img](/images/flow/http-request.png)

### Authentication

This request supports [Basic and OAuth2 Credential authentication](./http-authentication.md).

### Dynamic URLs

You can use Flow variables or [Workspace Variables](../../workspaces/workspace-variables.md) to create dynamic URLs.

![img](/images/flow/http-request-dynamic-url.png)

### Defining the request Body

Usually, all APIs using the `POST` or `PUT` HTTP methods accepts a body payload.  
The request body can be defined by either referencing a variable containing the entire body payload (for example an object returned from a [Function](../built-in/function.md)), or by defining the payload as a [JSON](https://en.wikipedia.org/wiki/JSON) object.

##### Defining the request body from a variable

To get the request body from a variable, it needs to be created first. In most cases, you can simply use a [Function](../built-in/function.md) to create and return the object that you want to send via the HTTP request. Note that the object you create must match the format in terms of structure, property names and data types that the HTTP API expects.

To use a variable as the body payload, simply switch to the `Body` tab and select the object from the variable selector. This will serialize the object and send it to the API when the Flow runs.

![img](/images/flow/http-request-body-variable.png)

##### Defining the request body by building a JSON object

You can manually construct the HTTP body by building a [JSON](https://en.wikipedia.org/wiki/JSON) object.

- A JSON object must begin with `{` and end with `}`.
- Property names must be quoted in double quotes.
- `String` and `date` values must be quoted in double quotes.
- Properties must be separated by commas.

When building the JSON object, you can combine hard-code values and variables as shown in the screenshot below.

> [!NOTE]
> You must remember to add quotes around `string` and `date` values, like shown with the `customerId`,`orderId`, and `productId` propperties below. Flow does not know which data type a property expects, so you will have to add quotes manually.

![img](/images/flow/http-request-body-json.png)

<br/>

### Response

An HTTP API can return information in multiple parts of a response. A HTTP response always has a [status code](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status) and one or more [headers](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers). When an HTTP API returns data, it is usually returned in the body, also known as the response `Content`. In some situations, APIs will return data in headers in addition to, or instead of, the body.

To this purpose, the `HTTP Request` action returns an HttpResponse&lt;T&gt; object which contains the information that an HTTP API might return. It is up to you to decide what to do with this information.

The HTTP Request action returns a HttpResponse object with the following properties:

```csharp
public sealed class HttpResponse<T> where T : class
{
    // Specifies whether or not the request succeeded. The status code is in the 200-299 range.
    public bool IsSuccess { get; set; }

    // The HTTP Status Code
    public int StatusCode { get; set; }

    // Response headers
    public Dictionary<string, List<string>> Headers { get; set; } = new Dictionary<string, List<string>>();

    // The content type, for example application/json, application/octet-stream, etc
    public string? ContentTypeName { get; set; }

    // The raw content returned from the HTTP API. This is either a string or a byte array.
    public T? Content { get; set; }
}
```

When calling an HTTP API, you must read the documentation for the API to learn how it replies to requests. Specifically, you need to understand the format of the response body (Content) so you can convert it to usable information on the receiving end, whether it be a Customer business object, a PDF file, or something else.

In the response tab, you can choose from the following respones types:

| Content type                          | Description                                                                                                                                                                                                                                                                                                                                                                                                                    |
| ------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| String                                | The string (text) format is usually used to represent complex business objects, (for example a Customer object), data sets, or simple values like text, numbers or dates. When an API returns business objects, it is usually returned in a [JSON](https://en.wikipedia.org/wiki/JSON) format. You can pass it through the [Convert](../built-in/convert.md) action to convert it to strongly typed objects you can work with. |
| Byte array                            | When an API returns a byte array, it usually represents the contents of a file. However, you must read the API docs to know what you are receiving.                                                                                                                                                                                                                                                                            |
| Byte array from base64 encoded string | Use this option if the API you are calling returns binary data as base64 encoded strings instead of raw binary format. By choosing this option, Flow will automatically convert the response to a byte array for you. Refer to the API documentation to determine if this option is appropriate.                                                                                                                               |

To convert the response body from its raw format to data you can work with (known as "deserialization"), you need to pass it through the [Convert](../built-in/convert.md) action and specify the data type that you want to deserialize it to.

#### Example

Suppose that an API returns a customer business object that you want to use in the business logic of your Flow.
The customer information has the following JSON format.

```json
{
  "customerId": 100198,
  "name": "Hypotesia",
  "vatNumber": 90012398
}
```

To convert the response from a string (text) to a business object, you must do the following:

1. Create a [custom data type](../../flows/defining-custom-types.md) for the Customer object. It must have the same structure, property names and data types as the JSON string above.

![img](/images/flow/http-request-example-define-custom-type.png)

2. In the Response tab of the HTTP Request action, choose `String` as the response type.

![img](/images/flow/http-request-example-response.png)

3. Add a [Convert](../built-in/convert.md) action after the HTTP Request action and use it to convert the `HttpResponse.Content` property to the customer object you defined in step 1.

![img](/images/flow/http-request-example-flow.png)

<br/>

![img](/images/flow/http-request-example-convert-content.png)
