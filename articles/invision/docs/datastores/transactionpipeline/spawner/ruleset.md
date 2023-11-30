
# Ruleset

The Ruleset table for the Spawner component contains the business rules used for spawning rows from the current source row context (data source or Distributer result set). As an example, the contents of the Ruleset table may look like this:
<br/>

| ProductID 	| TypeID    	|  Value 	| Operator 	| Condition                                                    	| AccountID 	|
|-----------	|-----------	|--------	|----------	|--------------------------------------------------------------	|-----------	|
| …         	| …         	| …      	|  …       	|  …                                                           	| …         	|
|  51       	| YearTotal 	| 1000   	| =        	| ProjectID == "P-1000" && CurrentPeriodValue`<decimal>()< 1000` 	| A1000     	|
| 51        	| YearTotal 	| 0.3    	| \*       	| ProjectID == "P1000" && CustomerID == "C-500"                	| A7000     	|

<br/><br/>

**You can read the table / configuration above as follows:**

*For the source row currently being processed:*

1.	*If the source row column mapped to ProductID equals 51, and the source row ProjectID equals "P-1000" and the (YearTotal) value currently being processed is less than 1000, then return 1000.*

2.	*If the source row column mapped to ProductID equals 51, and the source row ProjectID equals "P-100" and source row CustomerID equals "C-500", then multiply the current value (YearTotal) by 0.3 and return the value.*
<br/>

## Properties:

*	**Use Custom Calculation Expression**

 When this mode is enabled, the column designated as the Value column is expected to contain a valid C# expression that returns the (numeric) value of the generated row. If this mode is enabled, you should not configure an Operator Type column in the table. It will be ignored.

*	**Type Id Column (Optional)**

 Data type must be character based, for example nvarchar(50).

 A pipeline component iterates over the columns listed as Computation Source Columns in the component Input section and figures out which business rules to apply for generating output.

 Normally, every column in the list will have a separate rule set, and the TypeID column is used for specifying the rule set name. If you want to apply the same rule set to multiple Compuration Source Columns, you can use the same Type Id value for those columns.

 For example, if you want do process "YearTotal", and "NextYearTotal" the Type Id column of the Rulset would normally contain rows where the TypeId Column is "YearTotal" and "NextYearTotal" (in addition to any other Relationship keys). If, however, you wanted to use the same business rule for both of the columns, you could just use a common value for both the "YearTotal" and "NextYearTotal" columns.

*	**Value Column**

 Specifies the column in the Ruleset table used for computing the value of the Value column of the spawned row. When computing the value, the Operator column specifies which operator to apply to the context for calculating the value. 

*	**Operator Type Column**

 Specifies the column in the Ruleset table that contains the operator used for computing the value of the Value column. If the operator is ‘=’, the value of the Ruleset column is copied to the Value column or the spawned row.

 For any other operator, the value of the Value column of the spawned row is computed by applying the operator to the source value and the Ruleset value.

 Note! If "Use Custom Calculation Expression" is enabled, this setting is ignored.

*	**Condition Expression Column (Optional)**

 Condition Expression Column – data type must be character based.

 The Condition Expression column is used for dynamically evaluating the values of the row being processed to determine if an output should be generated.
