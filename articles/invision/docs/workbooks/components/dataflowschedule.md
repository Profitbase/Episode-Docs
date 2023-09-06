---
title: "Data Flow Schedule"
metaKeys: "Data Flow, Data Context Variables Assignment, Actions, start, stop, events, completed, executing, parameterized execution, "
folderOnly: "false"
pageIndex: 3
---

#### Data Flow Schedule

The [Data Flow](../../dataflows.md) Schedule component enables end users to create and edit the scheduled runs of Data Flows from a [Workbook](../../workbooks.md) instead of having to use the Designer.

<br/>

#### How to add a Data Flow Schedule component to a Workbook
1. Open the Workbook Designer,
2. Drag and drop the Data Flow Schedule component onto the surface.

<br/>

![dfs](https://profitbasedocs.blob.core.windows.net/images/dfs1.png)

<br/>

#### How to create a New Schedule for a Dataflow
<br/>

To create a new Data Flow Schedule, you need to execute the New action of the Schedule component and provide the id of the [Data Flow](../../dataflows.md). You can also provide one or more parameters that you want the Dataflow to be executed with.

1. Find the Data Flow Schedule component in the Actions explorer (for example for a button tapped event), 
2. Drag and drop the New action into the Actions list,
3. Use the Arguments(...) function to specify the id of the Dataflow. Optionally, you can define parameters that will be passed to the Dataflow when the schedule is run as the second parameter of the Arguments function.

<br/>

![dfs](https://profitbasedocs.blob.core.windows.net/images/dfs2.png)

<br/>

**Tip:** 

Click the Snippets button above the Instructions field to view the available functions to call.

<br/>

#### How to Edit a Schedule
<br/>

To edit a Dataflow Schedule, you need to provide the schedule id to the component.

1. Find the Data Flow Schedule component in the Actions explorer (for example for a button tapped event), 
2. Drag and drop the Load Data action into the Actions list,
3. Use the Arguments(...) function to specify the id of the scheduled job to edit.

<br/>

![dfs](https://profitbasedocs.blob.core.windows.net/images/dfs3.png)

<br/>

---

<br/>

![dfs](https://profitbasedocs.blob.core.windows.net/images/dfs4.png)

<br/>