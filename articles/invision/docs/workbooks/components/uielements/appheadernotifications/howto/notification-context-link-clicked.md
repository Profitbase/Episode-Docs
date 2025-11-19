### Notification Context Link Clicked - event
The **App Header Notifications** component requires the event handler **_Notification Context Link Clicked_** to process context link clicks. This handler must be implemented to handle the link as needed.

For example:

* Process the data passed as the link argument and navigate to the desired location, workbook, page, filter, etc.
* Navigate directly to a URL.

<br/>

![img](/images/invision/appheader-notifications-message-ctx-link-click-handler.png)

**Example** ![img](../../../../../../../../images/strz.jpg)  
The example above shows a **_Notification Context Link Clicked_** handler with an **Action** of type **Execute Expression()**, where the instruction is set to: **_alert(Event.Data)_**.

<br />

The argument **Event.Data** contains the value provided from the User Chat Workbook component in the **_Context Link_**-property.

```javascript
const contextLink = Event.Data
```


<br/>

![img](/images/invision/appheader-notifications-message-ctx-link-click-handler-result.png)

**Example** ![img](../../../../../../../../images/strz.jpg)  
The example above shows the result of the alert function added to the instructions of the **Execute Expression()** of the handler, where the value set in **_Context Link_** property is **_page=Sales_**.

Read more about **Context Link** on the User Chat workbook component [here](../../../../../workbooks/components/userchat/howto/context-link.md)

The data provided can be logic data that has to be processed by the handler, or just a simple url.

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


