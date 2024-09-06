# Check if table exists

Checks if a table with the specified name exists in a SQL Server database.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/check-if-table-exist.png)

## Properties

| Name         | Data type       | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title           | Optional | The title or name of the command.        |
| Connection    | Required   | The SQL Server connection. |
| Table name   | Required   | The name of a table. |
|Command timeout (sec) | Optional | The time limit for command execution before it times out. Default is 120 seconds.|
| Description   | Optional | Additional notes or comments about the action or configuration. |

## Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean) True if the table exists, otherwise false.
