# Setup

## Overview
This page allows you to configure the Profit and Loss input modules such as Personnel and Account. By configuration means the dimensionality, the use of historical reference columns and so on.<br/>
You can also name the modules, control their availability to end-users and how the individual modules are tied to specific report lines of the profit and loss summary report used in the:<br/>

Plan overview workbook (**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5 or later)<br/>

or<br/>

Budget and Forecast workbooks (**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4.x)<br/>
<br/>

![](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/InputSettingsSetup.JPG)

1. **Module specific configuration tables - main, upper area**<br/>
With the exception of the "Base settings" table (see description below), this area contains module specific configuration tables.<br/>
Please refer to the relevant module document in the "How to's" section below for details.
2. **Module specifics - lower left area**<br/>
This is where you can set the name of the modules and, by checking/un-checking the "Published" check box, control the availability of the module to end-user. A module with its "Published" check box unchecked is not available to end-users.<br/>
Note that the Sales forecast module has a separate setup workbook.
3. **Module to report line mapping - lower right area**<br/>
This is where you can tie an input module to a specific report line. This tie control which input module is launched when an end-user clicks the report line in either the Budget or Forecast summary.<br/>
Please refer to the relevant module document in the "How to's" section below for details.
<br/>

## The Base settings table

![](https://profitbasedocs.blob.core.windows.net/plannerimages/base-settings.JPG)

The Base settings table contains settings that span all profit and loss input modules.

## Column Descriptions

- **Setting ID**<br/>

The setting identifier.<br/>

- **Setting ID**<br/>

The actual value for the setting in question, see corresponding comment for valid options.<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/base-setting-close-up.JPG)

The following settings require additional explanation:<br/>

*FCTYearTotalFloating*: In a rolling forecast, this year will consist of an Actuals Year to Date part and a Forecast Rest of Year Part. When rolling forward 1 month, one forecast rest of year month is replaced with an actual year to date month. This setting controls how This year's total value is affected:<br/>

- TRUE: This year's total floats (changes) reflects the fact the new actuals year to date month differs from the replaced forecast rest of year month.<br/>
- FALSE: This year's total remains the same as it was prior to roll forward. This implies that any difference is spread across the remaining forecast rest of year months.<br/>

*AccountNetFactor*: Applies only to sum (net) lines in account-based input sheets and reports (valid values: -1 | 1), -1 is the default. Net is displayed as sum of amounts of individual accounts multiplied by account's sign factor. The net is then multiplied with the AccountNetFactor value.<br/>

What value to choose depends on which account sign is used, how data is input and how one would like to see the net of income and cost.<br/>

Default:<br/>

Account sign -1 for income accounts, +1 for cost accounts.<br/>
All normal input positive, income and cost.<br/>
AccountNetFact -1<br/>

These defaults will render a net profit as a positive number.<br/>

*ExternalLedgerActualDatasetID*:

The default is that all processes import the actual dataset from the external ledger.

In special cases, however, different processes may use different sets of actual data.

For this to take place, the ExternalLedgerActualDatasetID property can be used to point to the specific actual dataset id to be used in the current version.

NOTE: in such scenarios, no set should be named Actual in the external source. Name them individually as ActualSRS, ActualKontant and so on. If you have one set named Actual and one named ActualSRS in the external source both will be mapped to Actual given the above mapping and that is not what you want.

- **Comment ID**<br/>

Short description of the individual setting.<br/>

## How to`s

<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 6.1 or later

> [Configure the Account module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V6.1/Planner%20Account%20module.pdf)<br/>
> [Configure the Personnel module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V6.1/Planner%20Personnel%20module.pdf)<br/>
> [Configure the Driver based module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V6.1/Planner%20Driver%20based%20module.pdf)<br/>
> [Configure the CapEx module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V6.1/Planner%20CapEx%20module.pdf)<br/>
> [Configure the Loan module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V6.1/Planner%20Loan%20module.pdf)<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5.4 or later

> [Configure the Account module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.4/Planner%20Account%20module.pdf)<br/>
> [Configure the Personnel module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.4/Planner%20Personnel%20module.pdf)<br/>
> [Configure the Driver based module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.4/Planner%20Driver%20based%20module.pdf)<br/>
> [Configure the CapEx module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.4/Planner%20CapEx%20module.pdf)<br/>
> [Configure the Loan module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.4/Planner%20Loan%20module.pdf)<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5.2.4 or later

> [Configure the Account module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.2.4/Planner%20Account%20module.pdf)<br/>
> [Configure the Personnel module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.2.4/Planner%20Personnel%20module.pdf)<br/>
> [Configure the Driver based module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.2.4/Planner%20Driver%20based%20module.pdf)<br/>
> [Configure the CapEx module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.2.4/Planner%20CapEx%20module.pdf)<br/>
> [Configure the Loan module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.2.4/Planner%20Loan%20module.pdf)<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5.2

> [Configure the Account module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.2/Planner%20Account%20module.pdf)<br/>
> [Configure the Personnel module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.2/Planner%20Personnel%20module.pdf)<br/>
> [Configure the Driver based module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.2/Planner%20Driver%20based%20module.pdf)<br/>
> [Configure the CapEx module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.2/Planner%20CapEx%20module.pdf)<br/>
> [Configure the Loan module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.2/Planner%20Loan%20module.pdf)<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5

> [Configure the Account module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/v5/Planner%20Account%20module.pdf)<br/>
> [Configure the Personnel module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/v5/Planner%20Personnel%20module.pdf)<br/>

Note that the Driver based, Cap Ex and Loan modules have their individual setup workbooks.

> [Configure the Driver based module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/v5/Planner%20Sales%20Forecast%20module.pdf)<br/>
> [Configure the CapEx module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/v5/Planner%20CapEx%20module.pdf)<br/>
> [Configure the Loan module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/v5/Planner%20Loan%20module.pdf)<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4.x

> [Configure the Account module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/Planner%20Account%20module.pdf)<br/>
> [Configure the Personnel module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/Planner%20Personnel%20module.pdf)<br/>
> [Configure the Sales by GM module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/Planner%20Sales%20By%20GM%20module.pdf)<br/>

Note that the Sales forecast, CapEx and Loan modules have separate setup workbooks.

> [Configure the Sales forecast module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/Planner%20Sales%20Forecast%20module.pdf)<br/>
> [Configure the CapEx module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/Planner%20CapEx%20module.pdf)<br/>
> [Configure the Loan module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/Planner%20Loan%20module.pdf)<br/>
