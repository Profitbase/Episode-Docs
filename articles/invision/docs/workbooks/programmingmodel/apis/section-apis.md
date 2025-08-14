# Section APIs

The following APIs can be used in any [Execute Expression](../interactionmodel/workbookactions.md#execute-expression) Actions or [Form Schema functions](../../../forms/formschemas/functions.md).

#### open()
Opens a section (panel) in the Workbook.  

**Example**
```javascript
// Opens the left Workbook section.
this.app.ui.sections.left.open();
```


#### close()
Closes a section (panel) in the Workbook.

<br/>

##### API Definition

```javascript

this.app.ui.sections.top.open(): void
this.app.ui.sections.top.close(): void

this.app.ui.sections.left.open(): void
this.app.ui.sections.left.close(): void

this.app.ui.sections.right.open(): void
this.app.ui.sections.right.close(): void
```