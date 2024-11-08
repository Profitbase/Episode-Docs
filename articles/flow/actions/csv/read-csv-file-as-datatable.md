# Read CSV file as DataTable

Loads the contents of a CSV file into memory as a [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable).

This action is typically used when you need to import small to mid-sized CSV files to a database (< 250 000 rows). The [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) can be used as input to actions such as the [SQL Server Insert Data](../sql-server/insert-data.md) action.
<br/>

![img](https://profitbasedocs.blob.core.windows.net/flowimages/loadDT.png)

<br/>

## Properties

| Name                     | Type           | Description                                                                                          |
|--------------------------|----------------|------------------------------------------------------------------------------------------------------|
| Title                    | Optional       | A descriptive title for the action.                                                                  |
| File contents            | Required       | The contents of the file, provided as either a stream or a byte array.                              |
| Data start row           | Optional | Specifies the index of the row where the data starts. If the file has a header row, the data start row is typically 2. If the files does not have a header row, the start row is usually 1. |
| [Column mapping](configuration-properties/column-mapping.md) | Required       | The mapping between the field indices and field data types in the file, and the columns in the final data set. |
| [Data import options](configuration-properties/data-import-options.md)      | Optional       | Specifies options for error handling and how the contents of the file is parsed, such as dates and numbers. |
| [Field parser](configuration-properties/field-parser.md)             | Optional       | Provides advanced options to  handle parsing of field values during the import.                             |
| DataReader variable name | Required       | The name of the variable you can use to reference the DataTable in other actions.                   | 
| Description | Optional       | Additional notes or comments that describe what the action does. |

## Handling bad data

When importing data from a CSV format, you often get bad data in form of badly formatted values, missing fields, or simply unexpected values.
In a large data set, bad values may constitute a small amount of data, making them hard to track down. 
By enabling **Error handling** behaviors in the [Data import options](configuration-properties/data-import-options.md), you can record the bad data encountered during a CSV import and investigate which rows and fields prevent a successful import.

[Read about handling bad data here](bad-data.md)