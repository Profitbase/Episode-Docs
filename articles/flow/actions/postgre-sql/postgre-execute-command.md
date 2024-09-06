# Execute command

Executes a command in a PostgreSQL database. This action is useful when you want to perform database operations such as updating, deleting, or inserting records. The command will execute the provided SQL statement and return the number of rows affected by the operation.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/flowimages/postgre-execute-command.png)

<br/>

## Properties

| Name                        | Type     | Description                                                                                      |
| --------------------------- | -------- | ------------------------------------------------------------------------------------------------ |
| Title                       | Optional | The title or name of the command.                                                                |
| Connection                  | Required | The PostgreSQL database connection.                                                                    |
| SQL expression and parameters | Required | The command to execute along with any parameters.                             |
| Result variable name        | Optional | The name of the variable that will store the number of rows affected by the query.                   |
| Command timeout (seconds)   | Optional | The time limit for command execution before it times out. Default is 120 seconds.                |
| Description                 | Optional | Any additional notes or information relevant to the execution command or the SQL operation.       |

<br/>

