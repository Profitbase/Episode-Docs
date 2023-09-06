---
title: "TabControl"
metaKeys: "UI, Text Control, Controls,  Editable, tabs, collection"
pageIndex: 15
---

Inherits from [Control](control.md).

<br/>

![btn](https://profitbasedocs.blob.core.windows.net/images/tabctrol.png)

<br/>

<br/>

**Property:**

<br/>

`Tabs`

A collection of tabs. See example below:
**Example**

```xml
<TabControl Row="5" ColumnSpan="2">
        <Tab Header="Customers" HeaderTextCode="LNG_Customers"
            HeaderExpression="Some C# expression">
            <Grid Rows="auto auto 1fr" Columns="auto auto 1fr">
                ...content
            </Grid>
        </Tab>
        <Tab Header="Employees" HeaderTextCode="LNG_Employees"
            HeaderExpression="Some C# expression">
            <Grid Rows="auto auto 1fr" Columns="auto auto 1fr">
               ...content
            </Grid>
        </Tab>
</TabControl>
```

<br/>

#### See Also

- [More about TabControl](../../../workbooks/components/uielements/tabcontrol.md)

<br/>

#### Videos

- [Subscreens in Tabs](../../../../videos/workbooks.md)
