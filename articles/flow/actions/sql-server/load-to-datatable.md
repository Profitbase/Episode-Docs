# Load to DataTable

Loads data from a SQL Server database into memory as a [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) object.

## Returns

[DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable).

![img](https://profitbasedocs.blob.core.windows.net/flowimages/load-to-datatable.png)

## Properties

| Name         | Data type       | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title           |  Optional | The title or name of the command.     |
| Connection         | Required   | The SQL Server connection. |
| SQL expression and parameters   | Required      | The command to execute along with any parameters.   |
| Table variable name | Optional  |   |
| Command timeout (sec) | Optional | The time limit for command execution before it times out. Default is 120 seconds.|
| Description   | Optional | Additional notes or comments about the action or configuration. |
