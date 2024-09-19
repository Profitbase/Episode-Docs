# Read CSV file as DataTable

Loads the contents of a CSV file into memory as a [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable).

<br/>

![img](https://profitbasedocs.blob.core.windows.net/flowimages/loadDT.png)

<br/>

## Properties

| Name                     | Type           | Description                                                                                          |
|--------------------------|----------------|------------------------------------------------------------------------------------------------------|
| Title                    |    |    |
| File contents | Required       |  The contents of the file, provided as either a stream or a byte array. |
| Data start row           | Optional | Specifies the index of the row where the data starts. If the file has a header row, the data start row is typically 2. If the files does not have a header row, the start row is usually 1. |
| [Column mapping](configuration-properties/column-mapping.md) | Required       | The mapping between the field indices and field data types in the file, and the columns in the final data set. |
| [Data import options](configuration-properties/data-import-options.md)      | Optional       | Specifies options for error handling and how the contents of the file is parsed, such as date and number formattings. |
| [Field parser](configuration-properties/field-parser.md)             | Optional       | Provides a way to customize how field values are parsed during import.                             |
| DataReader variable name | Required       | The name of the variable you can use to reference the DataTable in other actions.                   | 
| Description | Optional       | Additional notes or comments about the action or configuration. |
