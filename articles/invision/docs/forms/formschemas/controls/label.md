---
title: "Label"
metaKeys: "UI, Text Control, Controls,  label, text, specify text, property, model, explicitly, localization, TextCode"
pageIndex: 10
---

Inherits from [Text Control](textcontrol.md).

<br/>

![btn](https://profitbasedocs.blob.core.windows.net/images/headings.png)

<br/>

---

Displays a text label. You can either specify the text explicitly or bind the Text property to a Model property.

**Example**

This shows how the text can be set explicitly using the Text property.

```xml
    <Label CssClass="margin-top-5" Row="4" Column="1" Text="Year" />
```

This shows how the Text property can be data bound to a Model property.

```xml
    <Label Name="YearLabel" CssClass="bold" Row="5" Column="2" Text="{Binding Path:FormData.Year}" />
```

This example shows how to enable localization by using the TextCode property. The Text property provides the fallback text if the text code could not be translated into the current user language.

```xml
    <Label CssClass="margin-top-5" Row="4" Column="1" Text="Year" TextCode="C_Year" />
```

<br/>

**Properties:**

<br/>

`LabelFor`  
Specifies the name of the input control that the label is associated with. https://developer.mozilla.org/en-US/docs/Web/API/HTMLLabelElement/htmlFor

**Example**

Notice that the **LabelFor** of the Label refers to the **Name** of the Input.

```xml
<Label Row="1" Column="1" Name="Lbl_CustomerID" Text="Customer ID" LabelFor="Input_CustomerID" />
<Input Row="2" Column="1" Name="Input_CustomerID" Value="{Binding Path:ToggleButtonSource.CustomerID}" Type="text" />
```

<br/>

### Videos

- [Form Schemas](../../../../videos/formschemas.md)

- [Controls - Basics](https://profitbasedocs.blob.core.windows.net/videos/Form%20Schema%20-%20Input%20Element.mp4)
