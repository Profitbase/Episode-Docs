# Extension Entry

Defines the API of an Extension.

Use this action to define a block of reusable business logic that you want to execute from multiple places _within_ your Flow.  
The Extension Entry action can only be added to an `Extension flowchart`. It defines the entry point of the Extension, and must be the first action of the Extension flowchart.  

You can define any number of parameters, and optionally a return type.

To call the Extension Entry action from another flowchart, use the [Execute object](../built-in/execute-object-method.md) action and select the `This` globally available variable as the object. Then select the name of the Extension entry as the method, and specify arguments to the parameters (if any).

## Properties

| Name               | Type     | Description |
|--------------------|----------|-------------|
|  Name           | Optional   | The name of the flowchart entry point. |
|  Is upgradable  | Optional  | Indicates whether this entry can be upgraded. |
|  Custom data types  | Required | Allows defining custom data types for the flowchart. |
|  Custom code    | Optional | Allows adding custom code to extend functionality. |
|  Description    | Optional | Provides additional information about this flowchart entry. |


![img](../../../../images/flow/extension-entry.png)

![img](../../../../images/flow/call-extension-entry.png)