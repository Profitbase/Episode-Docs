# When a new email arrives

Runs the Flow when a new email arrives in a Microsoft 365 mailbox.

Use this action to run a Flow when a new mail arrives in a Microsoft 365 Outlook mailbox. To do this, you need to create a [Microsoft 365 Outlook connection](../../actions/microsoft-365-outlook/outlook-connection.md) by logging on with an account having access to the mailbox.

## Attachments

When the trigger runs, only metadata about attachments (if any) in the message is returned. To get the actual content of the attachments, you need to use actions such as the [Get attachment](../../actions/microsoft-365-outlook/get-attachment.md) or [Foreach attachment](../../actions/microsoft-365-outlook/foreach-attachment.md) actions to download the files.

## Properties

<!--prettier-ignore-->
| Property          | Type      | Description                                               |
|-------------------|-----------------------------------------------------------------------|
| Connection        | Required  | Specifies the [Microsoft 365 Outlook connection](../../actions/microsoft-365-outlook/outlook-connection.md) that the trigger should use to check for new emails. |
| Polling interval  | Required  | Specifies how often to check for new emails.              |
| Disabled          | Optional  | Specifies if the trigger should be disabled. You may want to disable the trigger in the Development and Test environment once you have published to Production. |
| Filter            | Optional  | Specifies optional filters to restrict which emails to receive. See detailed description below. | 
| Folder            | Optional  | Specifies the folder to monitor for new emails. If not specified, all folders are monitored. |
| Output name       | Required  | The name of the output variable that represents the received mail message. You can change it from the default `mailMessage` to something that more clearly describes the received mail, for example `customerFeedbackMessage`. |

#### Filter

[!INCLUDE [filters](../../actions/microsoft-365-outlook/mail-filters-paragraph.md)]
