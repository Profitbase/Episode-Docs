
# Editable Control (base)

Inherits from [Control](control.md).

You cannot use this control directly in your configuration.

<br/>

## Properties

| Name          | Description                        |
|---------------|------------------------------------|
| TabIndex      | Specifies the tab index of the control within the Form Schema. |
| FormatString  | Specifies the formatting of the input. If this is a numeric input control, use [Numbro](http://numbrojs.com/) format strings. If this is a date input, use [Moment](https://momentjs.com/) format strings. If you do not specify a format string, the default formatting provided by the browser will be used. | 
| Placeholder   | The text to display as the (value) placeholder in the control. |
| PlaceholderTextCode | The text code used for translation of the placeholder. If the text code for the current user language cannot be found, the value of the Placeholder property is displayed. |
| PlaceholderExpression | A **C#** expression that returns a string. If this expression returns a string, this value overrides the PlaceholderTextCode and Placeholder property. |
| GridArea | Specifies a grid item’s size and location within a grid by contributing a line, a span, or nothing (automatic) to its [grid](grid.md) placement, thereby specifying the edges of its grid area. |
| Hotkey | Specifies a keyboard combination to set focus to the control. <br/> Note! On MacOS/iOS, the Ctrl key will automatically map to the Command key. You do not have to specify key combinations for different type of keyboards. |
| Heading | Specifies the heading of the control. |
| HeadingPlacement | Specifies the placement (top, left) of the heading relative to the input control. |
| HeadingType | The heading type (normal, heading1, heading2, heading3) | 

<br/>

#### GridArea example

```xml
    <Grid Rows="100px 1fr 50px" Columns="100px 1fr" Gap="8px" Areas="'header header' 'nav content' 'footer footer'">
        <Label Text="Header" GridArea="header" CssClass="a1"/>
        <Label Text="Nav" GridArea="nav" CssClass="a2"/>
        <Label Text="Content" GridArea="content" CssClass="a3"/>
        <Label Text="Footer" GridArea="footer" CssClass="a4"/>
    </Grid>
```
<br/>

#### Hotkey example

```xml
    <Input Hotkey="ctrl+alt+f"/>
```

#### Heading example

```xml
    <Grid Rows="auto auto 1fr">
       <Input Heading="User name" Value="{Binding Path:User.Name}" Column="1" Row="1">
       <Input Heading="Email" HeadingPlacement="left" HeadingType="heading3" Value="{Binding Path:User.Name}" Column="1" Row="2" >
    </Grid>
```


### See Also

- [Input](input.md)
- [Dropdown](dropdown.md)
- [Listbox](listbox.md)
- [TextArea](textarea.md)
