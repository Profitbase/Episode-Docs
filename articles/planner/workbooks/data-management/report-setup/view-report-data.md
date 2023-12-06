# View report data

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4  (removed from Planner 5).

## Overview
This is to inspect report setup. Since the purpose of this report is to inspect and test report setups, this report contains a mix of normal report data and definitions used to control the report such as formula and style.

With reference to the screen:

1. **Top and Left Section** <br/>
The left section contains the Department filter and gives the ability to slice data according to an organization hierarchy. 
The top sections contain mainly filter choices including selection of which report to presented. 
The upper right "Forecast start" tells which calendar period the forecast start. Since this may be a rolling forecast this period will be updated as the forecast reach next period. "Data last updated" tells when the input was last simulated to generate the full ledger. This process is normally scheduled to run at certain intervals. 

2. **Content Section** <br/>
The content section shows the reporting lines including sub-totals per period for a selected year. The Forecast dataset is composed of Actual data for periods before the Forecast start and Forecast input data from the Forecast start period (as shown in the upper right in the report).

## Filter Descriptions
Filter selections available apart from Department are:

- **Report**<br/>This allows for selecting between different report configurations
- **Dataset**<br/>Select dataset to be presented.
- **Scenario**<br/>This is used related to simulation providing the alternatives: "Baseline", "Best" and "Worst". Scenario is only relevant for Forecast and Budget datasets.
- **Year**<br/>Select what year to look at
- **Time function**<br/>Selecting Month will show the numbers for each month. Selecting Year-to-date will show the sum of this and preceding periods including OB for balance type reports. To see balanced you have to use Year-to-date.
- **Currency**<br/>Choose which currency to the used in the report. Average rate for each period is used for currency conversion.

## Column Descriptions

- **ID**<br/>
The unique identity for the report line.
- **Name**<br/>
The name for the report line.
- **Formula**<br/>
Formula used to calculate this row.
- **Style**<br/>
Style applied to this row.
- **Time function**<br/> 
Time function selected and applied to the row.
- **Currency**<br/>
Currency selected and applied to the report rows.
- **P01..P12**<br/> Is the 12 period columns showing amounts.

