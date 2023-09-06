---
title: "Context Menu Options Conditions"
metaKeys: "Context Menu Options conditions, write a condition, function,"
folderOnly: "false"
pageIndex: 5
---



![pic](https://profitbasedocs.blob.core.windows.net/images/contextMenu2.png)


<br/>

To specify whether a context menu option should be available, you have the following options:
-	**Yes**  
This means that the context menu option will always be available to all users. Some options may be disabled if it cannot be executed. For example, the Paste option will be disabled if there’s nothing on the clipboard.
-	**No**  
This means that the context menu option will not appear at all.
-	**Conditional**  
Use this option if an option needs to be conditionally available, for example, based on some Workbook variable or value in the cell or row that is clicked.

<br/>

#### How to write a condition

*	A condition is a function with a parameter called args. The args parameter contains information about 
    *	The row(s) that is currently selected, including the row that was right clicked. 
    *  The column that was right clicked.
    *	Any Workbook variables you have defined in addition to the variables provided by the system.
*	The function must return true or false. If true is returned, the menu option is enabled. If false is returned, the menu item is disabled.
*	args.selectedRows is an array containing one or more objects. An object has property names matching the columns in the source query, for example “AccountID”, “DepartmentID”, “Amount”, etc.  


**Example**

The following example will enable a menu option if the AccountID starts with 3 and Amount is greater than 100 000.

```
const {selectedRows, column, variables} = args
const row = selectedRows[0]
return row.AccountID?.startsWith("3") && row.Amount > 100000
```

**Example**

```
// Descructure the args parameter to it's easier to work with
// - selectedRows contains all the currently selected rows in the spreadsheet, including the row that was right clicked
// - column holds information about the column that was right clicked (use column.name)
// - variables contain all the Workbook variables provided by the system as well as those defined by you
const {selectedRows, column, variables} = args;

// Inspect args in the Browser DevTools console
console.log({args});

// Get the value of a Workbook variable
const myWorkbookVariable = variables.MyWorkbookVariable;

// Get information such as user name of the logged in user, workbook id, and solution id
const userName = variables.SYS.CurrentUserName;
const workbookId = variables.SYS.WorkbookId;
const solutionId = variables.SYS.SolutionId;

// Get the query string parameter "employeeId"
const employeeId = variables.QSP.employeeId;

// The condition must return true or false
return selectedRows[0].AccountID !== "1234" && selectedRows[0].Value > 200;
```

<br/>


![pic](https://profitbasedocs.blob.core.windows.net/images/contextMenu2.png)


<br/>


