# Profitbase Planner – Loan module

**Document:** Configuration and Operation – Loan module  
**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Version:** 3.2  
**Date:** 24.02.2023  

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

---

## 1. Abstract, intended audience and pre-requisites

This document describes configuration and operation of the **Loan module** in Profitbase Planner.

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

Editable fields are shown with white background.

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
- Serial principals can be overridden via the **Ovr** column
- Grace periods supported
- Balloon loans with no payments until maturity:
  - Override principal to `0` (not empty)
  - Enable **All interest due at maturity**

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
- Counter transactions generated via Loan (IC) engine only

---

## Loan analysis

Available views:
1. Cash report
2. P&L / Balance
3. P&L / Balance details (requires specific loan)
4. Transactions (requires specific loan)

---

## Flexible organizational input level

- Loans can be entered at any organizational level
- Each loan must be attached to a **Department**
- If entered above department level:
  - Legal entity and department columns become mandatory

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

Interest and fees may be input directly or derived from lookup tables.

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
- Default value for new loans
- Inclusion in plan
- Filtering

Only one status may be marked as **Initial value**.

---

## 4. Module configuration

Configured in **Input Settings and Administration → Setup** and **Loan workbook → Setup**.

---

## Publish and name module, control row context menu

Configurable options:
- Published
- Insert / Delete permissions
- Change dimensionality permissions
- Multi-department input (always true)
- Input row limit
- Auto-load on filter change

---

## Column setup

Mandatory columns cannot be removed.

Optional columns are enabled depending on required loan functionality.

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

---

## Loan status setup

Defines:
- LoanStatusID
- Translations
- Initial value (single)
- Include in plan flag

---

## 5. Settings

Configured in **Loan workbook → Setup → Settings**.

---

## Loan: Interest

Defines how interest is calculated.

| Column | Description |
|---|---|
| Legal entity | Ranked, mandatory |
| Text | Loan or `All` |
| From date | Effective-from |
| Int 365 days | Actual vs 30-day month |
| All int due at maturity | Interest paid at maturity |
| Comments | Optional |

---

## Loan: Interest %

Lookup table for interest rates.

Supports:
- Baseline
- High
- Low
- Rate changes over time

Used when `InterestPctOvr` is not input directly.

---

## Loan: Fee A Period

Lookup table for periodic fees.

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

Used only by Loan (IC) engine.
