# Get DataReader for Parquet file

Provides a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) for reading a forward-only stream or rows form a Parquet file.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/flowimages/get-datareader.png)

<br/>

## Properties

| Name                 | Type     | Description                                      |
| -------------------- | -------- | ------------------------------------------------ |
| Title                |          |                                                  |
| File contents        | Required | Select the file contents (Stream or byte array). |
| Column mapping       | Required | Configure row object.                            |
| Reader variable name | Optional | The name of the DataReader variable.             |
| Description          | Optional |                                                  |

<br/>

### Column mapping:

![img](https://profitbasedocs.blob.core.windows.net/flowimages/column-mapping.png)
