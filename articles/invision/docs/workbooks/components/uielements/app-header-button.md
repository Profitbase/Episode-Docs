# App Header Button

Use the App Header Button only when you want to customize the App Header by adding custom buttons to the toolbar. 

![img](/images/invision/appheader-button-example1.png)

<br/>

## Actions
The App Header Button supports the following actions.

| Action              | Description                   |
|---------------------|-------------------------------|
| Enable              | Enables the button.           |
| Disable             | Disables the button           |
| Execute expression  | Enables dynamically enabling / disabling the button by calling the EnableIf(boolean expression) function. [See example below](#example---execute-expression). |


#### Example - Execute expression
To dynamically set the enabled state of the button based on whether the _state.Counter is 0 or not, enter the following expression in the `Instructions` panel:

```javascript
EnableIf(_state.Counter === 0);
```

<br/>

## Events
The App Header Button supports the following events.

| Event name           | Description                                     |
|----------------------|-------------------------------------------------|
| Tapped               | This event is raised when the button is clicked. |

<br/>

## Button image
You need to specify the image displayed by the button. You can select from a range of built-in images, use one of your custom uploaded images, or refer to an image url. To specify the image, select the button and specify the `Image` in the `property panel`.

## Styling
Apart from specifying an image, the App Header Button's style cannot be customized. This is by design, and it automatically inherits the standard appearance of system App Header buttons.


