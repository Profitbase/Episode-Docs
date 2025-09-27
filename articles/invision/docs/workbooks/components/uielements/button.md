# Button

![btn](https://profitbasedocs.blob.core.windows.net/images/btnUI.png)

<br/>



<br/>

## Actions
The Button component supports the following actions.

| Action              | Description                   |
|---------------------|-------------------------------|
| Enable              | Enables the button. Note that if the `Disable if Workbook is read-only` property is enabled, and the Workbook is in read-only mode, the Enable action will have no effect. |
| Disable             | Disables the button.          |
| Execute expression  | The following functions are supported: <br/><br/>[EnableIf(...)](../../programmingmodel/instructions/enableif.md) to dynamically enable or disable the button.([See example below](#example---execute-expression)). <br/>[AddCssClass(…)](../../programmingmodel/instructions/cssclass.md), [RemoveCssClass(…)](../../programmingmodel/instructions/cssclass.md) and [ToggleCssClass(…)](../../programmingmodel/instructions/cssclass.md) to dynamically style the button. |


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

## Enabling and disabling

**Explicit enabling and disabling**  
A Button can be explicitly enabled and disabled by executing the `Enable` and `Disable` actions when handling an event. You would typically do this when executing a long-running task, by disabling the button when the task starts, and enable it when the task finishes.  

**Conditional enabling and disabling**  
A Button can be enabled or disabled based on the state of a filter or a variable.
Conditional enabling and disabling is performed by executing the EnableIf(..) instruction in the ExecuteExpression action of the button.

> [!NOTE]
> If the `Disable if Workbook is read-only` property is enabled, and the Workbook is in read-only mode (for example when the Work Process version it belongs to is closed), the button will always be disabled even if you run actions to enable it.

<br/>

**Example 1**

This example shows how to conditionally enable or disable a button based on the selected value of a filter. The EnableIf(..) instruction executes in the ExecuteExpression action of the button when the selected value of the filter is changed.

```
EnableIf(Filter("Filters","Department").SelectedValue.IsLeaf);
```

The Filter(a,b) function returns an object representing the selected filter value, having a Boolean property IsLeaf.
If the selected value of the «Department» filter is at the leaf (lowest) level, the button is enabled, otherwise, it is disabled.

<br/>

**Example 2**

This example shows how to enable or disable a button based on the level number of the selected value of a filter. The selected value must be at level 2 or higher in the hierarchy.

```
EnableIf(Filter("Filters", "Department").SelectedValue.Level >= 2);
```

<br/>

## Dynamic styling

A Button can be dynamically styled by calling the AddCssClass(…), RemoveCssClass(…) and ToggleCssClass(…) functions in an ExecuteExpression action.

<br/>

**Example**

This example shows 3 different ways to add, remove, or toggle the styling of a button by calling AddCssClass, RemoveCssClass, or ToggleCssClass.

```
AddCssClass("highlight");
```

```
RemoveCssClass("highlight underline");
```

```
ToggleCssClass("highlight", x == 250);
```

<br/>

## Videos

- [Workbooks](../../../../videos/workbooks.md)
- [Components - Buttons](https://profitbasedocs.blob.core.windows.net/videos/Workbook%20-%20Buttons.mp4)
