---
title: "Sales"
metaKeys: ""
folderOnly: "false"
pageIndex: 3
---

## Overview
In publishing and graphic design, Lorem ipsum is a placeholder text commonly used to demonstrate the visual form of a document or a typeface without relying on meaningful content.
<br/>

![](img/finance-settings-sales.jpg)

1. **Selecting Setting Table**<br/>The left area list the different setting tables available for the page. Ticking here will turn on and off the table.
2. **Tables View**<br/>The right area will display the selected tables and allows users to edit content.
<br/>

## Descriptions

Each table and columns are described below.

Key columns used for matching when looking up correct setting is marked (k).

#### Sales: Accounts
This table defines the account to be used when posting transactions.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **Product (k)**<br/>
Identify product or group of products for which the setting is valid.
- **Market (k)**<br/>
Identify market for which the setting is valid.
- **AR**<br/>
Account to be used for Accounts Receivables.
- **COGS**<br/>
Account to be used for cost of goods sold (COGS).
- **Inventory**<br/>
Account to be used for inventory.
- **AP**<br/>
Account to be used for accounts payable.
- **Comments**<br/>
Free text string to help document settings.

When accounts are not specified, Planner will use the internal account key. These will be visible in the trial balance report. Accounts that appear with internal account key names can also be mapped using the System Fallback Account mapping.
<br/>

#### Sales: Days Of Credit
This table defines when you will get paid for your invoices.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **Product (k)**<br/>
Identify product or group of products for which the setting is valid.
- **Market (k)**<br/>
Identify market for which the setting is valid.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **Value**<br/>
Number of days of credit (i.e. days from invoice until you expect to get paid).
- **Comments**<br/>
Free text string to help document settings.

In the example table above you can see that cash sales are defined for certain accounts setting value = 0 credit days.

Note that credit days should be set to when you normally get paid which is not always in time.
<br/>

#### Sales: Accrued
Sales accrued table allows for defining revenue that is booked and accrued for invoice and payment later in regular terms.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **Product (k)**<br/>
Identify product or group of products for which the setting is valid.
- **Market (k)**<br/>
Identify market for which the setting is valid.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **Term1Start**<br/>
Start date for first term
- **TermLength**<br/>
Number of months unless Weeks is set to true below.
- **Weeks**<br/>
Set to true if term lengths are defined as number of weeks.
- **PrePaid**<br/>
Set to true if payment is in advance before the term start.
- **PostingDays**<br/>
Number of days from term end until invoiced.
- **Comments**<br/>
Free text string to help document settings.

<br/>

#### Sales: SourceSign Is Plus
This table defines if income transaction will appear as positive amounts or negative amounts.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Value**<br/>
Set to true if income transactions are positive. The setting is mandatory and the normal setting is false which will use negative numbers for income transactions.
- **Comments**<br/>
Free text string to help document settings.

<br/>

#### Sales: InterCompany Accounts
This table defines the accounts to be used when posting counterparty transactions.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **Cp LegalEntity (k)**<br/>
Counterparty Legal Entity applicable.
- **Product (k)**<br/>
Identify product or group of products for which the setting is valid.
- **Cp Account**<br/>
Account to be used for counterparty transaction (purchase/expense or balance account).
- **Cp Is Expense**<br/>
Cp Account is expense account (if True) or balance account (if False).
- **Cp AP**<br/>
Account to be used counterparty accounts payable.
- **Cp Discount**<br/>
Account to be used for counterparty discount on purchase.
- **Cp Disc. periodic**<br/>
Account to be used for counterparty periodic discount determined by terms.
- **Cp AgioDisagio**<br/>
Account to be used for counterparty agio and disagio.
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
