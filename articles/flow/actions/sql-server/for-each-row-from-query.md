# For each row from query

Iterates over the rows returned by a SQL Server database query.



![img](https://profitbasedocs.blob.core.windows.net/flowimages/read-rows.png)

## Properties

| Name         | Type            | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title           | Optional | The title or name of the command.     |
| Connection      | Required | The [SQL Server Connection](./connection.md).         |
| Dynamic connection | Optional | Use this option of you needs to use a connection from the [Create Connection](./create-connection.md) action. |
| SQL expression and parameters   | Required      | The command to execute along with any parameters.   |
| Row to entity maping | Required  | Mapping between column and daentity property including data typ.   |
| Row variable name | Required  | Name of Row variable.  |
| Row data type | Optional  | Name of the created entity type.  |
| Command timeout (sec) | Optional | The time limit for command execution before it times out. Default is 120 seconds.|
| Description   | Optional | Additional notes or comments about the action or configuration. |

<br/>

[!INCLUDE [](__videos.md)]