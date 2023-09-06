---
title: "Cell and Row Styling Functions"
metaKeys: "Cell, Row Styling Functions, SETROWSTYLE, css class "
pageIndex: 5
---

### Styling Functions

You can style Rows and Cells individually by creating CSS styles and assigning them to rows writing Eaze expressions.

<br/>

``SETROWSTYLE(row address expression, style name : string)``
>Sets the style of rows matching the row address expression. 
>
>**Example 1** 
>
>Applies a specific css class ("ProductGroup1") to all rows where ProductID equals XYZ. 
```
SETROWSTYLE(ProductID == "XYZ", "ProductGroup1"); 
```

>**Example 2** 
>
>Applies a specific css class ("StyleA") to all rows where ProductID starts with the letter F. 
```
SETROWSTYLE(STARTSWITH(ProductID, "F"), "StyleA");
```

``SETCELLSTYLE(cell address expression, column name : string, css class name : string)`` 

>Sets the style of cells in a specific column matching the row address expression. 
>
>**Example 1** 
>
>Applies a specific css class ("RedCell") to cells in the "Total" column if Total is less than 1000 
```
SETCELLSTYLE(Total < 1000, "Total", "RedCell"); 
```

<br/>

### Videos
* [Worksheet](../../../videos/worksheet.md)
* [Cell and Row Styling Functions](https://profitbasedocs.blob.core.windows.net/videos/Worksheet%20-%20Cell%20and%20Row%20Styling%20Functions.mp4)