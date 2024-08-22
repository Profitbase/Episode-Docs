# Create Excel file as byte array

Creates an Excel file from a [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) or [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) and serializes it as a `byte array`.

## Returns

Returns the Excel file serialized as a [byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte) [array](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays)

<br/>

## Properties

| Name                 | Type     | Description                                                                                                   |
| -------------------- | -------- | ------------------------------------------------------------------------------------------------------------- |
| Title                |          |                                                                                                               |
| Source               | Required | Select DataTable or DataReades.                                                              |
| Sheet name           | Optional | Specifies the name of the sheet to read data from. Defaults to the first sheet in the file if not specified.  |
| Column mapping       | Optional | Defines the mapping between Excel column letters and business object property names.                          |
| Worksheet formatting options | Optional |                                                                                                       |
| Byte array variable name | Optional |                                                                                                           |
| Description | Optional |  Additional notes or comments about the action or configuration. |

<br/>

### Automatic column mapping

Columns can be mapped automatically by using the "Map from sample file" option.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/getDataReaderEx2.png)
