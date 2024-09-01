# Get attachment

Gets an attachment from an email in Microsoft 365 Outlook.

![img](/images/flow/microsoft-365-outlook-get-attachment.png)

When email messages are retrieved by Profitbase Flow, you may specify whether or not to include the contents of all attachments by default.
Use this action to fetch the contents of a specific attachment.

## Properties

| Property      | Type     | Description                                                                                                             |
| ------------- | -------- | ----------------------------------------------------------------------------------------------------------------------- |
| Connection    | Required | A [Microsoft 365 Outlook connection](./outlook-connection.md) which grants Profitbase Flow access to the email account. |
| Message Id    | Required | The id of the email message that contains the attachment.                                                               |
| Attachment Id | Required | The id of the attachment in the email message.                                                                          |
| Email account | Optional | Specify the email account only if you are getting attachments from a `shared mailbox`.                                  |
