# Get SQL execution chunks

Retrieves chunks of data from [Databricks](https://www.databricks.com/databricks-documentation) and iterates over them. The chunks are fetched by calling the [Execute SQL statement](https://docs.databricks.com/api/azure/workspace/statementexecution/executestatement) API.

![img](../../../../images/flow/databricks.png)

## Returns

As this node iterates over all chunks, it will return a new [IDataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) instance for each chunk.

## Properties

| Name              | Type       | Description												|
|-------------------|------------|----------------------------------------------------------|
| Connection        | Required   | Name of the Databricks connection.						|
| Warehouse Id      | Required   | Id of the Databricks SQL Warehouse.						|
| Catalog           | Optional   | Name of the Databricks [catalog](https://learn.microsoft.com/en-us/azure/databricks/introduction/).  |
| Schema            | Optional   | Name of the Databricks schema.							|
| SQL expression    | Required   | Definition of the Databricks SQL command.				|
| Chunk size		| Optional   | Number of rows in a chunk (default = 1000).				|
| Row variable name | Required   | Name of the variable containing the DataReader result.	|
