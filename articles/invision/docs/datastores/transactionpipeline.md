
## Transaction Pipeline

The Transaction Pipeline is a mechanism that reads a data set from a [Data Store](../datastores.md) and produces an output based on a set of business rules. You would typically run a Transaction Pipeline process if you need to periodize or distribute data from one or more columns, spawn transactions based on a set of business rules or just assign values to rows when exporting data to a target.


A Transaction Pipeline process consists of a Cell Adapter, [Distributer](transactionpipeline/distributer.md), and [Spawner](transactionpipeline/spawner.md) component, which all produce output by evaluating business rules.
The business rules (Ruleset) are configured in the Feature section of Setting [tables](../tables.md), using one Setting table pr feature configuration. (For example, you cannot use the same Setting table to configure business rules for both Cell Adapter and Distributer components).
<br/>

>**Note!**  
All Transaction Pipeline target Data Stores must have [Tracing Columns](tracingcolumns.md).  
>
Also, unless you intend for the entire source transaction data set to be reprocessed every time the pipeline is executed, you need to ensure that the [Data Context](../dataflows/datacontext/index.md) for both the Transaction Pipeline source and target Data Stores have been properly defined. 
>
If a Data Store does not have relationship Dimension bindings that can be used for fully resolving the Data Context, you need to specify the Data Context configuration for the Data Store as part of the [Global Data Context](../dataflows/datacontext/globaldatacontext.md).


<br/>

### See Also

* [Cell Adapter](transactionpipeline/celladapter.md)

* [Condition Expressions](transactionpipeline/conditionexpressions.md)

* [Distributer](transactionpipeline/distributer.md)

* [Spawner](transactionpipeline/spawner.md)



