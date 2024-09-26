# Remove InVision object from Cache

This action removes an InVision object from the Flow cache. 

For performance reasons, Flow will cache data and metadata for InVision objects when used in Calculation Flows. Specifically, the objects that are cached are [Lookup tables](../profitbase-invision/calculation-flow/lookup-tables.md), [Auto transactions](../profitbase-invision/calculation-flow/auto-transactions.md), [Distribution keys](../profitbase-invision/calculation-flow/distribution-keys.md) and `Dimensions`.  

You only need to use this action when you modify an object `programmatically`, or when using a `View` as a Lookup table source and the underlying data of the View changes.

**You DO need to use this action**  
- When you `programmatically` modify an object used in a Calculation Flow by adding, removing or updating rows using a SQL Script, Stored Procedure or any type of custom code where you execute custom SQL code against an object to add, delete or update rows.
- When using a `View` as a Lookup table, and the data from one of the underlying tables has changed.


**You DO NOT need to use this action**  
- When an object is modified from the InVision Designer or Workbooks through built-in UI components
- When an object is modified via an InVision API
- When dimensions are published

