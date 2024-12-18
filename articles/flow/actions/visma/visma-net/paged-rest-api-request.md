# REST API Request with paging

Use [Visma.Net REST APIs](https://integration.visma.net/API-index/) to read paged data.  


The **REST API Request with Paging** action allows you to use the [Visma.Net](https://developer.visma.com/api/visma-net) REST APIs to retrieve large, paginated datasets. This action simplifies working with endpoints that return multiple pages of data, such as lists of customers, invoices, or accounting records. Pagination is handled automatically, allowing you to focus on processing the data.  You can offcourse use it for none-paged requests also.

 <!-- TODO image.. -->

<br/>

## Properties

| Name            | Type     | Description                                                                                   |
|----------------- | -------- | -------------------------------------------------------------- |
| Title           | Optional | The title or name of the request.                         |
| Connection      | Required | Specifies the Visma.Net connection used for authentication with the REST API.         |
| Configuration   | Required | Defines the HTTP request to Visma.Net, including the method, URL, parameters, and return type.  |
| Company Id      | Optional | The Company Id to request data from. Default company can be set in the connection.        |
| Start page      | Optional | The page to begin retrieving data from. Defaults to 1 (if not specified).                            |
| Items per page  | Optional | The number of items to retrieve per page. Defaults to 1000 (if not specified).                  |
| Max page count  | Optional | The maximum number of pages to fetch. Defaults to 9999 (if not specified).                      |
| Description     | Optional | Additional notes or comments about the action or configuration.                               |

<br>

## Returns  

The return type is defined when configuring the action. It can be a custom data type set by e.g. the template,or the raw JSON response from the API.  

For templated requests returning a single item, the return type is an Entity. E.g. v1\Customer\12345 returns a CustomerDTO entity.
For API returning collections, the default return value is [HttpResponse&lt;T&gt;](../../../api-reference/built-in-types/http-response.md). This contains the result as a JSON string and the Status and any errors of the request.

We also recommend simply dumping the raw response to a data store, and then use data transformation tools to transform the data into a usable format. If you know the API returns small amounts of data (10 000 - 200 000 records), you can consider using the [Get JSON DataReader](../../json/get-json-datareader.md) to flatten JSON to a tabular format and process the data as rows and columns, for example by inserting directly to a SQL Server table.

<br/>

## Configuration  

To define a request to the Visma.Net REST API, you can start from a template, or define it manually.
If you press the `New Request` button in the Configuration dialog, you can choose from a set of predefined request templates.  

### Steps for Manual Configuration:  
1. **Method**: Specify the HTTP method (`GET`, `POST`, `PUT`, `DELETE`, etc.). Use `GET` for retrieving data.  
2. **URI**: Define the endpoint URL (e.g., `v1/project` or `v2/generalLedgerBalance`). Pass required parameters (e.g., IDs) as query parameters or in the request body.  
3. **Headers and Authorization**:  
   - Authentication is automatically set up from the connection settings.
   - Ensure proper encoding of any additional headers.  
4. **Response Type**: Use `HttpResponse<string>` by default for raw JSON responses. For large responses, this minimizes memory usage and improves performance.  

Refer to the [Visma.Net API documentation](https://integration.visma.net/API-index/) for endpoint-specific guidance.


<br/>

## Error handling

If the response from the Visma.Net request is set to [HttpResponse&lt;T&gt;](../../../api-reference/built-in-types/http-response.md), the response object has a property IsSuccess. If false, the response has an ErrorContent property that relay the error messages from the API call or from internally thrown exceptions. 
For other response types and for severe errors, the action will raise an error that could terminate the Flow unless either the `On Error` port is connected, or it is wrapped in a [Try-Catch](../../built-in/try-catch.md) action. 
The `On Error` error handler will be triggered for each `page error`, allowing you to handle errors individually and preventing Flow from automatically raising an error that might terminate the running process.

<br>

## API Limits  

Visma.Net APIs enforce rate limits to ensure fair usage and optimal performance. If you exceed these limits, the API will return a `429 Too Many Requests` error. 
The Action handles this by delaying calls and using retry. If retry limit is reached an error will be returned.
