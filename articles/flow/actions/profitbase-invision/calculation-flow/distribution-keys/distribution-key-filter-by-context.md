# DistributionKey.FilterByContext

Returns the Distribution Key rules having keys matching the key(s) of the data source input row currently used as context.  

Note that the returned set includes rows matching by "*" / "All level" as well as items having fully qualified matches.

> [!NOTE]
> In case there are no Distribution Key rules that match a search criteria, a default distribution key is returned. The default distribution key is `1.0/n`, where n = number of periods.

### Pseudo

The following example shows what will be returned from the "Factory Production By Month" Distribution Key table given the context {X,Y}.

**Dimension X**  

```md
All  
|-- A  
|---- A.1  
|-- B  
|---- B.1  
```

**Dimension Y**  

```md
All  
|-- T  
|---- T.1  
```

**Factory Production By Month (Distribution Keys)**

| X    | Y   | 2023-Jan | 2023-Feb  | 2023-Mar   | 
|------|-----|----------|-----------|------------|
| *    | *   | 10       | 12        | 9          | 
| A    | T   | 8        | 22        | 11         |
| A.1  | T.1 | 15       | 15        | 23         |
| B    | T.1 | 30       | 12.5      | 14         |

```dos

input = { X = "A", Y = "T" }
MySet.UseContext(input);
...
...
MySet.FilterByContext() will return two matches in order or best match score:  

(A, T, {Value: 8, Date: 2023-01-01}, {Value: 22, Date: 2023-02-01}, {Value: 11, Date: 2023-03-01})
(*, *, {Value: 10, Date: 2023-01-01}, {Value: 12, Date: 2023-02-01}, {Value: 9, Date: 2023-03-01})

**************************************************************************************************

input = { X = "A.1", Y = "T.1" }
MySet.UseContext(input);
...
...

MySet.FilterByContext() will return three matches in order or best match score:  

(A.1, T.1, 300)  
(A, T, {Value: 8, Date: 2023-01-01}, {Value: 22, Date: 2023-02-01}, {Value: 11, Date: 2023-03-01})  
(*, *, {Value: 10, Date: 2023-01-01}, {Value: 12, Date: 2023-02-01}, {Value: 9, Date: 2023-03-01})    

```

### Example 1

This example shows how to distribute a value to mutliple periods for the given context, _not including_ fallback values.  
> [!NOTE]
> Note that, as described in the pseudo code above, one distribution key rule is returned pr match, even for overrides defined at more granular levels of dimensions.
> If you want to ensure that you only get the distribution key rule with the best match (and not all matches), use the [Take](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.take) API as described in `Example 3` below.

```csharp

foreach(var distributionKeyRule in this.DistributionKeys.FactoryProductionPrMonth.FilterByContext())
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

This example shows how to use the [Take](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.take) API to get only the distribution key rule with the best match.

```csharp

// Call Take(1) if you only want the best match, not all matches
foreach(var distributionKeyRule in this.DistributionKeys.FactoryProductionPrMonth.FilterByContext().Take(1))
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