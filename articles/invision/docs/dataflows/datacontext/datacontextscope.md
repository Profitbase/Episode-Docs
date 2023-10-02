---
title: "Data Context Scope"
metaKeys: "Data Context Scope, Data Context Delegation, Storages, Use Data Context variables as Data Flow Activity arguments, Filters"
pageIndex: 1
---



In order for the Data Context to be applied during processing, the Data Context Scope must be set up for the Data Flow running the job. The Data Context Scope is set up from the Properties window of a Data Flow component in a Workbook. 

This means that every Data Flow has its own Data Context Scope, and that a Data Context Scope is bound to the state of a Workbook, for example selected filter values and Workbook variables.   
The Data Context Scope is defined by Filters, Variables and Data Storages.
<br/>

### Filters

In order for selected filter values in a Workbook to be used for determning the transaction set when processing data using a Data Flow, the filter must be registered in the Data Context Scope of the Data Flow. The filter must be based on a Dimension used in the star schemas of a Data Stores being processed during the Data Flow execution, or it must be based on a table resources enlisted (and configured) in the Globale Data Context. When the Data Flow is executed from a Workbook, the selected filter values will be used to determine the transaction set being processed.
<br/>

### Variables

This section is used for mapping Workbook variables to Data Context Variables.

In cases where it’s not pratical or possible to use filter values to determine the transaction set to process, you have the option of using arbitrary values instead. These values can be found in Workbook variables, and mapped to Data Context Variables. 


> [!NOTE]
> When mapping Workbook variables to Data Context Variables, you reference the Workbook variable by name, not by value, meaning you can’t use the @Var[…]-expression, just the name of the variable.

>**Example**
>
>A Data Flow should process data related to a specific project. 
>In this case, the Workbook does not have a project filter, but a project id still need to be be part of the Data Context in order to ensure that only transactions related to the specific project is being processed.
>To make this happen, the following configuration can be applied.
>
>>**1)	**Define a variable, «ProjectID», in the Globale Data Contexten and bind it to the appropriate column (ProjectID) in the Data Store(s) using a Value Binding.
>>
>>**2)	**Create a Workbook variable, for example «ProjectID» and assign a value to it. (_state.ProjectId = xyz)
>>
>>**3)	**In the Data Context Scope of the Data Flow, add a mapping from the Workbook variable to the Data Context variable. Make sure you don’t use the @Var[…]-syntax when referring to the Workbook Varialble, just the actual name of the variable.
 


**Use Data Context variables as Data Flow Activity arguments**

If you are executing Data Flows during Workflow state transitions and want to use Data Context variables to set arguments for the Data Flow Activities, you simply need to enter the name of the Data Context variable as the argument. By doing this, the value of the variable will be passed as an argument to the activity during execution.
<br/>

### Data Storages

In cases where data sources and targets in a processing chain contains data having equal dimensionality but are logically different based on where it is stored, you can enable the Data Context to take into account the origin of the transactions being processed by setting up the Data Storages of the Data Context Scope. 

Filtering on Data Storages are usually supplemental to using Filters and Variables. 

Alternatively, you can use the **SYS_DataSetID** Workbook Variable if you are running in a Workflow context. 
<br/>

### Data Context Delegation

Data Context Delegation is the concept of delegating the Data Context information to different columns than the columns that Data Context Slicer Repositories are associated with.
 
For example, if the Department dimension (DC Slicer Repository) is associated with the DepartmentID column of a Data Store, View or Setting, the DepartmentID would normally be the Data Context column used for determining which transactions to process and delete when a Data Context is applied to the exeution of a Data Flow. However, if you run processes that produce data from one Department to another (such as the Spawner may do), and you want to associate the offspring transactions with their parent transactions, you need to delegate the Data Context information to a different column than the DepartmentID column. 

In order to do this, you need to add a DepartmentID_DCD (DCD stands for Data Context Delegate) column to the targets of the processing pipeline.

Data Context Delegate columns are identified by the reserved **_DCD** postfix, for example DepartmentID_DCD. All columns in a Data Store, View or Setting with the _DCD postfix are considered Data Context Delegate columns in a processing pipeline, and must not be used for anything else. 

To enable Data Context Delegation for a database object, all you need to do is add corresponding **_DCD** columns for each "standard" Data Context column that you want to enable delegation for. 
