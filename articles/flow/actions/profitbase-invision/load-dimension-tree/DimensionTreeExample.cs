public void Foo(Profitbase.Flow.Extensions.Invision.Dimensions.DimensionTree<MyWorkspace.DimProps_GUID> departmentDimension)
{
    var regionEast = departmentDimension.FindMember("Region-East");
    // If Region-East does not exist, FindMember() returns null
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