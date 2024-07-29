# Defining Custom Types

Actions and Triggers in Profitbase Flow work together by exchanging data using data contracts. In computer systems, data contracts are commonly called data types and define the operations that can be performed on data, ensureing efficient and safe memory usage, contribute to clearer, more maintainable, and less error-prone code. An important benefit of using data types is that it makes it possible to create tooling to help the user during development, testing and debugging.  

Profitbase Flow is built on top of [.NET](https://dotnet.microsoft.com/en-us/), which means that all native .NET data types are available to use. However, most business systems requires custom data types to express business specific domains.

To define a custom type in Profibase Flow, click on the Flowchart (background) and click the `Custom data types` button in the Property panel.   
This will open a popup where you can define one or more data types that you can use in the Flow. Note that the data type is not available to other Flows.

![img](/images/flow/custom-data-types.png)

## Type builder

Use the Type builder when you want to create simple types where all properties are primitive types, such as string, int, double, decimal, DateTime etc.

## Advanced

Use the Advanced mode when you want to create complex business object, for example to represent an Order which contains a list of order lines.  
Example:
```csharp
public class Order(string orderId)
{
    public List<OrderLine> OrderLines {get; set;}
    public string OrderId {get; set;} = orderId;
}

public record OrderLine(string ProductId, int Quantity);
```