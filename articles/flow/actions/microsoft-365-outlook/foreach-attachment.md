# Foreach attachment

Iterates over the attachments in an email in Microsoft 365 Outlook.

Use this action to get all file attachments from an email in Microsoft 365 Outlook and process them one by one.

![img](../../../../images/flow/microsoft-365-outlook-foreach-attachment.png)

## Properties

| Property      | Type     | Description                                                                                                             |
| ------------- | -------- | ----------------------------------------------------------------------------------------------------------------------- |
| Connection    | Required | A [Microsoft 365 Outlook connection](./outlook-connection.md) which grants Profitbase Flow access to the email account. |
| Message Id    | Required | The id of the email message that contains the attachments.                                                              |
| Email account | Optional | Specify the email account only if you are getting attachments from a `shared mailbox`.                                  |
