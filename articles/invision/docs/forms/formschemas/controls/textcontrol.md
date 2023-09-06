---
title: "Text Control (base)"
metaKeys: "UI, Text Control, Controls,  Editable, TextCode, TextExpression, FormatString, input, numeric, formatting, format, display, user interface, translation, displayed, C# expression, "
folderOnly: "false"
pageIndex: 21
---

Inherits from [Control](control.md).

You cannot use this control directly in your configuration.

<br/>

#### Properties

<br/>

`Text`  
The text to display in the user interface.

<br/>

`TextCode`  
The text code used for translation, to resolve the value to display in the user interface. If the text code for the current user language cannot be found, the value in the Text property is displayed.

<br/>

`TextExpression`  
A **C#** expression that returns a string. If this expression returns a string, this value overrides the TextCode and Text property.

<br/>

`FormatString`  
Specifies the formatting of the input. If this is a numeric input control, use [Numbro](http://numbrojs.com/) format strings. If this is a date input, use [Moment](https://momentjs.com/) format strings. If you do not specify a format string, the default formatting provided by the browser will be used.

<br/>

### See Also

- [Button](button.md)
- [Labels](label.md)
- [Headings](headings.md)
