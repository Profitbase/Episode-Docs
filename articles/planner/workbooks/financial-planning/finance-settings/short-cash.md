---
title: "Short-Term Cash"
metaKeys: ""
folderOnly: "false"
pageIndex: 10
---

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5 or later.

## Overview

<br/>

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/finance-settings-short-cash-v5.JPG)

1. **Selecting Setting Table**<br/>The left area list the different setting tables available for the page. Ticking here will turn on and off the table.
2. **Tables View**<br/>The right area will display the selected tables and allows users to edit content.
<br/>

## Descriptions

The purpose of Short-Term Cash is to calculate the interest income and cost from the cash balance. This standard configuration setup supports one currency per legal entity.

The calculation model include separate interest rates for positive cash balance, interest rate for negative cash balance below the credit limit and interest rate applicable when exceeding the credit limit. In addition, the cost of credit limit can be calculated as a percent of the credit limit amount.

Payment of the interest due is controlled by setting number of due periods a year for  interest income and interest cost. If using 1 due term per year the due data will be 31.12.

Each table and columns are described below.

Key columns used for matching when looking up correct setting is marked (k).

Mandatory tables is marked (m).

#### Short Fin: Source Definition (m)
This table defines the source for legal entities, currencies and accounts to calculate interest.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.

- **BalanceCurrID (k)**<br/>
The currency used for the balance. This is normally the same as the legal entity functional currency but may be in foreign exchange rate.

- **Accounts (m)**<br/>
This is the list of source accounts that have the same currency and will be subject to interest calculation. In case of multiple accounts the list items is separated by comma (,); for example: 2380,2381.

- **Comments**<br/>
Free text string to help document settings.
<br/>

#### Short Fin: Due Term
This table defines the payment terms for the interest calculation.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.

- **BalanceCurrID (k)**<br/>
The currency used for the balance. This is normally the same as the legal entity functional currency but may be in foreign exchange rate.

- **From Date (k)**<br/>
The date from which this setting is valid from.

- **PeriodsAYear (+)**<br/>
This is number of periods per year that interest is paid in to the legal entity. If this is set to 1, it means that the accrued interest for this year is paid on the last day of the year.

- **PeriodsAYear (-)**<br/>
This is number of periods per year that interest is paid out from the legal entity. If this is set to 1, it means that the interest is accrued and will be paid on the last day of the year.

- **Comments**<br/>
Free text string to help document settings.
<br/>

#### Short Fin: Accounts (m)
This table defines the accounts to be used when posting the interest calculations.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.

- **BalanceCurrID (k)**<br/>
The currency used for the balance. This is normally the same as the legal entity functional currency but may be in foreign exchange rate.

- **From Date (k)**<br/>
The date from which this setting is valid from.

- **Balance** (m)<br/>
This is the balance account for cash. A the balance account must be specified to be able to calculate interest. This is main account used to sum the opening balances accounts specified under "Short Fin: Source Definition" accounts list above.

- **Acc '(+) to Cash'** <br/>
This is the account for transferring a positive balance to another cash account (balance type account).

- **Int income** <br/>
This is the account for interest income (profit-loss type account).

- **Int accrued** <br/>
This is the account for accrued interest (balance type account).

- **Int expense** <br/>
This is the account for interest expenses (profit-loss type account).

- **LimitFee** <br/>
This is the account for credit limit fees (profit-loss type account).

- **Comments**<br/>
Free text string to help document settings.
<br/>

In case columns is not filled in, the calculation will be posed using the internal codes as account. Unless these are properly mapped, they will not occur correctly in finance reports aggregated over set of accounts.


#### ShortFin(+): Interest % (m)
This table defines the interest rate for positive cash balance. If this is omitted for a legal entity or a currency, no transactions is generated for this case.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.

- **BalanceCurrID (k)**<br/>
The currency used for the balance. This is normally the same as the legal entity functional currency but may be in foreign exchange rate.

- **From Date (k)**<br/>
The date from which this setting is valid from.

- **Value (m)**<br/>
The interest percent.

- **High**<br/>
The interest high percent used for scenario simulation (optional).

- **Low**<br/>
The interest low percent used for scenario simulation (optional).

- **Comments**<br/>
Free text string to help document settings.
<br/>

#### ShortFin(-): Limit
This table defines the cash credit limit.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.

- **BalanceCurrID (k)**<br/>
The currency used for the balance. This is normally the same as the legal entity functional currency but may be in foreign exchange rate.

- **From Date (k)**<br/>
The date from which this setting is valid from.

- **Value (m)**<br/>
The credit limit amount.

- **High**<br/>
The credit limit high amount used for scenario simulation (optional).

- **Low**<br/>
The credit limit low amount used for scenario simulation (optional).

- **Comments**<br/>
Free text string to help document settings.
<br/>

#### ShortFin(-): Limit Fee %
This table defines the fee cost for the credit limit. The fee is calculated as a percent of the credit limit amount.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.

- **BalanceCurrID (k)**<br/>
The currency used for the balance. This is normally the same as the legal entity functional currency but may be in foreign exchange rate.

- **From Date (k)**<br/>
The date from which this setting is valid from.

- **Value (m)**<br/>
The fee percent.

- **High**<br/>
The fee high percent used for scenario simulation (optional).

- **Low**<br/>
The fee low percent used for scenario simulation (optional).

- **Comments**<br/>
Free text string to help document settings.
<br/>


#### ShortFin(-): Interest % (m)
This table defines the interest rate for negative cash balance; i.e. using the cash credit.

If this is omitted for a legal entity or a currency, no transactions is generated for this case.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.

- **BalanceCurrID (k)**<br/>
The currency used for the balance. This is normally the same as the legal entity functional currency but may be in foreign exchange rate.

- **From Date (k)**<br/>
The date from which this setting is valid from.

- **Value (m)**<br/>
The interest percent.

- **High**<br/>
The interest high percent used for scenario simulation (optional).

- **Low**<br/>
The interest low percent used for scenario simulation (optional).

- **Comments**<br/>
Free text string to help document settings.
<br/>

#### ShortFin(-): Overdraft Interest %
This table defines the interest rate for using negative cash balance above the credit limit.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.

- **BalanceCurrID (k)**<br/>
The currency used for the balance. This is normally the same as the legal entity functional currency but may be in foreign exchange rate.

- **From Date (k)**<br/>
The date from which this setting is valid from.

- **Value (m)**<br/>
The interest percent.

- **High**<br/>
The interest high percent used for scenario simulation (optional).

- **Low**<br/>
The interest low percent used for scenario simulation (optional).

- **Comments**<br/>
Free text string to help document settings.
<br/>

#### ShortFin: (+) = Cash
This table defines if interest income will be posted to another cash account.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.

- **BalanceCurrID (k)**<br/>
The currency used for the balance. This is normally the same as the legal entity functional currency but may be in foreign exchange rate.

- **From Date (k)**<br/>
The date from which this setting is valid from.

- **Value (m)**<br/>
The value is set to true for a positive cash balance to be transferred to the account defined in "Acc '(+) to Cash'" under accounts settings above.

- **Comments**<br/>
Free text string to help document settings.
<br/>
