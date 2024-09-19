# Get DataReader

Provides a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqldatareader) for reading a forward-only stream or rows from a Snowflake database.

## Properties

| Name         | Data type       | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title           | Optional | The title or name of the command.     |
| Connection         | Required   | The Snowflake connection. |
| Expression and parameters   | Required      | The query expression to execute along with any optional parameters.   |
| Reader variable name | Optional  | Name of the variable.  |
| Command timeout (sec) | Optional | The time limit for command execution before it times out. Default is 120 seconds.|
| Description   | Optional | Additional notes or comments about the action or configuration. |


## Returns

[IDataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader)