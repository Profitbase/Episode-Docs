# Profitbase Planner – Loan module

**Document:** Configuration and Operation – Loan module  
**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Version:** 3.5  
**Date:** 25.05.2025  

---

## Change log

| Date | Version | Changed by | Changes |
|---|---|---|---|
| 29.05.2020 | 0.0 | TN | Initial content |
| 12.10.2020 | 1.0 | TN | Revised |
| 20.05.2021 | 2.0 | TN | Revised for Planner v5 |
| 07.07.2022 | 3.0 | TN | Revised for Planner v5.2 |
| 06.12.2022 | 3.1 | TN | Revised for Planner v5.2.4 |
| 24.02.2023 | 3.2 | TN | Revised for Planner v5.4.0 |
| 24.06.2023 | 3.4 | TN | Revised for Planner v5.4.1 |
| 26.05.2025 | 3.5 | TN | Revised for Planner 6.1.0 |

---

## 1. Abstract, intended audience and pre-requisites

This document is part of the *Profitbase Planner Configuration and Operation* series and describes configuration and operation of the **Loan module**.

Target audience:
- Implementation partners
- Solution administrators

Pre-requisites:
- Profitbase Planner deployed
- User access to the solution

The Loan module is included as a standard module in Profitbase Planner.

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

Row deletion must be saved to take effect.

### Ranked input

Ranked input allows selection of higher-level dimension members.

Rules:
- Less specific rows should be placed higher
- More specific rows should be placed lower

---

## 3. Principle of operation

The Loan module handles loans **taken and issued** and calculates:
- Principal repayment
- Accrued and due interest
- Fees

Supported loan types:
- Term (serial) loans
- Annuity loans
- Balloon loans
- Intercompany loans

---

## Loan types handled

### Term loans

Default behavior:
- Define number of principal periods
- System calculates serial principal

**Balloon loans**
- Define both principal and number of periods
- Residual amount is due at maturity

Overrides:
- Serial principals can be overridden per period
- Grace periods supported
- No-payment balloon loans supported by setting principal to `0` and enabling *All interest due at maturity*

---

### Annuity loans

Requirements:
- `IsAnnuity` column must be enabled

Setup:
- Start date
- First instalment date (exactly one period from start date)
- Periods per year
- Total periods

If first instalment date precedes the normal first term, interest is calculated as **advance payment**.

---

### Intercompany loans

- Mark loan as **Loan out** for the lender
- Specify counterparty legal entity and department
- Transactions are generated for both parties using intercompany accounts

---

## Loan analysis

Available views:
1. Cash flow
2. P&L / Balance
3. P&L / Balance details (per loan)
4. Transactions (per loan)

---

## Flexible organizational input level

- Loans can be entered at any organizational level
- Each loan must be attached to a **Department**
- If entered above department level:
  - Legal entity and department must be selected explicitly

---

## Flexible input sheet

### Input columns

The input sheet can be configured depending on loan types required.

Always present:
- TextID
- Amount
- Start date
- 1st Period Date
- Periods per year
- Total periods
- Override indicator (Ovr)

Optional columns include:
- AccountID
- Counterparty fields (CpAccountID, CpDepartmentID, CpLegalEntityID)
- InterestPctOvr
- FeeAPeriodOvr
- FeeInitial
- CurrencyForeignID
- CurrencyFeeID
- LoanStatusID
- IsAnnuity
- IsLoanOut

Lookup tables may replace direct input for interest and fees.

---

## Dimensionality

Mandatory:
- Department
- Individual loan

Optional:
- Project
- Activity
- Dim1–Dim4

---

## Loan status

Loan statuses control:
- Default status for new loans
- Inclusion in plan
- Filtering

Only one status may be set as **Initial value**.

---

## 4. Module configuration

Configured in **Input Settings and Administration → Setup**.

### Publish and name module

Configurable options:
- Module name and translations
- Published flag
- Row context menu permissions
- Input row limits
- Auto-load behavior on filter change

---

## Column setup

Columns can be enabled or disabled depending on required functionality.

Some columns are mandatory and cannot be removed.

Lookup vs input behavior is controlled via column visibility and related settings tables.

---

## Dimension setup

Available dimensions:
- Project
- Activity
- Dim1–Dim4

Each dimension supports:
- Visibility
- Mandatory selection
- Filter usage
- Default filter values

Note:
- Counterparty dimensions only generate counter-postings for Sales (IC) and Loan (IC) engines.

---

## Translations

Translations are maintained in the **Translations** tab in *Input Settings and Administration*.

---

## 5. Settings

Settings are configured in **Loan workbook → Settings**.

---

## Loan: Interest

Defines how interest is calculated.

Key fields:
- Legal entity
- Loan text or `All`
- From date
- Day count (365 or 30)
- All interest due at maturity

---

## Loan: Interest %

Lookup table for interest rates.

Supports:
- Baseline
- High
- Low scenarios
- Rate changes over time

Used when direct input via `InterestPctOvr` is not desired.

---

## Loan: Fee A Period

Lookup table for periodic fees.

Used when:
- Direct input via `FeeAPeriodOvr` is not practical
- Fees change over time

---

## Loan: Accounts

Defines accounts for:
- Loan balance
- Interest
- Fees
- Agio / disagio

Loan account may also be input directly if enabled.

---

## Loan: Intercompany Accounts

Used for intercompany loans.

Defines counterparty accounts for:
- Loan balance
- Interest
- Fees
- Agio / disagio

Mandatory when counterparty posting is required.
