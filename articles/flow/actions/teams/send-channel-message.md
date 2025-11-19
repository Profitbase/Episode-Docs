# Send message in channel

Sends a message in a Microsoft Teams channel.

Use this action when you want to send a message to a channel in Microsoft Teams. The supported message formats are Text and HTML.

<br/>

## Properties

| Name           | Type           | Description                        |
|----------------|----------------|------------------------------------|
| Connection     | Required       | The [connection](./connection.md) to the Teams account. Setting up a connection requires a Microsoft `Work or School account`.|
| Team (ID)      | Required       | The ID of the team that the channel belongs to |
| Channel (ID)   | Required       | The ID of the channel to send the message in. |
| Message        | Required       | The message to send. This can be a plain text message, or a HTML message. If it is a HTML message, remember to set the `Message content type` property to `HTML`. |
| Message content type | Optional | Specifies whether the message is a Text or HTML message. |
| Attachments    | Optional       | The attachments to include in the message. Note that in Teams, an "attachment" is a reference to an _existing_ document in for example OneDrive / SharePoint, so cannot include a _file_ as an _attachment_. Instead, if you want to include a file (from a stream or byte array), you must used `Hosted content` instead. |

<br/>

## Returns
This action returns a [chat message](./api-reference/chat-message.md).

<br/>

## Attachments
In Teams, an _attachment_ is a _reference_ to a document, not the physical document content itself. This differs from email, where files are attached directly to email messages as attachments.  
To send a Teams message with attachment(s), the document(s) [must already exist in OneDrive / SharePoint](https://learn.microsoft.com/en-us/graph/api/chatmessage-post?view=graph-rest-1.0&tabs=csharp#example-4-send-a-message-with-file-attachment-in-it). To include the OneDrive / SharePoint document as an attachment, do the following:
1) In the Attachments property of the action, add attachements by defining their Id, Name, Content type and Content Url. 
2) In the message, a reference to the attachement **must** be included on the form `<attachment id="GUID"></attachment>`. The Id in the attachments tag in the message **must** match the Id of the attachment in the Attachements dialog. (See example below) 

| Name         | Type                | Description             |
|--------------|---------------------|-------------------------|
| Id           | Required            | The Id of the attachement. This must be a valid GUID. |
| Name         | Required            | The name of the attachement, for example the file name. |
| Content type | Required            | The content type specifying the attachment type. This defaults to `reference`. |
| Content URL  | Required            | The location of the document in OneDrive / SharePoint. Use one of the OneDrive actions to retrieve the document from OneDrive and use the `WebUrl` or `WebDavUrl` property of the OneDriveItem as the Content URL. |

![img](/images/flow/teams-message-attachments.png)

<br/>
<br/>

### Example - Send a message with an attachment  
As described above, in Teams, an _attachment_ is a _reference_ to a document, not the physical document content itself. 
To send a Teams message with an attachment, the document must already exist in OneDrive / SharePoint [as described here](https://learn.microsoft.com/en-us/graph/api/chatmessage-post?view=graph-rest-1.0&tabs=csharp#example-4-send-a-message-with-file-attachment-in-it). This example will highlight the required steps to send a Teams message with an attachement, as illustrated in the image below.

![img](/images/flow/teams-example-send-channel-message-with-attachment.png)

<br/>

##### References
[Microsoft Graph REST API Reference](https://learn.microsoft.com/en-us/graph/api/chatmessage-post?view=graph-rest-1.0&tabs=csharp#example-4-send-a-message-with-file-attachment-in-it)