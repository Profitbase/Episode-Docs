
## Unpivot

UNPIVOT performs the opposite operation to PIVOT by rotating columns of a table-valued expression into column values.

<br/>


| ... 	| **P01** 	| **P02** 	| **P03** 	| ... 	|
|-----	|---------	|---------	|---------	|-----	|
| ... 	| 100     	| 200     	| 300     	| ... 	|

<br/>


Unpivot to (example)

| ... 	| Amount 	| Transdate  	| ... 	|
|-----	|--------	|------------	|-----	|
| ... 	| 100    	| 2010.01.01 	| ... 	|
| ... 	| 200    	| 2010.02.01 	| ... 	|
| ... 	| 300    	| 2010.03.01 	| ... 	|


<br/>


### Columns
Specifies the non-pivoted columns. Together with any Scope columns, these values from these columns make up the key for each row produced by the Unpivot function.
<br/>

### Rows

Specifies the configuration for creating rows of data from source columns.
* **From**

 Specifies the column to unpivot

* **To**

 Specifies the column to receive the value from the Unpivot function

* **Scope**
  
 The Scope extends the Columns collection by specifying additional columns that add to the row key of each row produced by the unpivot function. 
 For example, suppose you are unpivoting a Data Store set up for periodic input for products to an Amount-Transdate format, and you want the produced rows to be keyed by the Transdate in addition to the ProductID, you would add the Transdate source column to the Scope collection of the unpivot configuration. Make sure that any Scope columns exist in the Transformation Result Columns collection to make them importable to the target Data Store. 
