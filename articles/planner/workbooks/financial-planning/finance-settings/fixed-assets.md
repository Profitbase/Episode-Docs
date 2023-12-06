# Fixed Assets
## Overview
This page defines input and settings form fixed assets.
<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/finance-settings-fixed-assets.jpg)

1. **Selecting Setting Table**<br/>The left area list the different setting tables available for the page. Ticking here will turn on and off the table.
2. **Tables View**<br/>The right area will display the selected tables and allows users to edit content.
<br/>

## Descriptions

Each table and columns are described below.

Key columns used for matching when looking up correct setting is marked (k).

### FixedAsset
This table is the input table for defining fixed asset balance and depreciation.

You can choose to register assets using the purchase value and purchase date or purchase value and accumulated depreciations up until the opening balance date.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Text (k)**<br/>
Name to identify an asset or group of assets.
- **Departm. (k)**<br/>
Department identifier.
- **Account**<br/>
Account to post the fixed asset balance amount.
- **AssetCost**<br/>
Asset purchase value
- **Depr. accum**<br/>
Accumulated depreciations override amount. This optional and is used with start date is set to opening balance date.
- **StartDate**<br/>
Booking date for purchase. Alternative set the opening balance date when "Depr. accum" override is used.
- **Depr. %**<br/>
Deprecation percent.
- **ResidualValue**<br/>
Residual value. Limit to stop deprecations.
- **Declining**<br/>
Set to true to depreciate based on balance. When false depreciate linear based on purchase value.
- **Y1 = full year**<br/>
Set to true to depreciate one full year the first year. Set to false will depreciate from start date.
- **Acc Depr.**<br/>
Account for depreciations (profit-loss account).
- **CAccount**<br/>
Counter account for depreciations (balance account).
- **Disp. date**<br/>
Disposal date.
- **Curr.Foreign**<br/>
Disposal foreign currency.
- **Disposal**<br/>
Disposal amount in foreign currency.
 **VAT %**<br/>
VAT percent applicable for disposal amount.
 **DaysOfCredit**<br/>
Days of credit (i.e. days until payment is received).
 **Acc AgioDis**<br/>
Account for agio-disagio.
 **Acc P&L**<br/>
Account for profit-loss.
- **Comments**<br/>
Free text string to help document settings.
- **Dim1, ... , Dim4**<br/>
Optional dimensions
<br/>

### DecliningBalance StopValue
This table defines when depreciation assets will stop.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **StopValue**<br/>
The balance limit amount to stop depreciating assets.
- **Comments**<br/>
Free text string to help document settings.
