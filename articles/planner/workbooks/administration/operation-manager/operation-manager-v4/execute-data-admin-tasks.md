---
title: "Execute data admin tasks"
metaKeys: ""
folderOnly: "false"
pageIndex: 1
---

 **Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4.x
 
### Overview

This page allows an administrator to create or modify operations, as well as scheduling them or executing them.
<br/>
A mechanism has been set up to prevent any of these operations to run simultaneously.
<br/>

1. **Operations list**<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/Operations1.png)

- Click an operation in the list on the left pane to view the details on the right pane.
- Operations that have been scheduled will have a clock and arrow icon.
- Operations that have been scheduled and failed have a red clock and arrow icon.
- Unscheduled operations that have failed have a red exclamation mark.

2. **Top section**<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/OperationsTopSection.png)

- Filter the operation list by category, to find the operation you are looking for faster.<br/>
- The "Add operation" button brings up the form used to [Add/Edit operations](AddEditOperation.md).<br/>
- The "Refresh" button gets the latest data but keeps your selection active.

3. **Right section**<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/OperationDetails.png)

After selecting an operation in the list, its full details are displayed on the right pane, as seen in the example above.

- The "Execute" button runs the operation manually and displays the detailed execution steps in a popup.
<br/>
When the execution is complete, the spinner icon, top right of the popup, goes away.

![](https://profitbasedocs.blob.core.windows.net/plannerimages/OperationRunning.png)

<br/>

- Basic information about the operation is displayed right under, such as the "Job Status", when it was last run, how long it took, etc.

- The "Schedule plan" displays a list of schedules. Those can be turned on or off using the toggle button.<br/>
To create a new schedule, click the [Create new schedule](AddEditSchedule.md) button.

- The steps are listed below. Grayed out steps have been disabled.


### Related Pages

-  [Add/Edit operations](AddEditOperation.md)
-  [Add/Edit schedule](AddEditSchedule.md)
-  [Execution log and error messages](OperationLog.md)
