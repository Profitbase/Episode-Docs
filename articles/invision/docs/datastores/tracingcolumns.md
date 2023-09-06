---
title: "Tracing Columns"
metaKeys: "Tracing Columns, Transaction Pipeline, target, Data Stores, Worksheets, Business, Module, Data, Flow, SYS_TransGeneratorID, SYS_OriginID, SYS_OriginRowIdentity, SYS_OriginColumnID, SYS_DataSetID, Cell Adapter, @Object[…].DataSet "
folderOnly: "false"
pageIndex: 13
---

Tracing Columns must exist in all [Transaction Pipeline](transactionpipeline.md) target [Data Stores](../datastores.md). Data Stores which are used for user input through [Worksheets](../worksheets.md) does normally not have Tracing Columns, because the system does not use then in that context.

* **SYS_TransGeneratorID**
 The ID of the process that generated the transactions, for example the Spawner or a custom Business Module Data Flow Item.

*	**SYS_OriginID**

 The ID of the Data Store that the transactions were originally read or generated from.

*	**SYS_OriginRowIdentity**

 The value of PBRowIdentity from the origin Data Store.

*	**SYS_OriginColumnID**

 The name of the source column in the origin Data Store.

*	**SYS_DataSetID**

 The name of the Data Set being processed.
 When processing data from an input Data Store (where SYS_DataSetID does not exists, or does not have a value) to a target Data Store, you need to specify how the Data Set Name should be resolved.

 The most common ways of doing this are:

 
    - When running a Transaction Pipeline process, for example the Cell Adapter, add an entry to Auxiallary Data of the Input configuration as a **Computed Column** (checkbox on the right side). Call the Computed Column "SYS_DataSetID" and specify the Data Set name in the **Expression**. You can either hard code the value as a single-quoted text, or use the `@Object[<source>].DataSet directive`.
 Note that using the `@Object[…].DataSet` directive requires that the Data Store is registered in the Data Set configuration of a Workflow, and it must be enclosed in single quotes, `‘@Object[<workflow name>].DataSet’`, since it will be used as part of a SQL SELECT clause.

    - If you want to load data from one Data Store to another using the Data Store designer, you need to add a binding from the source Data Store to the **SYS_DataSetID** column of the target Data Store and use the `@Object[…].DataSet` directive in the Expression property of the binding.

    - Using a custom SQL script, you can use the @Object[…].DataSet directive to resolve the Data Set name of the source Data Store.

