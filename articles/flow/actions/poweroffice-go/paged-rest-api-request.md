# REST API Request with paging

Use [PowerOffice Go REST APIs (v2)](https://developer.poweroffice.net) to retrieve paginated data.

The **REST API Request with Paging** action allows you to use the [PowerOffice Go REST APIs (v2)](https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net) to retrieve large, paginated datasets. This action simplifies working with endpoints that return multiple pages of data, such as lists of customers, invoices, or accounting records. Pagination is handled automatically, allowing you to focus on processing the data.  

![img](/images/flow/rest-api-paging-powerOff.png)  
<br/>

## Properties

| Name            | Type     | Description                                                                                   |
|----------------- | -------- | --------------------------------------------------------------------------------------------- |
| Title           | Optional | The title or name of the request.                              |
| Connection      | Required | The PowerOffice Connection used to make an authenticated request to PowerOffice REST API.         |
| Configuration   | Required | Specifies the HTTP request to the PowerOffice API, including the HTTP method, URL, parameters, and return type. |
| Start page     | Optional | The starting page of the data retrieval. Defaults to 1 if not specified.           |
| Items per page  | Optional | The number of items to retrieve per page. Defaults to 5000 if not specified.                  |
| Max page count  | Optional | The maximum number of pages to fetch. Defaults to 9999 if not specified.                      |
| Description     | Optional | Additional notes or comments about the action or configuration.                               |

<br>

## Returns  

The return type is defined when configuring the action. It can be a custom data type set by e.g. the template,or the raw JSON response from the API.  
We recommend using the built-in [HttpResponse&lt;T&gt;](../../api-reference/built-in-types/http-response.md) type because it will include additional information about the response, such as the HTTP status code and error(s).

We also recommend simply dumping the raw response to a data store, and then use data transformation tools to transform the data into a usable format. If you know the API returns small amounts of data (10 000 - 200 000 records), you can consider using the [Get JSON DataReader](../json/get-json-datareader.md) to flatten JSON to a tabular format and process the data as rows and columns, for example by inserting directly to a SQL Server table.

<br/>

## Configuration

To define a request to the PowerOffice Go REST API, you can start from a template, or define it manually.
If you press the `New Request` button in the Configuration dialog, you can choose from a set of predefined request templates.  

The PowerOffice Go REST API is large, so the template collection contains only a subset of the available APIs. If you cannot find a template for the request you want to make, you can refer to the [PowerOffice Go API documentation](https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net) and define the request manually.

![img](/images/flow/dynamics365-bc-new-request.png)


### Optional Query Parameters  

Specify query parameters to filter or customize the results. These can include:  

- **Filters**: Narrow down results based on criteria (e.g., date ranges or specific record types).  
- **Sorting**: Arrange results based on fields (e.g., ascending or descending order).  

Use variables or fixed values within your workflow to dynamically generate the parameters as needed.  

For a comprehensive guide to PowerOffice Go endpoints and parameter options, visit the [PowerOffice Go API documentation](https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net).  

<br/>

## Error handling

If the response from the PowerOffice Go request is set to [HttpResponse&lt;T&gt;](../../api-reference/built-in-types/http-response.md), the response object has a property IsSuccess. If false, the response has an ErrorContent property that relay the error messages from the API call or from internally thrown exceptions. 
For other response types and for severe errors, the action will raise an error that could terminate the Flow unless either the `On Error` port is connected, or it is wrapped in a [Try-Catch](../built-in/try-catch.md) action. 
The `On Error` error handler will be triggered for each `page error`, allowing you to handle errors individually and preventing Flow from automatically raising an error that might terminate the running process.

<br>

## API Limits  

PowerOffice Go enforces rate limits to ensure system stability. If you exceed these limits, the API will return a `429 Too Many Requests` error. 
The Action handles this by delaying calls and using retry. If retry limit is reached an error will be returned.

<br/>

## Workflow Example  

1. **Configure the Action**:  
   - Define the API endpoint, such as `customer` or `invoice`.  
   - Add any required query parameters, including filters or sorting options.  

2. **Handle the Response**:  
   - Process the data page-by-page, or store it for later transformation.  
   - If necessary, handle errors or retry logic within your workflow.  

3. **Post-Processing**:  
   - Use tools like SQL or Python to analyze and transform the retrieved data into a usable format.  

<br/>

By using the **REST API Request with Paging** action, you can effectively retrieve and handle large datasets from PowerOffice Go while adhering to best practices for performance and API compliance.
