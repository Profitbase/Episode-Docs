# Send email from shared mailbox

Sends an email from a shared mailbox using Microsoft 365 Outlook.

Use this action to send emails from a `shared` Microsoft 365 Outlook mailbox. If you don't already have one, you need to first create a [Microsoft 365 Outlook connection](./outlook-connection.md) by logging on with an account having access to the shared mailbox.

![img](/images/flow/microsoft-365-outlook-send-mail.png)

## Properties

| Name        | Type     | Description                                                                                                                      |
| ----------- | -------- | -------------------------------------------------------------------------------------------------------------------------------- |
| Connection  | Required | A [Microsoft 365 Outlook connection](./outlook-connection.md) with access to the shared email account specified in `From email`. |
| From email  | Required | The shared email account to use as the sender account, for example `support@corp.com`.                                           |
| Subject     | Optional | The email subject.                                                                                                               |
| Message     | Optional | The email message.                                                                                                               |
| Attachments | Optional | Any attachments to include in the email.                                                                                         |


<br/>

[!INCLUDE [](./__videos.md)]