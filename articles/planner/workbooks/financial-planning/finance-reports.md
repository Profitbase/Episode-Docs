---
title: "Finance Reports"
metaKeys: ""
folderOnly: "false"
pageIndex: 5
---
## Overview
The reports for Finance Planning that are provided with the solution:
<br/>


## Related Pages

- [Compare](/planner/workbooks/financial-planning/finance-reports/compare)<br/>This report compares actual and budget against selected dataset. Numbers can be compared on selected current period, year-to-date, rest-of-year and the total for year.

- [Year and Months](/planner/workbooks/financial-planning/finance-reports/year-and-months)<br/>The selected report will show totals and periods for selected year.

- [Trial Balance](/planner/workbooks/financial-planning/finance-reports/trial-balance)<br/>This report will show periods and totals per account for selected year and dataset.

- [Cash](/planner/workbooks/financial-planning/finance-reports/cash)<br/>This report will show a breakdown of cash contribution from simulated general ledger.

- [Cash Monthly](/planner/workbooks/financial-planning/finance-reports/cash-monthly)<br/>This report will show how cash is changed and affecting available capital per month

- [Scenario Trend](/planner/workbooks/financial-planning/finance-reports/scenario-trend)<br/>This report shows a graph containing period line trends for selected report lines

- [Trend](/planner/workbooks/financial-planning/finance-reports/trend)<br/>This report is a graph showing period trend for all report lines enabled for trending.
<br/>

The following reports are flexible in that they will work with several reports containing different report line configuration:
- Compare
- Year and Months
- Scenario Trend
- Trend

For the above reports to work, you have to map accounts to report lines according to your account plan. The same way you adjust report lines and account mapping, you can add additional reports for selection. This is done in the [Reports Setup](/planner/workbooks/financial-planning/report-setup).

The data presented in Finance Reports is the simulated results from input and finance settings. Finance simulation normally runs as a scheduled job (e.g. at least every night to every hour). Each report (upper right corner) shows the time for the last simulation.

Note that in most cases the Forecast dataset is made up by Actuals for periods before the cut-over period and Forecast data from the cut-over period. The cut-over period is controlled by the Month filter. Selecting e.g. June will use Actual data for the Forecast dataset before June and use Forecast data from June and onwards. 

The exception to this is the Trial Balance and Scenario Trend reports which always will show individual data from each dataset. This is for controlling and compare purposes.
<br/>

## See also
-  [Setup Reports](/planner/workbooks/data-management/report-setup)<br/>
Create reports and report lines. Manage account mapping to report lines and sub-total formulas.
