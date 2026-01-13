# Create table from source

Creates a table from an existing table or view in a SQL Server database.

This action creates a copy of another table in a SQL Server database by coping its schema. Note that data is _not_ copied.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/create-table-from-source.png)


## Properties

| Name         | Type            | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title              | Optional        | A descriptive title for the action.               |
| Connection      | Required | The [SQL Server Connection](./connection.md).         |
| Dynamic connection | Optional | Use this option if you need to use a connection created by the [Create Connection](./create-connection.md) action. |
| Source Table | Required | Select or enter source table name. |
| Target table | Required | Select or enter target table name.  |
| Replace existing table | Optional |  Check if You want to replace the table or an error will be thrown if it already exists. |
| Copy Primary Key   | Optional | This will copy the primary key from Source to Target. |
| Copy Foreign Key(s) | Optional | This will copy any foreign keys from Source to Target. |
| Copy Index(es) | Optional | This will copy the any index from Source to Target. |
| Command timeout (sec) | Optional | The time limit for command execution before it times out. Default is 120 seconds.|
| Description   | Optional | Additional notes or comments about the action or configuration. |

<br/>

[!INCLUDE [](__videos.md)]