
# Form Elements

Form Elements defined in the Solution can be added to the [Workbook](../../workbooks.md) by dragging and dropping them to the desired location. To load and save data, you need to call the LoadData or SaveData actions in response to raised events.

The current value of a [Form Element](../../forms/formelements.md) instance will always be stored in a variable whose name equals the Form Element instance name (Part Name). For example, the current value of a Form Element part having the name "MyFormElement" can be read using the **@Var[MyFormElement]** statement. 

> [!NOTE]
> That [Dropdown](../../forms/formelements/dropdown.md) Form Elements usually contains a list of objects with a display and value member (as specified in the select query), so you would need dot into the object to get either the display or value member.
<br/>

## Actions


*	**LoadData**  
Loads the value for the Form Element from the database.

*	**SaveData**  
Saves the current value of the Form Element to the database.

*	**ExecuteExpression**  
Use this action to dynamically style the Form Element by calling the [AddCssClass(…)](), [RemoveCssClass(…)]() and [ToggleCssClass(…)]() functions.
<br/>

## Events


*	**SelectionChangedEvent**  
This event is raised when the user changes the value of the form element. For text input elements, this event is raised for every character change, and for selection elements the event is raised when a value has been selected.

 *Event Arguments*

 @Event.Data – The current value of the form element is passed as the event argument of the SelectionChangedEvent. @Event.Data can be accessed in Actions handling the event.

 > [!NOTE]
> If Form Element is a selection type element (for example a Dropdown) which contains composite items (objects with display and value members as defined by the select query), the selected object will be passed as the event argument, not just the selected value. To read the value of a property of the selected object, access it using the dot-syntax. (See example 2 below).

<br/>

**Example**
>
>When the user types a new value into a Text Input form element, we want to store the value in a variable, MyVar.
>
>This is done by setting up an ExecuteExpression action with the following instruction when the SelectionChangedEvent is raised:
>
>       MyVar = @Event.Data;


<br/>

**Example**
>
>Using a Dropdown Form Element, having a Value and Display Member of "ProductID" and "ProductName", we want to store the name of the product in a variable, SelectedProductName.
>
>This is done by setting up an ExecuteExpression action with the following instruction when the SelectionChanged event is raised:
>
>       SelectedProductName = @Event.Data.ProductName;



*	**HasUnsavedDataEvent**  
This event is raised the first time the user changes the value of the form element. 

<br/>

## Dynamic styling

A Form Element can be dynamically styled by calling the AddCssClass(…), RemoveCssClass(…) and ToggleCssClass(…) functions in the ExecuteExpression action.

<br/>

**Example**
>
>This example shows 3 different ways to add, remove, or toggle the styling of a Form Element by calling AddCssClass, RemoveCssClass, or ToggleCssClass.
>
>       AddCssClass("highlight");
>
>       RemoveCssClass("highlight underline");
>
>       ToggleCssClass("highlight", x == 250);

<br/>

## Form Element Validation

You can apply validation rules to form elements. Validation rules are expressed as Eaze expressions and must return a Boolean value. The expression must evaluate to true in order for the validation to succeed.

The validation is executed when the form element changes value, for example when the user selects a value in a Dropdown or when the user has entered some text in a Text Input.

When writing validation expressions, you need to use the **@Data** contextual variable to access the current value of the form element.

For Form elements such as Dropdown and Date Picker, @Data contains a complex object reflecting the underlying data type such as the Dropdown Value and DisplayMember or the Date Pickers Date object.

Keep in mind that the value entered into a Text Input form element is always of data type string, even though you enter a "number" like 1000, so if you want to validate the entered value as a numeric type, you need to convert it to a number using the TONUMBER function.

<br/>

**Example**
>
>Suppose we have a Dropdown form element having a Value Member called Pressure, and we would like to validate if the selected item has a Pressure value of at least 1000 (Pa), use the following expression:
>
>       @Data.Pressure >= 1000;

<br/>

**Example**
>
>Suppose we have a Text Input form element, and we would like to verify that the user has entered a value, you can use the following expression:
>
>       L > EN(@Data) > 0;

<br/>

**Example**
>
>Suppose we have a Text Input form element, and we would like to verify that the user has entered a numeric value less than 100, you can use the following expression:
>
>       TONUMBER(@Data) < 100;

<br/>

## More about Form Elements

* [Form Elements](../../forms/formelements.md)

## See Also

* [Label](../../forms/formelements/label.md)
* [Textbox](../../forms/formelements/textbox.md)
* [Dropdown](../../forms/formelements/dropdown.md)
* [Date Picker](../../forms/formelements/datepicker.md)