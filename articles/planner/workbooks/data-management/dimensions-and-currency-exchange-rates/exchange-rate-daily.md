# Exchange rate daily
## Overview
This page is to manage exchange rates.
<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/dimensions-exchange-rate-daily.jpg)


1. **Changes and Overrides to Daily Exchange Rates**<br/>
Here you select which tables you want to work with:
- Exchange Rate - to set currency and rates. This is intended for manually controlling future exchange rates.
- Exchange Rate Historical Daily Override: To override historical rates that may be wrong or not to company rates for individual dates. Historical rates are by default imported and are the rates published by the European Central Bank and distributed by XIGNITE.
2. **Publish**<br/>
The publish button is used to process any changes and overrides to exchange rates. Daily and month rates will be processed here. When processing rates, historical rates is used as long as they are known and after that, rates from the Exchange Rate table is used.
<br/>
3. **Exchange Rates Daily**<br/>
The table to the right shows the daily exchange rates generated from historical and future rates. Using the filter capabilities, you can inspect exchange rates between different  combination of currencies.

## Descriptions

By default the system will import historical exchange rates and rely on the Exchange Rate table for future rates. Note that future rates will be generated after the last historical date.

Simulation is using rates from the Exchange Rate table and can be down to the daily rates. The normal recommended practice and default in system, is to use monthly average (or closing) rates (i.e. the last known rate).

It is also possible to import exchange rates. This is described in [Planner Data Requirements](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/Planner%20Data%20Requirements.pdf) document.

Exchange rates are published on all business days depending on the publisher working calendar. Therefore you will not get exchange rates published on public holidays. Profitbase Planner will generate rates for all days. In cases where there are not published rates (such as week-end and public holidays), that last known rate will be used.

Each table and columns is describe below.

Columns marked with (k) is key columns that will be used to match transactions when exchange rates are deployed in calculations.

### Exchange Rate
This table controls the exchange rates and is in itself sufficient to run Profitbase Planner with exchange rates.

Please ensure that you define exchange rates early enough to cover dates from the beginning of fiscal year. This is because simulation may use (depending on your settings) due payments using opening balance. Failing to do so will cause the simulation to not be able to complete correctly. Every exchange rate will last from the date given and until a new Value is provided on a new From Date.

This table also is the source for Currency dimension.

Columns:

- **Currency (k)**<br/>
3-character code to identify the currency.
- **Dataset (k)**<br/>
Dataset dropdown. It is advised to use the same currency for all datasets (i.e. use '*').
- **From Date (k)**<br/>
Set the date from when the exchange rate will be valid.
- **Value**<br/>
This is the rate that you use to convert an amount in currency as defined in Currency column to a base currency (i.e. NOK).
- **High**<br/>
Exchange rate that can be used for simulation purposes and represent the higher rate compared to value.
- **Low**<br/>
Exchange rate that can be used for scenario simulation purposes and is the low rate compared to Value.
- **Comments**<br/>
Free text sting to help document settings.
<br/>

### Exchange Rate Historical Daily Override
This table  is used to override historical exchange rates and allows for specifying from and to currency to make it convenient to input familiar rates.

Note that each row here will only override historical rates (not future rates) and only for the "From Date" date.

Columns:

- **From Currency (k)**<br/>
3-character code to identify the currency.
- **To Currency (k)**<br/>
3-character code to identify the currency.
- **From Date (k)**<br/>
Set the date from when the exchange rate will be valid.
- **Value**<br/>
This is the rate that you use to convert an amount in currency as defined in From Currency column to currency as defined in To Currency column. E.g. "From Currency"=EUR and "To Currency" = NOK and Value = 9.
- **Comments**<br/>
Free text sting to help document settings.
<br/>

### Exchange Rates Daily
This table is a report (read-only) showing the generated daily rates. Selecting From Currency, To Currency and Year you can inspect any rate.

The Comments column is here used to tell that this is historical rate or forecast (i.e. future) rate.

The columns here are as describe above. Note that the High and Low is populated using the Value rate as default.


