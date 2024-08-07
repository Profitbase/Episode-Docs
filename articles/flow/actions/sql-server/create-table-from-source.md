# Create table from source

Creates a table from an existing table or view in a SQL Server database.

This action creates a copy of another table in a SQL Server database by coping its schema. Note that data is _not_ copied.

## Properties

| Name         | Data type       | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title           |           |                        |
| Connection         | Required   | InVision SQL Server connection. |
|Source Table | Required      | Select or enter source table name. |
| Target table | Required  | Select or enter target table name.  |
| Replace existing table   |           |                  |
| Copy Primary Key   |           |                  |
|  Copy Foreign Key(s)     |           |                  |
|    Copy Index(es)     |           |                  |
|Command timeout (sec) | Optional | Command timeout in seconds.|
|   Description   |           |                  |
