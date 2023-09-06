---
title: "Set"
metaKeys: "Set"
folderOnly: "false"
pageIndex: 22
---

### Set function

<br/>

```
Set(value : object | Eaze expression [, levelNum : number | Eaze expression])
```
<br/>

We use **Set(…)** in **SetFilterValue** actions for specifying the newly selected value of the filter. For example, when a custom context menu item is invoked or the Action Link Column is clicked. 
<br/>

### Parameters

``value expression``

>Eaze expression that is evaluated to resolve the value set as the selected filter value.


``levelNum expression``  
>*(optional)*
>
>When setting a filter value using the Set(…) function, InVision checks tWohat the requested filter value actually exists in the data source of the filter. If the value is not found, the request is ignored. This means that if the filter value is being set for a hierarchical filter, you need to specify the level at which the value exists. If the levelNum expression is not defined, the value is expected to be found at the leaf level. 

<br/>

### Example

>This example shows how to set set the selected value of the filter to the value of the DepartmentID of row that was clicked or right clicked in a Worksheet or Report.

```
Set(@Event.Data.DepartmentID); // Value of DepartmentID is found at leaf level
Set(@Event.Data.DepartmentID, 3); // Value of DepartmentID is found at level 3
```

<br/>





