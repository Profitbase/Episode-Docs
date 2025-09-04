# Insert rows

Inserts rows into a PostgreSQL database from a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) or a [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) using bulk insert.

![img](../../../../images/flow/postgresql-insert-data.png)

**Example** ![img](../../../../images/strz.jpg)  
This flow loads customer data and then inserts it into a PostgreSQL table.

## Properties

| Name         | Data type       | Description                                       |
|--------------|-----------------|---------------------------------------------------|
|  Title | Optional | The name of the action. |
| Connection | Required   | The PostgreSQL database [connection](postgresql-connection.md). |
| Source  | Required   |Select the source for data. |
| Destination table   | Required   | Select or enter the name of the table to insert info. |
| Description   | Optional | Additional notes or comments about the action or configuration.|
