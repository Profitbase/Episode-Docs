
# Workbook Events

## LoadingEvent

 The Loading Event is raised when the TOC of the Workbook has finished loading. The TOC describes which component the Workbook contains and their initial configuration (no data). The event is raised before any components are rendered. 

>> [!NOTE]
> When you run more than one event for the Workbook Component, check the **"Run Actions in Parallel"** checkbox.

<br/>

## MessageReceivedEvent

 The MessageReceived Event is raised when the Workbook receives a message from an external application. The received message can be addressed to the user, the Workbook, or a combination of the two. 
<br/>

## See Also

* The topic about [Sending messages between Workbooks](sendingmsgbetween.md) for details. 
