# DimensionTree<TProps>

Represents a parent-child dimension tree.

## Methods

| Name                                       | Description                                                                                               |
|--------------------------------------------|-----------------------------------------------------------------------------------------------------------|
| FindMember(string)                         | Finds a [DimensionTreeItem](dimension-tree-item.md) with the specified id. Returns `null` if no match is found.                   |
| FindMemberOrDefault(string)                | Finds a [DimensionTreeItem](dimension-tree-item.md) with the specified id. Returns an empty member if no match is found.          |
| TryFindMember(string, [DimensionTreeItem](dimension-tree-item.md)) | Finds a [DimensionTreeItem](dimension-tree-item.md) with the specified id. If a member with the specified id is found, the method returns true as the return value and the member in the out variable. If there is no match for the id, the method returns false and the out variable is null. |

## Example

This example shows how to use the dimension tree API in a [Function](../../built-in/function.md).

[!code-csharp[](DimensionTreeExample.cs)]