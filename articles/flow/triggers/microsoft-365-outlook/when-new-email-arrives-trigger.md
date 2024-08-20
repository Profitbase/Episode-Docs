# When a new email arrives

Runs the Flow when a new email arrives in a Microsoft 365 mailbox.

Use this action to run a Flow when a new mail arrives in a Microsoft 365 Outlook mailbox. To do this, you need to create a [Microsoft 365 Outlook connection](../../actions/microsoft-365-outlook/outlook-connection.md) by logging on with an account having access to the mailbox.

## Properties

#### Connection

Specify the [Microsoft 365 Outlook connection](../../actions/microsoft-365-outlook/outlook-connection.md) that the trigger should use to check for new emails.

#### Polling interval

Specifies how often to check for new emails.

#### Disabled

Specifies if the trigger should be disabled. You may want to disable the trigger in the Development and Test environment once you have published to Production.

#### Filter

[!INCLUDE [filters](../../actions/microsoft-365-outlook/mail-filters-paragraph.md)]

#### Folder

#### Output name

The name of the output variable that represents the received mail message. You can change it from the default `mailMessage` to something that more clearly describes the received mail, for example `customerFeedbackMessage`.
