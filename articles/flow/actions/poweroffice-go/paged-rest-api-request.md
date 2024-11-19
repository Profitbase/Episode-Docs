# REST API Request with paging

Use [PowerOffice Go REST APIs (v2)](https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/?urls.primaryName=Accounting%20Settings) to retrieve paginated data.


## Properties

| Name            | Type     | Description                                                                                   |
|----------------- | -------- | --------------------------------------------------------------------------------------------- |
| Title           | Optional | The title or name of the request.                                                             |
| Connection      | Required | The PowerOffice Connection used to make an authenticated request to PowerOffice REST API.         |
| Configuration   | Required | Specifies the HTTP request to the PowerOffice API, including the HTTP method, URL, parameters, and return type. |
| Start page     | Optional | The starting page of the data retrieval. Defaults to 1 if not specified.           |
| Items per page  | Optional | The number of items to retrieve per page. Defaults to 5000 if not specified.                  |
| Max page count  | Optional | The maximum number of pages to fetch. Defaults to 9999 if not specified.                      |
| Description     | Optional | Additional notes or comments about the action or configuration.                               |



## Overview  

The **REST API Request with Paging** action allows you to use the [PowerOffice Go REST APIs (v2)](https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/?urls.primaryName=Accounting%20Settings) to retrieve large, paginated datasets. This action simplifies working with endpoints that return multiple pages of data, such as lists of customers, invoices, or accounting records. Pagination is handled automatically, allowing you to focus on processing the data.  

<br/>

## Parameters  

Specify query parameters as required by the API endpoint to filter or customize the results. These can include:  
- **Paging Parameters**: Set options like `page` or `pageSize` to control the data returned per page.  
- **Filters**: Narrow down results based on criteria (e.g., date ranges or specific record types).  
- **Sorting**: Arrange results based on fields (e.g., ascending or descending order).  

Use variables or fixed values within your workflow to dynamically generate the parameters as needed.  

<br/>

## Response Type  

The action processes paginated responses, returning:  
- **Raw JSON data** for each page of results.  
- **Pagination Metadata**, such as:  
  - `next`: A link to the next page of data.  
  - `totalCount`: The total number of records available.  

We recommend storing the raw JSON responses in a database or file storage for post-processing using tools like SQL, Python, or data transformation platforms.  

For a comprehensive guide to PowerOffice Go endpoints and parameter options, visit the [PowerOffice API documentation](https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/?urls.primaryName=Accounting%20Settings).  

<br/>

## API Limits  

PowerOffice Go enforces rate limits to ensure system stability. If you exceed these limits, the API will return a `429 Too Many Requests` error.  

### Best Practices for Handling API Limits  
- **Retry Mechanism**: Implement retries with exponential backoff to handle rate-limit errors gracefully.  
- **Optimize Requests**: Fetch only the necessary data to minimize API calls.  
- **Monitor Usage**: Track API usage metrics to avoid hitting rate limits during high-traffic operations.  

For more details about rate limits and error handling, refer to the [PowerOffice API documentation](https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/?urls.primaryName=Accounting%20Settings).  

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
