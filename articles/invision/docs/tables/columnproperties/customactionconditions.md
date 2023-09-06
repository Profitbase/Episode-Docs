---
title: "Custom Action Conditions"
metaKeys: "Custom Action conditions, custom context menu, IsEmailNotificationEnabled"
folderOnly: "false"
pageIndex: 5

---



![pic](https://profitbasedocs.blob.core.windows.net/images/customAction1.png)

<br/>

To specify whether a custom context menu action should be conditionally available, use the **Can Execute Condition** to specify an expression that returns true or false.

-	If no condition exists, the menu option is always visible and always enabled.
-	If the expression returns true, the menu option is enabled.
-	If the expression returns false, the menu option is disabled.


<br/>



>**Example** 
>
>The following example will enable a menu option if the Email field on the right click is specified, and if the Workbook variable “IsEmailNotificationEnabled” is true.

```
const {selectedRows, column, variables} = args;
// Check that the customer has a registered email, and that email notification is enabled
return selectedRows[0].EMail?.length > 0 && variables.IsEmailNotificationEnabled;
```


>**Example** 
>

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

![pic](https://profitbasedocs.blob.core.windows.net/images/customAction2.png)

<br/>
