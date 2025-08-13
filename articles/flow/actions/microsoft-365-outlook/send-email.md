# Send email

Sends an email using Microsoft 365 Outlook.

Use this action to send emails from a `personal` Microsoft 365 Outlook mailbox. If you don't already have one, you need to first create a [Microsoft 365 Outlook connection](./outlook-connection.md) to grant Profitbase Flow permissions to use the personal account on behalf of the user.

![img](/images/flow/microsoft-365-outlook-send-mail.png)

> [!CAUTION]
> Consider carefully whether to use a personal or rather a [shared mailbox](./send-email-from-shared-mailbox.md). You decide this when you create the Microsoft 365 Outlook connection.  
> If you work in a Workspace shared with other people, they can use the same connection to read, send, delete and update mail messages.  
> We recommend using shared mailboxes, or log on using a service user account (such as a company support account) so you don't accidentally grant other people access to your personal email account.

## Properties

<!--prettier-ignore-->
| Name        | Type     | Description                                                                                                                       |
| ----------- | -------- | --------------------------------------------------------------------------------------------------------------------------------- |
| Connection  | Required | A [Microsoft 365 Outlook connection](./outlook-connection.md) which grants Profitbase Flow access to sending email from a personal email account. The `sender` address will be the email account used to log on when creating the M365 Outlook connection. |
| Subject     | Optional | The email subject.                                                                                                                 |
| Message     | Optional | The email message.                                                                                                                 |
| Attachments | Optional | Any attachments to include in the email.                                                                                          |


<br/>

[!INCLUDE [](./__videos.md)]