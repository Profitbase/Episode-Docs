# DimensionTreeItem<TProps>

Represents an item / member of a [DimensionTree](dimension-tree.md).

## Properties

| Name        | Data type    | Description                                                        |
| ------------|--------------|--------------------------------------------------------------------|
| Id          | String       | The id of the dimension member, for example the department id.     |
| ParentId    | String       | The parent id of the dimension member.                             |
| Level       | Byte         | The level of the dimension member in the dimension.                |
| Properties  | TProps       | A property object that contains dimension properties when defined. |

## Methods

| Name                | Return type                                 | Description                                                                 |
|---------------------|---------------------------------------------|-----------------------------------------------------------------------------|
| TraverseDown()      | IEnumerable<DimensionTreeItem<TProps>>      | Returns descendants of the dimension member in a breadth first order.       |
| TraverseUp()        | IEnumerable<DimensionTreeItem<TProps>>      | Returns the ancestors of the dimension member.                              |

[!code-csharp[](DimensionTreeExample.cs)]