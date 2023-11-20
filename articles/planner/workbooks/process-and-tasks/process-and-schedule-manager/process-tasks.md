---
title: "Process tasks"
metaKeys: ""
folderOnly: "false"
pageIndex: 1
---
### Overview
Process tasks are recurring tasks that are based on specific events (example: month end closing).
<br/>
Those tasks are assigned to roles and distributed as tasks to every user of the role.

### Column Descriptions

- **Task Name**
The name of the task.
<br/>

- **Assigned to**
The **role** that will receive this task based on a [recurring event](recurring-events.md).
<br/>

- **Recurring event**
The name of the recurring [recurring event](recurring-events.md).
<br/>

- **Days before/after event**
<br/>

    - Assign: the task will be assigned to role users N days before (N is negative) or after (N is positive) the recurring event.
    - Deadline: the task will have a due date N days before (N is negative) or after (N is positive) the recurring event.
<br/>

Note: the deadline cannot be set before the assign date, which would result in tasks being overdue as they are distributed.
<br/>

- **Priority**
Low, medium or high.
<br/>

- **Description**
The text description from the recurring task.
<br/>

- **Go to task**
Link to the workbook or external site where the task can be performed. 
<br/>

- **Assigned by**
The user who created the task.
<br/>

- **Next assign**
Estimated assign date, based on the [process](processes.md) and [recurring events](recurring-events.md).
<br/>

- **Assign log**
    - A log showing to which users the task was assigned, and if they were sent an assign or overdue email.<br/>
    - A log of any emails that failed, typically if the user email is not properly configured (check [Access control](../../../workbooks/administration/access-control/user-management.md) settings) or misconfigured [SMTP server settings](notification-settings.md).
