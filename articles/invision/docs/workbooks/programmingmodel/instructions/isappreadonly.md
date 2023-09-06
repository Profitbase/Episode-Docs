---
title: "IsAppReadOnly"
metaKeys: "IsAppReadOnly()"
folderOnly: "false"
pageIndex: 12
---

### IsAppReadOnly function

<br/>

```
IsAppReadOnly() : boolean
```

<br/>

The IsAppReadOnly() function returns **true** if the Workbook is read-only, otherwise **false**. 
An example of when a Workbook will be in a read-only state is when the current** Work Process Version** is **closed**.
<br/>

**Example**

This example shows how to disable a button in a Workbook is read-only, for example if the current Work Process Version is closed.  
Use the Execute Expression action of a button and specify the following command:

```
EnableIf(!IsAppReadOnly())
```
<br/>


