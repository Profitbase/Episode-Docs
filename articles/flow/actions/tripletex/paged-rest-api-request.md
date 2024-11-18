# REST API Request with paging

Use Tripletex REST [APIs (v2)](https://tripletex.no/v2-docs/) to read paged data.  
**Purpose:** Designed to handle paginated data retrieval from APIs. It includes properties like Start index, Items per page, and Max page count, which are specifically for managing paginated responses.  
**Features:** Adds advanced controls for paginated requests, enabling users to specify the starting point, how many items to retrieve per page, and the maximum number of pages to fetch.

## Properties

| Name            | Type     | Description                                                                                   |
|----------------- | -------- | --------------------------------------------------------------------------------------------- |
| Title           | Optional | The title or name of the request.                                                             |
| Connection      | Required | The Tripletex Connection used to make an authenticated request to Tripletex REST API.         |
| Configuration   | Required | Specifies the HTTP request to the Tripletex API, including the HTTP method, URL, parameters, and return type. |
| Start index     | Optional | The starting point of the index for data retrieval. Defaults to 0 if not specified.           |
| Items per page  | Optional | The number of items to retrieve per page. Defaults to 5000 if not specified.                  |
| Max page count  | Optional | The maximum number of pages to fetch. Defaults to 9999 if not specified.                      |
| Description     | Optional | Additional notes or comments about the action or configuration.                               |
