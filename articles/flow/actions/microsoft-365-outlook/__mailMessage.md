### MailMessage properties

| Name              | Description          |
| ------------------|----------------------|
| MessageId         | The unique id of the mail message in Outlook. |
| InternetMessageId | The message ID in the format specified by RFC2822 |
| ConversationId    | The ID of the conversation the email belongs to. |
| EmailAccount      | The email account the message belongs to. |
| Body              | The email body. This can be HTML or plain text. |
| Subject           | The subject of the email. | 
| From              | The email sender. |
| To                | The email recipient. |
| Attachements      | Metadata about the email attachments. Note that this does not contain the actual attachment contents unless the `Include attachments` property is enabled. You can use the [Get attachment](get-attachment.md) action to retrieve the attachment contents on demand. |
| IsRead            | Specifies whether the email has been read. |
| ReceivedDateTimeUTC | The UTC date and time the message was received.  |
| SentDateTimeUTC   | The UTC date and time the message was sent. |
 
