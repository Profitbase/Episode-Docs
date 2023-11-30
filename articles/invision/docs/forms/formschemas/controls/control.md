

# Control (base)

A base control object that cannot be directly used in your configuration. This is the base control that all other controls inherit from.

<br/>

## Properties

<br/>

``Name``
>The name of the control. By specifying a name, you can access the control through the **Controls**/ **controls** keyword in Event Handlers and Functions. You do not need to specify a name for a control if you don’t need to reference it in code.

<br/>

``CssClass``
>The css class(es) to apply to the control. This property can be changed dynamically through the *AddCss(…)*, *RemoveCss(…)* and *ToggleCss(…)* APIs of the control.

<br/>

``Margin``
>The margin of the control. Uses standard css luesyntax.

<br/>

``MinWidth``
>The min width of the control. Uses standard css syntax.

<br/>

``HorizontalAlignment``
>Specifies the horizontal alignment of the control within the grid. Allowed values are **left, start, right, end, center, stretch.**

<br/>

``VerticalAlignment``
>Specifies the vertical alignment of the control within the grid. Allowed values are **start, top, end, bottom, center, stretch.**

<br/>

``Row``
>Specfies the grid row that the control is positioned in. 
>
>**Example** 
```
<Input Row ="1" …/>
```

<br/>

``RowSpan``
>Specifies the number of grid rows the control spans.
>
>**Example**
```
<Input RowSpan ="2" …/>
```

<br/>

``Column``
>Specifies the grid column that the control is positioned in. 
>
>**Example** 
```
<Input Column ="1" …/>
```

<br/>

``ColumnSpan``
>Specifies the number of grid columns the control spans. 
>
>**Example** 
```
<Input ColumnSpan ="3" …/>
```


<br/>



## Hotkeys in Form Schema

Yo can assign a hotkey to almost every control in the Form Schema, to do that use the Hotkey property.
<br/>

```
<Input Hotkey="..."/>
```

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/hotkeys.png)

<br/>


## See Also
* [Text Control](textcontrol.md)
* [Editable Control](editablecontrol.md)
* [Image](image.md)
* [TabControl](tabcontrol.md)
* [Layout](layout.md)
* [Html](html.md)
  