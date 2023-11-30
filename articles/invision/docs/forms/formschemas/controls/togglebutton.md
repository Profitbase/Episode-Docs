
# ToggleButton

![toggle](https://profitbasedocs.blob.core.windows.net/images/toggle1.png)
![toggle](https://profitbasedocs.blob.core.windows.net/images/toggle2.png)

<br/>

Inherits from [Control](control.md).

<br/>

**Property:**

<br/>

`Click`  
Specifies the name of the Function to call when the user clicks the ToggleButton.

**Example**

```xml
<ToggleButton Name="ToggleButton1" Text="Click me" Click="ShowAlert"/>
```

This example shows how to call a function when the ToggleButton is clicked, passing an argument.

```xml
<ToggleButton Name="ToggleButton1" Text="Click me" Click="ShowAlert('My message')"/>
```

<br/>

`Disabled`

Use the Disabled property to disable a control or set it to read-only.  
The disabled property support data binding or an explicit value (true, false).

**Example**

```xml
<ToggleButton Disabled="{Binding Path:Customer.NotActive}"/>
or
<ToggleButton Disabled="true"/>
```

You cannot use both a Binding AND the control APIs at the same time to set the disabled state of a control.  
If the Disabled property of a control has a Binding, using the control.Disable() or control.Enable() APIs will not work (binding will win).

Valid values for the **Disabled** property:

- True
- False
- {Binding}

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

`Value`

Valid for the **Value** property:

- True
- False
- {Binding}

**Example**

```xml
<ToggleButton Name="Toggle_IsHappy" Value="{Binding Path:ToggleButtonSource.IsHappy}" />
```

<br/>

`Hotkey`

Specifies the hotkey for the control.  
**Example**

```xml
<Input Hotkey="Alt+T"/>
```

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/hotkeys.png)

<br/>

## Videos

- [Form Schemas](../../../../videos/formschemas.md)

- [Controls - Basics](https://profitbasedocs.blob.core.windows.net/videos/Form%20Schema%20-%20Input%20Element.mp4)

- [Controls - ToggleButton](https://profitbasedocs.blob.core.windows.net/videos/Controls%20%20-%20ToggleButton.mp4)
