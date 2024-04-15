# Extension Entry

Defines the API of an Extension.

Use this action to define a block of reusable business logic that you want to execute from multiple places _within_ your Flow.  
The Extension Entry action can only be added to an Extension flowchart. It defines the entry point of the Extension, and must be the first action of the Extension flowchart.  

You can define any number of parameters, and optionally a return type.

To call the Extension Entry action from another flowchart, use the [Execute object](../built-in/execute-object-method.md) action and choose the `This` globally available variable as the object. Then choose the name of the Extension entry as the method.