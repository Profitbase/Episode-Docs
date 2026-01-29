# Get Startup argument

Gets the data (if any) passed to the Flow from the caller.

Use **Get startup argument** when your flow is designed to be called by another flow (or an external caller) and you need to read the input payload that was sent with the call.

Typical use cases:
- A helper flow that calculates values and returns the result to the caller.
- A reusable flow that behaves differently based on the input passed at startup.
- Passing parameters between flows without storing state.

![img](../../../../images/flow/get-startup-argument.png)

**Example** ![img](../../../../images/strz.jpg)  
This example shows a flow that starts with an [HTTP Trigger](../../triggers/http-trigger.md), reads the input payload using Get startup argument, [calculates](function.md) an end date based on that input, and [returns](return.md) the calculated end date to the calling flow.

![img](../../../../images/flow/get-startup-argument1.png)

## How the call works

To call this flow from another flow:

1. Add an **HTTP request** action in the calling flow.
2. Set **Method** to `POST`.
3. Set **URI** to the endpoint URL of the target flow.
4. Pass the input data in the **Body** of the request.

When the target flow starts, **Get startup argument** exposes the request body as `startupArgument`.  
The flow uses this value to calculate the end date and the **Return** action sends the result back in the HTTP response.

>[!NOTE]
> This action can only be used in the Main flowchart.
