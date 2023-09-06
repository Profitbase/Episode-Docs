---
title: "ConfigureMessage"
metaKeys: "ConfigureMessage, "
folderOnly: "false"
pageIndex: 3
---

### ConfigureMessage(...)

<br/>

```
ConfigureMessage(toWorkbookId : string, toUserName? : string, messageCode : string);

ConfigureMessage(toWorkbookId : string, toUserName? : string, messageCode : string, message : string, data : any);

messageCode : string | Eaze expression, message : string | Eaze expression, data : any | Eaze expression)
```

<br/>


ConfigureMessage is used specifying the address and payload for messages sent using a SendMessage action. For details, view the topic about Sending messages between Workbooks.
<br/>

**Example**

```
ConfigureMessage("xx123", "hypotesia\bg", "Hi");
```


<br/>


**Example**
<br/>

![Img](https://profitbasedocs.blob.core.windows.net/images/configureMsg.png)

<br/>

### Videos

* [Sending Messages Between Workbooks](https://profitbasedocs.blob.core.windows.net/videos/Workbook%20Interactions%20-%20Sending%20Messages%20Between%20Workbooks.mp4)