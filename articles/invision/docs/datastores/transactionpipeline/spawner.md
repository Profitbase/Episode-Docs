---
title: "Spawner"
metaKeys: "Spawner, transactions, filter, Ruleset,  "
folderOnly: "false"
pageIndex: 4
---


The Spawner component produces transactions based on source rows passing the filter and the business logic specified in the Spawner Ruleset. Based on the Ruleset, the Spawner may spawn zero or many rows from a single source row. 

<br/>

>**Example**
>
 >This example shows the result of passing a source row through the Spawner using a Ruleset specifying parameters for the spawning process.
>
>
 ><span style="color: blue;">Source Row</span>
>
>| EmployeeID 	| Transdate  	| Amount 	|
|------------	|------------	|--------	|
| 51         	| 2010.03.10 	| 500000 	|
>
><span style="color: blue;">Ruleset (snip)</span>
>
>| EmployeetID 	| TypeID         	| Value 	| Operator 	| AccountID   	|
|-------------	|----------------	|-------	|----------	|-------------	|
| ...         	| ...            	| ...   	| ...      	| ...         	|
| 51          	| EmployeeSalary 	| 0.25  	| \*       	| EmployerTax 	|
| 51          	| EmployeeSalary 	| 150   	| =        	| Misc        	|
>
><span style="color: blue;">Output</span>
>
>| EmployeeID 	| Transdate  	| Amount 	| AccountID   	|
|------------	|------------	|--------	|-------------	|
| ...        	| ...        	| ...    	| ...         	|
| 51         	| 2010.03.10 	| 125000 	| EmployerTax 	|
| 51         	| 2010.03.10 	| 150    	| Misc        	|

<br/>

If the Distributer is enabled, the Spawner will use the transaction(s) generated by the Distributer for spawning new transactions, meaning that the transaction date and computed value from the Distributer is used by the Spawner instead of resolving it from the actual source transaction in scope.
<br/>

### See Also

* [Input Configuration](spawner/inputconfig.md)

* [Ruleset](spawner/ruleset.md)

* [Output](spawner/output.md)