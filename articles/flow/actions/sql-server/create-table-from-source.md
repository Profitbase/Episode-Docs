# Create table from source

Creates a table from an existing table or view in a SQL Server database.

This action creates a copy of another table in a SQL Server database by coping its schema. Note that data is _not_ copied.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/create-table-from-source.png)


## Properties

| Name         | Data type       | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title           |  Optional | The title or name of the command.            |
| Connection         | Required   | The SQL Server connection. |
|Source Table | Required      | Select or enter source table name. |
| Target table | Required  | Select or enter target table name.  |
| Replace existing table   |           |                  |
| Copy Primary Key   |           |                  |
|  Copy Foreign Key(s)     |           |                  |
|    Copy Index(es)     |           |                  |
|Command timeout (sec) | Optional | The time limit for command execution before it times out. Default is 120 seconds.|
| Description   | Optional | Additional notes or comments about the action or configuration. |
