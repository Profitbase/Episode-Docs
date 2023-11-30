# Popup

<br/>

```
Popup(popupName : string | Eaze expression) : PopupCommandProxy
```
Returs an instance of a **PopupCommandProxy** that let you issue commands to the Popup with the specified name. The PopupCommandProxy contains the following methods:
<br/>

``SetCaption(caption : string)``

>Sets the caption of the Popup.

<br/>

>**Example**
>
```
Popup("Popup1").SetCaption("My New Caption");
```

<br/>

``SetCaptionSuffix(suffix : string, whitespaceBetween : bool = true)``

>Adds a suffix to the base caption. The base caption is either the caption set in the configuration, or the caption by a call to SetCaption(…). 

<br/>

``ResetCaption()``

>Resets the caption of the dialog to the caption specified in the configuration.

<br/>

``ClosePopup()``

>ClosePopup is used for closing a Popup (page). This function must be called from an ExecuteExpression Action. To close a popup, you have to provide its name. 

```
ClosePopup(popupName : string | Eaze expression)
```

<br/>

>**Example**
>
>The **«Details»** page is being displayed as a popup named **«My Popup»**. 
>
>To close the popup, use the following expression: 
>
```
ClosePopup("My Popup");
```


<br/>

## Videos

* [Workbooks](../../../../videos/workbooks.md)
* [Creating Popups](https://profitbasedocs.blob.core.windows.net/videos/Workbook%20-%20Creating%20Popups.mp4)