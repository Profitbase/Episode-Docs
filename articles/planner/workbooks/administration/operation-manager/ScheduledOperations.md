# Scheduled Operations

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Common 5.3.0 or later

## Overview

This page is used to schedule background operations that keep the system updated.

These may be executed manually or scheduled.

This page is designed to be more accessible and makes use of the [Operations](Operations.md) that are set up on page 2 which may require some knowledge of the Invision objects that exist in the system.

A warning icon ![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/warning_24.png)  will show if any problems are detected, such as no steps defined, or taret object not found in system. Click that icon to see the warning message.

###  Active functions in the listing:

These are the most commonly used functions on this page, and have therefore been added directly in the listing:

**Steps** - To Edit the Steps, which consists of Operations from the second page, click the action link in the list.

**Execute** - Same function as the "Execute in Version" in the 3 dots menu.

**Schedule Icon** - Can be clicked to open the scheduler popup. Also available under the 3 dots menu.

**Error Icon** - Can be clicked to view the error message.




### Click on the 3 dots menu in the operations list to view all possible actions:


**Edit** - Edit an operation : Rename, add translation, set the category or add a comment.

**Execute** - Execute an operation immediately, using stored settings.

**Execute in version..** - Execute an operation in a specific set of versions. An intermediary popup for selecting versions appears. An action link is available in the Operations list for this commonly used function.

**Operation log** - View execution log, showing when the job was run, who or what (schedule) started it, and see any errors.

**Link to workbook** - Makes the Operation available on the selected workbook(s), through a button that will be shown on the target workbook(s).

**Schedule Plan** - View, Add, or remove schedules.

**Version Execution Mode** - Select version(s) the operation should target when run on schedule. For every Process, the options are "Current Version" and "All Active Versions".

**Delete** - Deletes the operation. The steps are not deleted and are still available to add.




### Version Execution Mode

Select from the list of Processes using the checkbox.

When a Process has been selected, "Current Version" will be selected by default, and can be changed to "All Active Versions". A summary of the versions will be displayed.

![](https://profitbasedocs.blob.core.windows.net/plannerimages/versionexecutionmode.png)

### Steps

Steps on this page should only consist of "[Operations](Operations.md)", defined on page 2.

Steps can be enabled or disabled using the Toggle Button.

Hovering a step, will also display 4 small buttons to navigate to the operation (on page 2), move the steps up or down (re-ordering), or deleting the step from this scheduled operation.

To add a step, use the (orange) Actions menu top right: a popup will appear, so you can select an [Operation](Operations.md) from the list. Optionally, give it a more user friendly name and proper translation.


### Schedule

To add a schedule, use the (orange) Actions menu top right: a popup will appear where you can specify any type of time interval, daily, weekly, monthly or a CRON expression (advanced).

Multiple Schedules can be combined to produce very specific plans.

To delete a schedule, hover over it, and click the trash icon.


## Related Pages

[Operations](Operations.md)

[Settings](Settings.md)