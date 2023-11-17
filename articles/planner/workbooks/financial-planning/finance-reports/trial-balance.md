---
title: "Trial Balance"
metaKeys: ""
folderOnly: "false"
pageIndex: 3
---

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5 or later.

## Overview
This report provides a period view for Accounts including Opening and Closing Balance. This report also provides a sum across all accounts. This sum should be 0 (zero) for a correct trial balance. This report is sorted by account code but with accounts containing numbers first.

See an example of this report in picture below.
<br/>

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/finance-reports-trial-balance-v5.JPG)

1. **Top Section** <br/>
The top section contains mainly filter choices including selection of which report to presented.
The upper right "Forecast start" tells which calendar period the forecast start. Since this may be a rolling forecast this period will be updated as the forecast reach next period. "Data last updated" tells when the input was last simulated to generate the full ledger. This process is normally scheduled to run at certain intervals.

2. **Content Section** <br/>
The content section shows the period and total numbers per account for a selected year and dataset. The Forecast dataset here only contains Forecast input data. Depending on how data is loaded, the opening balance may be included in the first period and with the OB-column showing empty. In this case the data is loaded without marking the OB transactions.
Accounts with numbers are sorted first in the table. Accounts not used can be found sorted at the bottom.

3. **Left Section** <br/>
The left section contains the Department filter and gives the ability to slice data according to an organization hierarchy.

4. **Right Section - Upper** <br/>
Click on "Options" on the right edge of the window, you can select additional columns to be included after the report line name column in the table report (section 2). The picture above shows an example using dataset to compare between a forecast dataset and actual last year. Additional columns enabled here is subject to configuration settings.

5. **Right Section - Lower** <br/>
Click on "Options" on the right edge of the window, at the bottom you can select and additional filters to be applied when extracting data. You can see filters and values applied on the top section next to the label "Filter options:". Filters available here are subject to configuration settings.

## Filter Descriptions
Filter selections available apart from Department are:

- **Fiscal Year**<br/>What year to look at.
- **Dataset A**<br/>Select dataset to be presented.
- **compared to B**<br/>Optional select a dataset to be used for comparison together with selecting "Dataset" column under options.
- **Scenario**<br/>Is used related to simulation providing the alternatives: "Baseline", "Best" and "Worst". Scenario is only relevant for Forecast and Budget datasets.
- **Timefunction**<br/>Selecting Month will show the numbers for each month. Selecting Year-to-date will show the sum of this and preceding periods including OB. To see balanced you must use Year-to-date.
- **Currency**<br/>Choose which currency to the used in the report. Average rate for each period is used for currency conversion.

## Column Descriptions
Number-columns explained:

- **YYYYMM**<br/>These 12 columns contain numbers from the selected dataset.
- **OB**<br/>This is the Opening Balance.
- **CB**<br/> CB is the sum of OB for plan start and the following plan columns when Timefunction = Year-to-date. When Timefunction = Month, CB is the sum of OB and the 12 period values (not including plan start OB). This is why CB may show different values for different sleection of Timefunction because plan OB is missing or adjusted (and hence not equal to year-to-date actual periods before plan start period).
- **Total**<br/> Provides the sum of period values over the above 12 columns for Profit-Loss type reports.  For Balance type reports showing opening balance (OB) and period values (when Timefunction = Month), Total column is the sum on OB and period values. From Planner versions after 5.1.3, the column header is different (showing Total or CB) to reflect the way this column is calculated.

You can select additional columns under "Options". These will be dataset and other dimensions that may be used in the report. Available columns are subject to configuration settings for your solution.

## How to`s
<br/>

[Create new task](../../process-and-tasks/tasks/create-edit-task.md)<br/>
