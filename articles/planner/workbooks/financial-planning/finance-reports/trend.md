---
title: "Trend"
metaKeys: ""
folderOnly: "false"
pageIndex: 7
---

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5 or later.

## Overview
This report shows the line graph over periods for all report lines enabled for trending.
Report lines available for trending (selectable item to the right) is a subset of all report lines. The set enabled for trending is configured when defining the report lines.

<br/>To use this report:

1. Make any selections and click Refresh-button to draw the report
1. Click on the legends on the lower part to toggle on/off individual graph-lines

See an example of this report in picture below.
<br/>

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/finance-reports-trend-v5.JPG)

1. **Top Section** <br/>
The top sections contain mainly filter choices including selection of which report to presented. 
The upper right "Forecast start" tells which calendar period the forecast start. Since this may be a rolling forecast this period will be updated as the forecast reach next period. "Data last updated" tells when the input was last simulated to generate the full ledger. This process is normally scheduled to run at certain intervals. 

2. **Left Section** <br/>
The left section contains the Department filter and gives the ability to slice data according to an organization hierarchy.

3. **Content Section** <br/>
The content section shows graph lines for all report lines that are configured enabled for trending. The Forecast dataset is composed of Actual data for periods before the plan data start from the Forecast start period (as shown in the upper right in the report). The plan start period for the current version is also marked with a red vertical line.

The graph shows 3 fiscal years of data and 12 periods per year. The selected fiscal year appears as the middle year.

## Filter Descriptions
Filter selections available apart from Department are:

- **Report**<br/>Allows for selecting between different report configurations
- **Year**<br/>What year to look at
- **Dataset**<br/>Select dataset to trend.
- **Scenario**<br/>Select scenario "Baseline", "Best" or "Worst". Note that these are only relevant for plan dataset versions.
- **Timefunction**<br/>Selecting Month will show the numbers for each month. Selecting Year-to-date will show the sum of this and preceding periods. To see balanced you have to use Year-to-date.
- **Currency**<br/>Choose which currency to the used in the report. Average rate for each period is used for currency conversion.

Note that optional columns and filter under "Options" is not available for this report.

## Graph Descriptions

Each graph line represents a reporting line enabled for trending in the selected report. The amount is plotted on a per million scale. Moving the mouse over a period, will show a shared tooltip that present all amounts for the period.

Click on the bottom legend to toggle on/off graph lines. This is useful to enable to focus on certain series.

The graph series appearing here is configured in the [Report Setup](../../data-management/report-setup.md).

## How to`s

<br/>

[Create new task](../../process-and-tasks/tasks/create-edit-task.md)<br/>
