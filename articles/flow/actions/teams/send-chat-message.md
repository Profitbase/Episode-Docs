# Send chat message

Sends a message to a user in Microsoft Teams.

Use this action when you want to send a message to a user in Microsoft Teams. The supported message formats are Text and HTML, and you can also include attachments with the message.

![img](/images/flow/teams-send-chat-message.png)

<br/>

## Properties

| Name           | Type           | Description                        |
|----------------|----------------|------------------------------------|
| Connection     | Required       | The [connection](./connection.md) to the Teams account. Setting up a connection requires a Microsoft `Work or School account`.|
| User (ID)      | Required       | The ID of the user to send the message to. Note that this is the `Object ID (OID)` of the user in Microsoft Entra ID, not the email or UPN of the user.  |
| Message        | Required       | The message to send. This can be a plain text message, or a HTML message. If it is a HTML message, remember to set the `Message content type` property to `HTML`. |
| Message content type | Optional | Specifies whether the message is a Text or HTML message. |
| Attachments    | Optional       | The attachments to include in the message. Note that in Teams, an "attachment" is a reference to an _existing_ document in OneDrive / SharePoint, so you cannot include a _file_ as an _attachment_ directly. Instead, if you want to include a file (from a stream or byte array), you must used `Hosted content` instead. |

<br/>

## Returns
This action returns a [chat message](./api-reference/chat-message.md).

<br/>

### Examples

The example below describes sending a message with an attachment using the [Send message in channel](./send-channel-message.md) action, but the approach is exactly the same for `Send chat message`.

[!INCLUDE [](./__send-message-attachment-example.md)]

