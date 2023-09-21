---
title: "Data Set"
metaKeys: "Data Set Properties, Workbooks, name, SYS_DataSetID, flows, Workflow, designer, Filtering"
pageIndex: 1
---

The Data Set configuration of a [Workflow](../workflow.md) defines the data belonging to the business process. [Data Stores](../datastores/index.md), Settings and [Views](../views.md) in the data set are archived by executing a [Data Flow](../dataflows/index.md) containing the Archive Workflow Data Set Members [data flow item](../dataflowitems/index.md). As an example, a data flow for archiving the data set members can be added to an Action Activity as the last phase of a Workflow.  

Archive objects are created for every Data Store, Setting and View in the data set. The archiving process copies data from the working set to the archive by tagging each transaction with the id of the active workflow iteration.

<br/>

### Data Set Properties

*	**Name**

 Specifies the name of the Data Set. The Data Set Name is automatically assigned to the **SYS_DataSetID** column or new rows added to Settings displayed in Workbooks belonging to the Data Set (see the Workbooks property). 
 The name of the Data Set can be read using the ``@Object[…].DataSet-directive.`` The name of the Data Set is not associated to Workflow Iterations, so the name does not change when a new iteration is started.
 To pass the Data Set Name to Data Flow Items which are set up to filter the data being processed by **SYS_DataSetID** columns in the participating data sources and Settings, you need to map the **SYS_DataSetID** Global Data Context variable to the **SYS_DataSetID** workbook variable in the Data Context Scope property of the Data Flow component in the Workbook designer.
 This setup requires that the Workbook is registered in the Workbooks property of the Data Set (refer to the property below).

*	**Workbooks**

 Specifies which Workbooks belongs to the Data Set. The name of the Data Set will automatically be assigned to the **SYS_DataSetID** column of new rows added to Settings displayed in a Workbook. 

<br/>

### Filtering by Data Set when executing Data Flows
<br/>

When executing Data Flows containing Data Flow Items configured to filter data by the **SYS_DataSetID** column, for example the Financial Simulation Engines, the Data Set name needs to be passed as part of the arguments to the Data Flow. 

The standard way of doing this is to set up a Workflow and register the Workbook (which hosts the Data Flow) in the Workbooks collection of the Data Set. Next, ensure that the Global Data Context has been created in the Solution, and that it contains the **SYS_DataSetID** variable. Finally, edit the Data Context Scope property of the Data Flow component in the Workbook, and map the Global Data Context **SYS_DataSetID** variable to the Workbook **SYS_DataSetID** variable.  
Doing this will ensure that the Data Set name is assigned to the **SYS_DataSetID** variable when the Data Flow is executed, which in turn will enable any Data Flow Items to only use data belonging to the specified Data Set.

<br/>