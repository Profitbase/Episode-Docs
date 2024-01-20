# DimensionTreeItem<TProps>

Represents an item / member of a [DimensionTree](dimension-tree.md).

## Properties

| Name        | Data type                                                             | Description                                                        |
| ------------|-----------------------------------------------------------------------|--------------------------------------------------------------------|
| Id          | [String](https://learn.microsoft.com/en-us/dotnet/api/system.string)  | The id of the dimension member, for example the department id.     |
| ParentId    | [String](https://learn.microsoft.com/en-us/dotnet/api/system.string)  | The parent id of the dimension member.                             |
| Level       | [Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte)      | The level of the dimension member in the dimension.                |
| Properties  | TProps                                                                | A property object that contains dimension properties when defined. |

## Methods

| Name                | Return type                                 | Description                                                                 |
|---------------------|---------------------------------------------|-----------------------------------------------------------------------------|
| TraverseDown()      | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)<DimensionTreeItem<TProps>>      | Returns descendants of the dimension member in a breadth first order.       |
| TraverseUp()        | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)<DimensionTreeItem<TProps>>      | Returns the ancestors of the dimension member.                              |

[!code-csharp[](DimensionTreeExample.cs)]