# Trial Balance - Planner 4
**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4

## Overview
This report provides a period view for Accounts including Opening and Closing Balance. This report also provides a sum across all accounts. This sum should be 0 (zero) for a correct trial balance. This report is sorted by account code but with accounts containing numbers first.

See an example of this report in picture below.
<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/finance-reports-trial-balance.jpg)

1. **Top and Left Section** <br/>
The left section contains the Department filter and gives the ability to slice data according to an organization hierarchy. 
The top sections contain mainly filter choices including selection of which report to presented. 
The upper right "Forecast start" tells which calendar period the forecast start. Since this may be a rolling forecast this period will be updated as the forecast reach next period. "Data last updated" tells when the input was last simulated to generate the full ledger. This process is normally scheduled to run at certain intervals. 

2. **Content Section** <br/>
The content section shows the period and total numbers per account for a selected year and dataset. The Forecast dataset here only contains Forecast input data. Depending on how data is loaded, the opening balance may be included in the first period and with the OB-column showing empty. In this case the data is loaded without marking the OB transactions.
Accounts with numbers are sorted first in the table. Accounts not used can be found sorted at the bottom.

## Filter Descriptions
Filter selections available apart from Department are:

- **Report**<br/>Not relevant here.
- **Year**<br/>What year to look at.
- **Month**<br/>Not relevant here.
- **Dataset**<br/>Select dataset to be presented.
- **Scenario**<br/>Is used related to simulation providing the alternatives: "Baseline", "Best" and "Worst". Scenario is only relevant for Forecast and Budget datasets.
- **Timefunction**<br/>Selecting Month will show the numbers for each month. Selecting Year-to-date will show the sum of this and preceding periods including OB. To see balanced you must use Year-to-date.
- **Currency**<br/>Choose which currency to the used in the report. Average rate for each period is used for currency conversion.

## Column Descriptions
Number-columns explained:

- **YYYYMM**<br/>These 12 columns contain numbers from the selected dataset.
- **OB**<br/>This is the Opening Balance.
- **CB**<br/>This is the Closing Balance. This is the sum of the OB and the 12 periods.

## How to`s

<br/>

[Create new task](../../../process-and-tasks/tasks/create-edit-task.md)<br/>
