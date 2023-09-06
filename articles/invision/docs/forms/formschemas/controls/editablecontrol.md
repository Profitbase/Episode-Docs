---
title: "Editable Control (base)"
metaKeys: "UI, Controls, Control, directly, use, Editable, TabIndex, FormatString, Placeholder, PlaceholderTextCode, PlaceholderExpression, Form Schema, tab index, formatting of the input, Numbro, Moment, date input, translation, "
folderOnly: "false"
pageIndex: 20
---

Inherits from [Control](control.md).

You cannot use this control directly in your configuration.

<br/>

#### Properties

<br/>

`TabIndex`

Specifies the tab index of the control within the Form Schema.

<br/>

`FormatString`

Specifies the formatting of the input. If this is a numeric input control, use [Numbro](http://numbrojs.com/) format strings. If this is a date input, use [Moment](https://momentjs.com/) format strings. If you do not specify a format string, the default formatting provided by the browser will be used.

<br/>

`Placeholder`

The text to display as the placeholder of the control.

<br/>

`PlaceholderTextCode`

The text code used for translation, to resolve the value to display in the user interface. If the text code for the current user language cannot be found, the value in the Placeholder property is displayed.

<br/>

`PlaceholderExpression`

A **C#** expression that returns a string. If this expression returns a string, this value overrides the PlaceholderTextCode and Placeholder property.

<br/>

`GridArea`

Specifies a grid item’s size and location within a grid by contributing a line, a span, or nothing (automatic) to its [grid](grid.md) placement, thereby specifying the edges of its grid area.

<br/>

**Example**

```xml
    <Grid Rows="100px 1fr 50px" Columns="100px 1fr" Gap="8px" Areas="'header header' 'nav content' 'footer footer'">
        <Label Text="Header" GridArea="header" CssClass="a1"/>
        <Label Text="Nav" GridArea="nav" CssClass="a2"/>
        <Label Text="Content" GridArea="content" CssClass="a3"/>
        <Label Text="Footer" GridArea="footer" CssClass="a4"/>
    </Grid>
```

`Hotkey`

Specifies a keyboard combination to set focus to the control.
Note! On MacOS/iOS, the Ctrl key will automatically map to the Command key. You do not have to specify key combinations for different type of keyboards.

<br/>

**Example**

```xml
    <Input Hotkey="ctrl+alt+f"/>
```

### See Also

- [Input](input.md)
- [Dropdown](dropdown.md)
- [Listbox](listbox.md)
- [TextArea](textarea.md)
