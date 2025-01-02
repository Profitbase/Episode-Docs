# Currency exchange rates and calendar

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5 or later

## Overview
This is the workbook for maintaining currency exchange rates and the global calendar.

### How is exchange rates used
Currency exchange rates is used for all currency conversion in Profitbase platform (including Budget and Forecast and Consolidation). In Budget and forecast, daily rates are used for simulation to generate the general ledger transactions. For other currency conversions. for example , monthly average and closing rates are used. Monthly average rates are used to convert profit/loss transactions while monthly closing rates are used to convert balance transactions. The differences due to monthly average and closing rates, are calculated and can be mapped to an account (default AccountID and AccountKeyID = 'FXadjust').  
(See "Report Setup"->"Setup"->"Equity Account for Currency Translation Differences").

By default, historical rates are used before "switching" to future forecast rates. A scheduled operation is required for this (a).  
(To set up: "Operation Manager"->"Operations", click "Get System Operation" and select "Import and Reprocess Exchange Rates", create scheduled operation using this operation).

### How are exchange rates generated
Note that a time range that is aligned with the Time dimension must be defined for the exchange rates calculation. (See "Currency Exchange Rates"->"Setup" and select the "Calenda from-to")

Currencies involved is based on the currencies defined in the "Exchange Rate" table. (See "Currency Exchange Rates"->"Exchange Rates Daily" and select "Exchange Rate" table.)

Generating exchange rates:
1. Historical daily rates are imported via an online service and originates from European Central Bank. Ref. (a) above.
2. Forecast (and budget) rates is defined by user input
3. Optional users can override historical daily or monthly rates
4. "Publish" will generate daily rates for all days including holidays by using the last known rate to fill the days between specified rated dates. Currency from/to combination is calculated for all imported currencies. 'NOK' is used as the base currency (currency rates to 'NOK' imported). Historical overrides are generated into the daily exchange rate table.
5. "Publish" will then generate monthly arithmetic average over daily rates  - monthly average and closing rates. Currency from/to combination is calculated for all imported currencies. 'NOK' is used as the base currency. Monthly historical overrides are generated into the monthly exchange rate table. Note that rate combinations and average is generated from daily currencies with rated dates (and not based on t

Note that the daily rate and monthly rates can always be inspected, adjusted and published from the "Currency Exchange Rates" workbook.

### How to import your own exchange rates
It is possible to set up and import your own currency exchange rates. It is recommended to import monthly rates and thereby take full control on all exchange rates used for Plan overview and Finance Reports currency conversion.

To enable this you need to:
1. Establish and online source for your exchange rates available for import from e.g. Azure Blobstore
2. Enable import to target table SYN_Datamart_CurrencyExchangeRatesMonthly. (See "System Configuration"->"Synonym Configuration" and enable "SYN_Datamart_CurrencyExchangeRatesMonthly" for import.
3. Set up import ruleset
4. Schedule import

Note that for Budget and Forecast simulation you need to use the "Exchange Rate" table. As described above you can also import to this table (using SYN_Datamart_CurrencyExchangeRate).

<br/>

## Related Pages

-  [Exchange rates daily](dimensions-and-currency-exchange-rates/exchange-rate-daily.md)
-  [Exchange rate monthly](dimensions-and-currency-exchange-rates/exchange-rate-monthly.md)
-  [Setup](currency-exchange-rates-and-calendar/setup.md)
-  [Workday calendar](currency-exchange-rates-and-calendar/workday-calendar.md)

<br/>

## How to`s

<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5.2 or later

-  [Planner Data Requirements](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.2/Planner%20Data%20Requirements.pdf)<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5.0 or 5.1

-  [Planner Data Requirements](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/v5/Planner%20Data%20Requirements.pdf)<br/>
-  [Planner Data Requirements - import template](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/v5/Planner%20Data%20Requirements%20Template.xlsx)<br/>
<br/>


