# Get DataReader

Provides a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) for reading a foward-only stream of rows from CSV file.
The input can be either a byte array or a [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream).

This action is typically used when you need to import large CSV files to a database. The [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) can be used directly as input to actions such as the [SQL Server Insert Data](../sql-server/insert-data.md) action.

### Properties

| Name                     | Type           | Description                                                                                          |
|--------------------------|----------------|------------------------------------------------------------------------------------------------------|
| Title                    |                | An optional title for the action                                                                     |
| File contents source type| Required       | Specifies whether the data source is a Stream or a byte array.                                       |
| Data start row           | Required       | Specifies the index of the row where the data starts. If the file has a header row, the data start row is typically 2. If the files does not have a header row, the start row is usually 1. |
| [Column mapping](configuration-properties/column-mapping.md)           | Required       | The mapping between the field indices and field data types in the file, and the columns in the final data set. |
| [Data import options](configuration-properties/data-import-options.md)      | Optional       | Specifies options for error handling and how the contents of the file is parsed, such as date and number formattings. |
| [Field parser](configuration-properties/field-parser.md)             | Optional       | Provides a way to customize how field values are parsed during import.                             |
| DataReader variable name | Required       | The name of the variable you can use to reference the DataReader in other actions.                   | 