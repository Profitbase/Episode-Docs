---
title: "Options"
metaKeys: ""
folderOnly: "false"
pageIndex: 5
---

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5 or later.

# Overview
This is to configure additional options for Finance Reports. Based on available dimensions, you can allow users to use these as additional columns and/or filters in the reports.

Note that you cannot delete nor add rows to this table. The content is preset containing the available dimension in Planner.

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/report-setup-options-v5.JPG)

### Column Descriptions

- **Enabled**<br/>
Set to true to enable dimension to be available in [Finance Reports](../../financial-planning/finance-reports.md) options.
- **Name**<br/>
The name of the dimension. This list contains all possible dimensions that can be used.
- **Show as column**<br/>
Set to true to make this dimension available as optional column in certain reports (mainly table type reports).
- **Column order**<br/>
This defines the sort order of the columns.
- **Use as filter**<br/>
Set to true to enable this dimension to be used as a filter.
- **Built-in**<br/>
This is an information column to inform that there may be settings that are mandatory. For example, "Dataset" which is always enabled and available as additional column. It does not make sense to set "Use as filter" for "Dataset" since this dimension is already used as filter in [Finance Reports](../../financial-planning/finance-reports.md).


###Caution setting "Show as filter"
It is highly recommended to only enable filter for dimensions that are used consistently across all actual and plan dataset versions. Be aware that enabling dimensions that are rarely used across different actual and plan dataset versions may make it very confusing for the user since data will "come and go". For example, when using Project as a filter and project is not present for actual data from general ledger, the actual data columns or rows will disappear when filtering on a selected project.

###Dimensions listed

The dimensions listed in "Name" column is the dimensions available in Planner. Note that the names listed are the native Planner Names before you choose to rename them. For example, normally "Dim1" will be renamed to a more descriptive name for what Dim1 is used for.

Note that the list of dimensions is checked against enabled dimensions for plan input. If you miss a dimension, the reason should be that this dimension is not in use for plan input.
