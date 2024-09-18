# Create Excel file as stream

Creates an Excel file from a [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) or [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) and returns the result as a [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream).

## Returns

Returns the Excel file as a [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream)

<br/>

## Properties

| Name                 | Type     | Description                                                                                                   |
| -------------------- | -------- | ------------------------------------------------------------------------------------------------------------- |
| Title                |          |                                                                                                               |
| Source               | Required | Select DataTable or DataReader.                                                              |
| Sheet name           | Optional | Specifies a worksheet name. |
| Column mapping       | Optional | Defines the mapping between Excel column letters and business object property names.                          |
| Worksheet formatting options | Optional |                                                                                                       |
| Byte array variable name | Optional |                                                                                                           |
| Description | Optional |  Additional notes or comments about the action or configuration. |

<br/>

### Automatic column mapping

Columns can be mapped automatically by using the "Map from sample file" option.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/getDataReaderEx2.png)
