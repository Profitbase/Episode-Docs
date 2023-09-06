---
title: "Date for Time Frame Columns in Formulas"
metaKeys: "Using, date, Time Frame, Columns, formulas"
pageIndex: 20
---


If you need to use the date of a Time Frame column in a Worksheet formula, you can use the reserved **@Property[<column_name>.Date]** expression.

>**Example** 
>
```
@Property[P03.Date] will return the date of the P03 column in the Data Store.
```
