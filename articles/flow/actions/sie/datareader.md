# Get SIE DataReader

Use this action to convert collections in the [SIEREsultOBject](./file-parser.md#result) to an [IDataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader).

![img](/images/flow/sie-datareader.png)

<br/>

**Example** ![img](/images/strz.jpg)

The example above shows how a SIE file is read from the [Fortnox REST API](../fortnox/get-sie-file-stream.md), and parsed with the [SIE file parser](./file-parser.md). From the parsed result object, an **SIE DataReader** action is then used to extract values that are then [inserted into an SQL Server table](../sql-server/insert-data.md).

<br/>

## Properties

| Name            | Type     | Description          |
|---------------- | -------- | ---------------------|
| Title           | Optional | The title or name of the action.  |
| Source          | Required | A Stream containing an **SIEResultObject**. |
| Convert type    | Required | The type of [collection](./file-parser.md#object-collections) to flatten. | 
| Max flatten depth | Optional | The maximum number of nested object levels to flatten into column. |
| Result variable name | Required | The name of the variable that contains the output from this action. | 
| Description     | Optional | Additional notes or comments about the action. |

## Returns

[IDataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader)
