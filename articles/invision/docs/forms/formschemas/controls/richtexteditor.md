
# RichTextEditor

Inherits from [Editable Control](editablecontrol.md).

<br/>

![btn](https://profitbasedocs.blob.core.windows.net/images/rich%20text%20ed.png)

<br/>

The RichTextEditor enables editing and formatting rich text documents in Form Schemas.

<br/>

**The editor supports the following features: **

- Text formatting (bold, underline, italic, colorization)
- Font selection
- Font sizing
- Text alignment
- Lists
- Embedding images
- Embedding links
- Embedding code

**Properties:**

`Value`

The value of the RichTextEditor control. Use this property to bind the value of the control to a field in a Model, using the binding syntax.

**Example**

This example shows how to bind the Value of RichTextEditor control the the Text field of the Document Model.

```xml
    <RichTextEditor Row="2" Column="1" Value="{Binding Path:Document.Text}"/>
```

<br/>

`ToolbarOptions`

Use the ToolbarOptions to configure the optional tools in the Toolbar. The optional tools are Image, Code and Links tools.

**Example**

This example shows how to display the options in the toolbar for embedding images, links and code.

```xml
    <RichTextEditor Row="2" ColumnSpan="3" Value="{Binding Path:Document.Data}">
        <ToolbarOptions Images="true" Code="true" Links="true"/>
    </RichTextEditor>
```

<br/>

![RichTextEditor](https://profitbasedocs.blob.core.windows.net/images/RichTextEditor.png "RichTextEditor")

<br/>

`Disabled`

Use the Disabled property to disable a control or set it to read-only.  
The disabled property support data binding or an explicit value (true, false).

**Example**

```xml
<RichTextEditor Disabled="{Binding Path:Customer.NotActive}"/>
or
<RichTextEditor Disabled="true"/>
```

You cannot use both a Binding AND the control APIs at the same time to set the disabled state of a control.  
If the Disabled property of a control has a Binding, using the control.Disable() or control.Enable() APIs will not work (binding will win).

Valid values for the **Disabled** property:

- True
- False
- {Binding}

<br/>

`Hotkey`

Specifies the hotkey for the control.

**Example**

```xml
<Input Hotkey="Alt+B"/>
```

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/hotkeys.png)

<br/>

`StopClickEventPropagation`

Stops the click event from propagating up the DOM tree.


```xml
 <RichTextEditor Row="2" Column="1" Value="{Binding Path:Document.Text}" stopClickEventPropagation="true"/>
```

<br/>

## Videos

- [Form Schemas](../../../../videos/formschemas.md)

- [Controls - RichTextEditor](https://profitbasedocs.blob.core.windows.net/videos/Controls%20%20-%20RichTextEditor.mp4)
