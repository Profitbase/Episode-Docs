---
title: "Caption"
metaKeys: "Editing column layout, Default Value, Name, Caption, Expression, Store Column Binding, Order By, Dropdown Selection, custom parameters, format, formatter"
pageIndex: 2
---


#### Caption

The caption of the column displayed in the data grid. If no Caption or Caption expression is specified, the column Name is used as the caption.
<br/>

#### Caption Expression

A C#.NET expression returning a string used as the caption of the column in the data grid. Localization is supported by using the Localize-directive referring a text code registed in pbSimLangText.

In addition to the standard caption expression library, Time Frame columns can use an extended library of functions to resolve the caption expression based on the Time Frame information relative to the column.

**Example**
>
>We want to translate the Destination column name. In this example, we can see the English name of that column. 
<br/>

![caption expression](https://profitbasedocs.blob.core.windows.net/images/capt%20ex1.png)
<br/>

>We need to use Localize-directive:
><br/>
>
>``Localize("string textCode")``
><br/>
>
>```
>Localize("Destination")
>```
<br/>

![caption expression](https://profitbasedocs.blob.core.windows.net/images/capt%20ex2.png)

><br/>
>As we can see, the column caption automatically changed to Norwegian: 
>
<br/><br/>

![caption expression](https://profitbasedocs.blob.core.windows.net/images/capt%20ex3.png)

><br/>
>See how to do that step by step in our Localization video in the link below.
>
>
><br/>
><br/>

#### Videos about 

* [Localization](../../../videos/localization.md) 