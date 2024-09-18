# Read rows

Iterates over rows in a SQL Server database.



![img](https://profitbasedocs.blob.core.windows.net/flowimages/read-rows.png)

## Properties

| Name         | Data type       | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title           | Optional | The title or name of the command.     |
| Connection         | Required   | The SQL Server connection. |
| SQL expression and parameters   | Required      | The command to execute along with any parameters.   |
| Row to entity maping | Required  |   |
| Row variable name | Required  | Name of Row variable.  |
| Row data type | Optional  |   |
| Command timeout (sec) | Optional | The time limit for command execution before it times out. Default is 120 seconds.|
| Description   | Optional | Additional notes or comments about the action or configuration. |
