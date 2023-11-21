
## Pivot

You can use the PIVOT and UNPIVOT feature to change a table-valued expression into another table. PIVOT rotates a table-valued expression by turning the unique values from one column in the expression into multiple columns in the output and performs aggregations where they are required on any remaining column values that are wanted in the final output. UNPIVOT performs the opposite operation to PIVOT by rotating columns of a table-valued expression into column values.

<br/>

### Grouping and Filtering

*	**Use Time Dimension for Grouping and Filtering**

 Specifies that the Time Dimension added to the Data Store can be used for filtering and grouping the result set from the data source. If you are not pivoting to a periodic format, or date/time is not needed to produce the pivot result, you do not need to enable this option.

*	**Date Column from source**

 Specifies the date column in the data source that the filtering should be applied to.

*	**Date Column alias**

 Only applicable in an Aggregate Transform. Specifies that you want to use a different name for Date Column from the source in the result set.

<br/>

### Columns
Specifies the non-pivoted columns in the PIVOT transform.

*	**Source Column**

 The name of the non pivoted column in the data source.

*	**Alias (Optional)**

 Specifies that you want to use a different name for the Source Column in the result set.

*	**Join – Join on**

 Enables joining on a table in the Data Store star schema to filter the rows from the data source and enabling aggregation relative to the table being joined on.

*	**Join – Match on**

 Specifies the column in the joined table to match with Source Column.

*	**Aggregate**

 Enables aggregating the result set from the JOIN relative to a column in the joined table.

*	**Aggregate – Aggregate to**

 Specifies the column in the joined table that the result set will be aggregated to.

*	**Aggregate – Include in result**

 Specifies whether the Aggregate to the column should be included in the result set of the Transform.

*	**Aggregate – Aggregate alias**

 Specifies that you want to use a different name for Aggregate to in the result set of the Transform.

<br/>

### Pivot Columns

Specifies the pivoted columns in the PIVOT transform.

* **Source**

   Specifies a column to pivot

   - Aggregation
  
   Specifies the aggregation function (SUM, AVG, COUNT, MIN, MAX)
  - Conditions

   Specifies one more conditions for filtering the rows to the pivoted column
   
<br/>

### Target

Specifies the target column of the pivot function.
