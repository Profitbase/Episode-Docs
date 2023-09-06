---
title: "SetParamValue"
metaKeys: "SetParamValue"
folderOnly: "false"
pageIndex: 30
---

### SetParamValue function

<br/>

We use **SetParamValue** for passing arguments to Data Queries such as SQL Scripts, Report queries, and Form save scripts where we use custom parameters. The value can be obtained from variables or filters. The parameter set by SetParamValue(…) only exists in the context of the action being called and is not available in other actions.

```
SetParamValue(paramName : string, paramValue : any);
```
<br/>

### Example

>This example shows how to supply arguments to a parameterized query.
>
>The query being executed at the server:

```
SELECT *
FROM Orders
WHERE Ordertype = @Ordertype AND Country = @Country
```

>Using **SetParamValue(…)** to supply arguments to **@Ordertype** and **@Country**.  
>**SetParamValue(…)** is called in the Execute action of the SQL Script Workbook component.

```
SetParamValue("@Ordertype", Filter("Filters","Ordertypes").SelectedValue.Id);
SetParamValue("@Country",Selected_Country);
```

<br/>

![spv](https://profitbasedocs.blob.core.windows.net/images/setparamv.png)