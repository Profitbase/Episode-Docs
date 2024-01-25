# Get entities

Gets a list of entities based on a query agains a SQL Server database.

An `entity` is a .NET object with one or more properties, for example

```csharp
public record Customer(string VATNumber, string Name, string Address);
```

This actions returns a list of entities with properties as specified by the `Entity properties` configuration, for example

```csharp
List<Customer> customers;
```

## Returns

A [List](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1) of custom .NET objects with properties specified by the `Entity properties` configuration.