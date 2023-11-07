---
title: "Additional dim. mapping"
metaKeys: ""
folderOnly: "false"
pageIndex: 7
---

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5.2 or later.

# Overview

Normally, an account is mapped to a single report line for any given report. In some cases, however, additional dimensionality is required to define the mapping to a reportline. For example if a given account is split between two report lines depending on the value of the Activity dimension.

Note that accounts will have to be mapped to report lines in any case.

Having mapped accounts to the report lines, this page allows you to specify additional dimensionality to define the relationship between transactions and report lines.

Select the report in question in the leftmost filter to display the current additional mapping set up.

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/AdditionalDimMapping1.JPG)

## Column Descriptions

- **Report Line ID**<br/>
The Report Line ID for the line of the currently selected report. Readonly.<br/>
- **Report Line**<br/>
The Report Line name for the line of the currently selected report. Readonly.<br/>
- **View**<br/>
If additional dimension members are mapped to the report line, a View link is available. Click it to review the current mapping (see description of second grid below).<br/>
- **Edit**<br/>
In order to map additional dimension members to the given report line or to edit the current mapping, click the Edit link for the appropriate report line.<br/>
-  [Edit selection](/planner/workbooks/data-management/report-setup/additional-dim-mapping-edit-selection) click to edit selection.<br/>
- **Delete**<br/>
If additional dimension members are mapped to the report line, a Delete is avialable. If you require to delete the additional dimension mapping, click the Delete link.<br/>

Second grid:

- **Dimension columns (depending on configuration)**<br/>
Displays the additional dimension members currently mapped to the report line for which the View link is clicked. Readonly.<br/>
