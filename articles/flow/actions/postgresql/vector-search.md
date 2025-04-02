# Vector search

Vector search in a PostgreSQL database.

## Properties  

| Name                         | Type      | Description                                                                                      |
| ---------------------------- | --------- | ------------------------------------------------------------------------------------------------ |
| Title                     | Optional  | The title or name of the action, helping to identify the search operation.                        |
| Connection                | Required  | The PostgreSQL database [connection](postgresql-connection.md) that will be used for the search. |
| Table / view              | Required  | The name of the table or view where the vector search will be performed.                         |
| Search text               | Required  | The input text string used to perform the vector search, typically representing a query.         |
| Entity settings           | Optional  | Defines the entity or object model used in the search process, ensuring structured search logic. |
| Maximum score             | Optional  | A threshold value (e.g., 0.7) that determines the minimum similarity score for search results.   |
| Vector search options     | Optional  | Configuration settings for vector search, including:                                             |
|                               |           | - Top: The maximum number of results to return.                                             |
|                               |           | - Skip: The number of initial results to ignore.                                            |
| Search result variable name | Optional | The name of the variable where the retrieved search results will be stored for further processing. |
| Description               | Optional  | A text field for providing additional details or notes about the vector search operation.       |
