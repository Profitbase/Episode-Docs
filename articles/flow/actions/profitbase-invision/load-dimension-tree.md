# Load Dimension tree

Loads a Dimension hierarchy to memory as a DimensionTree object. You can then search the tree for members, and traverse up and down each member path.  

## Methods

| Name                                       | Description                                                                                               |
|--------------------------------------------|-----------------------------------------------------------------------------------------------------------|
| FindMember(string)                         | Finds a [DimensionMember]() with the specified id. Returns `null` if no match can be found.               |
| FindMemberOrDefault(string)                | Finds a [DimensionMember]() with the specified id. Returns an empty member if no match can be found.      |
| TryFindMember(string, [DimensionMember]()) | Finds a [DimensionMember]() with the specified id. Returns true if the member was found, otherwise false. |

## Example

1) Add a Load Dimension tree action to a Flow
2) In the property panel, select a `Connection`
3) In the property panel, select a `Dimension`
4) Add a [Function](../built-in/function.md) action to the Flow and pass in the dimension as a argument. 

```csharp
public void UseDimension()
```