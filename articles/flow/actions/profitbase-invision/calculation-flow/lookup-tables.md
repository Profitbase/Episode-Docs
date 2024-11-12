# Lookup tables

Lookup tables provide support for looking up values based on one or more keys. They are often used to define parameters for calculations, for example VAT, tax percent, currency exchange rates, and so on.
Technically, a Lookup table object is made up of `Keys` and `Values`, where the Keys are used to find the parameter value(s) to use in calculations. 

## Properties  

| Name         | Type             | Description                                                |
|--------------|------------------|------------------------------------------------------------|
| Key columns  | Optional         | All Lookup tables must have at least one logical key unless you only want to run manual lookups. If no primary key is defined on the table in InVision, or you want to use a different set of columns to make up the key, you can specify the key manually here. |
| Data         | Optional         | Specifies the fields / columns from the Lookup table that you want to use for calculation parameters and other types of business logic. By default, all non-key columns are automatically available.                                                   |
| Key mappings | Optional         | Use this option to define explicit mapping between the `Key columns` and the (corresponding) columns in the data source when names does not match. Flow determines which Auto Transactions to use by comparing the values in the `Key columns` to the corresponding columns in the input row from the data source. If not specified otherwise, it matches against columns with the same name. If you need a different behavior, you need to specify the mapping between the keys explicitly. |
| Options       | Optional | **Disable caching**: Enable this option if you are _generating_ the data in the Lookup table using a custom SQL script. When generating data into a table using a custom SQL script, InVision will not be able to detect the change and notify Flow to invalidate its cache. You can also use the [Remove InVision object from cache](../../built-in/remove-invision-object-from-cache.md) action to programatically evict the table from cache.  |

---

## Example

An Lookup Table definition for made-up product fees by state may look like this: 

**Product Fees**

| State             | Product            | Fee                    |
|-------------------|--------------------|------------------------|
| United States     | All                | 14.1 %                 |
| Alaska            | Bikes              | 8 %                    |
| California        | Skates             | 12.6 %                 |
| Texas             | Backpacks          | 11.8 %                 | 

When an Lookup Table is used in a Calculation Flow, we want to resolve the `value(s)` based on the `key(s)`. In the table above, the keys are `Region` and `Product`, while `Fee` is the value. 

Keys in most Lookup Table are associated with dimensions, for example the Department, Account or Product dimensions. This means that the _values in the `Key` columns are `dimension members`_, such as department ids, regions, account ids, product ids or product groups. Because dimensions usually have a hierarchical structure, we can define parameters at a high level, and the values will apply to all descendants. If we need to define values at a more granular level, we can pick those specific members lower in the hierarchies and apply a different values to them.


In the table above, `(Californa, Bikes)` returns `14.1 %` because there is no exact mapping in the table, so California is resolved as a child of 'United States', and Bikes is a child of 'All'.  
`(California, Skates)` returns `12.6 %` because there is an exact mapping in the Lookup Table.  
`(Alaska, Bikes)` returns `8 %` because there is an exact mapping in the Lookup Table.  
`(Arizona, Skis)` returns `14.1 %` because neither Arizona nor Skis is in the table, but they are children of 'United States' and 'All' respectivly.  



## Using Lookup Tables in code

```csharp

// This works because we have called Lookups.UseContext(...) earlier in the flow
var taxAmount = (Lookups.ProductFees.Fee / 100.0) * input.Amount / 100.2;

// Map to account based on calculation type
var targetAccount = Lookups.AccountMappings.FirstOrDefault(map => map.AccountType == "TaxPayable")?.TargetAccountID;

// Create an output transaction that will be stored in the database
Output.Add(AccountID: targetAccount, Amount: taxAmount, TransDate: input.TransDate);

```

## Using FromDate  
Data in Lookup tables such as finance settings is often related to date and time, for example tax periods, and interest payments. 

By convention, when a Lookup table contains a column named `FromDate`, the result of a lookup will be filtered based on the dates in this column by limiting the result to only include matches for rows having a date _greater or equal_ to the date specified when calling `LookupTable.UseTimeframe(...)`.

**To use FromDate as a condition in Lookup tables, you need to do the following:**
1) Add the FromDate column as a `Data` column. _Note! It cannot be a Key column, even if it's part of the primary key. Key columns are matched by equality, which is not how FromDate should be evaluated._
2) Set the current timeframe by calling `Lookups.UseTimeframe(...)` or `Lookups.MyTable.UseTimeframe(...)` in a Function. This must be done prior to doing a lookup as shown in the example below (You only need to call UseTimeframe when the date changes, not every time you want to do a lookup).


### Example using FromDate
```csharp
public void Calculate(ForecastInput sourceTransRow)
{
    Lookups.UseContext(sourceTransRow);

    // Call UseTimeframe to specify to Flow which date to use as a reference date when doing a lookup
    Lookups.UseTimeframe(sourceTransRow.TransDate);

    // Because Flow was told the reference date (by calling UseTimeframe) in the line above, 
    // you now get back the price of the product applicable for sourceTransRow.TransDate 
    var totalAmount = Lookups.ProductPriceByPeriod.Price * sourceTransRow.Qty;
}
```