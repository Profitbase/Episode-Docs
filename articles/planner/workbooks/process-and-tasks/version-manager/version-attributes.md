---
title: "Version attributes"
metaKeys: ""
folderOnly: "false"
pageIndex: 2
---
## Overview
Once created, some of the version's attributes can be maintained. This is done in the "Version attributes" page:

<br/>

![](img/processes-and-versions-attributes.JPG)

<br/>

The following attributes can be maintained:

**Display name**
The (short) name to display in version drop downs when selecting which version to report and/or compare.
<br/>

**Avail. for operations**
Indicates whether this version is available for executing operations against. Operations are executed in the [Operation manager](/planner/workbooks/administration/operation-manager).<br/>

This attribute is automatically set to checked (true) when opening the version and to un-checked (false) when closing the version. The attribute is editable.
<br/>

**Current Version**
Indicates that this version is the current version for the process in question. For a version to be current, it has to be Avil. for operations.

This attribute is automatically set to checked (true) when opening the version and any other version for the same process that has its Current Version checked will be un-checked so that only one version with each version is the current version.

A version can be manually set as the current version by right-clicking the column and selecting the "Set as current version" menu.

**Assign process tasks when version is open**
Indicates whether process tasks should be assigned to this version when the version is open. Process tasks are maintained in the [Process and schedule manager](/planner/workbooks/process-and-tasks/process-and-schedule-manager).<br/>

This attribute is automatically set to checked (true) on the first open of the version. The attribute is editable.
<br/>

**Avail. for reporting**
Indicates whether the version is available for reporting and/or comparison. Reporting is done in the [Finance reports](/planner/workbooks/financial-planning/finance-reports).<br/>

This attribute is automatically set to checked (true) on the first open of the version. The attribute is editable.
<br/>

**Export name**
The export name (if any) attached to the version. Please refer to [Export name](/planner/workbooks/process-and-tasks/version-manager/export-name) for details on export name.<br/>

<br/>

**Set (export name)**
Attach an export name to the given version. Note that only one version can hold a given export names at any one time. Please refer to [Export name](/planner/workbooks/process-and-tasks/version-manager/export-name) for details on export name.<br/>
<br/>

**Comments**
Optional comments. Editable.
<br/>
