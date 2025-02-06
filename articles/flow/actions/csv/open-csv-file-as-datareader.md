# Open CSV file as DataReader

Provides a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) for reading a foward-only stream or rows from a CSV file.
The input can be either a byte array or a [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream).

This action is typically used when you need to import large CSV files to a database. The [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) can be used as input to actions such as the [SQL Server Insert Data](../sql-server/insert-data.md) action.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/getDataReaderCSV.png)

<br/>

### Properties

<!-- prettier-ignore-->
| Name                     | Type           | Description                                                                                          |
|--------------------------|----------------|------------------------------------------------------------------------------------------------------|
| Title                    |    |    |
| File contents | Required       |  The contents of the file, provided as either a [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream) or a byte array. |
| Data start row           | Optional | Specifies the index of the row where the data starts. If the file has a header row, the data start row is typically 2. If the files does not have a header row, the start row is usually 1. |
| [Column mapping](configuration-properties/column-mapping.md) | Optional       | The mapping between the field indices and field data types in the file, and the columns in the final data set. If you don't specify a column mapping, it is required that the first line in the file is a header record. Also, if you don't specify a column mapping, all fields will be read as `string`.  |
| [Data import options](configuration-properties/data-import-options.md)      | Optional       | Specifies options for error handling and how the contents of the file is parsed, such as dates and numbers. |
| [Field parser](configuration-properties/field-parser.md)             | Optional       | Provides a way to customize how field values are parsed during import.                             |
| DataReader variable name | Required       | The name of the variable you can use to reference the DataReader in other actions.                   | 
| Description | Optional       | Additional notes or comments that describe what the action does. |

<br/>

## Handling bad data

When importing data from a CSV format, you often get bad data in form of badly formatted values, missing fields, or simply unexpected values.
In a large data set, bad values may constitute a small amount of data, making them hard to track down. 
By enabling **Error handling** behaviors in the [Data import options](configuration-properties/data-import-options.md), you can record the bad data encountered during a CSV import and investigate which rows and fields prevent a successful import.

[Read about handling bad data here](bad-data.md)

>[!NOTE]
> If you don't specify `Column mappings`, or specify the data type of all columns as `string`, all values in the file will be read as `text` (string). No data conversion or formatting will be performed, so you will simply get the raw data in the file. 