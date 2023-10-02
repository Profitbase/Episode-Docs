---
title: "Label"
metaKeys: "Label, Static text, Dynamic,styling, Translation, Localize, displays text, Workbook, Translation, "
folderOnly: "false"
pageIndex: 5
---


<br/>

![btn](https://profitbasedocs.blob.core.windows.net/images/headings.png)

<br/>

___

A Label displays text. The text of Labels can be changed dynamically based on states in the Workbook when events are fired.

### Static text

To specify a static text, simply enter it into the Text-property of the Label.

### Dynamic text

The text of a Label can be changed dynamically based on variables or selected filter values. 

To enable dynamically changing text, you have two options:

1. Use the [SetTextIf(…)](../../programmingmodel/instructions/settextif.md) or [SetText(…)](../../programmingmodel/instructions/settext.md) function in the Text property and execute the UpdateText action of the Label when you want the text to be updated.
   
2.  Call the [UpdateText(...)]() action of the Label and then call the [SetTextIf(…)](../../programmingmodel/instructions/settextif.md) or [SetText(…)](../../programmingmodel/instructions/settext.md) functions, OR call **< LabelName >.Text = …** in the action instruction editor.  
   
   ```
   SetTextIf(condition : boolean | Eaze expression, trueText : string | Eaze expression, falseText : string | Eaze expression)
   ```

   
   
   ```
   SetText(text : string | Eaze expression)
   ```

<br/>

**Example 1**
>
>This example shows how to specify the text displayed by a Label based on the selected value of the Department filter.  
>The IsFilterSet(…) function checks whether a values has been selected. If it has, the label text is set to the value returned by the Filter("Filters", "Department").SelectedValue.Description statement. If not, the label text is set to "All Departments".
>
>     SetTextIf(IsFilterSet("Filters", "Department"), Filter("Filters", "Department").SelectedValue.Description, "All Departments");
>

> [!NOTE]
> You have to execute the UpdateText Action of the Label for the text to change.


<br/>


**Example 2**
>
>The following example shows how the text can be combined using the Eaze CONCAT function.
>
>     SetTextIf(IsFilterSet("Filters", "Department"), CONCAT("Selected Department is ", Filter("Filters", "Department").SelectedValue.Description), "No Department is selected");


<br/>


**Example 3**
>
>The following example shows how to use the null coalescing operator (??) to conditionally set the text of a Label to either the Description-value of selected filter item, or "All".
>
>     SetText(Filter("Filters", "Department").SelectedValue?.Description ?? "All")


<br/>


**Example 4**
>
>This example shows how to set the value of a Label by directly assigning to the Text property of the Label. This statement must be executed in the UpdateText action of the Label. 
Assuming the name of the Label is LBL_MyLabel, the expression will be:
>
>     LBL_MyLabel.Text = "Hello";

<br/>

### Dynamic styling

A Label can be dynamically styled by calling the [AddCssClass(…)](../../programmingmodel/instructions/cssclass.md), [RemoveCssClass(…)](../../programmingmodel/instructions/cssclass.md) and [ToggleCssClass(…)](../../programmingmodel/instructions/cssclass.md) functions in an ExecuteExpression action.

<br/>

**Example**
>
>This example shows 3 different ways to add, remove or toggle the styling of a label by calling AddCssClass, RemoveCssClass or ToggleCssClass.
>
      AddCssClass("hightlight");
>    
      RemoveCssClass("hightlight underline");
>      
      ToggleCssClass("highlight", x == 250);

<br/>

### Translation

Text that changes dynamically on the client can be translated using the [Localize(…)](../../../directives/csharpdirectives/localize.md) function inside the [SetText(…)](../../programmingmodel/instructions/settext.md) of [SetTextIf(…)](../../programmingmodel/instructions/settextif.md) functions.

```
Localize(text_code : string, interpolationParams? : JSON object)
```


<br/>


#### Parameters

*	**text_code**  
the text code to translate. The text code must be registered in pbSimLangText with Type $AppUIResource.

*	**interpolationParams** (optional)  
A JSON object with the interpolation information

<br/>


#### Suppose pbSimLangText has contains the following entries:
<br/>


| ItemID           	| LangID 	| LangText                                                     	| Type           	|
|------------------	|--------	|--------------------------------------------------------------	|----------------	|
| ExpiryWarning    	| EN     	| Your subscription has expired                                	| $AppUIResource 	|
| ExpiryWarning    	| NO     	| Abonnementet ditt har utløpt                                 	| $AppUIResource 	|
| UserBirthMessage 	| EN     	| Hello, {{userName}}, your month of birth is {{monthOfBirth}} 	| $AppUIResource 	|
| UserBirthMessage 	| NO     	| Hei, {{userName}}, din fødselsmåned er {{monthOfBirth}}      	| $AppUIResource 	|

<br/>

**Example 1**
>
>Using the following expression, identities with EN as the selected locale will see the text "Your subscription has expired!" as the label text, while identities with NO as the selected locale text will see "Abonnementet ditt har utløpt!".
>
>     SetText(Localize("ExpiryWarning"));

<br/>

**Example 2**
>
>The example shows text translation: 
>
      SetText(Localize("UserBirthMessage", {"userName" : UserName, "monthOfMonth" : MonthOfBirth}));


<br/>

### See Also

* [More about Label in Forms](../../../forms/formelements/label.md)

<br/>


### Videos

* [Workbooks](../../../../videos/workbooks.md)
* [Components - Label](https://profitbasedocs.blob.core.windows.net/videos/Workbook%20-%20Label.mp4)