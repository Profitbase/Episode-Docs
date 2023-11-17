---
title: "Expense"
metaKeys: ""
folderOnly: "false"
pageIndex: 4
---

## Overview
This page contains settings related to operating expenses.
<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/finance-settings-expense.jpg)

1. **Selecting Setting Table**<br/>The left area list the different setting tables available for the page. Ticking here will turn on and off the table.
2. **Tables View**<br/>The right area will display the selected tables and allows users to edit content.
<br/>

## Descriptions

Each table and columns are described below.

Key columns used for matching when looking up correct setting is marked (k).

#### Expense: Accounts
This table identifies the accounts to be used when creating expense transactions.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **SupplierID (k)**<br/>
Identify the supplier as criteria when matching setting row.
- **AP**<br/>
Account for Account Payables for purchased goods.
- **Discount**<br/>
Account for discount.
- **Disc. periodic**<br/>
Account for periodic discounts.
- **EPTax**<br/>
Account for employment tax.
- **Comments**<br/>
Free text string to help document settings.
<br/>

#### Expense: Days Of Credit
This table defines the number of days until expenses will be paid.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **SupplierID (k)**<br/>
Identify the supplier as criteria when matching setting row.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **Value**<br/>
Number of days to payment.
- **Comments**<br/>
Free text string to help document settings.
<br/>

#### Expense: Accrued
This table is used to define expenses that are accrued for payment at regular terms.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **SupplierID (k)**<br/>
Identify the supplier as criteria when matching setting row.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **Term1Start**<br/>
Start date for first term.
- **TermLength**<br/>
Number of months unless Weeks is set to true below.
- **Weeks:**<br/>
Set to true if term length will be defined as number of weeks.
- **PrePaid**<br/>
Set to true if payment is in advance before the term.
- **PostingDays**<br/>
Number of days between booking and invoice received for payment.
- **Comments**<br/>
Free text string to help document settings.

<br/>

#### NonCash: Counter Account
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