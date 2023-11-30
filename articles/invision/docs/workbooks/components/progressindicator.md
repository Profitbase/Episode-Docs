
# Progress Indicator

The progress indicator displays a spinner and text that can be started and stopped for long-running tasks, such as the execution of [Data Flows](../../dataflows/index.md) when you're not displaying the Data Flow execution UI.

## Actions

*	**ExecuteExpression**

 Use this action to dynamically style the Progress Indicator by calling the [AddCssClass(…)](), [RemoveCssClass(…)]() and [ToggleCssClass(…)]() functions.

## Dynamic styling

A Progress Indicator can be dynamically styled by calling the [AddCssClass(…)](), [RemoveCssClass(…)]() and [ToggleCssClass(…)]() functions in the ExecuteExpression action.

>**Example**
>
>This example shows 3 different ways to add, remove, or toggle the styling of a Progress Indicator by calling AddCssClass, RemoveCssClass, or ToggleCssClass.
>
>       AddCssClass("hightlight");
>
>       RemoveCssClass("hightlight underline");
>
>       ToggleCssClass("highlight", x == 250);




