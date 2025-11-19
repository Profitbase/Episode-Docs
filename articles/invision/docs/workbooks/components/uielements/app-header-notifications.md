# App Header Notifications

To enable notifications for a user’s unread messages, use the **App Header Notifications** component.  
This feature is designed specifically for the App Header and should be added to the toolbar.


![img](/images/invision/appheader-message-notifications.png)

The App Header Notifications is shaped like button, showing a bell icon. When there are new or unread notifications, a red circle will be displayed at the top-right corner of the icon.

<br/>

You can access the App Header toolbar from the workbook toolbar by enabling the **_Show App Header designer_** checkbox. Then, add the **App Header Notifications** component. Read more about App Header [here](../../../header/header-section.md).

<br/>

## Actions
The App Header Notifications supports the following actions:

| Action              | Description                   |
|---------------------|-------------------------------|
| Enable              | Activates the button.           |
| Disable             | Deactivates the button           |
| Execute expression  | Dynamically activates or deactivates the button using the EnableIf(boolean expression) function. [See example below](#example---execute-expression). |


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
| Notification Context Link Clicked | Triggered when a context link in a message is clicked. A context link is defined in the User Chat workbook component and stored for each message added to the chat. |

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

## Context Text and Context Link

If the **User Chat Workbook** component is configured with:

* **Context Text**
* **Context Link**

each message will display the provided **Context Text** as a clickable link.

Read more about **Context Text** in the User Chat workbook component [here](../../../workbooks/components/user-chat.md#context-text)


***

![img](/images/invision/appheader-notifications-message-ctx-link.png)

**Example** ![img](../../../../../../images/strz.jpg)  
The above example shows an example of a message where the **_Context Text_** has been set to **_Sales report_**, made clickable because the **_Context Link_** is also provided.

<br/>

### Notification Context Link Clicked - event
The **App Header Notifications** component requires the event handler **_Notification Context Link Clicked_** to process context link clicks. This handler must be implemented to handle the link as needed.

For example:

* Process the data passed as the link argument and navigate to the desired location, workbook, page, filter, etc.
* Navigate directly to a URL.

<br/>

![img](/images/invision/appheader-notifications-message-ctx-link-click-handler.png)

**Example** ![img](../../../../../../images/strz.jpg)  
The example above shows a **_Notification Context Link Clicked_** handler with an **Action** of type **Execute Expression()**, where the instruction is set to: **_alert(Event.Data)_**.

<br />

The argument **Event.Data** contains the value provided from the User Chat Workbook component in the **_Context Link_**-property.

```javascript
const contextLink = Event.Data
```


<br/>

![img](/images/invision/appheader-notifications-message-ctx-link-click-handler-result.png)

**Example** ![img](../../../../../../images/strz.jpg)  
The example above shows the result of the alert function added to the instructions of the **Execute Expression()** of the handler, where the value set in **_Context Link_** property is **_page=Sales_**.

Read more about **Context Link** on the User Chat workbook component [here](../../../workbooks/components/user-chat.md#context-link)

The data provided can be logic data that has to be processed by the handler, or just a simple url.

<br/>

## Styling
The style of the App Header Notifications cannot be customized. This is intentional, as it inherits the standard appearance of system App Header buttons.

<br/>

## Examples

**Example simple url**
```javascript
window.location.href = Event.Data
```

**Example complex data - e.g. when Event.Data is 'page=Sales'**
```javascript
const args = Event.Data.split('|').reduce((acc, pair) => {
  const [key, value] = pair.split('=');
  acc[key] = value;
  return acc;
}, {})

window.location.href = 'myworkbook/p=' + args.page
```




