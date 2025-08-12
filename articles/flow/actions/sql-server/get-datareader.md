# Get DataReader

Provides a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqldatareader) for reading a forward-only stream of rows from a SQL Server database.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/get-datareader-sql.png)

**Example** ![img](../../../../images/strz.jpg)  
This flow example shows a process that reads data from a database, splits records into multiple chunks, converts each chunk into CSV format, and appends it to a blob storage.  
Actions used in the flow are: SQL Server [Get DataReader](), [DataReader chunker](../built-in/datareader-chunker.md), [Create CSV file as byte array](../csv/create-csv-file-as-byte-array.md) and [Append to Blob](../azure-blob-storage/append-to-blob.md). 

## Properties

| Name         | Type            | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title           | Optional | The title or name of the command.     |
| Connection      | Required | The [SQL Server Connection](./connection.md).         |
| Dynamic connection | Optional | Use this option of you needs to use a connection from the [Create Connection](./create-connection.md) action. |
| SQL expression and parameters   | Required      | The command to execute along with any parameters.   |
| Reader variable name | Optional  | Name of the return variable.  |
| Command timeout (sec) | Optional | The time limit for command execution before it times out. Default is 120 seconds.|
| Description   | Optional | Additional notes or comments about the action or configuration. |


## Returns

[IDataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader)

<br/>

[!INCLUDE [](__videos.md)]