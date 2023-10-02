---
title: "Filter slicing"
metaKeys: "Filter slicing"
folderOnly: "false"
pageIndex: 1
---

You can slice hierarchical filters, so they only contain items specified in list of leaf level members.

For example, suppose you have a spreadsheet with data relating to departments and products. Users first filter the spreadsheet based on department, but they want to further filter the spreadsheet on products and product groups. They want the Product filter to contain only the product hierarchies for the products in the spreadsheet, not all products in the Product dimension.

To achieve this, you need to call the **SetLeafLevelConstraints(…)** and specify a list of product ids in the Load Data action of the filter.


<br/>


**Example**

1. Create a Workbook variable to store the product ids:

![pic](https://profitbasedocs.blob.core.windows.net/images/slicingFilter1.png)

<br/>

2. Create a JavaScript which returns a list of product ids:

![pic](https://profitbasedocs.blob.core.windows.net/images/slicingFilter2.png)

<br/>

3. In the spreadsheet calculations, call the JavaScript and assign the result to the Workbook variable:

![pic](https://profitbasedocs.blob.core.windows.net/images/slicingFilter3.png)

<br/>

4. In the Load Data action of the (Product) filter, call SetLeafLevelConstraint(…) and pass in the variable. 

> [!NOTE]
> You need to call Load Data on the filter AFTER the spreadsheet has been loaded, or else the list of product ids has not been created.

![pic](https://profitbasedocs.blob.core.windows.net/images/slicingFilter4.png)

<br/>


### Videos

* [Workbooks](../../../../videos/workbooks.md)
