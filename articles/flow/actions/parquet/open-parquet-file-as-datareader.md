# Open Parquet file as DataReader

Provides a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) for reading a forward-only stream or rows form a Parquet file.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/flowimages/get-datareader.png)

<br/>

## Properties

| Name                 | Type     | Description                                      |
| -------------------- | -------- | ------------------------------------------------ |
| Title                |          |                                                  |
| File contents | Required       |  The contents of the file, provided as either a stream or a byte array. |
| Column mapping       | Required | Defines the mapping between Parquet column names and business object property names.                          |
| Reader variable name | Optional | The name of the DataReader variable.             |
| Description          | Optional |  Additional notes or comments about the action or configuration. |

<br/>

### Column mapping:

![img](https://profitbasedocs.blob.core.windows.net/flowimages/column-mapping.png)
