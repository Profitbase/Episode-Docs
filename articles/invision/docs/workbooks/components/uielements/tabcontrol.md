# TabControl

<br/>

![btn](https://profitbasedocs.blob.core.windows.net/images/onTappedTab0.png)

<br/>

The Tab Control lets you organize content in tabs, and each tab can host a single Subscreen.

You can drag and drop a Tab Control onto a page from the UI Elements toolbox folder.
<br/>

## Tabs

To add Tabs, click **Edit Tabs** in the Property pane.  
Using the Tabs editor, you can manage the tab items of your Tab Control by setting the header texts and contents.

To set the contents of a tab, choose a Subscreen from the **Contents** dropdown.

> [!NOTE]
> Subscreen can only be used once, so if you don’t see a Subscreen in the dropdown, this means that it is already in use somewhere else in the Workbook.
> <br/>

### Tab properties:

| Name              | Description                                                       |
| ----------------- | ----------------------------------------------------------------- |
| Header            | The text displayed in the tab header                              |
| Header expression | A C# expression returning the text to display as the tab header   |
| Content           | A [Subscreen](../../subscreens.md) to display as the tab content. |

<br/>

### Tabs API

You can use the Tabs API to control different states of the tabs dynamically, such as the header texts and enabled/disabled states.

The Tabs API can be called from the **Execute Expression** action of the Tab Control.

<br/>

### TabItem(...)

Returns a reference to a Tab which has the following API.

<!--prettier-ignore-->
| Method name                                                      | Description               | Example                                     |
| ---------------------------------------------------------------- | ------------------------- | ------------------------------------------- |
| SetHeader(text: string)                                          | Sets the header of a tab item. | TabItem("MyTabName").SetHeader("Customers") |
| SetHeaderSuffix(text: string, whitespaceBetween: boolean = true) | Adds a suffix to the original tab item header. The optional whitespaceBetween enables you to determine whether you want whitespace between the base header text and the suffix (the default is true) | TabItem("MyTabName").SetHeaderSuffix("World")  |
| ResetHeader()                                                    | Resets the header text to its original value | TabItem("MyTabName").ResetHeader()|
| Disable(disable: boolean = true)                                 | Disables a tab item           | TabItem("MyTabName").Disable()                   | 
| Enable(enable: boolean = true)                                   | Enables a tab item            | TabItem("MyTabName").Enable()                    |
| Activate()                                                       | Activates (selects) a tab.    | TabItem("MyTabName").Activate()                  |

<br/>

### Example: Change Tab when a button is clicked

The example below shows how to activate a tab when a [Button](button.md) is clicked.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/onTappedTab0.png)

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/onTappedTab1.png)

<br/>

### See Also

- [More about TabControl](../../../forms/formschemas/controls/tabcontrol.md)

<br/>

### Videos

- [Subscreens in Tabs](../../../../videos/workbooks.md)
