# Get DataReader

Provides a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqldatareader) for reading a forward-only stream or rows from a SQL Server database.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/get-datareader-sql.png)

## Properties

| Name         | Data type       | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title           |           |                        |
| Connection         | Required   | InVision SQL Server connection. |
|SQL expression and parameters   | Required      | Enter SQL expression and optional parameters. |
| Reader variable name | Optional  | Name of the variable.  |
|Command timeout (sec) | Optional | Command timeout in seconds.|
|   Description   |           |                  |


## Returns

[IDataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader)