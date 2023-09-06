---
title: "Data Flow"
metaKeys: "Data Flow, Data Context Variables Assignment, Actions, start, stop, events, completed, executing, parameterized execution, "
folderOnly: "false"
pageIndex: 2
---


In order to execute Data Flows from a [Workbook](../../workbooks.md), you need to add them to a page. If you do not want to show the execution log of a Data Flow to the user, you can add it to a hidden page. You can still indicate that some process is running by adding spinners and starting and stopping them when the Data Flow starts and stops.

<br/>


![img](https://profitbasedocs.blob.core.windows.net/images/DFny.png)

<br/>

### Actions

*	**Start**  
It starts an asynchronous execution of the Data Flow. This action does not wait for the Data Flow to complete its execution, it returns immediately once the execution has started. 


*	**Stop**  
Sends a request to the server asking to stop the current execution of the Data Flow. The execution is not guaranteed to stop immediately, instead it will stop at the first available opportunity.

<br/>

### Events

*	**Completed**  
The Completed event is raised when the Data Flow completes execution. The event is raised when the Data Flow completes normally, and after an abort request has been sent by the Stop action.

<br/>

### Executing Data Flows

To start executing a Data Flow from a Workbook, you need to call the **Start Action** of the Data Flow. Calling the Start action will start a new instance of the Data Flow. When the Start action returns, it means that the execution has started, not that the Data Flow has run to completion. When the Data Flow has run to completion, the Data Flow raises the **Completed** event. 

<br/>

### Parameterized execution

To pass arguments to a Data Flow being executed from a Workbook, you need to edit the Arguments property of the Data Flow part from the Workbook designer.

The editor shows a list of all activities and their respective parameters hosted by the Data Flow. When selecting the activity, you get a list of the parameters and any default arguments. 

To override the default values, you can use variables, the Filter(…) function, or hard coded values. InVision resolves the arguments by evaluating all values as Eaze expressions.

<br/>

**Example**
>
>This example shows how to specify the arguments passed to a Data Flow Activity.  
>The values listed in the Default Value column is used unless a value is provided in the Override Value column. The values in the Override Value column must be valid Eaze expressions, meaning they can contain references to variables.
>
>In this example, a variable x = "FOO" exists. (We’re referencing it in the myAbbrev argument expression, by only getting the first 2 letters).
>
>| Argument name 	| Default Value 	| Override Value                                   	|
|---------------	|---------------	|--------------------------------------------------	|
| myInt         	| 1             	| 1                                                	|
| myString      	| Hello         	| "Hello"                                          	|
| myDate        	| 1900.01.01    	| DATE(1900,1,1)                                   	|
| myDec         	| 22.4          	| 11.6                                             	|
| myDepartment  	|               	| Filter("Filters", "Department").SelectedValue.Id 	|
| myAbbrev      	|               	| SUBSTRING(x, 0, 2)                               	|


<br/>


<br/>

### Data Context Scope

To apply a Data Context for transactions, being processed based on states (selected filter values and variables) in the Workbook, you need to specify the Data Context Scope for the Data Flow. 

Setting up a Data Context Scope for the execution will enable the Data Flow to only process the transaction subset resolved from the selected filter values and variables in the Workbook.  
Read more about the [Data Context](../../dataflows/datacontext.md) and [Data Context Scope](../../dataflows/datacontext/datacontextscope.md) here. 

What is the difference between parameterized execution for filtering data to process and using Data Context Scope?  
The Data Context Scope enables the system to resolve the transaction subset for processing while using parameterized execution leaves it up to the consultant to set up the filtering logic.

Some business modules, for example, the Finance module, uses the reserved system column **SYS_DataSetID** to specify which data set in various tables belongs to which business process (for example, Budget or Forecast). 

To process the correct data set when running a Data Flow from a Workbook, you need to configure the Data Context (of the Data Flow) and provide the id of the data set to process. 

You do this by selecting the appropriate Data Flow Component in the Workbook Designer and then edit its Data Context property. 

Next, you need to assign a value to the Data Context variable(s). Business modules developed by Profitbase usually defines a single Data Context variable named **@SYS_DataSetID**, but there may be more than one. The Data Context variables and their mappings are defined in the Global Data Context. 

To assign a value to a Data Context Variable, for example, @SYS_DataSetID, add a row to the *Data Context Variables Assignment* list in the Data Context property editor and select the @SYS_DataSetID entry from the dropdown.  

In the Workbook Variable field, type the name of the variable that contains the id of the data set that identifies the business process (for example, Budget or Forecast) that you want to target.  
If the Workbook is associated with a Workflow, the **SYS.SYS_DataSetID** variable contains the id of the data set. A Workflow represents a business process and has the Data Set configuration where the id of the business process is specified.

<br/>

So, in short, to use **SYS_DataSetID** to target a specific data set when processing data, you need to do the following:

1.	Select the **Data Flow Component** in a Workbook and edit its **Data Context property**;

2.	Add a row to the **Data Context Variables Assignment** list;

3.	Choose the **@SYS_DataSetID** item from the dropdown list;

    *	If the Workbook is associated with a Workflow, type **SYS.SYS_DataSetID** in the Workbook Variable field

    *	If the Workbook is not associated with a Workflow, type the name of some other variable (your custom) that contains the id of the data set you want to target

If you didn't get the expected result after setting up the Data Context, probably:

1.	The Global Data Context does not contain mappings between Data Context variable(s) and table columns, for example the @SYS_DataSetID variable is not mapped to the SYS_DataSetID column of a table participating in the execution of the Data Flow.

2.	Resources (Data Views) in Data Flow Items are not configured to filter based on the Data Context. Tabular resources (tables, views) referenced in Data Flow Items as Resource references must contain a special WHERE clause to apply filtering based on the Data Context. If this WHERe clause is not present, no filtering is applied. 

<br/>

### Runtime information

When a Data Flow is started, InVision creates a variable with the name of the Data Flow part and assigns an info object to the variable containing a TaskId and DataFlowId property. 

*	**DataFlowId** is the (metadata) id of the Data Flow.

*	**TaskId** is the Id of the execution instance. Every time a Data Flow is started, it gets a unique execution id, but the DataFlowId stays the same.

If you are creating custom Data Flow Items, the TaskId and DataFlowId can be read from the Infinity runtime and used for tagging output relative to the execution instance. This makes it possible to load resources generated by a Data Flow, for example a PDF or some other content, once the Data Flow has completed. 


<br/>

**Example**
>
>This example shows how to access the DataFlowId or TaskId properties of a Data Flow, «DataFlow1", after it has been started by addressing the variable created when the Data Flow has been started.
>
```
@Var[DataFlow1].DataFlowId // returns the metadata if of the executing data flow
```
>
```
@Var[DataFlow1].TaskId // returns the execution instance id
```

<br/>

### Logging

To display the Data Flow while it’s running, you need to set the Show Execution Log property to True in the properties editor. Also, the Data Flow cannot be hosted on a hidden page.

Please note that if the Show Execution Log property is set to true, the Popup Execution Errors property is ignored.

<br/>

### Error notifications

To enable error notifications, you need to set the **Popup Execution Errors** property to True in the Properties editor.

Please note that if the Show Execution Log property is set to true, the Popup Execution Errors property is ignored.


<br/>

### See Also
* [More about Data Flows](../../dataflows.md)
* [Execution of Data Flows](../../dataflows/execution.md)
* [Data Context](../../dataflows/datacontext.md)
<br/>

### Videos

* [Data Flows](../../../videos/dataflows.md)
* [Introduction to Parameterization](https://profitbasedocs.blob.core.windows.net/videos/Data%20Flow%20-%20Introduction%20to%20parameterization.mp4)
* [Execute from Workbook with arguments](https://profitbasedocs.blob.core.windows.net/videos/Data%20Flow%20-%20Execute%20from%20Workbook%20with%20arguments.mp4)
* [Execute Using dfcmdutil Command Line Tool](https://profitbasedocs.blob.core.windows.net/videos/Data%20Flow%20-%20Execute%20using%20dfcmdutil%20command%20line%20tool.mp4)
* [Control Flow and Branching](https://profitbasedocs.blob.core.windows.net/videos/Data%20Flow%20-%20Control%20Flow%20and%20Branching.mp4)
* [Guest Executables - Basics](https://profitbasedocs.blob.core.windows.net/videos/Guest%20Executables%20-%20Basics.mp4)