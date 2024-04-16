# “hotkey” function

InVison is equipped with a “hotkey” function. You can assign shortcut key combinations to either execute a website function or set focus to a website element. 

Developers can create custom hotkeys for all components that support user interaction.

<br/>

## Built-in Hotkeys:

- **Ctrl+Alt+1:** Show/hide left panel (if present)
- **Ctrl+Alt+2:** Show/hide top panel (if present)
- **Ctrl+Alt+3:** Show/hide right panel (if present)
- **Ctrl+Alt+F2:** Exit datagrid and go to next element
- **Ctrl+Alt+X:** Close currently open dialog with focus
- **Ctrl+Alt+O:** Open Options dialog

<br/>

**Example**

Top panel:

![](https://profitbasedocs.blob.core.windows.net/images/toppanel.png)


<br/>

## How to set up a Hotkey in the Workbook

<br/>

- Open Hotkey Editor in the properties window for the selected control
- Write your key combination
- press the OK button
- save changes made to that object

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/Accessibility.png)

<br/>

## Hotkeys in Form Schema

You can assign a hotkey to almost every control in the Form Schema, to do that use the Hotkey property.
<br/>

```
<Input Hotkey="..."/>
```

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/hotkeys.png)

<br/>



### Videos

- [Accessibility](../../videos/accessibility.md)
- [Hotkey](https://profitbasedocs.blob.core.windows.net/videos/Accessibiblity%20-%20hotkeys.mp4)