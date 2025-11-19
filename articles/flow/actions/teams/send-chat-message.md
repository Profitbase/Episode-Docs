# Send chat message

Sends a message to a user in Microsoft Teams.

Use this action when you want to send a message to a user in Microsoft Teams. The supported message formats are Text and HTML.

<br/>

## Properties

| Name           | Type           | Description                        |
|----------------|----------------|------------------------------------|
| Connection     | Required       | The [connection](./connection.md) to the Teams account. Setting up a connection requires a Microsoft `Work or School account`.|
| User (ID)      | Required       | The ID of the user to send the message to. Note that this is the `Object ID (OID)` of the user in Microsoft Entra ID, not the email or UPN of the user.  |
| Message        | Required       | The message to send. This can be a plain text message, or a HTML message. If it is a HTML message, remember to set the `Message content type` property to `HTML`. |
| Message content type | Optional | Specifies whether the message is a Text or HTML message. |
| Attachments    | Optional       | The attachments to include in the message. Note that in Teams, an "attachment" is a reference to an __existing__ document in for example OneDrive / SharePoint, so cannot include a __file__ as an __attachment__. Instead, if you want to include a file (from a stream or byte array), you must used `Hosted content` instead. |

<br/>

## Returns
This action returns a [chat message](./api-reference/chat-message.md).

### Example - Send a message

##### References
[Microsoft Graph REST API Reference](https://learn.microsoft.com/en-us/graph/api/chatmessage-post?view=graph-rest-1.0&tabs=csharp#example-4-send-a-message-with-file-attachment-in-it)