# Load file to DataTable

Executes an SQL query on a PostgreSQL database and retrieves the result to a [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) object. This action is commonly used to load data from the database for further processing, allowing you to work with the data within your workflow. You can specify the SQL query to fetch data and the DataTable variable will store the resulting rows, making them accessible for other actions in your process.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/flowimages/postgre-load-dataTB.png)

<br/>


## Properties

| Name                        | Type     | Description                                                                                      |
| --------------------------- | -------- | ------------------------------------------------------------------------------------------------ |
| Title                       | Optional | The title or name of the action.                                                                 |
| Connection                  | Required | Select a database connection.                                                                    |
| SQL expression and parameters | Required | Enter the SQL query or command to execute along with any parameters.                             |
| Table variable name         | Optional | Name of the DataTable variable that stores the result of the query.                              |
| Command timeout (seconds)   | Optional | Specify the time limit in seconds for the query execution before it times out.                    |
| Description                 | Optional | Any additional notes or information relevant to the DataTable action.                            |
