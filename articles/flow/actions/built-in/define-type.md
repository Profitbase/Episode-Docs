# Define type

Defines one or more custom data types using a type builder interface, JSON schema or C#.

Use the type builder when the data type of all properties in the custom type is a [built-in .NET type](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types).  

If you need to define complex, nested types, use the C# or JSON schema editor in the `Advanced` tab.


<!-- ![img](../../../../images/flow/decrement-value.png)

<br/> -->

## Properties

| Name         | Data type       | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title           | Optional | The title or name of the action.     |
| Type definition         | Required   | Definition of one or more custom data types using JSON schema or C#. |
| Description   | Optional      | Additional notes or comments about the action or configuration.   |