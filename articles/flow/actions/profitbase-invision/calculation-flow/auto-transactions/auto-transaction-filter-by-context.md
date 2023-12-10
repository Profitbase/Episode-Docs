# AutoTransaction.FilterByContext

Returns the Auto Transactions having key match against the data source input row currently used as context.  

## Parameters

`includeFallbackValue` [Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean) (Optional. Default is 'false')  
Setting this value to true will include the fallback Auto Transaction row (if specified) even if exact matches were found.  
The fallback Auto Transaction row is the row where the "All Level" value is set on all key columns. 
Use this feature if you want to define an Auto Transaction that should _always_ be created, in addition to specific ones.

### Pseudo

**AutoTrans**

| X    | Y   | Value  |
|------|-----|--------|
| *    | *   | 100    |
| A    | B   | 200    |
| A.1  | C.1 | 300    |
| B    | B.1 | 400    |

```dos

input = { X = "A", Y = "B" }

AutoTrans.UseContext(input);

AutoTrans.FilterByContext() will return (A,B,200)
AutoTrans.FilterByContext(true) will return [(A,B,200), (*,*,100)]
```

### Example

```csharp
// Returns which employee benefits to generate for the given context.
foreach(var autoTrans in this.AutoTransactions.EmployeeBenefits.FilterByContext())
{
    this.Output.Add(AccountID: autoTrans.TargetAccountID, Amount: amount * autoTrans.Factor);
}
```

### Example

```csharp

// Returns which employee benefits to generate for the given context, including the fallback row if present.
foreach(var autoTrans in this.AutoTransactions.EmployeeBenefits.FilterByContext(true))
{
    this.Output.Add(AccountID: autoTrans.TargetAccountID, Amount: amount * autoTrans.Factor);
}
```
