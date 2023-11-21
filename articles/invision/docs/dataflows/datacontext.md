
## Data Context

![img](https://profitbasedocs.blob.core.windows.net/images/Dcont.png)

<br/>



The Data Context is the mechanism that defines the transaction set is processed by a Data Flow, for example, a Financial Simulation, Distributor, or Spawner.

All [Data Stores](../datastores.md) being sources or targets in a processing chain must have a Data Context specified for InVision to figure out which set of transactions to process. If you do not set up a Data Context, you must configure the transaction filtering manually.

The Data Context of a Data Store is normally determined based on the Dimensions which are a part of the star schema. If one or more Filters based on star schema Dimensions are connected to the [Data Context Scope](datacontext/datacontextscope.md) of a Data Flow, the selected filter values will be used to determine which transactions to process. All sources and targets in a processing chain must have a Data Context because the [Data Context Scope](datacontext/datacontextscope.md) controls not only which transactions are being read from the sources, but also which transactions are being deleted from the targets.

To enable other resources (dimensions not being part of star schemas, tables, and custom values) to determine the transaction set being processed, you need to define them in the [Global Data Context](datacontext/globaldatacontext.md).

<br/>

#### See Also

* [Data Context Scope](datacontext/datacontextscope.md)
* [Global Data Context](datacontext/globaldatacontext.md)