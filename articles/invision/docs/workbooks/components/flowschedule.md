# Flow Schedule

The  [Flow](../../../../flow/flow.md) Schedule component enables end users to create and edit the scheduled runs of Flows from a [Workbook](../../workbooks.md) instead of having to use the Designer.

<br/>

## How to add a Flow Schedule component to a Workbook
1. Open the Workbook Designer,
2. Drag and drop the Flow Schedule component onto the surface.

<br/>

![dfs](../../../../../images/flow/dfs1.png)

<br/>

## How to create a New Schedule for a Flow
<br/>

To create a new Flow Schedule, you need to execute the New action of the Schedule component and provide the id of the  Flow](../..flows/index.md). You can also provide one or more parameters that you want theflow to be executed with.

1. Find the Flow Schedule component in the Actions explorer (for example for a button tapped event), 
2. Drag and drop the New action into the Actions list,
3. Use the Arguments(...) function to specify the id of theflow. Optionally, you can define parameters that will be passed to theflow when the schedule is run as the second parameter of the Arguments function.

<br/>

![dfs](https://profitbasedocs.blob.core.windows.net/images/dfs2.png)

<br/>

**Tip:** 

Click the Snippets button above the Instructions field to view the available functions to call.

<br/>

## How to Edit a Schedule
<br/>

To edit aflow Schedule, you need to provide the schedule id to the component.

1. Find the Flow Schedule component in the Actions explorer (for example for a button tapped event), 
2. Drag and drop the Load action into the Actions list,
3. Use the Arguments(...) function to specify the id of the scheduled job to edit.

<br/>

![dfs](https://profitbasedocs.blob.core.windows.net/images/dfs3.png)

<br/>

---

<br/>

![dfs](https://profitbasedocs.blob.core.windows.net/images/dfs4.png)

<br/>