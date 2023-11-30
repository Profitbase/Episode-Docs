
# DatePicker

Inherits from [Editable Control](editablecontrol.md).
<br/>

![dpic](https://profitbasedocs.blob.core.windows.net/images/DPic.png)

<br/>

Provides a date picker control which supports selecting a date and optionally a time of day.
<br/>

**Properties:**
<br/>

`Value`

The selected date of the control. Use this property to bind the selected date of the control to a field in a Model, using the binding syntax.

**Example**

```xml
<DatePicker Name="DatePicker_OrderDate" Value="{Binding Path:Order.OrderDate}" />
```

<br/>

`Type`

Specifies whether the user can select a date or both a date and time of day. Valid values are **Date** and **DateTime**. The default value is Date.

**Example**  
This example shows how to enable time of day selection by setting the Type property to "DateTime".

```xml
<DatePicker Name="DatePicker_OrderDate" Value="{Binding Path:Order.OrderDate}" Type="DateTime" />
```

<br/>

`Disabled`

Use the Disabled property to disable a control or set it to read-only.  
The disabled property support data binding or an explicit value (true, false).

**Example**

```xml
<DatePicker Disabled="{Binding Path:Order.IsShipped}" />
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
<Input Hotkey="Alt+D"/>
```

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/hotkeys.png)

<br/>

## Videos

- [Form Schemas](../../../../videos/formschemas.md)
- [DatePicker](https://profitbasedocs.blob.core.windows.net/videos/Form%20Schema%20-%20DatePicker.mp4)
