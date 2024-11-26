# REST API Request with paging

Use Visma.Net REST [APIs](https://integration.visma.net/API-index/) to read paged data.  


The **REST API Request with Paging** action allows you to use the [Visma.Net](https://developer.visma.com/api/visma-net) REST APIs to retrieve large, paginated datasets. This action simplifies working with endpoints that return multiple pages of data, such as lists of customers, invoices, or accounting records. Pagination is handled automatically, allowing you to focus on processing the data.  

 <!-- TODO image.. -->

<br/>

## Properties

| Name            | Type     | Description                                                                                   |
|----------------- | -------- | -------------------------------------------------------------- |
| Title           | Optional | The title or name of the request.                         |
| Connection      | Required | Specifies the Visma.Net connection used for authentication with the REST API.         |
| Configuration   | Required | Defines the HTTP request to Visma.Net, including the method, URL, parameters, and return type.  |
| Start page      | Optional | The page to begin retrieving data from. Defaults to 1 (if not specified).                            |
| Items per page  | Optional | The number of items to retrieve per page. Defaults to 1000 (if not specified).                  |
| Max page count  | Optional | The maximum number of pages to fetch. Defaults to 9999 (if not specified).                      |
| Description     | Optional | Additional notes or comments about the action or configuration.                               |



## Returns  

The return type is configurable and can be:  
- A **custom data type**.  
- A raw JSON response from the API.  

For simplicity and debugging, use the built-in `HttpResponse<T>` type. It provides additional metadata, such as HTTP status codes, ensuring compatibility with Visma.Net API responses.  

To process the data effectively:  
1. Store the raw response in a data repository (e.g., database or cloud storage).  
2. Transform the stored data using tools like SQL, Python, or data transformation pipelines.  

<br/>

## Configuration  

### Setting Up a Request  

Requests to the Visma.Net API can be defined manually or by using predefined templates.  

#### Steps for Manual Configuration:  
1. **Method**: Specify the HTTP method (`GET`, `POST`, `PUT`, `DELETE`, etc.). Use `GET` for retrieving data.  
2. **URI**: Define the endpoint URL (e.g., `v1/project` or `v2/generalLedgerBalance`). Pass required parameters (e.g., IDs) as query parameters or in the request body.  
3. **Headers and Authorization**:  
   - Authentication is automatically set up from the connection settings.
   - Ensure proper encoding of any additional headers.  
4. **Response Type**: Use `HttpResponse<string>` by default for raw JSON responses. For large responses, this minimizes memory usage and improves performance.  

Refer to the [Visma.Net API documentation](https://integration.visma.net/API-index/) for endpoint-specific guidance.


<br/>

## Response Paging  

Visma.Net APIs often return paginated responses for large datasets. For example, list endpoints like `v2/project` or `v2/customer` include pagination metadata (e.g., `next`, `totalCount`).  

To handle paging:  
- Use the `next` link from the API response to fetch subsequent pages.  
- Repeat until no further pages are available.  

Ensure your API client or workflow can handle this iterative process effectively.  

<br/>

## API Limits  

Visma.Net APIs enforce rate limits to ensure fair usage and optimal performance. These limits may vary depending on the API endpoint, account type, or subscription plan. Exceeding these limits can result in temporary restrictions, such as delayed requests or HTTP 429 (Too Many Requests) responses. 

### Best Practices for Handling API Limits:  

- Implement additional retry mechanism.  
- Optimize queries to fetch only necessary data.  
- Monitor API usage to avoid hitting the limit during peak periods.  

For more information, visit the [Visma.Net API documentation](https://integration.visma.net/API-index/).  

By following these guidelines, you can integrate with the Visma.Net API efficiently and avoid common pitfalls.
