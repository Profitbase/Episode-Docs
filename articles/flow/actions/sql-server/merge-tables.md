# Merge tables

Merges data from a SQL Server source table or view into a target table.  
This action provides a lightweight wrapper for the [Merge](https://learn.microsoft.com/en-us/sql/t-sql/statements/merge-transact-sql) statement in SQL Server. If you need to perform a complex MERGE statement, use the [Execute command](execute-command.md) action and write a custom MERGE statement. 



![img](https://profitbasedocs.blob.core.windows.net/flowimages/merge-tables.png)

## Properties

| Name         | Data type       | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title           |           |                        |
| Connection         | Required   | InVision SQL Server connection. |
| Source   | Required      | Select or enter source table/view to merge from. |
| Target table | Required  |  Select or enter target table name. |
| Merge configuration | Required  | Select or edit merge configuration.  |
| Result variable name | Required  | Name of the variable returning number of rows affected. |
| Command timeout (sec) | Optional | Command timeout in seconds.|
| Description   | Optional | Additional notes or comments about the action or configuration. |
