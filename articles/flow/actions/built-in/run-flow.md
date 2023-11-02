# Run Flow (nested execution)

Runs a Flow inside another Flow.

## Properties

| Name              | Type               | Description                                                    |
|-------------------|--------------------|----------------------------------------------------------------|
| Flow              | Required           | The Flow to run. You can only run Flows from the same Workspace. If you need to run a Flow in a different Workspace, you can use a [HTTP request](../http/http-request.md) action. |
| Input             | Optional           | The argument to pass to the Flow you want to run.              |
| Output data type  | Optional           | Specifies the data type of the value returned by the selected Flow. You must specify the data type if you want to use the returned value as input data to other actions in the main Flow. If you don't, the main Flow will assume that the data type is [System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object), which will prevent you from using the returned value as input to most actions. If the selected Flow returns a custom data type, you must toggle `Use custom type(s)` on, and specify the type definition(s) of the custom objects. The easiest way to get the custom type definitions is to open the selected Flow and copy the configuration of the custom types from there. |
| Output variable name | Required        | The name of the variable that contains the value returned value (if any) from the selected Flow. |

### Example

Using the Run Flow action is demonstrated in the [nested execution topic](../../flows/running-flows/nested-execution.md)