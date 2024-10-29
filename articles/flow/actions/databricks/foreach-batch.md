# Foreach Databricks batch

Connects to an Azure Databricks instance and retrieves data.

![img](../../../../images/flow/databricks.png)

## Returns

[IAsyncEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerable-1?view=net-8.0)<[IDataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader)>

## Properties

| Name              | Type       | Description                                             |
|-------------------|------------|--------------------------------------------------------|
| Connection        | Required   | Name of the Databricks connection.                     |
| Warehouse Id      | Required   | Id of the Databricks SQL Warehouse.                    |
| Catalog           | Optional   | Name of the Databricks catalog.                        |
| Schema            | Optional   | Name of the Databricks schema.                         |
| SQL expression    | Required   | Definition of the Databricks SQL command.              |
| Row variable name | Required   | Name of the variable containing the IDataReader result. |
