# Get entities

Gets a list of entities from a query against a SQL Server database.

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


![img](https://profitbasedocs.blob.core.windows.net/flowimages/get-entities.png)



## Properties

| Name         | Data type       | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title           |  Optional | The title or name of the command.      |
| Connection         | Required   | The SQL Server connection. |
| SQL expression and parameters   | Required      | The command to execute along with any parameters.   |
| Entity name | Optional  |   |
| Entity properties | Required  |   |
| Result variable name | Required  | Name of resulting list of entities variable  |
| Result data type | Optional  |   |
| Command timeout (sec) | Optional | The time limit for command execution before it times out. Default is 120 seconds.|
| Description   | Optional | Additional notes or comments about the action or configuration. |
