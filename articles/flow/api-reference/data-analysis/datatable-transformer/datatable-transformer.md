# DataTableTransformer

Modifies the schema and contents of a [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) by applying a sequence of transformations.

> [!NOTE]
> Remember to invoke ApplyAsync() in order for the transformation to be applied.

#### Example

This example shows how to transform a DataTable using the DataTableTransformer.

```csharp
var transformer = new DataTableTransformer(dataTable)
    .FillMissingValues("Age", FillMethod.Average)    
    .MergeColumns(["City", "Street"], "Address", separator: ", ")
    .ForEachRow(row =>
    {
        row["Name"] = row["Name"].ToString().ToUpper();
    })
    .AddColumn("AgeInMonths", "int")
    .ComputeColumn("AgeInMonths", row =>
    {
        var age = (int)row["Age"];
        return age * 12;
    })
    .RenameColumn("dob", "DateOfBirth")
    .RemoveColumn("email");

// Invoke ApplyAsync() to apply the transformations.
await transformer.ApplyAsync();

/*
Source table
| Name     | Age    | City        | Street            | Email                | dob        |
|----------|--------|-------------|-------------------|----------------------|------------|
| John     | 35     | London      | Brick Lane        | john@hypotesia.com   | 1979-07-12 |
| Jane     | NULL   | Huston      | Patterson Street  | jane@hypotesia.com   | 1992-05-23 |
| Luke     | 31     | Los Angeles | Victory Boulevard | luke@hypotesia.com   | 2003-06-12 |

Target table
| Name     | Age    | Address                        | AgeInMonths  | DateOfBirth    |
|----------|--------|--------------------------------|--------------|----------------|
| JOHN     | 35     | London, Brick Lane             | 420          | 1979-07-12     | 
| JANE     | 33     | Huston, Patterson Street       | 396          | 1992-05-23     | 
| LUKE     | 31     | Los Angeles, Victory Boulevard | 372          | 2003-06-12     |
*/

```

<br/>

## Methods
| Name                                                       | Description                                |
|------------------------------------------------------------|--------------------------------------------|
| AddColumn(string columnName, string dataType)              | Adds a new colum to the DataTable.         |
| CloneColumn(string columnToClone, string nameOfNewColumn)  | Clones an existing column, along with the data. |
| RemoveColumn(string columnName)                            | Removes a column from the DataTable.       |
| SplitColumn(string columnName, string[] splitInto, string separator, bool expand = false, trim = true) | Splits the value of a column into multiple other columns. Set expand to `true` to keep the source column in the DataTable. This operation can only be applied to columns having data type `string`.|
| MergeColumns(string[] columns, string toColumn, string separator = " ") | Merges two or more columns into a target column and removes the source columns. |
| ConcatColumns(string[] columns, string toColumn, string separator = " ") | Merges two or more columns into a target column **without** removing the source columns. | 
| RenameColumn(string oldName, string newName) | Renames a column. |
| ChangeColumnDataType(string columnName, string newDataType)| Changes the data type of a column to the specified data type. This operation will fail if the the values in the column is not convertible to the new data type. |
| SetColumnValue(string columnName, object value) | Assigns a value to all cells in the specified column. |
| RemoveRowsWithMissingValues(string columnName) | Removes all rows from the DataTable where the specified column has no value (null).  |
| FillMissingValues(string columnName, FillMethod fillMethod, object? value = null) | Assigns a value to all cells in the specified columns having no value (null). The specified FillMethod defines the value to be assigned to each empty cell. `value` is only used for `FillMethod.Value`. | 
| ForEachRow(Action<DataRow> action) | Performs an action for each row in the DataTable. |
| ComputeColumn(string columnName, Func<DataRow, object?> fn) | Invokes a function for each row in the DataTable and assigns the value returned to the specified column. |
| ApplyAsync()  | Applies the transformations. |


### Examples

#### SplitColumn(string columnName, string[] splitInto, string separator, bool expand = false, trim = true)

```csharp
var transformer = new DataTableTransformer(dataTable)    
    .SplitColumn("Address", ["City", "Street"], separator: ",");
await tranformer.ApplyAsync();
```

#### ConcatColumns(string[] columns, string toColumn, string separator = " ")

```csharp
var transformer = new DataTableTransformer(dataTable)    
    .ConcatColumns(["City", "Street"], "Address", separator: ", ");
await tranformer.ApplyAsync();
```

#### ChangeColumnDataType(string columnName, string newDataType)

```csharp
var transformer = new DataTableTransformer(dataTable)    
    .ChangeColumnDataType("Weight", typeof(double).FullName)
    .ChangeColumnDataType("IsStudent", "bool");
await tranformer.ApplyAsync();
```

#### FillMissingValues(string columnName, FillMethod fillMethod, object? value = null)

```csharp
var transformer = new DataTableTransformer(dataTable)    
    .FillMissingValues("Age", FillMethod.Average)
    .FillMissingValues("IsStudent", FillMethod.Value, value: true);
await tranformer.ApplyAsync();
```

#### ForEachRow(Action<DataRow> action)

```csharp
var transformer = new DataTableTransformer(dataTable)    
    .ForEachRow(row => row["IsAdult"] = (int)row["Age"] >= 18);
await tranformer.ApplyAsync();
```

#### ComputeColumn(string columnName, Func<DataRow, object?> fn)

```csharp
var transformer = new DataTableTransformer(dataTable)    
    .ComputeColumn("IsAdult", row => (int)row["Age"] >= 18);
await tranformer.ApplyAsync();
```