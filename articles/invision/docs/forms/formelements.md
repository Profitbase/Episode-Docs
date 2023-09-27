---
title: "Form Elements"
metaKeys: "Form Elements and Form Element Collections, Label, TextBox,  Dropdown, Date Picker, "
folderOnly: "false"
pageIndex: 2
---

#### Form Elements and Form Element Collections

Form Elements are components, for example, text boxes, dropdown lists, and date pickers used to display and/or edit a uniquely identifiable value. Form Elements are first configured in the Solution and then added to Workbooks where the user interaction can take place.

Form Elements are stored in Form Element Collections, which is the only function of Form Element Collections. The reason for storing Form Elements in collections instead of the main Solution structure is that since a Form Element can only manage a single value, you can end up getting many Form Elements in a Solution that clutters up your Solution structure.

To create a Form Element, open (or create) a Form Element Collection and drag a Form Element Template from the Toolbox to the designer.  
Once a Form Element has been created, you cannot change the type, so you need to make sure to select the right template when first creating it.

To enable loading and saving data, you need to specify [Data Queries](../sqlreports/dataqueries.md).
Please note that filter directives are not supported by Form Element Data Queries because Form Elements can display and edit a single value and filter directives kan return multiple values. 
To enable filtering in Form Element Data Queries, use custom parameters.
<br/>

##### Selected Value - @FormElementValue()

The @FormElementValue() – directive is used in the Save Data Expression to refer to the value selected or entered by the user. The TextBox and Dropdown examples show the use of the @FormElementValue directive.

<br/>

#### More about Form Elements

* [Form Elements](../workbooks/components/formelements.md)

#### See Also

* [Date Picker](formelements/datepicker.md)
* [Dropdown](formelements/dropdown.md)
* [Label](formelements/label.md)
* [Textbox](formelements/textbox.md)




