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
