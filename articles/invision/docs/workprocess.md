---
title: "Work Process"
metaKeys: "Work Process, Tasks and Workbooks, Version, blueprint"
folderOnly: "false"
pageIndex: 33
---

A Work Process defines a set of Tasks and [Workbooks](workbooks.md) required to run a periodically repeated business process. Examples of such business processes are forecasting, budgeting, or any type of periodic planning process where identities have a set of tasks to complete each time.

A Work Process must have at least one Version before a user can do any work. [Versions](workprocess/workprocessversions.md) are created based on the Work Process blueprint, where the blueprint can contain Workbooks from one or more Solutions.

In order for a Workbook to be included in a Work Process blueprint, it must be in a [Package](package.md), and the Package must be in a Solution which is tagged as a **"blueprint Solution"** in the Designer.

When a Version is created, a new copy of every Package in the blueprint is created and added to a new Solution. If the blueprint contains more than one Package from the same Solution, they will all be placed together in the new Solution. This means that you can create your own Packages which extend the functionality or references objects in other Packages, and deploy them together in Work Processes.

![WP](https://profitbasedocs.blob.core.windows.net/images/workprocess2.png)

<br/>

### See Also

- [How To's](workprocess/howto.md)
- [Work Process Versions](workprocess/workprocessversions.md)
- [Work Process Configuration](workprocess/workprocessconfiguration.md)
- [Work Process Editor](workbooks/components/workprocesseditor.md)

### Videos

- [Work Process](../videos/workprocess.md)
- [Work Process - Basics](https://profitbasedocs.blob.core.windows.net/videos/Work%20Process%20-%20Basics.mp4)
- [Work Process - Versions](https://profitbasedocs.blob.core.windows.net/videos/Work%20Process%20Versions.mp4)

<br/>
