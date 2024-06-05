
# Sending Messages Between Workbooks

[Workbooks](../../../workbooks.md) can send and receive messages from other Workbooks running on the same website. 

To send a message to other open Workbooks, use the [messageHub.sendMessage API](../apis/message-hub-apis.md)

Messages are received by subscribing to the `Message Received Event` of the Workbook.


### Receiving a message

Messages are received by subscribing to the `Message Received Event` of the Workbook. When the event is raised, you can access the message object through the `Event.Data` property. 
The `Event.Data` variable will contain the MessageCode, Message, and Data that was sent. You can use the message data in conditions and instructions after the message is received to determine what to do.


## Videos

[Sending Messages Between Workbooks](https://profitbasedocs.blob.core.windows.net/videos/Workbook%20Interactions%20-%20Sending%20Messages%20Between%20Workbooks.mp4)
