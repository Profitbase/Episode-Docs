# Get attachment

Gets an attachment from an email in Microsoft 365 Outlook.

![img](/images/flow/microsoft-365-outlook-get-attachment.png)

When email messages are retrieved by Profitbase Flow, only metadata about attachments are included. The actual content of the attachments must be fetched using separate actions, such as the `Get attachment` action described in this topic.

## Properties

| Property      | Type     | Description                                               |
| ------------- | -------- | --------------------------------------------------------- |
| Message Id    | Required | The id of the email message that contains the attachment. |
| Attachment Id | Required | The id of the attachment in the email message.            |
