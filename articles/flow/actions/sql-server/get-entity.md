# Get entity

Gets a single entity based on a query against a SQL Server database.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/get-entity.png)

<br/>

## Properties

| Name         | Type            | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title              | Optional        | A descriptive title for the action.               |
| Connection      | Required | The [SQL Server Connection](./connection.md).         |
| Dynamic connection | Optional | Use this option of you needs to use a connection from the [Create Connection](./create-connection.md) action. |
| SQL expression and parameters   | Required      | The command to execute along with any parameters.   |
| Entity name | Optional  | Name of the entity data type returned. |
| Entity properties | Required  | Name of the properties and its data types.  |
| Result variable name | Required  | Name of resulting variable containing the entity.  |
| Command timeout (sec) | Optional | The time limit for command execution before it times out. Default is 120 seconds.|
| Description   |  Optional  |  Additional notes or comments about the action or configuration. |

<br/>

## Returns

Returns an object with the properties specified by the `Entity properties` configuration.

An `entity` is a .NET object with one or more properties, for example

```csharp
public record Customer(string VATNumber, string Name, string Address);
```
<br/>

[!INCLUDE [](__videos.md)]
