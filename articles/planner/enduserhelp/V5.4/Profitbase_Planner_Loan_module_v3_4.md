# Profitbase Planner – Loan module

**Document:** Configuration and Operation – Loan module  
**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Version:** 3.4  
**Date:** 24.06.2023  

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

---

## 1. Abstract, intended audience and pre-requisites

This document is part of the *Profitbase Planner Configuration and Operation* series and describes configuration and operation of the **Loan module**.

Target audience:
- Implementation partners  
- Solution administrators  

Pre-requisites:
- Profitbase Planner deployed  
- User access to the solution  

The Loan module is included as a standard Profitbase Planner module.

---

## 2. Common functionality

- Changes are **not saved automatically**
- **Save** commits changes
- **Refresh** discards unsaved changes
- **Ctrl + Z** undoes the last unsaved change

### Row operations
- Insert row
- Insert row below
- Insert copy of row
- Delete row

Row deletion must be saved to take effect.

### Ranked input

Ranked input allows selecting higher-level dimension members.

Rules:
- Less specific rows must be placed higher
- More specific rows must be placed lower

Row order determines precedence.

---

## 3. Principle of operation

The Loan module handles loans **taken and issued** and calculates:
- Interest (accrued and due)
- Installments
- Fees

Supported loan types:
- Term (serial) loans
- Balloon loans
- Annuity loans
- Intercompany loans

---

## Loan types handled

### Term loans

Default behavior:
- Define number of installment periods
- System calculates serial principal automatically

**Balloon loans**
- Define both number of installment periods and principal amount
- Residual value is due at maturity

Overrides:
- Serial principals can be overridden using the **Ovr** column
- Grace periods supported
- Balloon loans with no payments until maturity supported by:
  - Overriding principal to `0`
  - Enabling **All interest due at maturity**

---

### Annuity loans

Requirements:
- `IsAnnuity` column must be enabled

Setup:
- Start date
- 1st instalment date (exactly one period from start date)
- Periods per year
- Total number of instalments

If the first instalment date precedes the normal first term, interest is calculated as **advance payment**.

---

### Intercompany loans

- Mark loan as **Loan out** for the lender
- Specify counterparty legal entity and department
- Transactions are generated for both parties using intercompany accounts

---

## Loan analysis

Available views:
1. Cash report
2. P&L / Balance
3. P&L / Balance details (requires specific loan selection)
4. Transactions (requires specific loan selection)

Analysis can be done per loan or across loan portfolios.

---

## Flexible organizational input level

- Loans can be entered at any organizational level
- Each loan must be attached to a **Department**
- If entered above department level:
  - Legal entity and department must be explicitly selected

---

## Flexible input sheet

### Input columns

Always present:
- TextID
- Amount
- Start date
- 1st Period Date
- Periods A Year
- Principal Periods
- Ovr

Optional:
- AccountID
- CpAccountID
- CpDepartmentID
- CpLegalEntityID
- CurrencyForeignID
- CurrencyFeeID
- ExternalRefID
- FeeAPeriodOvr
- FeeInitial
- InterestPctOvr
- IsAnnuity
- IsLoanOut
- LoanStatusID

Interest and fees may be input directly or derived via lookup tables.

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

Only one status may be marked as **Initial value**.

---

## 4. Module configuration

Configured in **Input Settings and Administration → Setup** and **Loan workbook → Setup**.

---

## Publish and name module, control row context menu

Configurable options:
- Published flag
- Insert / Delete / Change dimensionality permissions
- Multi-department input (always true)
- Input row limit
- Auto-load on filter change

---

## Column setup

Mandatory columns cannot be removed.

Optional columns can be enabled or disabled depending on required loan functionality.

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

Note:
Counterparty dimensions generate counter-postings only for **Sales (IC)** and **Loan (IC)** engines.

---

## Loan status setup

Defines:
- LoanStatusID
- Translations
- Initial value (single)
- Include in plan flag

---

## Translations

Maintained in **Input Settings and Administration → Translations**.

---

## 5. Settings

Settings are configured in **Loan workbook → Setup → Settings**.

---

## Loan: Interest

Defines interest calculation logic.

Fields:
- Legal entity (ranked)
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
- Fees vary over time
- Direct input is not practical

---

## Loan: Accounts

Defines accounts for:
- Loan balance
- Interest
- Fees
- Agio / disagio

Loan account may also be input directly if enabled.

---

## Loan: InterCompany Accounts

Defines counterparty accounts for intercompany loans.

Mandatory when counterparty posting is required.
