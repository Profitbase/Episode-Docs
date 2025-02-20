# Open Parquet file as DataReader

Provides a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) for reading a forward-only stream of rows form a Parquet file.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/flowimages/get-datareader.png)

<br/>

## Properties

| Name                 | Type     | Description                                      |
| -------------------- | -------- | ------------------------------------------------ |
| Title                |          |                                                  |
| File contents | Required        | The contents of the file, provided as either a stream or a byte array. |
| Column mapping       | Optional | Defines a mapping between columns in the Parquet file, and the output format of the reader. You can also define this option to skip columns from the Parquet file, typically when you don't want to read all the data from the file. | 
| Reader variable name | Optional | The name of the DataReader variable.             |
| Description          | Optional | Additional notes or comments about the action or configuration. |

<br/>

### Column mapping:

![img](https://profitbasedocs.blob.core.windows.net/flowimages/column-mapping.png)
