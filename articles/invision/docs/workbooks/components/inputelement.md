
# Input Elements

Input Elements are similar to [Form Elements](formelements.md), except they do not have a backend data binding (no LoadData and SaveData actions with [SQL queries](../../sqlreports/dataqueries.md) to handle the database serialization).

## Actions

*	**UpdateValue**  
Used for setting the value of the Input Element. The value is set by assigning a value to the Input Element in the UpdateValue instructions list. To assign a value to an Input Element, you need to address the Input Element by name and set its **.Value** property.


**Example**
>
>If you have an Input Element called Input_CustomerName, you can update its value by using the following statement in the UpdateValue actions.
>
>       Input_CustomerName.Value = "customer name";



*	**ExecuteExpression**  
The primary use case for this action in the context of an Input Element is to use the [AddCssClass(…)](../programmingmodel/instructions/cssclass.md), [RemoveCssClass(…)](../programmingmodel/instructions/cssclass.md) and [ToggleCssClass(…)](../programmingmodel/instructions/cssclass.md) functions to change its style.
You can also change the read-only state of the Input element by calling [SetReadOnly(…)](../programmingmodel/instructions/setreadonly.md).

## Events

*	**ValueChanged**  
This event is raised when the value of an Input Element changes, either through user interaction or if its value is changed from a UpdateAction.

## Properties

*	**Step**  
The step attribute specifies the legal number intervals for an < input > element.
The step attribute works with the following input types: number, range, date, datetime, datetime-local, month, time, and week.
*	**Tab Index**  
Represents the tab order of the current element. 

```
[HTMLOrForeignElement.tabIndex]
(https://developer.mozilla.org/en-US/docs/Web/API/HTMLElement/tabIndex).
```



## Videos

* [Workbooks](../../../videos/workbooks.md)
* [Input Element](https://profitbasedocs.blob.core.windows.net/videos/Workbook%20-%20Input%20Element.mp4)