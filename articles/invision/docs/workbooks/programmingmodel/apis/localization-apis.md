# Localization Service

The following APIs can be used in any [Execute Expression](../interactionmodel/workbookactions.md#execute-expression) Actions or [Form Schema functions](../../../forms/formschemas/functions.md).

#### localize(string, object)

Takes a text code as input and returns the value in the language currently selected by the user. If the text has interpolation params, you can pass an object with substitution variables to the method, and the interpolated text will be returned.

##### API Definition

```javascript
this.app.ui.localization.localize(textCode: string, interpolationParams?: {}) : Promise<string | undefined>
```


##### Example 1

Given the following [translations defined](../../../translationsloc/howto/setup.md):  

| Text code      | Language     |  Text                               |
|----------------|--------------|-------------------------------------|
| TC_ClientAdded | en           | The client was added.               |
| TC_ClientAdded | no           | Klienten ble lagt til.              |

If the user has selected `English (en)` in the Options dialog in the app header, a message box with the text "Client was added" is shown.

```javascript

const message = await this.app.ui.localization.localize('TC_ClientAdded');
this.app.ui.dialogs.showMessage(message);

```

##### Example 2

Given the following [translations defined](../../../translationsloc/howto/setup.md):  

| Text code      | Language     |  Text                               |
|----------------|--------------|-------------------------------------|
| TC_UserDeleted | en           | The user {{userName}} was deleted.  |
| TC_UserDeleted | no           | Brukeren {{userName}} ble slettet.  |

If the user has selected `Norwegian (no)` in the Options dialog, and the user name of the currently logged in user is `luke@rebellion.galaxy`, a message box with the text "Brukeren luke@rebellion.galaxy ble slettet" is shown.

```javascript

const message = await this.app.ui.localization.localize('TC_UserDeleted', {
    userName: this.app.variables.SYS.CurrentUserName
});
this.app.ui.dialogs.showMessage(message);

```  
