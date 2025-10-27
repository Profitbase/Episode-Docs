# Get DataReader

Provides a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqldatareader) for reading a forward-only stream of rows from a Google BigQuery database.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/bigquery-get-datareader.png)

<br/>

## Properties

| Name         | Data type       | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title           | Optional | The title or name of the command.     |
| Connection         | Required   | The Google BigQuery database connection. |
|SQL expression and parameters   | Required      | The command to execute along with any parameters.   |
| Reader variable name | Optional  | Name of the variable.  |
| Description   | Optional | Additional notes or comments about the action or configuration. |

<br/>

## Returns

[IDataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader)
