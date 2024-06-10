# APIs

The following APIs can be used in any [Execute Expression Actions](../programmingmodel/interactionmodel/workbookactions.md#execute-expression) or [Form Schema functions](../../forms/formschemas/functions.md).

[Dialog Service APIs](./apis/dialog-service-apis.md)  
[Filter APIs](./apis/filter-apis.md)  
[Flow APIs](./apis/flow-apis.md)  
[HTTP APIs](./apis/http-apis.md)  
[Message Hub APIs](./apis/message-hub-apis.md)  
[Toast Notification APIs](./apis/toast-notification-apis.md)  
[Localization APIs](./apis/localization-apis.md)  


## Generic networking API

#### apiBase()

Returns the base API endpoint for InVision, for example `https://app1.profitbase.com/customer/`

```javascript
this.app.net.apiBase() : string
```

