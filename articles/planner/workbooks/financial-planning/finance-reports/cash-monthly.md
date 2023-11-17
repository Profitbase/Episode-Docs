---
title: "Cash Monthly"
metaKeys: ""
folderOnly: "false"
pageIndex: 5
---

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5 or later.

## Overview
This report shows how cash is developing over the periods of a year. 
<br/>

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/finance-reports-cash-monthly-v5.JPG)

1. **Top Section** <br/>
The top sections contain mainly filter choices including selection of which report to presented. 
The upper right "Forecast start" tells which calendar period the forecast start. Since this may be a rolling forecast this period will be updated as the forecast reach next period. "Data last updated" tells when the input was last simulated to generate the full ledger. This process is normally scheduled to run at certain intervals. 

2. **Content Section** <br/>
Starting with the upper left "Cash Available OB", cash movements in and out is detailed in the report lines and subtotals and eventual in "Net Cash Flow" - showing the net for each period and Total column.
<br/>"Available Cash CB" is the sum of "Cash Available OB" and "Net Cash Flow" and provides the "Cash Available OB" for the following period. Hence the OB and CB (top and bottom row) shows aggregated values while the period columns show movements for that period.
<br/>The row "Cash Adjustments" is provided for doing quick adjustments which is directly applied to the cash development. Note that changes here are not saved anywhere.
<br/>The Forecast dataset is composed of Actual data for periods before the forecast start and Forecast input data from the forecast start period.

3. **Left Section** <br/>
The left section contains the Department filter and gives the ability to slice data according to an organization hierarchy. 

## Filter Descriptions
Filter selections available apart from Department are:

- **Fiscal Year** <br/>
Select year for presentation.
- **Dataset** <br/>
Select dataset to be presented.
- **Scenario** <br/> 
Is used related to simulation providing the alternatives: "Baseline", "Best" and "Worst". Scenario is only relevant for Forecast and Budget datasets.
- **Currency** <br/> 
Choose which currency to the used in the report. Average rate for each period is used for currency conversion.

Note that optional columns and filter under "Options" is not available for this report.

## Column Descriptions
Number-columns explained:

- **MMM YY** <br/> these 12 columns contain numbers from the selected dataset and shows the changes for each period.
- **Total** <br/> shows the sum of changes over the period.

## How to`s

<br/>

[Create new task](../../process-and-tasks/tasks/create-edit-task.md)<br/>