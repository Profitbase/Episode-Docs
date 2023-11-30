# SetIf function

<br/>

```
SetIf(condition : boolean | Eaze expression, value : object | Eaze expression, levelNum : number | Eaze expression)
```
**SetIf(…)** is used in SetFilterValue actions for conditionally setting a new selected value for the filter, for example when a custom context menu item or Action Link Column is clicked.
<br/>

## Parameters
<br/>

``condition``

>Boolean value (true/false) or Eaze expression that evaluates to true/false to determine whether the new value should be set as the selected filter value. The expression must evaluate as true or false.


``value``

>Object (text, number, date) or Eaze expression that is evaluated to resolve the value set as the selected filter value.


``levelNum``

>When setting a filter value using the Set(…) function, InVision checks that the requested filter value exists in the data source of the filter. If the value is not found, the request is ignored. This means that if the filter value is being set for a hierarchical filter, you need to specify the level at which the value exists. If the levelNum expression is not defined, the value is expected to be found at the leaf level.

<br/>

## Example

>This example shows how to set the selected value of the filter to the value of the DepartmentID of a row that was clicked or right-clicked in a Worksheet or Report.

```
Set(@Event.Data.DepartmentID); // Value of DepartmentID is found at leaf level
Set(@Event.Data.DepartmentID, 3); // Value of DepartmentID is found at level 3
```


>The following statement sets the selected value of the filter if the Action name (of the custom context menu item) is "MyCustomAction".

```
SetIf(@Event.Sender.ActionName == "MyCustomAction", @Event.Data.DepartmentID);
``` 


>The following statement sets the selected value of the filter if the name of the column that action was invoked from is "ItemID".

```
SetIf(@Event.Sender.ColumnName == "ItemID", @Event.Data.DepartmentID);
```


>The following statement sets the selected value of the filter by checking both the name of the action that was invoked, and which column it was invoked from.

```
SetIf(@Event.Sender.ActionName == "ViewInvoice" && @Event.Sender.ColumnName == "InvoiceLineID", @Event.Data.InvoiceID);
``` 


