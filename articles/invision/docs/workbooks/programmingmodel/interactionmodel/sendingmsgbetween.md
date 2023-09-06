---
title: "Sending Messages Between Workbooks"
metaKeys: "Sending messages between Workbooks, Receiving, Object Properties, ToWorkbookId, ToUserName, MessageCode, Message, Data"
folderOnly: "false"
pageIndex: 1
---



[Workbooks](../../../workbooks.md) can send and receive messages from other Workbooks running on the same website. 
Messages are being sent by executing SendMessage Actions by providing the receiver address and the payload by calling the [ConfigureMessage(…)](../instructions/configuremessage.md) function.

Messages are received by subscribing to the MessageReceivedEventet of the Workbook.

*	**Sending a message**  
A message is sent using the SendMessage action and calling the [ConfigureMessage(…)](../instructions/configuremessage.md) function to specify the address and payload. For details, see the topic of Creating and sending a message object.

*	**Receiving a message**  
Messages are received by subscribing to the MessageReceivedEventet of the Workbook. When the event is raised, you can access the message object through the @Event.Data property. 
The @Event.Data variable will contain the MessageCode, Message, and Data that was sent. You can use the message data in conditions and instructions after the message is received. 

>**Example**
>
>This example shows how to store the Message and Data values from a received message in two variables by calling the Execute Expression action when a message is received.
>
        ReceivedMessage = @Event.Data.Message;
        ReceivedData = @Event.Data.Data;


*	**The message object**  
Messages are sent between Workbooks using a fixed format message object. The message object has 5 properties, which specify the receiver address and the message contents. If you do not specify an address, the message is broadcasted to all Workbooks running on the same website. 
The message object is set up by calling the [ConfigureMessage(…)](../instructions/configuremessage.md) function.

**Message Object Properties**


``ToWorkbookId``  
*Data Type : string.*  
To send a message to a specific Workbook, you need to assign the metadata id of the target Workbook to this property. The metadata id of the target Workbook can be found by right-clicking the Workbook in the Solution Explorer and selecting «Copy to Clipboard».

``ToUserName``  
*Data Type : string.*  
To send a message to a specific user, you need to assign the user id of the receiver to this property, for example *hypotesia\bg*.

`MessageCode`  
*Data Type : string.*  
This property is is part of the message contents and can be used to specify the content type of message category. 

``Message``     
*Data Type : string.*  
This property is part of the message content and is used for specifying the actual message being passed. Note that the data type of the property is text, so if you want to send a value not being a text, you need to use the Data property.

``Data``  
*Data Type : Any.*  
This property is part of the message content and is used for passing arbitrary data with the message.


___


**Creating and sending a message object**

Message are sent by executing a SendMessage Action and calling the ConfigureMessage function to specify the message receiver and payload.

>**Example**
>
>This example shows how to send a message by specifying the receiving Workbook and the message contents.  
>The SendMessage Action is found in the list of available actions of the Workbook.
>
        ConfigureMessage("xx123", null,"Code_123","Hello World", 1000.5);
>
>Using the ConfigureMessage function, we provided the following arguments:  
>Receiver workbook : xxx123  
>Receiving user : null (everyone)  
>Message code : Code_123  
>Message : Hello world  
>Data : 1000.5 

 
**Using variables**

When creating a message object, you can assign values to the properties from variables.

>**Example**
>
>This example shows how to create a message object and compile the message using the builtin system variable CurrentUserName and the CONCAT function.
>
        ConfigureMessage("xx123",null, "Code_123",  
        CONCAT("Hello World from ", SYS.CurrentUserName), 1000.5);


<br/>

### Videos 

* [Sending Messages Between Workbooks](https://profitbasedocs.blob.core.windows.net/videos/Workbook%20Interactions%20-%20Sending%20Messages%20Between%20Workbooks.mp4)
