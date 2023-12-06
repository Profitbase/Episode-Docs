# Purchase
## Overview
This page contains settings related to purchase of goods for sales or production.
<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/finance-settings-purchase.jpg)

1. **Selecting Setting Table**<br/>The left area list the different setting tables available for the page. Ticking here will turn on and off the table.
2. **Tables View**<br/>The right area will display the selected tables and allows users to edit content.
<br/>

## Descriptions

Each table and columns are described below.

Key columns used for matching when looking up correct setting is marked (k).

### Purchase: Accounts
This table identifies which accounts to be used for purchased goods.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **SupplierID (k)**<br/>
Identify the supplier as criteria when matching setting row.
- **Product (k)**<br/>
Identify product or group of products for which the setting is valid.
- **AP**<br/>
Account for Account Payables for purchased goods.
- **Duty**<br/>
Account for duty.
- **Comments**<br/>
Free text string to help document settings.

When accounts are not specified, Planner will use the internal account key. These will be visible in the trial balance report. Accounts that appear with internal account key names can also be mapped using the System Fallback Account mapping.
<br/>

### Purchase: Days Of Credit
This table define number of days until purchased goods will be paid.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **SupplierID (k)**<br/>
Identify the supplier as criteria when matching setting row.
- **Product (k)**<br/>
Identify product or group of products for which the setting is valid.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **Value**<br/>
Number of days to payment.
- **Comments**<br/>
Free text string to help document settings.
<br/>

### Purchase: Accrued
Use this table to set up accrued purchase. This is purchased goods that are booked but accrued for payment at later regular terms.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **SupplierID (k)**<br/>
Identify the supplier as criteria when matching setting row.
- **Product (k)**<br/>
Identify product or group of products for which the setting is valid.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **Term1Start**<br/>
Start date of first term.
- **TermLength**<br/>
Number of months unless Weeks is set to true.
- **Weeks**<br/>
Set to true if term length is defined as number of weeks.
- **PrePaid**<br/>
Set to true if payment is in advance.
- **PostingDays**<br/>
Number of days between end of term and invoice booked.
- **Comments**<br/>
Free text string to help document settings.

<br/>

### NonCash: Counter Account
Transactions matching these settings (Legal Entity and Account) will be posted as "non-cash". A non-cash transaction means that the input transactions matching LegalEntity and Account will generate a transaction on selected counteraccount only - not involving any payments.  

Note that any other functions that would involve this account will be deactivated for this Legal Entity and Account combination.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable for setting.
- **Account (k)**<br/>
Named account from Account dimension.
- **NCT CAcc**<br/>
Counteraccount selected from account dimension.
- **Comments**<br/>
Free text string to help document settings.
<br/>