# App Header Notifications

To enable notifications for a user’s unread [chat messages](../../../components/userchat/user-chat.md), use the **App Header Notifications** component.  
This feature is designed specifically for the App Header and should be added to the toolbar.


![img](/images/invision/appheader-message-notifications.png)


The App Header Notifications is shaped like button, showing a bell icon. When there are new or unread notifications, a red circle will be displayed at the top-right corner of the icon.

<br/>

You can access the App Header toolbar from the workbook toolbar by enabling the **_Show App Header designer_** checkbox. Then, add the **App Header Notifications** component. [App Header](../../../../header/header-section.md).

<br/>

## Actions
The App Header Notifications supports the following actions:

| Action              | Description                   |
|---------------------|-------------------------------|
| Enable              | Enables the button.           |
| Disable             | Disables the button           |
| Execute expression  | Dynamically enables or disables the button using the EnableIf(boolean expression) function. |


**Example: Execute Expression()**<br/>
To dynamically set the enabled state of the button based on whether the _state.Counter is 0 or not, enter the following expression in the `Instructions` panel:

```javascript
EnableIf(_state.Counter === 0);
```

<br/>

## Events
The App Header Notifications supports the following event:

| Event name           | Description                                     |
|----------------------|-------------------------------------------------|
| Notification Context Link Clicked | Triggered when a context link in a message is clicked. A context link is defined in the [User Chat workbook component](../../userchat/howto/context-link.md) and stored for each message added to the chat. |

<br/>

## Notifications
When the button is clicked, a pop down will appear beneath it, showing a list of all unread messages for the logged-in user.

Each message includes:<br/>
* The name of the chat solution item (or its translated name from the text code).
* Optional context text from the User Chat Workbook component. If a context link is provided, the context text becomes clickable.
* The sender’s name. 

<br/>

> [!NOTE]
> Clicking a message automatically marks all messages from the same chat as read. Read messages will not appear as new or unread the next time the page is loaded.

<br/>

![img](/images/invision/appheader-new-message-notifications.png)

<br/>

## Styling
The style of the App Header Notifications cannot be customized. This is intentional, as it inherits the standard appearance of system App Header buttons.

<br/>


# See Also
* [How to's](./howto/index.md)