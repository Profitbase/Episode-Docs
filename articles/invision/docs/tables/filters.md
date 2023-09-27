---
title: "Filters"
metaKeys: "filtering, Workbooks, Filters configuration, Setting, column, added, endpoint(s) "
pageIndex: 7
---

### Filtering the Table
To support filtering when settings are hosted in Workbooks, you need to add [Filters](../filters/index.md) to the filter configuration and specify the setting column for matching values. When filters are added to the Setting configuration, you can bound them to the filter endpoint(s) of the Setting.
<br/>

>You add a filter to the Filters section of the Table by g and droping it.

![Filter](https://profitbasedocs.blob.core.windows.net/images/filtersintables1.png)
<br/>

>Bind the Filter in the Table properties in Workbook designer.

![Filter](https://profitbasedocs.blob.core.windows.net/images/filtersintables2.png)
### Properties
<br/>

**Filter Name**  
>The name of the filter. Filters, are added by dragging and dropping from the Toolbox. Filters cannot be changed, only removed and added.

**Filter On**  
>Specifies the name of the Setting column used for matching values.

**Accept Wildcard**  
>If the Setting column used formatching values contains a the **'*'**-value, meaning that it acts as a fallback matching anything not explicitly matched in other rows in the data set, and you want to include these rows in the data set of the grid, the value of thisproperty must be NULL (default dash) or True (checked).

### See Also
* [More about Filters](../filters/index.md)
* [Filtering Worksheets](../worksheets/filters.md)

### Videos
* [Filters](../../videos/filters.md)
