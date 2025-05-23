# Open CSV file as DataReader

Provides a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) for reading a foward-only stream or rows from a CSV file.
The input can be either a byte array or a [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream).

This action is typically used when you need to import large CSV files to a database. The [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) can be used as input to actions such as the [SQL Server Insert Data](../sql-server/insert-data.md) action.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/getDataReaderCSV.png)

**Example** ![img](../../../../images/strz.jpg)  
The example above shows flow that can be used to read and process customer orders from a CSV file, applying two actions to each record (e.g., validating the order and updating inventory). Read more about [Function](../built-in/function.md) and [DataReader iterator](../built-in/datareader-iterator.md).

<br/>

### Properties
 
<!-- prettier-ignore-->
| Name                     | Type           | Description                                                                                          |
|--------------------------|----------------|------------------------------------------------------------------------------------------------------|
| Title                    | Optional        | A descriptive title for the action.                                                                  |
| File contents            | Required        | The contents of the file, provided as either a [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream) or a byte array. |
| Data start row           | Optional        | Specifies the index of the row where the data starts. If the file has a header row, the data start row is typically 2. If the file does not have a header row, the start row is usually 1. |
| [Column mapping](configuration-properties/column-mapping.md) | Optional | The mapping between the field indices and field data types in the file, and the columns in the final data set. If you don't specify a column mapping, it is required that the first line in the file is a header record. Also, if you don't specify a column mapping, all fields will be read as `string`. |
| [Data import options](configuration-properties/data-import-options.md) | Optional | Specifies options for error handling and how the contents of the file is parsed, such as dates and numbers. |
| Enable dynamic data import options | Optional | Indicates whether dynamic data import options should be used. |
| Dynamic data import options | Optional | A [JSON](json.md) object containing dynamic configuration for data import.     |
| [Field parser](configuration-properties/field-parser.md) | Optional | Provides a way to customize how field values are parsed during import. |
| DataReader variable name | Required        | The name of the variable you can use to reference the DataReader in other actions.                   |
| Description              | Optional        | Additional notes or comments that describe what the action does.                                    |


## Handling bad data

When importing data from a CSV format, you often get bad data in form of badly formatted values, missing fields, or simply unexpected values.
In a large data set, bad values may constitute a small amount of data, making them hard to track down. 
By enabling **Error handling** behaviors in the [Data import options](configuration-properties/data-import-options.md), you can record the bad data encountered during a CSV import and investigate which rows and fields prevent a successful import.

[Read about handling bad data here](bad-data.md)

<br/>

## Dynamic data import options



## Videos

#### Dump CSV file from Azure Blob container to Azure SQL table
This video demonstrates how to import all records from a CSV file into an Azure SQL table.  
In the demo, no data import options (such as data type conversion, number or date formatting) are specified, meaning the data is imported as raw text.  

![video](https://profitbasedocs.blob.core.windows.net/videos/Flow-Dump-CSV-file-to-Azure-SQL.mp4)

