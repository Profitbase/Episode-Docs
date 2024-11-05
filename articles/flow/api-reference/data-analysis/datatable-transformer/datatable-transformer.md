# DataTableTransformer

Modifies the rows and columns of a [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) by applying a sequence of one or more transformations.

#### Example

This example shows how to transform a DataTable using the DataTableTransformer.
The DataTableTransformer is retuned by calling the `UseTransform()` extension method on a DataTable.

```csharp

DataTable dataTable = ... // load the data table.

// Call the UseTransform() extension method on a DataTable instance to get an instance of DataTableTransformer
dataTable.UseTransform()
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
| AddColumn(string columnName, string [dataType](#data-types))              | Adds a new colum to the DataTable.         |
| CloneColumn(string columnToClone, string nameOfNewColumn)  | Clones an existing column, along with the data. |
| RemoveColumn(string columnName)                            | Removes a column from the DataTable.       |
| [SplitColumn(string columnName, string[] splitInto, string separator, bool expand = false, trim = true)](#splitcolumnstring-columnname-string-splitinto-string-separator-bool-expand--false-trim--true) | Splits the value of a column into multiple other columns. This operation can only be applied to columns having data type `string`. <br/> Set `expand` to `true` to keep the source column in the DataTable. <br/> Set `trim` to `false` to not trim whitespace from the split values. |
| MergeColumns(string[] columns, string toColumn, string separator = " ") | Merges two or more columns into a target column and removes the source columns. |
| [ConcatColumns(string[] columns, string toColumn, string separator = " ")](#concatcolumnsstring-columns-string-tocolumn-string-separator---) | Concatenates the values of two or more columns into a target column **without** removing the source columns. The values are separated by `separator`. | 
| RenameColumn(string oldName, string newName) | Renames a column. |
| [ChangeColumnDataType(string columnName, string newDataType)](#changecolumndatatypestring-columnname-string-newdatatype)| Changes the data type of a column to the specified data type. This operation will fail if the the values in the column is not convertible to the new data type. |
| SetColumnValue(string columnName, object value) | Assigns a value to all cells in the specified column. |
| RemoveRowsWithMissingValues(string columnName) | Removes all rows from the DataTable where the specified column has no value (null).  |
| [FillMissingValues(string columnName, FillMethod fillMethod, object? value = null)](#fillmissingvaluesstring-columnname-fillmethod-fillmethod-object-value--null) | Assigns a value to all cells in the specified columns having no value (null). The specified FillMethod defines the value to be assigned to each empty cell. `value` is only used for `FillMethod.Value`. | 
| [ForEachRow(Action<DataRow> action)](#foreachrowaction-action) | Performs an action for each row in the DataTable. |
| [ComputeColumn(string columnName, Func<DataRow, object?> fn)](#computecolumnstring-columnname-funcdatarow-object-fn) | Invokes a function for each row in the DataTable and assigns the value returned to the specified column. |


<br/>

### API Examples

The following examples shows how to use the different transform APIs. Remember that you only need to call `UseTransform()` once, and chain multiple transforms together.

##### AddColumn(string columnName, string dataType)

```csharp
dataTable.UseTransform().AddColumn("Address", "string");
```

##### SplitColumn(string columnName, string[] splitInto, string separator, bool expand = false, trim = true)

```csharp
// Create an instance of DataTableTransformer
new DataTableTransformer(dataTable).SplitColumn("Address", ["City", "Street"], separator: ",");

//  OR call the UseTransform() extension method
dataTable.UseTransform().SplitColumn("Address", ["City", "Street"], separator: ",");
```

##### ConcatColumns(string[] columns, string toColumn, string separator = " ")

```csharp
dataTable.UseTransform().ConcatColumns(["City", "Street"], "Address", separator: ", ");
```

##### ChangeColumnDataType(string columnName, string newDataType)

```csharp
dataTable.UseTransform()    
    .ChangeColumnDataType("Weight", typeof(double).FullName)
    .ChangeColumnDataType("IsStudent", "bool");
```

##### FillMissingValues(string columnName, FillMethod fillMethod, object? value = null)

```csharp
var transformer = dataTable.UseTransform()    
    .FillMissingValues("Age", FillMethod.Average)
    .FillMissingValues("IsStudent", FillMethod.Value, value: true);
```

##### ForEachRow(Action<DataRow> action)

```csharp
var transformer = dataTable.UseTransform()
    .ForEachRow(row => row["IsAdult"] = (int)row["Age"] >= 18);
```

##### ComputeColumn(string columnName, Func<DataRow, object?> fn)

```csharp
dataTable.UseTransform()    
    .ComputeColumn("IsAdult", row => (int)row["Age"] >= 18);
```

## Data types

The following data types are supported as `dataType` parameters.

| Name           |  
|----------------|
| string         |
| bool           |
| byte           |
| short          |
| int            |
| float          |
| double         |
| decimal        |
| long           |
| DateTime       |
| DateTimeOffset |
| DateOnly       |
| TimeOnly       |
| TimeSpan       |
| Guid           |

### Example

```csharp
dataTable.UseTransform().AddColumn("Email", "string").AddColumn("Weight", "double");
```
