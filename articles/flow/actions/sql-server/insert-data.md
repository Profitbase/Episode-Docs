# Insert data

Inserts data into a SQL Server database from a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) or a [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) using bulk insert.


![img](https://profitbasedocs.blob.core.windows.net/flowimages/insert-data.png)

## Properties

| Name         | Data type       | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title           |           |                        |
| Connection | Required   | The SQL Server connection. |
| Source  | Required   |Select the source for data. |
| Destination table   | Required   | Select or enter the name of the table to insert info. |
| Batch size   | Optional   | Enter batch size. |
| Result variable name | Optional  | Name of the variable containing the number of rows affected.  |
| Command timeout (sec) | Optional | The time limit for command execution before it times out. Default is 120 seconds.|
| Description   | Optional | Additional notes or comments about the action or configuration.|
