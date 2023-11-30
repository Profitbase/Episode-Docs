
# Input Configuration

## Relationship

Specifies the column mapping used for determining which rows from the source table gets processed by the Cell Adapter component when the pipeline is run. In addition to this mapping, the Cell Adapter Ruleset table may extend the filter by specifying a Condition Expression column containing a logical expression that determines if the row should be processed or not. The rows from the source table not passing the filtering step are ignored by the component.	

<br/>

## Computation Source Column(s)

Specifies the column(s) to unpivot (to a data-value pair) and write to the target. The Cell Adapter component will generate rows for each item defined in the list if the source row passes the filtering step. The number of rows generated from each source row depends on the number of matches found in the Ruleset table. The columns defined in this list must be **Time Frame Measure Columns** so they can be unpivoted and written as date-value pairs to the target.

**Properties:**

``Column Name``  
>Specifies the Time Frame Measure column to unpivot and write to the target.

``TypeId``  
>Specifies an identifier for the Computation Source Column that maps to a set of business rules in the Ruleset table. By default, the TypeId value is equal to the Column Name.  
>Suppose you have two Computation Source Columns, Forecast1, and Forecast2, and you want to use the same set of business rules for both of them, you can specify the same TypeId value for both of them and use that TypeId value in the Type ID column of the Ruleset table.

``No Commit``  
>Specifies whether no output row should be generated for the column by the Cell Adapter component.

``Value Expression (SQL)``  
>SQL expression for computing the value of the column when it's read from the database.

``Processing Condition (C#)``  
>Optional. A C# expression returning a boolean value (true/false) used for specifying whether to process the current input row for the Computation Source Column. You can use the **Condition Expression** methods as part of the Processing Condition expression. 




<br/>

## Additional columns

Additional columns is a list of columns that can be included in the output with the standard output. To output the additional columns, they need to be mapped to target columns in the **Additional Output** list of the Output configuration.

**Properties:**

``Column Name``  
>Specifies the name of the additional column to include in the output.

``Computed Column``  
>Allows specifying a custom column that does not exist in the source. When this feature is enabled, the Expression property must have a valid SQL statement that provides the value for the computed column.

``SQL Value Expression``  
>SQL expression for computing the value of the column when it's read from the database, for example, **substring** (AccountID,0,2).