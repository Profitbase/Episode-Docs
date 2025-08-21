
# Input

Inherits from [Editable Control](editablecontrol.md).

<br/>

![btn](https://profitbasedocs.blob.core.windows.net/images/headings.png)

<br/>

---

Represents a standard HTML Input control.

<br/>

**Properties:**

<br/>

`Value`
The value of the Input control. Use this property to bind the value of the control to a field in a Model, using the binding syntax.

**Example**

This example show how to bind the Value of an Input control the the FirstName field of the Person Model.

```xml
<Input Row="2" Column="1" Type="text" Value="{Binding Path:Person.FirstName}"/>
```

<br/>

`Type`

Specifies the type of input control. Valid values are **text, number, checkbox, date, email, month, password, time, url, week.**

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

<br/>

`Hotkey`

Specifies the hotkey for the control.

**Example**

```xml
<Input Hotkey="Alt+I"/>
```

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/hotkeys.png)

<br/>

`StopClickEventPropagation`

Stops the click event from propagating up the DOM tree.


```xml
<Input Hotkey="Alt+I" stopClickEventPropagation="true"/>
```

<br/>

## Videos

- [Form Schemas](../../../../videos/formschemas.md)

- [Controls - Basics](https://profitbasedocs.blob.core.windows.net/videos/Form%20Schema%20-%20Input%20Element.mp4)
