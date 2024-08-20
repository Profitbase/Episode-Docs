# Check if table exists

Checks if a table with the specified name exists in a SQL Server database.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/check-if-table-exist.png)

## Properties

| Name         | Data type       | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title           |           |                        |
| Connection    | Required   | InVision SQL Server connection. |
| Table name   | Required   | The name of a table. |
|Command timeout (sec) | Optional | Command timeout in seconds.|
| Description   |           |                  |

## Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean) True if the table exists, otherwise false.
