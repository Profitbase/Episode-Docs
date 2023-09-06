---
title: "ShowToastNotification"
metaKeys: "ShowToastNotification, "
folderOnly: "false"
pageIndex: 36
---

### ShowToastNotification(...)

<br/>

```
ShowToastNotification(title : string | Eaze expression, message : string | EAZE expression, 
type : string = “success” | “information” | “warning” | “error”)
```
<br/>

**ShowToastNotification** is used for showing a toast notification to the user. ShowToastNotification can be invoked from an ExecuteExpression Action. The title and message is specified using a text or an Eaze expression. 
<br/>

**Example**

This example shows how to show a toast notification using a fixed expression as the title and a composite expression as the message.

Suppose the the variable _count contains the number 23, message displayed by the toast is "23 items were updated"

```
ShowToastNotification("Update",CONCAT(_count," items were updated"));
```

```
ShowToastNotification("Update",Filter("Filters", "Dept").SelectedValue.Id);
```