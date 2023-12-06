# OBDue

## Overview
This page contains settings related to how to use the opening balance with respect to opening values and accounts payable and receivable.
<br/>

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/finance-settings-obdue.JPG)

1. **Selecting Setting Table**<br/>The left area lists the different setting tables available for the page. Ticking here will turn on and off the table.
2. **Tables View**<br/>The right area will display the selected tables and allows users to edit content.
<br/>

## Descriptions

Each table and columns are described below.

Key columns used for matching when looking up correct setting is marked (k).

### OBDue: Other Payable
This table defines how payables in opening balance will be paid.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **Text (k)**<br/>
Name to identify an asset og group of assets.
- **SimItem**<br/>
Dropdown list to identify different type of payments:
   - OBDueAccountsPayable - payments due based in received invoices from suppliers
   - OBDueCompanyTax - company tax is normally paid based on a profit for the previous year
   - OBDueDividend - dividend to be paid to shareholders
   - OBDueGroupContribution - contribution to be paid to group
   - OBDueOtherPayable - other payables that does not fit other items on this list
   - OBDueVacationPay - vacation pay to be paid is normally earned the previous year
- **IsOBYear**<br/>
Set to true if opening balance for the full year is to be used (e.g. to calculate vacation pay).
- **Amt Due**<br/>
Amount due off the payable balance.
- **Due %**<br/>
Percent of payable balance.
- **PlusDays**<br/>
Additional days until due from Due Date.
- **SpreadDays**<br/>
Number of days to spread the payment across starting from due date (optional plus additional days).
- **Due Date**<br/>
Due date for payment. If this date is left empty or date is before OB-date (plan start date), then OB-date is used.
- **Yearly**<br/>
Set to true if this should be yearly. This means that the "Due Date" will be applied the same month and day for the following years - without the need to change "Due Date" every year.
- **Employer tax %**<br/>
Employer tax percent (e.g. employer tax on vacation pay).
- **EPTFromAccount**<br/>
Account for accrued employer tax.
- **Comments**<br/>
Free text string to help document settings.

A simple way to use a setting that will last across period rollovers for forecast, is to leave the DueDate empty, specify Due % and PlusDays. This way the percent of the balance will be paid the number of days after the OB-date or plan start date (OB-date should be on plan start date).
<br/>

### OBDue: Other Receivable
This table defines how receivable in the opening balance should be paid.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **Text (k)**<br/>
Name to identify an asset og group of assets.
- **SimItem**<br/>
Dropdown list to identify different type of receivables:
   - OBDueAccountReceivables - payments to be received from sales invoices
   - OBDueGovernmentGrant - payments to be received from local or central government sources
   - OBDueOtherReceivable - any other payments to be received that does not fit other items on this list
- **Amt Due**<br/>
Amount due to be received.
- **Due %**<br/>
Percent of opening balance due to be received
- **PlusDays**<br/>
Additional days to payment from Due Date.
- **SpreadDays**<br/>
Number of days payment should spread on starting from Due Date plus optional PlusDays.
- **Due Date**<br/>
Due date for payment. If this date is left empty or date is before OB-date (plan start date), then OB-date is used.
- **Yearly**<br/>
Set to true if this should be yearly. This means that the "Due Date" will be applied the same month and day for the following years - without the need to change "Due Date" every year.
- **Comments**<br/>
Free text string to help document settings.

A simple way to use a setting that will last across period rollovers for forecast, is to leave the DueDate empty, specify Due % and PlusDays. This way the percent of the balance will be paid the number of days after the OB-date or plan start date.
<br/>

### OBDue: Terms
This table defines alternative accounts for different type of term payments such as VAT and employer tax, tax payment, duty etc.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **SimItem**<br/>
Dropdown list to identify different of terms (e.g. VAT, Employer Tax, etc.)
- **AccountDepositOvr**<br/>
Alternative account for short-term credit (e.g. tax payment)
- **Comments**<br/>
Free text string to help document settings.
<br/>

### OBDue: Agio- / Disagio Accounts

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **AgioDis**<br/>
Account for agio-disagio.
- **Cp AgioDisagio**<br/>
Counter account for agio-disagio.
- **Comments**<br/>
Free text string to help document settings.

## Examples

The following will describe a few typical examples for how to set up due payments based on opening balance:
- Vacation Pay
- Accounts Receivables
- Accounts Payable

Any of the others will be similar to these 3 examples.<br/><br/>

### Vacation Pay Explained

Vacation pay is normally (in Norway) earned the calendar year before it is paid. Vacation pay is due for example June every year for the vacation pay accrued the year before.

Note that Planner require monthly actual general ledger data to be able to create a monthly opening balances which is the basis for booking correct numbers between actual and plan data.

Let us look at some cases during a year of rolling monthly forecast with vacation pay due on June 15. yearly.

- Assume plan start date on fiscal year start on January 1st: <br/><br/>
Vacation pay due this year is what was earned the year before and hence is the value on opening balance for the vacation pay accrued account (for example 2940). Planner will book the payment on June 15. this year.<br/><br/>
On January 1st there are no vacation pay accrued due the following year in actual data. Planner forecast will book for the month January through December. Planner will book the payment on June 15. next year.

- Assume we roll forward a few months and reach plan start date of May 1:<br/><br/>
Vacation pay due this year is still the same: Amount on opening balance for vacation pay accrued account (for examples 2940). Planner will book the payment on June 15. this year.<br/><br/>
Vacation pay due next year has been earned and book as actual data for January through April. This amount is on the opening balance for the rolling forecast dated May 1. In addition, Planner forecast will book for May through December. Planner will book this for payment on June 15 next year.

- Assume we roll forward to plan start October 1:<br/><br/>
Vacation pay due this year has been paid and booked as actual data on June 15. <br/><br/>
Vacation pay due next year has been earned and booked as actual data for January through September. This amount is on the opening balance for the rolling forecast dated October 1. In addition, Planner forecast will book for October through December. Planner will book this for payment on June 15 next year.

From the above we can conclude:

1. Vacation pay due this year is the amount from the opening balance for this year.

2. Vacation pay due next year is the opening balance for the plan start date plus the contribution from plan periods for the year.

3. Vacation pay due the year after next is the contribution from the plan periods next year. Likewise for following years.

The picture below shows how to do the settings for this:<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5 or later:
The settings below using a combination for current and next year only works from Planner 5. For Planner 4 use a single line for vacation pay or multiple lines with amount on specific due date as in example 3 below.

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/vacation-pay-obdue-settings.jpg)

The first row in picture above set Text = 'ThisYear' is the setting for vacation pay due this year based on opening balance for the year. Therefore IsOBYear = true and Due Date is set to June 15. The year is not that important since Yearly = true. Note that no vacation pay will be posted before this date so the first due date with this setting will be June 15 2021. Yearly = true means that the same setting will work one year from now with a new year opening balance.

The second row will book the opening balance for the plan start date (remember rolling forecast) to be paid 365 = 1 year after current Due Date which will be June 15 2022.

The above is the vacation pay contribution from opening balance (= sum of actual data account and periods), but we lack contribution from plan periods.

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/vacation-pay-payroll-settings.jpg)

The picture above shows the "Vacation Pay %" settings that determine which accounts and which percent to calculate the vacation pay for plan periods. The "VacationPay Due Term" define the start date for when to start accruing vacation pay for a year (Term1Start) and the number of month for the term (TermLength) and the corresponding due date for the defined term (Term1Due).
<br/>

**Vacation Pay Example 1** <br/>

This example has plan start date set to 2021-01-01 and vacation due to June 15 yearly. Finance Settings is as above, and [Opening Balance](../../financial-planning/opening-balance/edit.md) is set as shown in picture below.

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/vacation-pay-ex1-Opening-balance-2021-01-01.jpg)

Note that with opening balance for the first period in the year, the opening balance for the last known complete year is "2021 OB" which is the same as the plan stat date opening balance "2021-01-01 OB". In this case the OB is adjusted to give an amount that is easy to recognize.

The picture below shows the booking performed by Planner.

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/vacation-pay-ex1-trans-2021-01-01.jpg)

The top marked line is from opening balance and the last line is from plan accrued vacation pay during 2021.

**Vacation Pay Example 2**

This example has plan start date set to 2021-07-01 and vacation due to June 15 yearly. Finance Settings is as above, and [Opening Balance](../../financial-planning/opening-balance/edit.md) is set as shown in picture below.

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/vacation-pay-ex2-opening-balance-2021-07-01.jpg)

The picture below shows the transactions.

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/vacation-pay-ex2-trans-2021-07-01.jpg)

Note that there is no vacation pay due in 2021 because the plan start date (2021-07-01) is past this year due for vacation pay (2021-06-15). The marked rows for vacation pay due June 15 2022 origin from opening balance (actual vacation pay accrued) and plan vacation accrued during year 2021.

**Vacation Pay Example 3**

The above is the most correct way and avoid having to look after settings regularly. The above example is assuming actual data is available and updated at least monthly and that the opening balance is representative. If for some reason this is not in order and you do not get this correct, there is a shortcut by just putting the amount to be booked in the settings table.

In this example we use vacation pay du on August 15 and plan start date on July 1. 2021. OBDue allows for posting amounts directly as shown in picture below.

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/finance-settings-OBDue-vacation-pay-amount-example2-settings.jpg)

The picture above show "Amt Due" = 1 600 000 due on August 15 2021 and for the following year 800 000 on August 15 2022. Note that "Text" is part of the key for the setting row and must be set to make the 2 rows unique. The amount for the second row must be adjusted to represent the vacation pay accrued this far into the year. Planner will accrue from plan start date and book the payment due in the following year. This is shown in the picture below.

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/finance-settings-OBDue-vacation-pay-amount-example2-results.jpg)

Note in the picture above, that there are 4 payment due lines showing:

   * Transdate 15.08.2021: 1 600 000 - this is the vacation pay due this year accrued last year from OBDue settings "Amt Due".
   * Transdate 15.08.2022: 800 000 - this is the OBDue settings "Amt Due" value.
   * Transdate 15.08.2022: 792 000 - this is the amount accrued in plan for the period July through December in 2021.
   * Transdate 15.08.2023: 891 531 - this is the amount accrued in plan from 2022.

This is useful if you lack actual data and opening balances. But you must update the OBDue settings for every rollover period to keep that total vacation pay due amount correct.

**Payables and Receivables Example**

There will be several payments on opening balance that will be due the next following periods. These are outstanding payments from customers, invoices from suppliers to be paid and a few others. The SimItem dropdown allow for differentiating them.

The principle for payable and receivables are the same. Below is an example setup for accounts receivable and accounts payable:

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/Payments-OBDue-settings-ar-ap.jpg)

Payments on opening balance can be set up to be split and spread over the next few periods. Looking at SimItem = OBDueAccountsReceivable in bottom table above:

* AR1: 60% of balance on account 1510 will be paid 15 days after plan start date (15 days after January 1 2021 in this example)
* AR2: 30% of balance will be paid 45 days after plan start date
* AR3: 10% of balance will be paid 75 days after plan start date

The line where Text = *, tell that amount of 1000 will be received on October 20 2021. This is just to show that amounts can be booked directly on due dates.

The picture below shows the results from these. The opening balance in account 1510 is 6 848 478.13 in this example.

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/Payments-OBDue-trans-ar.jpg)

The first 3 lines should sum to a total of -6 848 478.13 (same as account receivables opening balance - with negative sign) and the last line is the amount payment of 1000 on October 20 2021.

**Term Payments**

There are a few payables that have to follow terms. These terms are assumed already set up under [Finance Settings - Payroll](../../financial-planning/finance-settings/payroll.md).

Use the setting "OBDue: Term" to identify accounts for:

* Employer tax (OBDueEmployerTax)
* Special Tax (OBDueSpecialTax)
* Value Added Tax - VAT (OBDueValueAddedTax)
* Withhold Tax (OBDueWithhold TaxPayable)
* Duty and VAT (OBDueDutyAndVAT - this term is not enabled in the standard configuration setup)

The Sim Item column value will together with the Legal Entity identify the term definition to be used from [Finance Settings - Payroll](../../financial-planning/finance-settings/payroll.md). The account identified here is the accrued account for the term payment. Some of these terms extends 2 months and hence will use the opening balance from previous months to determine the correct payment to be made.
