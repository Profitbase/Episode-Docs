# Setup
## Overview
This is the setup page for the loan module. On this page, you can configure settings such depreciation accounts, depreciation rates and so on as well as configure the input page in terms of which columns to include and how to name them.<br/>
A separate document deals with the setup, please refer to the "How to's" link below.<br/>
<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/CapExSetup.JPG)

## Descriptions

Each table and columns are described below.

Key columns used for matching when looking up correct setting is marked (k).


### Investment: Depreciation
This table defines settings for investments depreciation. Different settings can be applied to all og specific companies and Asset Groups and yielding From Date.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Asset Group (k)**<br/>
Named group for a set of assets.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **Depr.%**<br/>
Yearly depreciation percent.
- **Declining**<br/>
Set to true if depreciation is calculated based on residual value (investment amount less accumulated depreciation). The default value is false which means that depreciation is linear; i.e. calculated as a percent of investment amount.
- **Y1 = full year**<br/>
Set to true will calculate depreciation for the full year. This is only valid for depreciation calculated using Declining method (i.e. only in effect when Declining is set to true).
- **ResidualValue**<br/>
Defines the residual value limit for an investment. When this value is reached the depreciation calculation is stopped. Residual value is the investment value less accumulated depreciation.
- **Account**<br/>
This is the account to be used for depreciation.
- **CAccount**<br/>
This is the counter-account to depreciation which is a balance account for accrued depreciation.
- **Comments**<br/>
Free text string to help document settings.
<br/>

### Investment: Accounts
This table defines the accounts involved with investments.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Asset Group (k)**<br/>
Named group for a set of assets.
- **FixedAsset**<br/>
This is the account for the fixed asset investment amount.
- **AP**<br/>
This is the account for accounts payable.
- **AgioDis**<br/>
This is the account for agio and disagio. When investing and paying in foreign currency there may be exchange rate changes between invoice data and payment date. The difference is booked to this account.
- **Comments**<br/>
Free text string to help document settings.
<br/>

### DecliningBalance StopValue
This table defines the default residual value limit and will be used whenever the ResidualValue is left out from Investment: Depreciation above.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **StopValue**<br/>
Defines the residual value limit to stop depreciation calculation.
- **Comments**<br/>
Free text string to help document settings.
<br/>

## How to`s

<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 6.1 or later
> [Configure the CapEx module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V6.1/Planner%20CapEx%20module.pdf)<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5.2.4 or later
> [Configure the CapEx module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.2.4/Planner%20CapEx%20module.pdf)<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5.2 
> [Configure the CapEx module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.2/Planner%20CapEx%20module.pdf)<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5 or later
> [Configure the CapEx module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/v5/Planner%20CapEx%20module.pdf)<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4.x
> [Configure the CapEx module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/Planner%20CapEx%20module.pdf)<br/>
