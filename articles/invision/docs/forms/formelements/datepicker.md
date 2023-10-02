---
title: "Date Picker"
metaKeys: "Date Picker, Max Value Query, Selected Value Query, Save Data Expression"
pageIndex: 1
---



![dpic](https://profitbasedocs.blob.core.windows.net/images/DPic.png)

<br/>

 
Enables editing a date using a [Date Picker](../formschemas/controls/datepicker.md) component.

<br/>

**Max Value Query**

Specifies a SQL query returning the highest allowed date that the user can enter or select.  

> [!NOTE]
>  The returned value must be of a date data type, not a string.*

**Min Value Query**

Specifies a SQL query returning the lowest allowed date that the user can enter or select.  

> [!NOTE]
> The returned value must be of a date data type, not a string.*

>**Example**
>
    SELECT CAST('20150101' AS datetime)


**Selected Value Query**

Specifies a query returning the initial value of the Date Picker.  

> [!NOTE]
> The returned value must be of a date data type, not a string.*

**Save Data Expression**

Specifies the [Data Query](../../sqlreports/dataqueries.md) used for saving data. The query must handle both insertion of a new row and updating an existing one. 