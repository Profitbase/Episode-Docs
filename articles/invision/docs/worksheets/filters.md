---
title: "Filters"
metaKeys: "filtering, Workbooks, Filters configuration, Setting, column, added, endpoint "
pageIndex: 9
---

### Filtering Worksheets
To enable filtering for the [Worksheet](../worksheets.md), you must add a [Filter](../filters.md) to the Filters section of the Worksheet designer. This will create a filter endpoint that you must bind to a filter instance in the [Workbook](../workbooks.md) designer.

When adding a filter to the Worksheet, you need to specify the [Data Store](../datastores.md) column to filter by. To specify the Data Store column to filter by, select the filter in the Filter Section of the Worksheet and then select the Data Store column from the properties editor.

To enable the filter column to be auto populated when a user adds a new row to the Worksheet, you need to register the filter in the **Add Row Settings** [Worksheet Properties](wproperties.md) collection. 


<br/>

>You add a filter to the Filters section of the Worksheet designer by dragging and dropping it.

![Filters](https://profitbasedocs.blob.core.windows.net/images/filtersinworksheet.png)

<br/>

>Select the Data Store column from the properties editor.

![Filters](https://profitbasedocs.blob.core.windows.net/images/filtersinworksheet2.png)

<br/>


### See Also
* [More about Filters](../filters.md)
* [Filtering Tables](../tables/filters.md)

### Videos
* [Filters](../../videos/filters.md)
