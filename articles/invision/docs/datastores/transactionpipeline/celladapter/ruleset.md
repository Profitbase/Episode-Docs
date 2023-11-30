
# Ruleset

The Ruleset table for the Cell Adapter component specifies the business rules used by the component to assign values to each row being processed. The table must have the following configuration:
<br/>

## Required Columns

*	**One or more columns for row matching**

In addition to the TypeID column which specifies the rule set category, you would need at least one column for row matching. The data type of this column needs to match the data type of the corresponding column of the Data Store being processed.

*	**One or more columns containing the values to assign to the generated rows.**

These columns contain the values to be assigned to the generated rows when the TypeID and row matching columns have been evaluated.
<br/>

## Optional Columns

*	**TypeID**  

Data type must be character-based, for example nvarchar(50).
A pipeline component iterates over the columns listed as Computation Source Columns in the component Input section and figures out which business rules to apply to generate output.
Normally, every column in the list will have a separate rule set, and the TypeID column is used for specifying the rule set name. If you want to apply the same rule set to multiple Computation Source Columns, the same Type Id value can be used for them all.

*	**Condition Expression Column** 

Data type must be character-based.
The Condition Expression column is used for dynamically evaluating the values of the row being processed to determine if output should be generated.
