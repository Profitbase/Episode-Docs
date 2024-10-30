# Foreach Databricks batch

Connects to an [Azure Databricks](https://learn.microsoft.com/en-us/azure/databricks/introduction/) instance and retrieves data.


<!-- (bit more descriptive) Connects to an [Azure Databricks](https://learn.microsoft.com/en-us/azure/databricks/introduction/) instance to execute batch processing on customer data. This action retrieves data from the specified Databricks SQL Warehouse, processes each customer record in sequence, and prepares it for further transformations or database insertion, enabling streamlined data handling for large-scale workflows.-->

![img](../../../../images/flow/databricks.png)

## Returns

[IAsyncEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerable-1?view=net-8.0)<[IDataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader)>

## Properties

| Name              | Type       | Description                                             |
|-------------------|------------|--------------------------------------------------------|
| Connection        | Required   | Name of the Databricks connection.                     |
| Warehouse Id      | Required   | Id of the Databricks SQL Warehouse.                    |
| Catalog           | Optional   | Name of the Databricks [catalog](https://learn.microsoft.com/en-us/azure/databricks/introduction/).  |
| Schema            | Optional   | Name of the Databricks schema.                         |
| SQL expression    | Required   | Definition of the Databricks SQL command.              |
| Row variable name | Required   | Name of the variable containing the IDataReader result. |
