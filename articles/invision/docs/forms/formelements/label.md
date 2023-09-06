---
title: "Label"
metaKeys: " Label, read only value , query, "
pageIndex: 3
---

<br/>

![btn](https://profitbasedocs.blob.core.windows.net/images/headings.png)

<br/>

___                                                                 

### Presents data as a read only value 

**Select Value Query ** 

Specifies the Data Query which returns a single value which is displayed to the user. 
>**Example** 
>
>This example shows a query for displaying the number of units in store for a given product. 
>
    SELECT Qty  
    FROM @Object[Products].DbObjectName  
    WHERE ProductID = @ProductID

<br/>

### See Also

* [More about Label](../../workbooks/components/uielements/label.md) 