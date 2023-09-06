---
title: "CssClass"
metaKeys: "CssClass, Add, Remove, Toggle"
folderOnly: "false"
pageIndex: 5
---

### AddCssClass

<br/>

```
AddCssClass(cssClassName : string)
```
Applies to Workbook Label and Button and can be called in an ExecuteExpression action.
Adds the specified CSS class(es) (separated by spaces) to the element if they not already exist. 
<br/>

>**Example 1**
>The following statement will add the CSS class "highlight" to the element if it does not already exist.
>
```
AddCssClass("highlight");
```
>
>**Example 2**
>The following statement will add the CSS classes "highlight" and "underline" to the element if they does not already exist.
>
```
AddCssClass("hightlight underline");
```

<br/>

### RemoveCssClass

<br/>

```
RemoveCssClass(cssClassName : string)
```

Applies to Workbook Label and Button and can be called in an ExecuteExpression action.
Removes the specified CSS class(es) (separated by spaces) from the element.
<br/>

>**Example 1**
>The following statement will remove the CSS class "highlight" from the element if it exist.
>
```
RemoveCssClass("highlight");
```
>
>**Example 2**
>The following statement will remove the CSS classes "highlight" and "underline" from the element if they exist.
>
```
RemoveCssClass("hightlight underline");
```

<br/>

### ToggleCssClass

<br/>

```
ToggleCssClass(cssClassName : string [,condition : Boolean | Eaze expression])
```

Applies to Workbook Label and Button and can be called in an ExecuteExpression action.
Adds or removes one or more classes (separated by spaces), depending on either the class's precense or the value of the condition argument.
<br/>

>**Example 1**
>The following statement will add the CSS class "highlight" to the element if it does not exist, or remove it if it does exist.
>
```
ToggleCssClass("hightlight");
```
>
>**Example 2**
>The following statement will add the CSS class "hightlight" to the element if the condition evaluates to true, otherwise the class will be removed.
>
```
ToggleClass("hightlight", X == 250);
```


<br/>

### Videos

* [Themes and Styles](../../../../videos/themesandstyles.md)
* [Styling - Adding a Css Class](https://profitbasedocs.blob.core.windows.net/videos/Styling%20-%20AddCssClass.mp4)
* [Cell and Row Styling Functions](https://profitbasedocs.blob.core.windows.net/videos/Worksheet%20-%20Cell%20and%20Row%20Styling%20Functions.mp4)
* [Conditional Formatting](https://profitbasedocs.blob.core.windows.net/videos/Worksheet%20-%20Conditional%20Formating.mp4)
