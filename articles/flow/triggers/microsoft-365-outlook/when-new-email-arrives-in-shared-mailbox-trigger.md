# When a new email arrives in a shared mailbox

Runs the Flow when a new email arrives in a shared Microsoft 365 mailbox.

Use this action to run a Flow when a new mail arrives in a shared Microsoft 365 Outlook mailbox. If you don't already have one, you need to first create a [Microsoft 365 Outlook connection](../../actions/microsoft-365-outlook/outlook-connection.md) by logging on with an account having access to the shared mailbox.

![img](/images/flow/microsoft-365-outlook-when-email-arrives.png)

## Properties

<!--prettier-ignore-->
| Property            | Type      | Description                                               |
|---------------------|-----------------------------------------------------------------------|
| Connection          | Required  | Specifies the [Microsoft 365 Outlook connection](../../actions/microsoft-365-outlook/outlook-connection.md) that the trigger should use to check for new emails. |
| Polling interval    | Required  | Specifies how often to check for new emails.              |
| Disabled            | Optional  | Specifies if the trigger should be disabled. You may want to disable the trigger in the Development and Test environment once you have published to Production. |
| Shared email account| Required  | Specifies the email address of the shared email account to monitor, for example `support@corp.com`.   |
| Filter              | Optional  | Specifies optional filters to restrict which emails to receive. See detailed description below. | 
| Folder              | Optional  | Specifies the folder to monitor for new emails. If not specified, all folders are monitored. |
| Include attachments | Optional  | Specifies whether or not to fetch the contents of all attachments when the trigger runs. [Read more about this option below](#attachments). |
| Output name         | Required  | The name of the output variable that represents the received mail message. You can change it from the default `mailMessage` to something that more clearly describes the received mail, for example `customerFeedbackMessage`. |

#### Filter

[!INCLUDE [filters](../../actions/microsoft-365-outlook/mail-filters-paragraph.md)]

## Attachments

If `Include attachments` is set to false (unchecked), only metadata about any attachments in the message is included when the trigger runs.
If this is the case, you need to use an additional action such as [Get attachment](../../actions/microsoft-365-outlook/get-attachment.md) or [Foreach attachment](../../actions/microsoft-365-outlook/foreach-attachment.md), to get the actual file contents of the attachments.  
If emails contains large attachments, and you don't need all of them when processing the messages, it is recommended to set the `Include attachments` to false, and instead selectively get attachments you need using the [Get attachment](../../actions/microsoft-365-outlook/get-attachment.md) action.
