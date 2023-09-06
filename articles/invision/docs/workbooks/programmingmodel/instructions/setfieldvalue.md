---
title: "SetFieldValue"
metaKeys: "SetFieldValue"
folderOnly: "false"
pageIndex: 28
---

### SetFieldValue function

<br/>

```
SetFieldValue(targetObject : object, targetProperty : string, value : any | Eaze expression)
```
<br/>

We use **SetFieldValue(…)** for setting a property of an object when an event is handled.
<br/>

### Parameters
<br/>

``targetObject``

>Specifies the object.

``targetProperty``

>Specifies the name of the property that the new value should be assigned to.

``value``

>Specifies the value to assign to the property. The value can be a hard coded value, a variable or a Eaze expression returns the value.

<br/>

### Example

>This example shows how to set the ProductID property of a new row being added to a Worksheet based on the value of a variable.
When a new row is added, the ItemAdded event is raised. The object in context of the event is the new row. The instruction is set a Workbook ExecuteExpression action.

```
SetFieldValue(@Event.Data, "ProductID", _state.SelectedProductID);
```

>**Note** that you can also set the value of the field using the following expression in an ExecuteExpression action:

```
@Event.Data.ProductID = _state.SelectedProductID;
```

