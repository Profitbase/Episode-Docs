# Exchange rate monthly
## Overview
Here you can override and inspect the monthly exchange rates including regenerating the monthly rates.
<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/dimensions-exchange-rate-monthly.jpg)


1. **Changes Rate Historical Monthly Override**<br/>
This table allows you to override monthly exchange rates.
2. **Publish**<br/>
The publish button is used to generate monthly rates based on daily exchange rates.
3. **Exchange Rates Monthly**<br/>
The table to the right shows the daily exchange rates generated. Using the filter capabilities, you can inspect exchange rates between different combination of currencies.

## Descriptions

Monthly average exchange rates are used for most currency conversions. An exception is the simulation to generate the general ledger which will use any level of detail down to daily exchange rate. To get the same currency

Each table and columns is described below.

Columns marked with (k) is key columns that will be used to match transactions when exchange rates are deployed in calculations.

### Exchange Rate Historical Monthly Override
This table allows you to override monthly exchange rates.

Columns:

- **From Currency (k)**<br/>
3-character code to identify the currency.
- **To Currency (k)**<br/>
3-character code to identify the currency.
- **PeriodNo (k)**<br/>
This is number defining the calendar period on format YYYYMM.
- **From Date (k)**<br/>
Set the date from when the override will be applicable.
- **RateOpen**<br/>
The rate at the first-rate day in month.
- **RateHigh**<br/>
The highest rate during the month.
- **RateLow**<br/>
The lowest rate during the month.
- **Rate Lst Day**<br/>
The rate the last rate date in the month.
- **Rate Average**<br/>
The arithmetic means between all rate dates.
- **Comments**<br/>
Free text sting to help document settings.

Note that all rates must be input as the rate that you use to convert an amount in currency as defined in From Currency column to currency as defined into Currency column. E.g. "From Currency"=EUR and "To Currency" = NOK and Value = 9.

Exchange rates are published on all business days depending on the publisher working calendar. Therefore you will not get exchange rates published on public holidays. That is why the term "rate days" is used above.
<br/>

### Exchange Rates Monthly
This table is a report (read-only) showing the generated monthly rates. Selecting From Currency, To Currency and Year you can inspect any rate.

The Comments column is here used to tell that this is historical rate or forecast (i.e. future) rate.

Columns:

Columns:

- **Dataset** (k)**<br/>
Identify the dataset that the exchange rate applies to
- **From Currency (k)**<br/>
3-character code to identify the currency.
- **To Currency (k)**<br/>
3-character code to identify the currency.
- **Period No. (k)**<br/>
This is number defining the calendar period on format YYYYMM.
- **Rate Average**<br/>
The arithmetic means between all rate dates.
- **Rate Last Day**<br/>
The rate the last rate date in the month.
- **Comments**<br/>
Free text sting to help document settings.
