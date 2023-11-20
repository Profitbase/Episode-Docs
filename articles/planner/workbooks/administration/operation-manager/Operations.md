---
title: "Operations"
metaKeys: ""
folderOnly: "false"
pageIndex: 2
---
**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Common 5.3.0 or later

### Overview

This page is used to create operations that are made available as steps for the [Scheduled Operations](ScheduledOperations.md) on page 1.

Each step is a reference to an existing Invision object of either of these types: PowerShell scripts, SQL Scripts, DataFlows.

All the steps within an Operation must belong to the same Application.

A warning icon ![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/warning_24.png) will show if any problems are detected, such as no steps defined, or taret object not found in system. Click that icon to see the warning message.


####Active functions in the listing:

These are the most commonly used functions on this page, and have therefore been added directly in the listing:

**Steps** - To Edit the Steps, which consists of Operations from the second page, click the action link in the list.

**Execute** - Same function as the "Execute in Version" in the 3 dots menu.



####Click on the 3 dots menu in the operations list to view all possible actions:


**Edit** - Edit an operation : Rename, add translation, set the category or add a comment.

**Execute** - Execute an operation immediately, using stored settings.

**Execute in version..** - Execute an operation in a specific set of versions. An intermediary popup for selecting versions appears. An action link is available in the Operations list for this commonly used function.

**Operation log** - View execution log, showing when the job was run, who or what (schedule) started it, and see any errors.

**Link to workbook** - Makes the Operation available on the selected workbook(s), through a button that will be shown on the target workbook(s).

~~**Schedule Plan**~~ - Option Disabled for page 2. Only [Scheduled Operations](ScheduledOperations.md) can be set on schedule.

**Version Execution Mode** - Select version(s) the operation should target when run on schedule. For every Process, the options are "Current Version" and "All Active Versions". The last column will show a list of version(s) that would currently correspond to.

**Delete** - Deletes the operation. The steps are not deleted and are still available to add.



####Steps

Steps on this page should only consist of Invision objects of the type: SQL Script, PowerShell Script or DataFlow.

Steps can be enabled or disabled using the Toggle Button.

Hovering a step, will also display 3 small buttons to move the steps up or down (re-ordering), or deleting the step from this scheduled operation. Deleting a step will not delete the Invision object, only the step!

To add a step, use the (orange) Actions menu top right: a popup will appear, so you can select an Invision object from the list. The type dropdown will filter the objects. Optionally, give it a more user friendly name and proper translation.

The Object selection dropdown has text search enabled to help find the step.

Arguments (advanced) may be added to objects of the type SQL Script and PowerShell. The Data Import module, for example, makes use of these arguments.

### Related Pages

[Scheduled Operations](ScheduledOperations.md)

