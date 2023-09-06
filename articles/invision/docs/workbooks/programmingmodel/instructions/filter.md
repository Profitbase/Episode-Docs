---
title: "Filter"
metaKeys: "Filter"
folderOnly: "false"
pageIndex: 8
---

### Filter function

<br/>

```
Filter(filterGroup : string, filterName : string).SelectedValue.Id

Filter(filterGroup : string, filterName : string).SelectedValue.Description

Filter(filterGroup : string, filterName : string).SelectedValue.IsLeaf

Filter(filterGroup : string, filterName : string).SelectedValue.Level

```

<br/>
We use the Filter(a,b) function to obtain information about a filter, for example reading the selected value. If multiple values are selected, the first value is returned. 

When addressing the filter, we need to specify both the **Filter Group** name and the **Filter** name since we can add the same filter multiple times to the same Workbook.
<br/>
The Filter(…) function returns an object with the following properties:

* **FullName**  
  The full name of the Filter, usually the group name and filter name concatenated by a period, ".".  
  A use case for FullName is when you need to invoke an action group in a filter using ConfigureInvocation, for example ConfigureInvocation(Filter("GroupName", "FilterName").FullName, "…", null)
* **SelectedValues**  
  SelectedValues returns object of type **SelectedFilterItems**.
* **SelectedValue**  
  SelectedValue returns object of type **SelectedFilterItem**.


<br/>

### SelectedFilterItems
<br/>

``Items``
>Array of **SelectedFilterItem**.

``Descriptions(separator : string = ",")``	
>Function that returns the the concatenated Descriptions of the selected items separated by the specified separator. The default separator is comma. Specifying a separator is optional.

``Ids(separator : string = ",")	``

<br/>

### SelectedFilterItem
<br/>

``Id``
>*object*  
>The value of the item.

``ColumnName``
>*String*  
>The name of the column in the underlying data table that the selected filter item gets its value from. For an "All Level" node, this value is null.

``Description``	
>*string*  
>The display text of the item

``IsLeaf``	
>*boolean*  
>Applicable only for dimension based filters. Returns a boolean value indicating whether the filter value exists at the leaf (lowest) level of the dimension hierarchy or not. 

``Level``	
>*number*  
>Applicable only for dimension based filters. Returns the level at which the value exists the dimension hierarchy. 

<br/>

#### Example

>
>This example shows a few ways to use the Filter function

```
SetParamValue("@MyParam",Filter("Mainfilters","Department").SelectedValue.Id);

_departmentName = Filter("Page1Filters","Department").SelectedValue.Description;

CurrentLevel = Filter("Page1Filters","Department").SelectedValue.Level;

IsLowestLevel = Filter("MainFilters","Department").SelectedValue.IsLeaf;
```
