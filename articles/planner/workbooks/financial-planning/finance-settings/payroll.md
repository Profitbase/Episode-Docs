---
title: "Payroll"
metaKeys: ""
folderOnly: "false"
pageIndex: 2
---

## Overview
This page contains setting to control payroll related transactions such as social tax.
<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/finance-settings-payroll.jpg)

1. **Selecting Setting Table**<br/>The left area list the different setting tables available for the page. Ticking here will turn on and off the table.
2. **Tables View**<br/>The right area will display the selected tables and allows users to edit content.
<br/>

## Descriptions

Each table and columns are described below.

Key columns used for matching when looking up correct setting is marked (k).

#### Personnel: Accounts
This table defines which accounts to be used for posting employer tax, pension (employer and employees) Vacation pay and employment tax on vacation pay.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **Employee (k)**<br/>
Employee or employee type from the Employee dimension.
- **EPTax**<br/>
Account for calculated employer tax.
- **Pension**<br/>
Account for calculated pension which can contain both employer and employee's part.
- **VacationPay**<br/>
Account for calculated vacation pay.
- **EPTOnVPay**<br/>
Account for calculated employer tax on vacation pay.
- **Comments**<br/>
Free text string to help document settings.
<br/>

#### Salary: Accrued
This table define how salary is accrued and paid.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **Term1Start**<br/>
Start date for first term.
- **TermLength**<br/>
Number of months unless Weeks is set to true below.
- **Weeks:**<br/>
Set to true if term length will be defined as number of weeks.
- **PrePaid**<br/>
Set to true if payment is in advance.
- **PostingDays**<br/>
Number of days between term end and payment when not pre-paid (PrePayed = false). If pre-paid (PrePaid = true), the number of posting days is relative to the start of term. Number of days can be positive to count days forward or negative to count days backward.
- **Comments**<br/>
Free text string to help document settings.

Examples:

- Monthly salary to be paid on 10th in same month it is earned: Term1Start = 2020-01-01, TermLength = 1, PrePaid = true, PostingDays = 9 (9 days from the term start which is here the 1st)
- Monthly salary to be paid on 10th in following month it is earned: Term1Start = 2020-01-01, TermLength = 1, PrePaid = false, PostingDays = 10 (10 days from the term end which is here the last day of month)


<br/>

#### Pension Employer %
This table defines the rates applicable for employer pension.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable for setting.
- **Departm.**<br/>
Department applicable for setting.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **Value**<br/>
Percent employer pension.
- **Comments**<br/>
Free text string to help document settings.
<br/>

#### Pension Employees %
This table define the rates applicable for employee's pension.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable for setting.
- **Departm.**<br/>
Department applicable for setting.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **Value**<br/>
Percent employee's pension.
- **Comments**<br/>
Free text string to help document settings.
<br/>

#### Employer Payroll Tax %
This table defines the applicable rates for employer payroll tax.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable for setting.
- **Departm.**<br/>
Department applicable for setting.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **Value**<br/>
Percent employer tax.
- **Comments**<br/>
Free text string to help document settings.
<br/>

#### VacationPay %
This table defines the rates for vacation pay.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable for setting.
- **Departm.**<br/>
Department applicable for setting.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **Value**<br/>
Percent vacation pay.
- **Comments**<br/>
Free text string to help document settings.
<br/>

#### WithholdTax %
This table defines the rates for tax on salary.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable for setting.
- **Departm.**<br/>
Department applicable for setting.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **Value**<br/>
Percent withhold tax.
- **Comments**<br/>
Free text string to help document settings.
<br/>

#### PensionDueTerm
This table defines the payment terms for pension.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable for setting.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **Term1Start**<br/>
Start date for first term.
- **TermLength**<br/>
Number of months.
- **Term1Due**<br/>
Due date for first term.
- **Comments**<br/>
Free text string to help document settings.
<br/>

#### Empl. Payroll Tax: Due Term
This table defines the payment terms for employer payroll tax.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable for setting.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **Term1Start**<br/>
Start date for first term.
- **TermLength**<br/>
Number of months.
- **Term1Due**<br/>
Due date for first term.
- **Comments**<br/>
Free text string to help document settings.
<br/>

#### VacationPay Due Term
This table defines the payment terms for vacation pay.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable for setting.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **Term1Start**<br/>
Start date for first term.
- **TermLength**<br/>
Number of months.
- **Term1Due**<br/>
Due date for first term.
- **Comments**<br/>
Free text string to help document settings.
<br/>

#### WithholdTax Due Term
This table defines the payment terms for withhold tax.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable for setting.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **Term1Start**<br/>
Start date for first term.
- **TermLength**<br/>
Number of months.
- **Term1Due**<br/>
Due date for first term.
- **With.Tax Deposit**<br/>
Posted on separate tax deduction account.
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
