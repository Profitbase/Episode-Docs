#### Defining custom code within schemas

Defining Custom code is an advanced feature which enables you to write custom C# code that can be used in Function actions in a Flow. The custom code you can write ranges from custom classes, to just helper functions that you want to reuse throughout the Flow. Note that the custom code is not available to other Flows in the Workspace. When writing custom code, you have access to the entire .NET SDK class library. If you need to use features that are not part of .NET, you must use an external API (such as an Azure Function) to do the work and return the result to Flow.