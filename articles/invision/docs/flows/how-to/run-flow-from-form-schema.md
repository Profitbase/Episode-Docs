# How to: Run Flow from Form Schema

To run a Flow from a Form Schema, use the [Flow API](../../forms/formschemas/apis/flow-api.md) from a [Function](../../forms/formschemas/functions.md) and specify the name of the Flow, and optionally the data payload.

## Example

This example shows how to run a Flow from a Form Schema. It uses the [Flow API](../../forms/formschemas/apis/flow-api.md) to run the Flow named "Activate Contract". Note that the "Activate Contract" Flow and the Form Schema must be in the same InVision Solution.

```xml
<Function Name="RunMyFlow" Async="true">
    const activationResult = await this.flow.execute("Activate Contract", {
       data: {
           contractId: this.models.Contract.ContractId
       }
    });
    
    // Do something with the data returned from the Flow. 
    // The contents of the activationResult depends on the implmentation of the "Activate Contract" Flow.
    console.log(activationResult.activated);
</Function>
```

