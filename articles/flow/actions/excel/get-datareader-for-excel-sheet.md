# Get DataReader for Excel sheet

Provides a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) for reading a forward-only stream or rows from an Excel sheet.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/getDataReaderEx.png)

<br/>

## Properties

| Name                 | Type     | Description                                                                                                   |
| -------------------- | -------- | ------------------------------------------------------------------------------------------------------------- |
| Title                |  |                                                                                                               |
| File contents        | Required | Select the file contents (Stream or byte array).                                                              |
| Sheet name           | Optional | Specifies the name of the sheet to read data from. Defaults to the first sheet in the file if not specified.  |
| Data start row       | Optional | The row number of the first row to read. If the worksheet has a header row, `Data start row` is typically `2` |
| Column mapping       | Required | Defines the mapping between Excel column letters and business object property names.                          |
| Reader variable name | Optional |                                                                                                               |

<br/>

### Automatic column mapping

Columns can be mapped automatically by using the "Map from sample file" option.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/getDataReaderEx2.png)
