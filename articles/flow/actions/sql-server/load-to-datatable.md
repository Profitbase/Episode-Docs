# Load to DataTable

Loads data from a SQL Server database into memory as a [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) object.

## Returns

[DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable).

![img](https://profitbasedocs.blob.core.windows.net/flowimages/load-to-datatable.png)

## Properties

| Name         | Type            | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title              | Optional        | A descriptive title for the action.               |
| Connection      | (Required) | The [SQL Server Connection](./connection.md).         |
| Dynamic connection | Optional | Use this option of you needs to use a connection from the [Create Connection](./create-connection.md) action. |
| SQL expression and parameters   | Required      | The command to execute along with any parameters.   |
| Table variable name | Required  | The name of the variable returning the DataTable  |
| Command timeout (sec) | Optional | The time limit for command execution before it times out. Default is 120 seconds.|
| Description   | Optional | Additional notes or comments about the action or configuration. |
