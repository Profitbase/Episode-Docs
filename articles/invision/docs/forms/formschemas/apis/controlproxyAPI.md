---
title: "Control API"
metaKeys: "ControlProxy API, hide, hideIf, show, showIf, AddCss, collapse, SetValidity, validateRequired, NativeElement, RemoveCss, ToggleCss, Disable, DisableIf, Enable, EnableIf, SetIsEnabled "
pageIndex: 2
---

`hide()`  
Hides a control by setting its visibility property to hidden. This will not remove the control from the DOM.

**Example**

```js
controls.Input1.hide();
```

<br/>

`hideIf(condition: boolean)`  
Conditionally hides a control.

**Example**  
 This example shows whether a control is shown or hidden based on a product id from the Workbook.

```js
Controls.Input1.hideIf(AppVariables.CurrentProductID == "Product123");
```

<br/>

`collapse()`  
Hides a control by setting its display property to none so that it will not take up any space in the DOM.

**Example**

```js
controls.Input1.collapse();
```

<br/>

`show()`  
Shows a control by setting its visibility to visible.

**Example**

```javascript
controls.Input1.show();
```

<br/>

`showIf(condition: boolean)`  
Conditionally shows or hides a control.

**Example**  
This example shows whether a control is shown or hidden based on a product id from the Workbook.

```js
Controls.Input1.showIf(AppVariables.CurrentProductID == "Product123");
```

<br/>

`addCss(cssClass : string)`  
Adds one or more css classes to the to the HTML Element if the css classes are not already applied.

**Examples**

```js
Controls.Input1.addCss("bold alert");
Controls.Input1.addCss("positive-number");
```

<br/>

`setValidity(isValid : true | false, text? : string, cssClass? : string)`  
Sets the validity state of a control.

- Passing false as the **isValid** argument will draw a red border around the control.
- Passing a **text** argument will display an error message below the control. _This argument is optional._
- Passing a **cssClass** argument enables you to apply custom styling to the control. _This argument is optional._

**Example**

```js
var isValid = this.someComplexValidation(models.Customer.Name);
controls.CustomerName.setValidity(isValid, texts.Fields_Is_Required);
```

<br/>

`validateRequired(text? : string, cssClass? : string)`  
Validates that the input control (Dropdown, Text Area or Input) has a value.

- Passing a **text** argument will display an error message below the control. _This argument optional._
- Passing a cssClass argument enables you to apply custom styling to the control. _This argument is optional._

**Example**  
This example shows how to validate that the Input_Email control has a value. If it does not, the text represented by the Email_Required text resource is displayed as the validation failure message.

```js
controls.Input_Email.validateRequired(texts.Email_Required);
```

<br/>

`nativeElement()`  
Returns the native DOM element of the control.

<br/>

`setIsVisible(isVisible: boolean)`
Sets the visibility of the control.

**Example**

```js
Controls.Input1.setIsVisible(IsVisible.CurrentProductID == "Product123");
```

<br/>

`removeCss(cssClass : string)`  
Removes the css class of the control.

<br/>

`toggleCss(cssClass: string, condition: boolean)`  
Toggles the css class of the control depending on the condition.

<br/>

`disable()`  
Disables the control.

**Example**

```js
controls.Input1.enable();
```

<br/>

`disableIf(condition: boolean)`  
Disables the control if the condition is true.

**Example**

```js
Controls.Input1.disableIf(AppVariables.CurrentProductID == "Product123");
```

<br/>

`enable()`  
Enables the control.

**Example**

```js
controls.Input1.enable();
```

<br/>

`enableIf(condition: boolean)`  
Enables the control if the condition is true.

**Example**

```js
Controls.Input1.enableIf(AppVariables.CurrentProductID == "Product123");
```

<br/>

`setIsEnabled(isEnabled: boolean)`  
Sets the status of the control as Enabled.
