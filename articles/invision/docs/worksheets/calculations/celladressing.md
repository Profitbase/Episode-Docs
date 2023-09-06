---
title: "Cell Addressing"
metaKeys: "Cell Addressing, column, Row selector expression, "
pageIndex: 4
---

To address a cell, you need to specify the name of the column, and optionally a row selector expression.  
If you do not specify a row selector expression, the right hand side expression will be evaluated for every cell in the column.

*	Use **@< column >[]** to address all cells in a column.

 >**Example**  
 ```
 @Amount[] = 10; will assign the value 10 to all cells in the Amount column.
 ```

*	Use **@< column >[expression]** to identify one or more cells.

 >**Example**  
 ```
 @Amount[AccountID = "N-3000"] = 10; will assign the value 10 to all cells in the  
 amount column where AccountID or the row equals the string N-3000.
 ```

**Row selector expression**

The Row selector expression specifies the condition for matching rows in a data set. The expression may return 0 or many rows.

The operands in an expression can be hard coded values, such as strings and numbers, column references and functions.

For example, a typical expression may look as follows, where **ItemID** and **RefID** are columns in the data set being processed. The expression matches all rows where **ItemID** equals **"NO-765-P"** and **RefID** starts with **"X"**.

**@SomeColumn[ItemID == "NO-765-P" && LEFT(RefID,1) == "X"].**


>**Example 1**  
This example shows how to select all cells in the Amount column where AccountID = 2000 and ProjectID is N-500
>
```
Amount[AccountID == "2000" && ProjectID == "N-500"]
```

>**Example 2**  
This example shows how to select all cells in the Amount column where AccountID = 2000 and ProjectID starts with N
>
```
@Amount[AccountID == "2000" && LEFT(ProjectID, 1) == "N"]
```


