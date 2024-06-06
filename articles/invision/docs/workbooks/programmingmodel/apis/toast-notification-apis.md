# Toast notification API

The following APIs can be used in any [Execute Expression](../interactionmodel/workbookactions.md#execute-expression) Actions or [Form Schema functions](../../../forms/formschemas/functions.md).

#### showSuccess({string, string})

Shows a success toast notification.

##### API Definition

```javascript
this.app.ui.toasts.showSuccess({title: string, text: string})
this.app.ui.toasts.showSuccess(text: string)
```

##### Example

The following example shows how to display a toast notification in a [Execute Expression](../interactionmodel/workbookactions.md#execute-expression) Actions or [Form Schema functions](../../../forms/formschemas/functions.md).

```javascript
this.app.ui.toasts.showSuccess({title: "Submit order", text: "The order was successfully submitted."})
```

#### showError({string, string})
#### showError(string)

Shows a error toast notification.

##### API Definition

```javascript
this.app.ui.toasts.showError({title: string, text: string})
this.app.ui.toasts.showError(text: string)
```

#### showInfo({string,string})
#### showInfo(string)

Shows a information toast notification.

##### API Definition

```javascript
this.app.ui.toasts.showInfo({title: string, text: string})
this.app.ui.toasts.showError(text: string)
```

#### showWarning({string,string})
#### showWarning(string)

Shows a warning toast notification.

##### API Definition

```javascript
this.app.ui.toasts.showWarning({title: string, text: string})
this.app.ui.toasts.showError(text: string)
```