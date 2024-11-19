# REST API Request

Use [PowerOffice Go REST APIs (v2)](https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/?urls.primaryName=Accounting%20Settings) to retrieve or write data.


## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Title  | Optional | The title or name of the request. |
| Connection | Required  | Select a connection. |
| Configuration | Required | Define configuration. |
| Description | Optional | Additional notes or comments about the action or configuration. |

## Overview  

The **PowerOffice REST API Request** action allows you to interact with PowerOffice APIs to read or write data. You can retrieve information such as customers, invoices, or accounting settings, or update records in the PowerOffice system using HTTP methods (`GET`, `POST`, `PUT`, `DELETE`, etc.).  

<br/>

## Returns  

The response from a PowerOffice API request can either be:  
- A **custom data type** defined in your workflow, or  
- The raw JSON response from the API.  

To maximize compatibility and performance, we recommend using the `HttpResponse<T>` type. This provides:  
- The raw response body.  
- Additional details such as the HTTP status code.  

For further processing, store the raw JSON response in a database or file storage, and use data transformation tools to convert it into the required format.  

<br/>

## Configuration  

### Defining a REST API Request  

1. **Method**: Choose the appropriate HTTP method for your request:  
   - `GET`: Retrieve data from PowerOffice (e.g., list customers or invoices).  
   - `POST`: Create new records (e.g., add a new invoice or customer).  
   - `PUT`: Update existing records (e.g., modify accounting settings).  
   - `DELETE`: Remove records (e.g., delete a customer or invoice).  

2. **URI**: Specify the endpoint for your request. For example:  
   - `customer`: To manage customer records.  
   - `invoice`: To work with invoices.  
   - `accountingSettings`: To manage accounting settings.  

3. **Headers**: Include the required authorization token and any additional headers. Example:  
   ```http
   Authorization: Bearer <access_token>
   Content-Type: application/json

4. **Parameters**: Add query or body parameters as required by the endpoint. Use variables or fixed values based on your workflow to customize the request and ensure it retrieves or updates the desired data.  

<br/>

### Response Type  

Use the default `HttpResponse<string>` to work with raw JSON data. This approach is especially recommended for large datasets as it minimizes memory usage and enhances performance.  

For detailed information on endpoints and parameters, refer to the [PowerOffice API documentation](https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/?urls.primaryName=Accounting%20Settings).  

<br/>

### API Limits  

PowerOffice enforces rate limits to maintain stable server performance. If you exceed these limits, the API will return a `429 Too Many Requests` error.  

#### Best Practices for Handling API Limits: 
 
- **Retry Mechanism**: Implement retries using an exponential backoff strategy.  
- **Request Optimization**: Fetch only the necessary data to minimize API calls.  
- **Usage Monitoring**: Track API usage to avoid hitting the limit during high-traffic periods.  

For more details, visit the [PowerOffice API documentation](https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/?urls.primaryName=Accounting%20Settings).  

<br/>

By following these guidelines, you can integrate with the PowerOffice API efficiently and avoid common pitfalls.

