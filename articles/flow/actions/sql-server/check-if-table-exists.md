# Check if table exists

Checks if a table exists in a SQL Server database.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/check-if-table-exist.png)

## Properties

| Name            | Type     | Description                                       |
|-----------------|----------|---------------------------------------------------|
| Title              | Optional        | A descriptive title for the action.               |
| Connection      | Required | The [SQL Server Connection](./connection.md).         |
| Dynamic connection | Optional | Use this option of you needs to use a connection from the [Create Connection](./create-connection.md) action. |
| Table name      | Required   | The name of a table to check for. |
| Command timeout (sec) | Optional | The time limit for command execution before it times out. Default is 120 seconds.|
| Description      | Optional  | Additional notes or comments about the action or configuration. |

## Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean) True if the table exists, otherwise false.
