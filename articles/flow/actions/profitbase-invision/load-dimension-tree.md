# Load Dimension tree

Loads a Dimension hierarchy to memory as a DimensionTree object. You can then search the tree for members, and traverse up and down each member path.  

## Methods

| Name                                       | Description                                                                                               |
|--------------------------------------------|-----------------------------------------------------------------------------------------------------------|
| FindMember(string)                         | Finds a [DimensionMember]() with the specified id. Returns `null` if no match can be found.               |
| FindMemberOrDefault(string)                | Finds a [DimensionMember]() with the specified id. Returns an empty member if no match can be found.      |
| TryFindMember(string, [DimensionMember]()) | Finds a [DimensionMember]() with the specified id. Returns true if the member was found, otherwise false. |

## Example

The example below describes how to use a dimension in a [Function](../built-in/function.md) to find a dimension member by id, traversing ancestors and descendants and using dimension properties to perform business logic. 

1) Add a Load Dimension tree action to a Flow
2) In the property panel, select a `Connection`
3) In the property panel, select a `Dimension`
4) In the property panel, optionally choose one or more `Properties`. Note that not all dimensions have properties.
5) Add a [Function](../built-in/function.md) action to the Flow and pass in the dimension as a argument. You can then use it in your code.

```csharp
public void Foo(Profitbase.Flow.Extensions.Invision.Dimensions.DimensionTree<MyWorkspace.DimProps_GUID> departmentDimension)
{
    var regionEast = departmentDimension.FindMember("Region-East");
    // regionEast is null if Region-East does not exist.
    if(regionEast != null)
    {        
        foreach(var descendants in regionEast.TraverseDown())
        {
            // Visit all descendants of region east
        }

        foreach(var ancestor in regionEast.TraverseUp())
        {
            // Visit all ancestors of region east
        }
    }

    var department2 = departmentDimension.FindMemberOrDefault("E-002");
    // If E-002 does not exist, FindMemberOrDefault() returns an empty default member
    if(department2.Id != null)
    {
        // E-002 was found
    }
    else
    {
        // E-002 was NOT found
    }

    if(departmentDimension.TryFindMember("E-003", out var department3))
    {
        // E-003 was found. Check the Manager Email property of the dimension member and perform an action.
        if(!string.IsNullOrWhitespace(department3.Properties.ManagerEmail))       
        {
            // Print manager email to the debug window
            this.Context.Diagnostics.Log.Debug($"Manager email for department {department3.Id} is {department3.Properties.ManagerEmail}.");
        }        
    }
}
```