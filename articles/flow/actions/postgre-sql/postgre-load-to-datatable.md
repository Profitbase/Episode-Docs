# Load file to DataTable

Loads data from PostgreSQL database into memory as a [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) object.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/flowimages/postgre-execute-command.png)

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
