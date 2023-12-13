# AutoTransaction.FilterByContext

Returns the Auto Transactions having keys matching the key of the data source input row currently used as context.  

## Parameters

`includeFallbackValue` [Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean) (Optional. Default is 'false')  
Setting this value to true will include the fallback Auto Transaction row (if specified) even if exact matches were found.  
The fallback Auto Transaction row is the row where the "All Level" value is set on all key columns associated with dimensions. 
Use this feature if you want to define an Auto Transaction that should _always_ be created, in addition to specific ones.

### Pseudo

The following example shows what will be returned from the "MySet" Auto Transaction table given the context {X,Y}.

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

**MySet (Auto Transactions)**

| X    | Y   | Value  |
|------|-----|--------|
| *    | *   | 100    |
| A    | T   | 200    |
| A.1  | T.1 | 300    |
| B    | T.1 | 400    |

```dos

input = { X = "A", Y = "T" }
MySet.UseContext(input);
...
...
MySet.FilterByContext() will return one match: (A, T, 200)
MySet.FilterByContext(true) will return two matches: [(A, T, 200), (* , *, 100)]

**************************************************************************************************

input = { X = "A.1", Y = "T.1" }
MySet.UseContext(input);
...
...
MySet.FilterByContext() will return two matches: [(A.1, T.1, 300), (A, T, 200)]
MySet.FilterByContext(true) will return three matches: [(A.1, T.1, 300), (A, T, 200), (*, *, 100)]

```

### Example

This example shows how to create one output transaction pr employee benefit for the given context, _not including_ fallback values.

```csharp
// Returns which employee benefits to generate for the given context.
foreach(var autoTrans in this.AutoTransactions.EmployeeBenefits.FilterByContext())
{
    this.Output.Add(AccountID: autoTrans.TargetAccountID, Amount: amount * autoTrans.Factor);
}
```

### Example

This example shows how to create one output transaction pr employee benefit for the given context, _including_ fallback values.

```csharp

// Returns which employee benefits to generate for the given context, including the fallback row if present.
foreach(var autoTrans in this.AutoTransactions.EmployeeBenefits.FilterByContext(true))
{
    this.Output.Add(AccountID: autoTrans.TargetAccountID, Amount: amount * autoTrans.Factor);
}
```

#### Continue reading

To understand more about how the FilterByContext API works, read about:  
[Set lookups](../set-lookups.md)