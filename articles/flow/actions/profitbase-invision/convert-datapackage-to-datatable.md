# Convert DataPackage to DataTable

Converts an InVision DataPackage to a .NET [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable).

You can use this action to convert the data returned from an [InVision SQL Script returning data](./sql-script/execute-sql-script-returning-datapackage.md) action to a standard .NET DataTable.  
The DataTable can then be used by other actions, such as [Function](../built-in/function.md) for custom business logic, exporting to Excel, PDF, CSV, or Parquet, writing to databases like PostgreSQL or SQL Server, and more.

<br/>

## Properties

| Name               | Type          | Description                      |
|--------------------|---------------|----------------------------------|
| Source DataPackage | Required      | The DataPackage, typically returned from a [SQL Script returning data](./sql-script/execute-sql-script-returning-datapackage.md) action, to convert to a .NET DataTable.  |

<br/>

## Returns
Returns a .NET [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable).