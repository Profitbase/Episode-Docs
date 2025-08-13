# For each row in Excel file

Iterates over rows in an Excel sheet. Each row is represented by a business object as defined by the `Column mapping` property.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/redrum.png)

<br/>

## Properties

<!--prettier-ignore-->
| Name              | Type      | Description                                                                                    |
| ----------------- | --------- | ---------------------------------------------------------------------------------------------- |
| Title                | Optional |   The title of the action.                    |
| File contents | Required       |  The contents of the file, provided as either a stream or a byte array. |
| Sheet name          | Optional | The name of the sheet(s) from which to read data. If you don't specify anything, data is read from the first sheet in the file. When specifying multiple sheets, use a semicolon to separate sheet names. In the rare case that a sheet name contains a semicolon, use square brackets around the sheet name.       |
| Data start row    | Optional  | The row number of the first row to read. If the worksheet has a header row, `Data start row` is typically `2`.  |
| Column mapping    | Required  | Defines the mapping between Excel column letters and business object property names.           |
| Row variable name | Optional  | The name of the Row (business object) variable.                                                |
| Row data type     | Read-only | Displays the name of the data type (business object) that contains the data of the row.        |
| Description       | Optional  |  Additional notes or comments about the action or configuration.  |

<br/>

### Automatic column mapping

Columns can be mapped automatically by using the "Map from sample file" option.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/getDataReaderEx2.png)


<br/>

[!INCLUDE [](./__videos.md)]