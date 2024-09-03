# Execute command

Executes n SQL command in a PostgreSQL database and returns the number of rows affected.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/flowimages/postgre-execute-command.png)

<br/>

## Properties

| Name                        | Type     | Description                                                                                      |
| --------------------------- | -------- | ------------------------------------------------------------------------------------------------ |
| Title                       | Optional | The title or name of the command.                                                                |
| Connection                  | Required | Select a database connection.                                                                    |
| SQL expression and parameters | Required | Enter the SQL query or command to execute along with any parameters.                             |
| Result variable name        | Optional | Name of the variable that will store the number of rows affected by the query.                   |
| Command timeout (seconds)   | Optional | Specify the time limit in seconds for the query execution before it times out.                    |
| Description                 | Optional | Any additional notes or information relevant to the execution command or the SQL operation.       |

<br/>
