# Send email

Send email using SendGrid.


![img](../../../../images/flow/send-grid-email.png)

To get started, visit [SendGrid docs here](https://docs.sendgrid.com/).  
Read more about how to [Send email with Microsoft Azure here](https://docs.sendgrid.com/for-developers/partners/microsoft-azure-2021).


## Properties

| Name | Type | Description                                                                 |
|----------------------|-------------------|-----------------------------------------------------------------------------|
| Title                |           |                                                                   |
| Connection           | Required          | Select or create a new connection.                                                         |
| From email           | Required          | Enter the "from" email address.                                               |
| From name            | Required          | Enter the display name of the sender.                                        |
| To                   | Required          | Enter email addresses separated by semicolons.                               |
| Subject              | Required          | Enter the subject.                                                           |
| Message              | Required          | Define message.                                                              |
| Attachments          | Optional          | Select or edit attachments.                                       |
| Description          | Optional          | Additional information or context for the email.                |
