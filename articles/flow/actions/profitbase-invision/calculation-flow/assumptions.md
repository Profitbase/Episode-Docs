# Assumptions

Assumptions are used to define parameters for calculations, for example VAT, tax percent, currency exchange rates, and so on.
Technically, an assumption object is made up of `Keys` and `Values`, where the Keys are used to find the parameter value(s) to use in calculations. 

An Assumption definition for made-up product fees by state may look like this: 

**Product Fees**

| State             | Product            | Fee                    |
|-------------------|--------------------|------------------------|
| United States     | All                | 14.1 %                 |
| Alaska            | Bikes              | 8 %                    |
| California        | Skates             | 12.6 %                 |
| Texas             | Backpacks          | 11.8 %                 | 

When an Assumption is used in a Calculation Flow, we want to resolve the `value(s)` based on the `keys`. In the table above, the keys are `Region` and `Product`, while `Fee` is the value. 

Keys in most Assumptions are associated with dimensions, for example the Department, Account or Product dimensions. This means that the _values in the `Key` columns are `dimension members`_, such as department ids, regions, account ids, product ids or product groups. Because dimensions usually have a hierarchical structure, we can define assumptions at a high level, and the values will apply to all descendants. If we need to define values at a more granular level, we can pick those specific members lower in the hierarchies and apply a different values to them.

## Example

In the table above, `(Californa, Bikes)` returns `14.1 %` because there is no exact mapping in the table, so California is resolved as a child of 'United States', and Bikes is a child of 'All'.  
`(California, Skates)` returns `12.6 %` because there is an exact mapping in the assumption table.  
`(Alaska, Bikes)` returns `8 %` because there is an exact mapping in the assumption table.   
`(Arizona, Skis)` returns `14.1 %` because neither Arizona nor Skis is in the table, but they are children of 'United States' and 'All' respectivly.  



## Using Assumptions in code

```csharp

// This works because we have called Assumptions.UseContext(...) earlier in the flow
var taxAmount = (Assumptions.ProductFees.Fee / 100.0) * input.Amount / 100.2;

// Map to account based on calculation type
var targetAccount = Assumptions.AccountMappings.FirstOrDefault(map => map.AccountType == "TaxPayable")?.TargetAccountID;

// Create an output transaction that will be stored in the database
Output.Add(AccountID: targetAccount, Amount: taxAmount, TransDate: input.TransDate);

```
