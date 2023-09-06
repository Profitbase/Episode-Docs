---
title: "Basic Column Properties"
metaKeys: "Editing column layout, Default Value, Name, Caption, Expression, Store Column Binding, Order By, Dropdown Selection, custom parameters, format, formatter"
pageIndex: 1
---

Below you will find a list of the basic **Column Properties**.
<br/>

#### Name

The name of the column in the data set. Use the name for addressing the column in formulas. The name must be unique within the column set. Setting Columns can provide a localized caption based on the Name property if the value is registed in pbSimLangText and there is no Caption or Caption Expression providing an override Caption value.

<br/>

#### Store Column Binding

Specifies the id of the Data Store column that the grid column is bound to.
<br/>

#### Default Value

Specifies a default value to assign to the cell when a new row is added to the grid.
<br/>

#### Order By

Specifies if the Worksheet data set should be ordered by the values of the column when loaded from the server.  
*Priority* must be greater than 0 to order the data set by the column. Priority also specifies the index of the column in the order by clause.  
*Sort Descending* specifies if the values of the column should be sorted in descending order instead of ascending.
<br/>

#### Trim whitespace on save

Specifies whether to remove leading and trailing whicespace characters from text column values when data is saved to the database. Dropdown or Ranked Input columns will only be trimmed if this property is set to True. Standard text input columns will be trimmed unless the value is explicitly set to False.
<br/>

#### Context Menu Actions

Specifies **Custom Context Menu Actions** for the column. 
<br/>

#### Is Action Link Column

Specifies whether the column should be an Action Link Column. The values of Action Link Columns are displayed as hyperlinks, and cannot be edited by the user. When clicked, an event is raised in the Workbook context containing information about the clicked row, action and column.
<br/>

#### Format String

Specifies the format string used to display the rendered value of the column.
<br/>

#### Width Type

Specifies how the column should be sized.
<br/>

#### Width

Specifies the width if Width Type is set to Numeric.
<br/>

#### Content Alignment

Specifies the alignment of the cell values of the column.
<br/>


#### Is Fixed

Specifies if the column is be fixed / pinned to the left side of the grid.
<br/>

#### Conditional Formatting

Specifies styling and formatting rules for the column based on cell values. Due to performance reasons, we recommend specifying cell formatting using [Style Formulas](../calculations/cellnrowstylfunc.md), **SetRowStyle(…)** and **SetCellStyle(…)**, instead of the Conditional Formatting feature.


<br/>

#### Summary Function

Specifies which summary function to apply the the column when the Summary Row feature of the data grid is enabled. Available functions are Default, Sum, Min, Max, Count, Average and None. For numeric columns, the default is Sum and for all other columns, the default is None.


<br/>

#### Videos
* [Worksheet](../../../videos/worksheet.md)
* [Conditional Formatting](https://profitbasedocs.blob.core.windows.net/videos/Worksheet%20-%20Conditional%20Formating.mp4)