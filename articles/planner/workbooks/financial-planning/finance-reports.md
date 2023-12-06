# Finance Reports
## Overview
The reports for Finance Planning that are provided with the solution:
<br/>


## Related Pages

- [Compare](../../workbooks/financial-planning/finance-reports/compare.md)<br/>This report compares actual and budget against selected dataset. Numbers can be compared on selected current period, year-to-date, rest-of-year and the total for year.

- [Year and Months](../../workbooks/financial-planning/finance-reports/year-and-months.md)<br/>The selected report will show totals and periods for selected year.

- [Trial Balance](../../workbooks/financial-planning/finance-reports/trial-balance.md)<br/>This report will show periods and totals per account for selected year and dataset.

- [Cash](../../workbooks/financial-planning/finance-reports/cash.md)<br/>This report will show a breakdown of cash contribution from simulated general ledger.

- [Cash Monthly](../../workbooks/financial-planning/finance-reports/cash-monthly.md)<br/>This report will show how cash is changed and affecting available capital per month

- [Scenario Trend](../../workbooks/financial-planning/finance-reports/scenario-trend.md)<br/>This report shows a graph containing period line trends for selected report lines

- [Trend](../../workbooks/financial-planning/finance-reports/trend.md)<br/>This report is a graph showing period trend for all report lines enabled for trending.
<br/>

The following reports are flexible in that they will work with several reports containing different report line configuration:
- Compare
- Year and Months
- Scenario Trend
- Trend

For the above reports to work, you have to map accounts to report lines according to your account plan. The same way you adjust report lines and account mapping, you can add additional reports for selection. This is done in the [Reports Setup](../../workbooks/data-management/report-setup.md).

The data presented in Finance Reports is the simulated results from input and finance settings. Finance simulation normally runs as a scheduled job (e.g. at least every night to every hour). Each report (upper right corner) shows the time for the last simulation.

Note that in most cases the Forecast dataset is made up by Actuals for periods before the cut-over period and Forecast data from the cut-over period. The cut-over period is controlled by the Month filter. Selecting e.g. June will use Actual data for the Forecast dataset before June and use Forecast data from June and onwards. 

The exception to this is the Trial Balance and Scenario Trend reports which always will show individual data from each dataset. This is for controlling and compare purposes.
<br/>

## See also
-  [Setup Reports](../../workbooks/data-management/report-setup.md)<br/>
Create reports and report lines. Manage account mapping to report lines and sub-total formulas.
