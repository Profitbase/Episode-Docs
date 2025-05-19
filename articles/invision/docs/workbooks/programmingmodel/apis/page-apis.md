# Page APIs

The following APIs can be used in any [Execute Expression](../interactionmodel/workbookactions.md#execute-expression) Actions or [Form Schema functions](../../../forms/formschemas/functions.md).

#### navigateTo()
Navigates to a page. If a page is a defined as a Popup page, the popup is opened. If the page is defined as a [Drawer](../../drawers.md) page, the drawer is opened.
If the user does not have access to the page, 

#### show()
Shows a page in the application menu, or opens a [Drawer](../../drawers.md). This API is intended to be used when you want to conditionally show or hide a page in the application menu.  
Calling show() and hide() on a page displayed in a [Drawer](../../drawers.md) will also open and close the Drawer.

#### hide()
Hides a page from the application menu, or closes a [Drawer](../../drawers.md). This API is intended to be used when you want to conditionally show or hide a page in the application menu.  
Calling show() and hide() on a page displayed in a [Drawer](../../drawers.md) will also open and close the Drawer.

<br/>

##### API Definition

```javascript
this.app.ui.pages.get(pageIdOrName: string).navigateTo() : Promise<number>
this.app.ui.pages.get(pageIdOrName: string).show() : Promise<number>
this.app.ui.pages.get(pageIdOrName: string).hide() : Promise<number>
```