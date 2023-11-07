---
title: "Scenario Trend"
metaKeys: ""
folderOnly: "false"
pageIndex: 6
---

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5 or later.

## Overview
This report is using splines to show the trend over time for selected report lines. To the right you can select which report lines you want to show. This report shows data from selected dataset versions and all scenarios. Note that scenarios is only relevant for plan datasets (e.g. plan data from Forecast and Budget process).
<br/>Report lines available for trending (selectable item to the right) is a subset of all report lines. The set enabled for trending is configured when defining the report lines.

To use this report:

1. Select report lines on the upper right in report.
1. Make any other selections and click Refresh-button to draw the report.
1. Click on the legends on the lower part to toggle on/off individual graph-splines.

See an example of this report in picture below.
<br/>

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/finance-reports-scenario-trend-v5.JPG)

1. **Top Section** <br/>
The top sections contain mainly filter choices including selection of which report to presented. 
The upper right "Forecast start" tells which calendar period the forecast start. Since this may be a rolling forecast this period will be updated as the forecast reach next period. "Data last updated" tells when the input was last simulated to generate the full ledger. This process is normally scheduled to run at certain intervals. 

2. **Left Section** <br/>
The left section contains the Department filter and gives the ability to slice data according to an organization hierarchy.

3. **Graph Selection** <br/>
The upper right table allows for selecting the report lines to be displayed. This is to avoid too many lines being drawn at the same time which makes it difficult to see the trend from actual continuing in forecast and budget periods. 

The graph series for selection appearing here is configured in the [Report Setup](\planner\workbooks\data-management\report-setup).

4. **Content Section** <br/>
The content section shows graph lines for all report lines that are configured enabled for trending. The Forecast dataset is composed of Actual data for periods before the Forecast start and Forecast input data from the Forecast start period (as shown in the upper right in the report).
Note that the graph is prepared to display up to scenario version Baseline, Best and Worst for plan dataset versions.

The time axis will show 12 periods for 3 fiscal years with the selected fiscal year as the middle year. The red vertical line draws where the plan start is for the current version.

## Filter Descriptions
Filter selections available apart from Department are:

- **Report**<br/>Allows for selecting between different report configurations
- **Year**<br/>What year to look at
- **Dataset A**<br/>Select dataset to be presented.
- **compared to B**<br/>Optional select a dataset to be used for comparison together with selecting "Dataset" column under options.
- **Scenario**<br/>Not relevant for this report.
- **Timefunction**<br/>Selecting Month will show the numbers for each month. Selecting Year-to-date will show the sum of this and preceding periods. To see balanced you have to use Year-to-date.
- **Currency**<br/>Choose which currency to the used in the report. Average rate for each period is used for currency conversion.

This report allows slicing on additional dimensions - found under "Options".

## Graph Descriptions

Each graph line represents a reporting line enabled for trending in the selected report. The amount is plotted on a per million scale. Moving the mouse over a period, will show a shared tooltip that present all amounts for the period.

Click on the bottom legend to toggle on/off graph lines. This is useful to enable to focus on certain series.

## How to`s

<br/>
[Create new task](/planner/workbooks/process-and-tasks/tasks/create-edit-task)<br/>
