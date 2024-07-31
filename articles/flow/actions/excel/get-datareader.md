# Get DataReader

Provides a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) for reading a forward-only stream or rows from an Excel sheet.


![img](https://profitbasedocs.blob.core.windows.net/flowimages/getDataReaderEx.png)

<br/>


## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Title  | Optional |        |
| File contents | Required  | Select the file contents (Stream or byte array). |
| Worksheet name | Optional | Select or enter Worksheets name. |
| Data start row | Optional |  |
| Column mapping | Required | Configure row object. |
| Reader variable name | Optional |  |
| Reader variable name | Optional |  |

<br/>

### Automatic column mapping

Columns can be mapped automatically by using the "Map from sample file" option.


![img](https://profitbasedocs.blob.core.windows.net/flowimages/getDataReaderEx2.png)