# Execute SQL Script returning DataPackage

Executes an [SQL Script](/articles/invision/docs/sqlscripts.md) in an InVision Solution that returns a DataPackage.

>[!NOTE]
> The SQL Script must take less than 5 minutes to complete.


<br/>

## Convert to .NET DataTable
To work with the data returned from the action, convert the result to a .NET DataTable using the [Convert DataPackage to DataTable](../convert-datapackage-to-datatable.md) action. The DataTable can then be used by other actions, such as [Function](../../built-in/function.md) for custom business logic, exporting to Excel, PDF, CSV, or Parquet, writing to databases like PostgreSQL or SQL Server, and more.

