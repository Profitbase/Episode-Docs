# Global Parameters


Global Parameters can be used to pass arguments to all Dataflow Items in a Dataflow. Arguments are automatically passed to each item that has parameters with the same name. For example, if you have a Global Parameter named @Param1 and a Dataflow Item with a parameter named @Param1, the Global Parameter value is **automatically** passed to the Dataflow Item parameter.

If you execute a Dataflow inside another Dataflow, using Global Parameters will let arguments automatically be passed to the child Dataflow.

<br/>

**Example:**

Suppose you have multiple Dataflow Items doing some work based on a department id. The Dataflow Items might also be executed by different Dataflows, and the Dataflows might event be nested.  
In order to easily pass a department id to all items during execution, simply define a parameter named @DepartmentId for all Dataflow Items, AND all Dataflows which executes the Dataflow Items.   
When the main Dataflow is executed, the department id is automatically passed to all Dataflow Items.
<br/>

## Define Global Parameters

To define Global Parameters, click "Dataflow Properties" in the Dataflow editor screen and open the editor from the Properties panel.

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/glparam1.png)
<br/>

In the Parameters dialog, add parameters and optionally provide default values.
<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/glparam2.png)
<br/>

## Passing arguments using Global Parameters

When a Dataflow is executed from a Workbook, you can pass arguments to the Dataflow from the Arguments property of the Dataflow Workbook component.

In the Workbook editor, click to select the Dataflow. Then, in the **Properties panel**, click to edit the **Arguments** property.
Switch to the Global arguments tab and provide a value for each parameter.

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/glparam3.png)

<!-- ## Videos

* [Data Flow](../../../../videos/dataflows)
* []() -->
