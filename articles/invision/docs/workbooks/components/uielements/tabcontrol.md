
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
<br/>

### Tab properties:

**Header**
>The text displayed as the tab header.

**Header Expression**
>A C# expression returning a string.

**Content**
>The subscreen to display as the tab content. 


<br/>


### Tabs API

You can use the Tabs API to control different states of the tabs dynamically, such as the header texts and enabled/disabled states. 

The Tabs API can be called from the **Execute Expression** action of the Tab Control.

<br/>

### TabItem(...)

Returns a reference to a Tab instance which has the following API.  

```
TabItem("tab name")
```  


<br/>

### SetHeader(...)

Sets the header of a tab.

```
SetHeader(text : string | Eaze expression)
```  


<br/>

**Example**
>
>This example shows how to change the header of the Tab named “Tab1” from the **Execute Expression** action of a **Tab Control**:
>
        TabItem("Tab1").SetHeader("My Header");



<br/>

### SetHeaderSuffix(...)

Adds a suffix to the original tab header. The optional whitespaceBetween enables you to determine whether you want whitespace between the base header text and the suffix (the default is true).

```
SetHeaderSuffix(text : string | Eaze expression[, whitespaceBetween | boolean = true])
```  


<br/>

**Example**
>
>This example shows how to set a suffix of the Tab named “Tab1” from the **Execute Expression** action of a **Tab Control**
>
        TabItem("Tab1").SetHeaderSuffix("My suffix");


<br/>

### ResetHeader(...)  

Resets the header to its original value.
<br/>

**Example**
>
>This example shows how to reset the text of the Tab named “Tab1” to its original state from the **Execute Expression** action of a **Tab Control**:
>
        TabItem("Tab1").ResetHeader();

<br/>

### Disable(...)

Lets you specify whether a tab is disabled or not. 

```
Disable([disable:boolean = true])
```  



<br/>

**Example**
>
>This example shows how to disable the Tab named “Tab1” from the **Execute Expression** action of a **Tab Control**:
>
        TabItem("Tab1").Disable();

>You can also call Disable(…) by passing a boolean value indicating whether the Tab should be disabled or not, which basically means you can set the disabled state.
>
        TabItem("Tab1").Disable(false); // Since we’re passing false, Enables the Tab.

<br/>

### Enable(...)

Lets you specify whether a tab is enabled or not.

```
Enable([enable:boolean = true])
```  


<br/>

**Example**
>
>This example shows how to enable the Tab named “Tab1” from the **Execute Expression** action of a **Tab Control**:
>
        TabItem("Tab1").Enable();
>
>You can also call call Enable(…) by passing a boolean value indicating whether the Tab should be enabled or not, which basically means you can set the enabled state.
>
        TabItem("Tab1").Enable(false); // Since we’re passing false, Disables the Tab.


<br/>


### Change tab using OnTapped Event 

This functionality allows to switch Tabs using other controls such as [Button](button.md).

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/onTappedTab0.png)

<br/>


**1. Activating using Event **OnTapped** in the button control on the main Page:**

![img](https://profitbasedocs.blob.core.windows.net/images/onTappedTab1.png)

<br/>


**2. Activating using Event **OnTapped** in the button control inside of the SubScreen:**


![img](https://profitbasedocs.blob.core.windows.net/images/onTappedTab2.png)

<br/>


Activate the tab by adding Custom event to the TabControl:

![img](https://profitbasedocs.blob.core.windows.net/images/onTappedTab3.png)

<br/>


### See Also
* [More about TabControl](../../../forms/formschemas/controls/tabcontrol.md)

<br/>


### Videos

* [Subscreens in Tabs](../../../../videos/workbooks.md)