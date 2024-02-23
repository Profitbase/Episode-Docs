# Data context

When executing a Calculation Flow, the Data Context specifies the context of which the Flow is run and determines the slice of data that is processed. When run from InVision, this is typically the filter selections made by the user. For example a specific department, an account group, or a selection of multiple different filters. The Data Context can also be constructed programatically by 3rd party clients or in a [Function](../../built-in/function.md) action.

## Example - Data Context from InVision

To include a Data Context when running the Flow from InVision, [please refer to this example](../../../../invision/docs/flows/how-to/run-flow-from-workbook.md).

## Example - custom Data Context

This example shows how to programatically create a custom [Data Context](data-context.md) for a Calculation Flow.
The code is defined in a [Function](../../built-in/function.md) action.

[!code-csharp[](custom-data-context-example.cs)]