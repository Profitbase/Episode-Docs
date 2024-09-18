# Read Excel file as DataTable

Loads the contents of an Excel sheet into memory as a [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable).

![img](../../../../images/flow/excel-load-to-datatable.png)


## Properties


| Name                | Type     |Description     |
| ------------------- | -------- | --------------------------------------------- |
| Title                |          |            |
| File contents       | Required | Select the file contents (Stream or byte array).      |
| Sheet name          | Optional | The name of the sheet(s) from which to read data. If you don't specify anything, data is read from the first sheet in the file. When specifying multiple sheets, use a semicolon to separate sheet names. In the rare case that a sheet name contains a semicolon, use square brackets around the sheet name.       |
| Data start row      | Optional | The row number of the first row to read. If the worksheet has a header row, `Data start row` is typically `2`.   |
| Column mapping      | Required | Defines the mapping between the `column letters` (A,B,C, etc) in a worksheet, and the `column names` (CustomerID, Amount, etc) in the target DataTable. |
| Table variable name | Optional | The name of the DataTable variable returned from the action. |
| Description | Optional | Additional notes or comments about the action or configuration. |

<br/>

### Automatic column mapping

Columns can be mapped automatically by using the "Map from sample file" option.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/getDataReaderEx2.png)

## Returns

[DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) containing data from all rows and columns as specified by the `Data start row` and `Column mapping` properties.
