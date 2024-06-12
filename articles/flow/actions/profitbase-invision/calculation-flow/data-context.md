# Data context

When executing a Calculation Flow, the Data Context specifies the context of which the Flow is run and determines the slice of data that is processed. When run from InVision, this is typically the filter selections made by the user. For example a specific department, an account group, or a selection of multiple different filters. The Data Context can also be constructed programatically by 3rd party clients or in a [Function](../../built-in/function.md) action.

## Example - Data Context from InVision

To include a Data Context when running the Flow from InVision, [please refer to this example](../../../../invision/docs/flows/how-to/run-flow-from-workbook.md).

## Example - custom Data Context

This example shows how to programatically create a custom [Data Context](data-context.md) for a Calculation Flow.
The code is defined in a [Function](../../built-in/function.md) action.

[!code-csharp[](custom-data-context-example.cs)]

## Example - Clone the Data Context passed in from InVision

When you [run a Flow from an InVision Workbook with a DataContext](../../../../invision/docs/flows/how-to/run-flow-from-workbook.md#example-execute-flow-with-data-context), you sometimes need to make copies of the data context passed in to Flow, and replace certain values, for example which department you want to process data for. The easiest way to do this is to clone the data context passed in as the startup argument, and then modify the cloned object.

The example below shows how use a [Function](../../built-in/function.md) to easily create a new data context by cloning an existing one, and set which department id to use.

The list of dimensions has been loaded using the [Get entitities](../../sql-server/get-entities.md) action, using a query agains the [SYS_Objects](../../../../invision/docs/systemviews.md#sys_objects) view in InVision.

```csharp
public Profitbase.Flow.Extensions.Invision.CalculationFlow.CalculationFlowDataContext CreateScopedDataContext(Profitbase.Flow.Extensions.Invision.CalculationFlow.CalculationFlowDataContext globalDataContext, List<DimensionInfo> dimensions)
{   
    var departmentDimensionId = dimensions.FirstOrDefault(c => c.Name == "Department")?.ObjectID;    
    return globalDataContext
        .Clone()
        .SetReferenceTableDataContext(departmentDimensionId, "DepartmentID", "My-New-Department-Id");
}
```