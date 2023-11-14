# Assumptions

Assumptions are used to define any type of parameters for (financial) calculations, for example VAT, tax percent, currency exchange rates, and so on.
Technically, an assumption object is made up of `Keys` and `Values`.

An Assumption definition for made-up product fees by state may look like this: 

| State             | Product            | Fee                    |
|-------------------|--------------------|------------------------|
| United States     | All                | 14.1 %                 |
| Alaska            | Bikes              | 8 %                    |
| California        | Skates             | 12.6 %                 |
| Texas             | Backpacks          | 11.8 %                 | 

When an Assumption is used in a Calculation Flow, we want to resolve the `value(s)` based on the `keys`. In the table above, the keys are `Region` and `Product`, while `Fee` is the value. 

Keys in most Assumptions are associated with dimensions, for example the Department, Account or Product dimensions. This means that the _values in the key columns are dimension members_, such as department ids, regions, account ids, product ids or product groups. Because dimensions usually have a hierarchical structure, we can define assumptions at a high level, and the values will apply to all descendants. If we need to define values at a more granular level, we can pick those specific members lower in the hierarchies and apply a different values to them.

**For example** 
`(Californa, Bikes)` returns `14.1 %`
`(California, Skates)` returns `12.6 %`  
`(Alaska, Bikes)` returns `8 %`  
`(Arizona, Skies)` returns `14.1 %`
