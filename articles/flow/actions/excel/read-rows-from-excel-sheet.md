# Read rows from Excel sheet

Iterates over rows in an Excel sheet. Each row is represented by a business object as defined by the `Column mapping` property.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/redrum.png)

<br/>

## Properties

<!--prettier-ignore-->
| Name              | Type      | Description                                                                                    |
| ----------------- | --------- | ---------------------------------------------------------------------------------------------- |
| Title             |           |                                                                                                |
| File contents     | Required  | Select the file contents (Stream or byte array).                                               |
| Sheet name        | Optional  | The name of the Worksheet to read data from. Defaults to the first worksheet if not specified. |
| Data start row    | Optional  | The row number of the first row to read. If the worksheet has a header row, `Data start row` is typically `2`.  |
| Column mapping    | Required  | Defines the mapping between Excel column letters and business object property names.           |
| Row variable name | Optional  | The name of the Row (business object) variable.                                                |
| Row data type     | Read-only | Displays the name of the data type (business object) that contains the data of the row.        |
| Description       | Optional  |                                                                                                |

<br/>

### Automatic column mapping

Columns can be mapped automatically by using the "Map from sample file" option.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/getDataReaderEx2.png)
