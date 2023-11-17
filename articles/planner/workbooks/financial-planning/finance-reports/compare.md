---
title: "Compare"
metaKeys: ""
folderOnly: "false"
pageIndex: 1
---

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5 or later.

## Overview
This report is used for comparing finance ledger aggregated to reporting lines. Data versions are compared by selecting two dataset versions (A and B). The forecast datasets are combining actual data up until forecast start and forecast data from forecast start and forward. 

This report contains sections to comparing the selected period, year-to-date, rest-of-year and year-total.

See an example of this report in picture below.
<br/>

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/finance-reports-compare-v5.JPG)

1. **Top Section** <br/>
The top section contains mainly filter choices including selection of which report to presented. 
The upper right "Forecast start" tells which calendar period the forecast start. Since this may be a rolling forecast this period will be updated as the forecast reach next period. "Data last updated" tells when the input was last simulated to generate the full ledger. This process is normally scheduled to run at certain intervals. 

2. **Content Section** <br/>
The content section shows the reporting lines including rows for sub-totals. The table is divided into 4 sections for comparison between actual, selected dataset (i.e. Forecast by default) and Budget:

+ **Month**<br/>Compare selected month
+ **Year To Date**<br/>Compare year to date for according to selected month
+ **Rest of Year**<br/>Compare Forecast and Budget for rest of year
+ **Year Total**<br/>Compare year outlook combining aggregating actual periods with remaining periods

The Forecast dataset is composed of Actual data for periods before the Forecast start and Forecast input data from the Forecast start period (as shown in the upper right in the report).

3. **Left Section** <br/>
The left section contains the Department filter and gives the ability to slice data according to an organization hierarchy.

## Filter Descriptions
Filter selections available apart from Department are:

- **Report**<br/>Allow selecting different report configurations.
- **Fiscal Year**<br/>Select year to compare.
- **Month**<br/>Select what month to compare. This also determines the time range for year-to-date and rest-of-year.
- **Dataset A:**<br/>Select dataset A. The current version data is the default dataset and others can be selected using the dropdown list. The field for selecting dataset is marked "A" to help put a reference to the selected dataset on columns headers in content section.
- **compared to B:**<br/>Select dataset B. The default dataset here is actual last year data. Use the dropdown list to select another dataset as needed.
- **Scenario**<br/>Is used related to simulation providing the alternatives: "Baseline", "Best" and "Worst". Scenario is only relevant for Forecast and Budget datasets.
- **Currency**<br/>Choose which currency to the used in the report. Average rate for each period is used for currency conversion.

## Column Descriptions

Number-columns explained:

- **Actual**<br/> This contains numbers from the account system.
- **Budget**<br/> This contains numbers from Budget and Scenario = "Baseline".
- **Forecast**<br/> This contains numbers from Forecast or another selected dataset.
- **&Delta; Budget**<br/> This is the difference between Actual and Budget. The &#37;-column to the right shows the difference as percentage.
- **&Delta; Forecast**<br/> This is the difference between Actual and Forecast. The &#37;-column to the right shows the difference as percentage.
- **Act.+Forecast**<br/> This contains the sum of Actual year-to-date and Forecast rest-of-year. Note that the selected month controls the year-to-date and rest-of-year.
- **Act.+Budget**<br/> This contains the sum of Actual year-to-date and Budget rest-of-year. Note that the selected month controls the year-to-date and rest-of-year.

## How to`s

<br/>

[Create new task](../../process-and-tasks/tasks/create-edit-task.md)<br/>