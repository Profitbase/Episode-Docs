---
title: "TextArea"
metaKeys: "UI, Text Control, Controls,  Editable, input, TextArea, multi line text, model, binding syntax"
pageIndex: 16
---

Inherits from [Editable Control](editablecontrol.md).

<br/>

![btn](https://profitbasedocs.blob.core.windows.net/images/text%20area.png)

<br/>

---

The TextArea control is a multi line text input control.
<br/>

**Properties:**
<br/>

`Value`

The text of the TextArea control. Use this property to bind the text of the control to a field in a Model, using the binding syntax.

**Example**

```xml
    <TextArea Row="4" Column="1" ColumnSpan="2" Value="{Binding Path:Customer.Notes}"/>
```

<br/>

`Disabled`

Use the Disabled property to disable a control or set it to read-only.  
The disabled property support data binding or an explicit value (true, false).

**Example**

```xml
<Button Disabled="{Binding Path:Customer.NotActive}"/>
or
<Button Disabled="true"/>
```

You cannot use both a Binding AND the control APIs at the same time to set the disabled state of a control.  
If the Disabled property of a control has a Binding, using the control.Disable() or control.Enable() APIs will not work (binding will win).

Valid values for the **Disabled** property:

- True
- False
- {Binding}
