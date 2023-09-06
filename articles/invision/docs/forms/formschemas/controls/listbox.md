---
title: "Listbox"
metaKeys: "UI, SetModel, Control, List, Listbox, Controls,  Editable, ItemsSource, ItemsSourceFilter, DisplayMember, ValueMember, SelectedValue, KeyProp, ItemSelected, ItemTemplate, binding, collection, Form Runtime, "
folderOnly: "false"
pageIndex: 12
---

Inherits from [Editable Control](editablecontrol.md).

<br/>

#### Properties

<br/>

`ItemsSource`  
Specifies the name of the List or SetModel that contains the items that is displayed to the user, or a binding to a collection in the Form Runtime.

<br/>

`ItemsSourceFilter`  
**Optional.** Specifies a function that returns the items to render in the Listbox. The function cannot be asynchronous.

**Example**

```xml
<Form>
  <Data>
    <Models>
      <Model Name="Customer" Source="@Object[Customers].DbObjectName" Fields="ID,Name" />
    </Models>
    <Lists>
    	<List Name="Customers" Source="@Object[Customers].DbObjectName" Fields="ID,Name"/>
    </Lists>
  </Data>
  <Functions>
  	<Function Name="MyFilter" Parameters="items, controlName">
  		return items.filter(item => item.ID !== "Customer1");
  	</Function>
  </Functions>
  <UI Grid="ui-root">
    <Listbox Name="MyListbox" Row="1"
    	MinWidth="100px"
        ItemsSource="Customers"
        ItemsSourceFilter="MyFilter($Data, $Ctrl.Id)"
    	DisplayMember="Name"
    	ValueMember="ID"
    	SelectedValue="{Binding Path:Customer.ID}" />
  </UI>
</Form>
```

<br/>

`DisplayMember`  
Specifies the field of the List or SetModel member that is displayed to the user. This is usually a description or some sort of user friendly text. This property is ignored if you have specified an **ItemTemplate.**

<br/>

`ValueMember`  
Specifies the field of the Set Model member or List that holds the value to assign to the SelectedValue when the user selects an item in the list.

<br/>

`SelectedValue`  
**Optional.** Specifies the binding to the field in a Model or custom object that the ValueMember should update.

<br/>

`KeyProp`  
**Required.** This property indicates which field in the ItemsSource that uniquely identifies an item in the ItemsSource.

<br/>

`ItemSelected`  
A Function to call when the user has selected an item from the list. You can pass the selected item to the function using the special \$Data keyword, or you can get the selected value from within the function from the object property bound to the SelectedValue property.

<br/>

`ItemTemplate`  
The ItemTemplate enables you to customize how you want each item in the listbox to be displayed, using all the available UI controls.

>

<br/>

### See Also

- [Rendering Items](listbox/renderingitems.md)
