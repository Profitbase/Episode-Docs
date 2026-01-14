# Loan module

Profitbase

25.05.2025

Version 3.5

---

## Abstract, intended audience and pre-requisites

The Profitbase Planner Configuration and Operation series consist of several documents dealing with the configuration and operation of individual Planner modules and functions.

The intended audience of this document is implementation partners configuring the solution initially and solution administrators responsible for operating it thereafter.

This document assumes that a Profitbase Planner solution has been deployed and that access to this solution is given to the reader.

The Loan module is included as a standard Profitbase Planner.

---

## Common functionality

Changes made to input sheets are not saved automatically. To save changes, click the “Save” button. The “Save” button will remain disabled until a change has been made.

To undo all unsaved changes, click the “Refresh” button.

To undo the last of a series of unsaved changes, click the Ctrl and Z keys simultaneously.

To insert new rows to an input sheet, right-click in the sheet and select one of the available options:

- Insert row  
- Insert row below  
- Insert copy of row  

To delete a row from an input sheet, right-click the row in question and select:

- Delete row  

Inserting and deleting rows can be controlled as part of the configuration, see Publish and name module, control row context right-click menu options.

Please note, that although the row is no longer visible in the input sheet, the change must be committed using the “Save” button or undone using the “Refresh” button.

In input sheets, editable fields are distinguished from non-editable fields by fill color, editable fields have by default a white fill color.

In setting tables, a so-called ranked input concept is often used for the dimensional context. Ranked input allows for a high-level selection of dimensional nodes and gives the opportunity to alter the rank or specificity between rows.

A ranked input cell can be set through the ranked input selector by clicking the cell value (cell will display 3 dots if no value is set):

[IMAGE PLACEHOLDER: ranked input selector cell]

The ranked input selector will display the dimensional hierarchy and allows for the selection of a high-level dimensional node. The selection of a high-level node implies that the setting applies to all sub-ordinate nodes.

Select node and click “OK”.

Click “Cancel” to leave the selector without selecting.

In a table containing multiple rows, the rank or specificity of individual rows can be altered by moving the row up (decrease specificity) or down (increase specificity) by right-click the row in question and selecting:

- Move up  
- Move down  

The less specific the setting is, row should be high up in the table. The more specific the setting is, the further down in the table the row should reside.

---

## Principle of operation

### Loan types handled including examples

Handles loans; both taken and issued. Calculates interest (accrued and due), installments and fees on term (serial) and annuity loans, including balloon loans.

---

### Term loans

For term loans, the default is to define the number of installment periods and let the system calculate the serial principal.

[IMAGE PLACEHOLDER: term loan serial principal]

A so-called “balloon loan” is defined by setting both the number of installment periods and the principal amount. When the number of installment periods is reached, the total residual value will be due.

[IMAGE PLACEHOLDER: balloon loan example]

If you need a grace period or adjust the principal amount you can override the automatically generated serial principals, by right clicking the “Ovr” column depending on the input sheet setup. In the following dialogue, principals may be specified individually.

The adjustment will take effect on the following rollover (as 1st Period Date).

[IMAGE PLACEHOLDER: override principal dialog]

To set one specific principal to 0 and then resume the payments thereafter, set -1 in the period that should be 0 (-1 = -100%) and then the original principal amount in the next period as shown in the image below.

[IMAGE PLACEHOLDER: zero principal override]

To define a Balloon loan with no payments until maturity, override the principal and set it to 0 (not empty) – first image below - and check the All int due at maturity – second image below.

[IMAGE PLACEHOLDER: balloon loan no payments]

---

### Annuity loan

To input annuity loans, the “Annuity” check box column must be included in the input sheet (not included by default).

Please refer to Column setup for details on column setup.

Once included, check the “Annuity column”:

[IMAGE PLACEHOLDER: annuity checkbox]

Set the start date, first instalment (1st Instalm. Date) to exactly 1 period length from start date (*), instalments a year (Periods A Year) and the total number of instalments (Periods); system will calculate every changing mix of interest and instalment for each term until maturity.

(*) If date for 1st installment is set prior to the “normal” start of 1st term, the interest calculation will switch to advance payment.

---

### Intercompany loan

Loans can also be set up as intercompany loans with a counterpart legal entity defined as the loaner depending on the input sheet setup.

An intercompany loan must be marked as a “Loan out” from the lender and the loaner must be set as the counterparty.

---

### Analyze the financial effect of portfolio and individual loans

Click the icon to view the transactions generated from the individual loan in question, note the tab control to switch between the reports:

[IMAGE PLACEHOLDER: loan reports tabs]

Cash report

[IMAGE PLACEHOLDER: cash report]

Click the tabular icon to display the data:

[IMAGE PLACEHOLDER: cash report table]

P&L / Balance

[IMAGE PLACEHOLDER: P&L balance]

P&L / Balance details (requires a specific loan to be selected)

[IMAGE PLACEHOLDER: P&L balance details]

Transactions (requires a specific loan to be selected)

[IMAGE PLACEHOLDER: transactions view]

---

## Flexible organizational input level

Loans can be input from anywhere in the organizational dimension. Each loan must, however, be attached to a department.

If a department is selected when input is done, this department is automatically assumed to be the department for the loan.

If at a higher level, the legal entity and department columns are automatically visible and relevant values must be selected from the dropdown lists attached to the columns:

[IMAGE PLACEHOLDER: legal entity and department columns]

---

## Flexible input sheet

### Input columns

Depending on the variety of loans to support, annuity, serial, intercompany loans, etc., the input sheet may be configured differently.

By default, the input sheet is set up to support external serial loans with the option of overriding the serial principals.

The loan account is by default a lookup and the interest rate is by default an input field (“Interest % ovr”), and fields for inputting establishment and periodic fees are visible:

[IMAGE PLACEHOLDER: default input sheet]

This can be changed by excluding and/or including input columns as appropriate. For details on defining input columns, please refer to Column setup for details.

Please note that the input sheet works in conjunction with various setting (lookup) tables associated with the loan module.

Please refer to Settings for details on loan settings.

---

## Dimensionality

The basic dimensionality of the Loan module is department and the individual investment.

Extra dimensionality may be added as needed, please refer to Dimension setup for details.

---

## Loan status

A Loan status table can be defined with behaviors such as include in plan which determines whether loans of a certain status is to be included in the plan or not.

Please refer to Loan status for details.

---

## Module configuration

### Publish and name module, control row context right-click menu options

Select the “Input Settings and Administration” workbook and go to the “Setup” page, and edit the “Input modules” table:

[IMAGE PLACEHOLDER: input modules table]

| Column | Description |
|------|-------------|
| Input module | Name of input module and admin link |
| Published | Published or not |
| Description | Default name |
| New | Allow insert new rows |
| Delete | Allow delete |
| Delete (act. = 0) | Delete only if no actuals |
| Ch. dim. | Allow change dimensionality |
| Ch. dim. (act. = 0) | Change dim only if no actuals |
| Multi-dept. input | Always true |
| Input row limit | Max row limit |
| Auto load on filter chg. | Auto load data |

---

## Setup of the Loan module

The Loan module is configured in the “Setup” page of the “Loan” workbook. In the “Setup” page, select the “Input model” tab:

[IMAGE PLACEHOLDER: loan setup input model]

The module can be published by checking the “Published” checkbox and clicking the “Save” button. Conversely, the module can be taken offline by unchecking the “Published” checkbox.

---

## Column setup

The following columns are always present:

- TextID  
- Amount  
- Start date  
- 1st Period Date  
- PeriodsAYear  
- PrincipalPeriods  
- Ovr  

The columns available for selection are selected in the “Column setup” table.

[IMAGE PLACEHOLDER: column setup table]

---

## Dimension setup

The department and individual loan dimensions are always present. Extra dimensions may be enabled.

[IMAGE PLACEHOLDER: dimension setup table]

---

## Loan status

Loan statuses can be used to filter out certain loans.

[IMAGE PLACEHOLDER: loan status table]

---

## Translations

Translations are added in the Translations tab in the Input Settings and Administration workbook.

---

## Settings

The loan settings are defined in the “Setup” page of the “Loan” workbook. Select the “Settings” tab:

[IMAGE PLACEHOLDER: loan settings tab]

---

### Loan: Interest

| Column | Description |
|------|-------------|
| Legal entity | Ranked input |
| Text | Loan or All |
| From date | Start date |
| Int 365 days | Actual or 30 days |
| All int due at maturity | Interest at maturity |
| Comments | Optional |

---

### Loan: Interest %

| Column | Description |
|------|-------------|
| Legal entity | Ranked input |
| Text | Loan or All |
| From date | Start date |
| Value | Interest rate |
| High | High scenario |
| Low | Low scenario |
| Comments | Optional |

---

### Loan: Fee A Period

| Column | Description |
|------|-------------|
| Legal entity | Ranked input |
| Text | Loan or All |
| From date | Start date |
| Value | Fee |
| High | High scenario |
| Low | Low scenario |
| Comments | Optional |

---

### Loan: Accounts

| Column | Description |
|------|-------------|
| Legal entity | Ranked input |
| Text | Loan or All |
| From date | Start date |
| Loan | Balance account |
| Interest | P&L account |
| Fee | P&L account |
| Agio dis | P&L account |
| Comments | Optional |

---

### Loan: InterCompany Accounts

| Column | Description |
|------|-------------|
| Legal entity | Counterparty entity |
| Text | Loan or All |
| From date | Start date |
| Cp Loan | Balance account |
| Cp Interest | P&L account |
| Cp Fee | P&L account |
| Cp Agio disagio | P&L account |
| Comments | Optional |

---


