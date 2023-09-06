---
title: "iFrame"
metaKeys: "iFrame, Actions, Load Data, Execute Expression, Send Message, events, Message Received "
folderOnly: "false"
pageIndex: 3
---




The iFrame component lets you embed external content, such as InFront or Power BI reports, in a Workbook. Use the **LoadData** action and call the [SetSrc(…)](../../programmingmodel/instructions/setsrc.md) function to specify the source url dynamically, or set the Source property to specify a static or initial source.
<br/>

### Actions

*	**Load Data**  
Use this action to refresh or change the contents displayed by calling the [SetSrc(…)](../../programmingmodel/instructions/setsrc.md) function. If you just want to display static content, specify the url in the Source property of the component.

*	**Execute Expression**  
Use this action if you want to dynamically change the css class applied to the iframe container. You can call [AddCssClass(…)](../../programmingmodel/instructions/cssclass.md), [RemoveCssClass(…)](../../programmingmodel/instructions/cssclass.md) and [ToggleCssClass(…)](../../programmingmodel/instructions/cssclass.md) functions.

*	**Send Message**  
Sends a message to the iFrame window using window.postMessage(…).  
To specify the message to pass to the iFrame, use:
```
ConfigureMessage(payload, targetOrigin)
```
<br/>

**Example**
>
>This example shows how to send a message to an iFrame using the Send Message action of the iFrame component.  
>To specify the message, use the ConfigureMessage(…) function:
>
```
ConfigureMessage({"MyMessage" : "Hello World"}, "*");
```

<br/>

### Events

*	**Message Received**  
Receives messages sent from the iframe content window. Use the @Event.Data property access the received message.

 **Note to senders:**
 
 Use the sendMessage(...) API in the **invision-extensions-iframe-sdk** npm module to send messages from the iframe to the Workbook.



<br/>


### Videos

* [Workbooks](../../../../videos/workbooks.md)
* [Components - iFrame - Basics](https://profitbasedocs.blob.core.windows.net/videos/Workbook%20-%20Iframe%20-%20Basics.mp4)
* [Components - iFrame - Communication Between Workbook and the iFrame Component](https://profitbasedocs.blob.core.windows.net/videos/iFrame%20-%20Communication%20Between%20Workbook%20and%20the%20iFrame%20Component.mp4)
