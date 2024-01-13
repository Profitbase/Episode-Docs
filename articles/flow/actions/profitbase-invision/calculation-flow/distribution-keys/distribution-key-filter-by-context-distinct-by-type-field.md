# DistributionKey.FilterByContextDistinctByTypeField

Returns the Distribution Key rules having keys matching the key(s) of the data source input row currently used as context, in addition to also filtering by the `Distribution Key type` property. If you have specified the `Distribution Key type` property, you must use this API to avoid the possibility of getting duplicate Distribution Key rules for a given type.

Note that the returned set includes rows matching by "*" / "All level" as well as items having fully qualified matches.


> [!NOTE]
> In case there are no Distribution Key rules that match a search criteria, a default distribution key is returned. The default distribution key is `1.0/n`, where n = number of periods.

### Example 1

This example shows how to distribute a value to mutliple periods for the given context, _not including_ fallback values.  
> [!NOTE]
> Note that, as described in the pseudo code above, one distribution key rule is returned pr match, even for overrides defined at more granular levels of dimensions.
> If you want to ensure that you only get the distribution key rule with the best match (and not all matches), use the [Take](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.take) API as described in `Example 3` below.

```csharp

foreach(var distributionKeyRule in this.DistributionKeys.FactoryProductionPrMonth.FilterByContextDistinctByTypeField())
{
    // Distribute to all periods defined in the distribution key 
    foreach(var periodicValue in distributionKeyRule)
    {
        // Use GetShare(...) to get the share of the periodic value relative to the total distribution key
        var monthProductionValue = input.YearTotal * distributionKeyRule.GetShare(periodicValue.Value);
        this.Output.Add(Amount: monthProductionValue, TransDate: periodicValue.Date);
    }    
}
```

### Example 2

This example shows how to distribute a value to mutliple periods for the given context, _including_ fallback values.

```csharp

foreach(var distributionKeyRule in this.DistributionKeys.FactoryProductionPrMonth.FilterByContextDistinctByTypeField())
{
    // Distribute to all periods defined in the distribution key 
    foreach(var periodicValue in distributionKeyRule)
    {
        // Use GetShare(...) to get the share of the periodic value relative to the total distribution key
        var monthProductionValue = input.YearTotal * distributionKeyRule.GetShare(periodicValue.Value);
        this.Output.Add(Amount: monthProductionValue, TransDate: periodicValue.Date);
    }    
}
```

### Example 3

This example shows how to use the [Take](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.take) API to get only the distribution key rule with the best match, not all matches.

```csharp

// Call Take(1) if you only want the best match, not all matches
foreach(var distributionKeyRule in this.DistributionKeys.FactoryProductionPrMonth.FilterByContextDistinctByTypeField().Take(1))
{
    // Distribute to all periods defined in the distribution key 
    foreach(var periodicValue in distributionKeyRule)
    {
        // Use GetShare(...) to get the share of the periodic value relative to the total distribution key
        var monthProductionValue = input.YearTotal * distributionKeyRule.GetShare(periodicValue.Value);
        this.Output.Add(Amount: monthProductionValue, TransDate: periodicValue.Date);
    }    
}
```


#### Continue reading

To understand more about how the FilterByContext API works, read about:  
[Set lookups](../set-lookups.md)