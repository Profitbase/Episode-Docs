# Profitbase Planner – Loan module

**Document:** Configuration and Operation – Loan module  
**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Version:** 1.0  
**Date:** 12.10.2020  

---

## Change log

| Date | Version | Changed by | Changes |
|---|---|---|---|
| 29.05.2020 | 0.0 | TN | Initial content |
| 12.10.2020 | 1.0 | TN | Revised |

---

## 1. Abstract, intended audience and pre-requisites

This document is part of the *Profitbase Planner Configuration and Operation* series and describes configuration and usage of the **Loan module**.

Target audience:
- Implementation partners
- Solution administrators

Pre-requisites:
- Profitbase Planner deployed
- User access to the solution

The Loan module is a standard Profitbase Planner module and is available for both **Budget** and **Forecast**.

---

## 2. Common functionality

- Changes are **not saved automatically**
- **Save** commits changes
- **Refresh** discards unsaved changes
- **Ctrl + Z** undoes last unsaved change

### Row operations
- Insert row
- Insert row below
- Insert copy of row
- Delete row

Deleted rows are removed only after saving.

### Ranked input

Ranked input enables selecting higher-level dimensional nodes:
- Higher rows = less specific
- Lower rows = more specific

Used throughout module settings and configuration.

---

## 3. Principle of operation

The Loan module handles:
- Loans taken and issued
- Term (serial) loans
- Annuity loans
- Balloon loans
- Intercompany loans

It calculates:
- Principal repayment
- Accrued and due interest
- Fees

---

## Loan types

### Term loans

- Define number of instalment periods
- System calculates serial principal

**Balloon loans**
- Define instalment periods and principal
- Residual amount is due at maturity

Overrides:
- Serial principals can be overridden per period
- Grace periods supported
- No-payment balloon loans supported

---

### Annuity loans

Requirements:
- `IsAnnuity` column enabled

Setup:
- Start date
- First instalment date
- Periods per year
- Total periods

The system calculates interest and instalments dynamically.

Advance payment logic applies if the first instalment date is earlier than the first term.

---

### Intercompany loans

- Defined as *Loan out* from lender
- Counterparty legal entity must be specified
- Generates transactions for both parties

---

## Loan analysis

Available views:
1. Cash flow
2. P&L / Balance
3. P&L / Balance details
4. Transactions

Analysis can be done per loan or across loan portfolios.

---

## Flexible organizational input

- Loans can be entered at any organizational level
- Each loan must be tied to a department
- Legal entity and department are required if entered at higher level

---

## Input columns

The input sheet is configurable depending on loan type.

Always present:
- TextID
- Amount
- Start date
- First period date
- Periods per year
- Total periods
- Override indicator

Optional columns include:
- InterestPctOvr
- FeeAPeriodOvr
- FeeInitial
- CurrencyForeignID
- Counterparty fields
- LoanStatusID
- IsAnnuity
- IsLoanOut

---

## Dimensionality

Mandatory:
- Department
- Individual loan

Optional:
- Dim1–Dim4

---

## Loan status

Loan statuses control:
- Default status
- Inclusion in plan
- Filtering in reports

Only one status may be set as default.

---

## 4. Module configuration

Configured in **Loan workbook → Setup**.

### Column setup

- Select which input columns are visible
- Mandatory core columns cannot be removed
- Loan accounts and interest can be lookups or inputs

### Dimension setup

- Configure Dim1–Dim4
- Set visibility and mandatory flags

---

## 5. Settings

Settings are configured under **Loan workbook → Settings**.

---

### Loan: Interest

Defines how interest is calculated.

Key fields:
- Legal entity
- Dataset
- Loan text
- From date
- Day count (365 or 30)
- Interest due at maturity

---

### Loan: Interest %

Lookup table for interest rates.

- Can replace manual interest input
- Supports baseline, high, and low scenarios
- Allows rate changes over time

---

### Loan: Fee A Period

Lookup for periodic fees.

- Alternative to direct fee input
- Supports baseline, high, and low values

---

### Loan: Accounts

Defines:
- Loan balance account
- Interest account
- Fee account
- Agio/disagio account

Accounts may also be input directly if enabled.

---

### Loan: Intercompany Accounts

Used for intercompany loans.

Defines counterpart:
- Loan balance account
- Interest account
- Fee account
- Agio/disagio account

Mandatory for intercompany posting.

---

## Notes and best practices

- Avoid overly specific settings unless required
- Use lookup tables when rates or fees change over time
- Use historic analysis views to validate loan behavior
