# Flow trigger

A Flow trigger defines the entry point of a Flow when it is executed from another Flow.
The Flow trigger also defines how to convert data passed as input, to a format that can be used in the Flow. 
<br/>

![img](/images/flow/flow-trigger.png)

**Example**![img](/images/strz.jpg)  
This flow receives an order request, creates a new order ID, saves the order and its order lines into the database, and finally returns the completed order object back to the caller.

<br/>

## Properties

| Name                 | Type       | Description                                                   |
|----------------------|------------|---------------------------------------------------------------|
| Output data type     | Required   | Defines the data type of the object that the trigger outputs. By defining a data type, you define a contract of what the Flow expects as input. The trigger will try to convert input to the Flow to the specified data type. If the input cannot be converted to the specified type and format, the execution will fail. |
| Output variable name | Required   | The name of the variable that the output from the trigger is stored in. |

<br/>

## Returns

This trigger returns a single variable with the specified name and Output data type. 

![img](../../../images/flow/schedule-trigger-output-type.png)
<br/>

### Example

Using the Flow trigger is demonstrated in the [nested execution topic](../flows/running-flows/nested-execution.md).