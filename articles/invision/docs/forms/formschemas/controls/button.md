---
title: "Button"
metaKeys: "UI, Text Control, Controls, on click, click, clicks, button, call function"
pageIndex: 1
---

Inherits from [Text Control](textcontrol.md).

<br/>

![btn](https://profitbasedocs.blob.core.windows.net/images/btnUI.png)

<br/>

**Property:**

<br/>

`Click`

Specifies the name of the Function to call when the user clicks the button.

**Example**

```xml
<Button Name="Button1" Text="Click me" Click="ShowAlert"/>
```

This example shows how to call a function when the button is clicked, passing an argument.

```xml
<Button Name="Button1" Text="Click me" Click="ShowAlert('My message')"/>
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

<br/>

`Type`

Specifies the default look of the button. Valid values are "Default", "Primary", "Secondary", "Confirm", "Link"

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

### Videos

- [Form Schemas](../../../../videos/formschemas.md)

- [Controls - Basics](https://profitbasedocs.blob.core.windows.net/videos/Form%20Schema%20-%20Input%20Element.mp4)
