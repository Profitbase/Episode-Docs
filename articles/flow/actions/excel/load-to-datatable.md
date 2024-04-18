# Load to DataTable

Loads the contents of an Excel sheet into memory as a [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable).

![img](../../../../images/flow/excel-load-to-datatable.png)

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| File contents    | Required  | The [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream) or [byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte) [array](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays) containing the Excel file raw data. |
| Worksheet name   | Optional  | The name of the worksheet to read data from. If you don't specify anything, data is read from the first worksheet in the file.  |
| Data start row   | Optional  | The index of the first row to read. If the worksheet has a header row, `Data start row` is typically `2`. |
| Column mapping   | Required  | Configure row object.                                  |
| Table variable name | Optional | The name of the DataTable variable returned from the action. |

## Returns

[DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) containing data from all rows and columns as specified by the `Data start row` and `Column mapping` properties.
