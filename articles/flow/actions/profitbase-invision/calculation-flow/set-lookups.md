# Set lookups

[Lookup Tables](lookup-tables.md), [Distribution Keys](distribution-keys.md) and [Auto Transactions](auto-transactions.md) are `Sets` that provide APIs for performing fast lookups to find rows where keys match the value(s) specified in the search criteria.

The APIs that use fast set lookups are:  
- `FilterByContext(bool)`  
- `FilterByContextDistinctByTypeField(bool)` 

All `Sets` (Lookup Tables, Distribution Keys and Auto Transactions) must have at least one key column, for example `ProductID`.  
A key column in a Set is often associated with a dimension, for example the Product dimension.  

Before a lookup can be performed using the above mentioned APIs, you must set a `context` on the `Set`. You do this by calling [Set].`UseContext(obj)` in a [Function](../../built-in/function.md) action (see code snippet below). This sets the search criteria so that the runtime knows which values to use when searching for matching rows in a Set. The runtime knows which fields and values to compare based on the configuration of the [Lookup Tables](lookup-tables.md), [Distribution Keys](distribution-keys.md) and/or [Auto Transactions](auto-transactions.md) actions in the Flow. 

```csharp
this.Lookups.UseContext(myInputRow);
```

Matching is performed by comparing values for each key column in order from first to last defined. When a match in a key column is found, it is assigned a weight based on the index of the key column. If the key column is associated with a dimension, the calculated weight includes the level at which the matching dimension member id is found (meaning members deeper in a dimension gives a higher weight).  
The sum of all key matches or a `Set` row makes up its total `Match Score`.  

- Rows returned by calling `FilterByContext(LookupResultOrdering.OrderByMatchScore)` and `FilterByContextDistinctByTypeField(LookupResultOrdering.OrderByMatchScore)` are ordered so that the rows with the highest match score appears at the beginning of the sequence.  
- Rows returned by calling `FilterByContext()` and `FilterByContextDistinctByTypeField()` are ordered so that the matched rows are returned in order of highest to lowest index (position) in the source table. (Rows defined later in the source table have a higher index score which puts them at the beginning of the sequence returned from the lookup functions)

The section below describes in rough details how key matching is performed (although not even remotely close to how it is actually done)

```dos

Pseudo code

matches = []
for each setRow in Set.rows
    matchScore = 0
    matchCount = 0
    for each keyColumn in setRow.keyColumns
        if(isMatch(keyColumn.[ColumnX], myInputRow.[ColumnX]))
            matchScore += calcWeight()
            matchCount = matchCount + 1
    if(matchCount equals setRow.keyColumns.count) // only include the row if all key columns matched
       matches.add({setRow, matchScore})
if(orderByMatchScore)    
    return matches.orderByMatchScoreDescending() // return matches with the highest match score first in the sequence
else
    return matches.orderByRowIndexDescending() // return matches with the highest match score first in the sequence
     
```


