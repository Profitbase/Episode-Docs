# Calculation

## Overview
This page allows you to define a calculation tied to a model measure.
<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/calculation.JPG)

There are two types of calculations:<br/>

-	Cell-calculations: simple arithmetic calculations (+ - * /) between measures of a model. These calculations are performed automatically, as-you-type, when editing data in the input model.<br/>

Note that when defining the cell-calculation formula, the measures are defined by the measure id enclosed in square brackets, for example [SalesQty] * [SalesUnitPrice].<br/>

-	Button-click calculations: more complex calculations involving for example conditionals. Such calculations are defined as SQL statements and will not calculate automatically, as-you-type, when editing data in the input model. These calculations will require the click of a button to execute, specifically the “Recalculate” button. For more advanced SQL calculation options, such as the use of aggregation over time, please consult:<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 6.2 or later
-  [Configure the Driver based module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V6.2/Planner%20Driver%20based%20module.pdf)<br/>

In the calculation dialogue, one can also enter more elaborate descriptions using the “Calculation description” fields.<br/>

Click "Save" to save any changes made.<br/>
Click "Close" to close the dialogue.

<br/>


