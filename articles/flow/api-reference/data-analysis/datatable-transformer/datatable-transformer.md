# DataTableTransformer

Modifies the schema and contents of a DataTable by applying a sequence of transformations.

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

// Invoke ApplyAsync to apply the transformations.
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
| SplitColumn(string columnName, string[] splitInto, string separator, bool expand = true) | Splits the value of a column into multiple other columns. Set expand to `false` to remove the source column from the DataTable. |
| MergeColumns()