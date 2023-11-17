---
title: "Reports"
metaKeys: ""
folderOnly: "false"
pageIndex: 1
---

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or later.

# Overview
This is to define new reports and edit attributes related to reports.

A report is the entity that hold a set of report lines. Reports are used to define typical finance reports such as Profit & Loss, Balance and Cashflow.  

Note that from Planner 5.2, this page renders in a pop-up as opposed to a separate page as it did in previous versions.
<br/>

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/report-setup-reports.JPG)

Right-click mouse to insert a new row for new report.
<br/>

## Column Descriptions

- **Report ID (k)**<br/>
ID text string to uniquely identify the report. Mandatory.

- **Report**<br/>
Name text string used to display the name; unless translation is defined. Mandatory.

- **EN: Report**<br/>
Name translation in English. Optional.

- **NO: Report**<br/>
Name translation in Norwegian. Optional.

- **Report Type**<br/>
Dropdown list to define what type of report. Mandatory. Listed values are:
   - "Profit Loss" for profit and loss type of report (with year total but not opening and closing balance).
   - "Balance Sheet" for balance type of report (with opening and closing balance).
   - "Other" for other type of reports that will not have any finance logic associated when presenting the report.

- **Selectable**<br/>
Set to true (ticked) if the report shall appear in dropdown list in Finance reports as a selectable report.

- **Comments**<br/>
Free text string to help document the settings here.

The following columns is for external consumers of these report definitions and not relevant to Profitbase Planner use.

- **Active**<br/>
Report can be used by external report tool.

- **Drilldown**<br/>
This report is a drilldown report.

- **Report Number**<br/>
Sequence number for report.

