# Get entity

Gets a single entity based on a query against a SQL Server database.

## Returns

Returns an object with the properties specified by the `Entity properties` configuration.

An `entity` is a .NET object with one or more properties, for example

```csharp
public record Customer(string VATNumber, string Name, string Address);
```

![img](https://profitbasedocs.blob.core.windows.net/flowimages/get-entity.png)

## Properties

| Name         | Data type       | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title           |           |                        |
| Connection         | Required   | InVision SQL Server connection. |
| SQL expression and parameters   | Required      |  |
| Entity name | Optional  |   |
| Entity properties | Required  |   |
| Result variable name | Required  | Name of resulting variable  |
| Command timeout (sec) | Optional | Command timeout in seconds.|
| Description   |  Optional  |  Additional notes or comments about the action or configuration. |
