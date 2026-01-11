# Profitbase Planner – Loan module

**Document:** Configuration and Operation – Loan module  
**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Version:** 2.0  
**Date:** 20.05.2021  

---

## Change log

| Date | Version | Changed by | Changes |
|---|---|---|---|
| 29.05.2020 | 0.0 | TN | Initial content |
| 12.10.2020 | 1.0 | TN | Revised |
| 20.05.2021 | 2.0 | TN | Revised for Planner v5 |

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
- **Ctrl + Z** undoes last unsaved change

### Row operations
- Insert row
- Insert row below
- Insert copy of row
- Delete row

Row deletion must be saved to take effect.

### Ranked input

Ranked input allows selecting higher-level dimensional nodes.

Rules:
- Less specific rows should be placed higher
- More specific rows should be placed lower

Row order controls precedence.

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
- Balloon loans with no payments supported by overriding principal to `0` and enabling **All interest due at maturity**

---

### Annuity loans

Requirements:
- `IsAnnuity` column must be enabled in the input sheet

Setup:
- Start date
- First instalment date (exactly one period length from start date)
- Periods per year
- Total number of periods

If the first instalment date precedes the normal first term, interest is calculated as **advance payment**.

---

### Intercompany loans

- Loans can be marked as **Loan out** for the lender
- Counterparty legal entity and department must be specified
- Transactions are generated for both parties using intercompany accounts

---

## Loan analysis

Available analysis views:
1. Cash report
2. P&L / Balance
3. P&L / Balance details (requires loan selection)
4. Transactions (requires loan selection)

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

The input sheet can be configured depending on supported loan types.

Always present:
- TextID
- Amount
- Start date
- 1st Period Date
- Periods A Year
- Principal Periods
- Ovr (override indicator)

Optional columns include:
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

Only one status may be marked as **Initial value**.

---

## 4. Module configuration

Configured in **Loan workbook → Setup → Input model**.

---

## Publish module

- Check **Published** to expose module to users
- Uncheck to take module offline

---

## Column setup

Mandatory columns cannot be removed.

Optional columns can be enabled or disabled depending on required functionality.

Interest rate and fees may be:
- Input directly
- Looked up via settings tables

---

## Dimension setup

Available dimensions:
- Project
- Activity
- Dim1–Dim4

Each dimension supports:
- Visibility
- Mandatory selection

---

## Loan status setup

Defines:
- Status ID
- Translations
- Initial value (single)
- Include in plan flag

---

## 5. Settings

Settings are maintained in **Loan workbook → Setup → Settings**.

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
- Interest rate changes over time

Used when direct input is not practical.

---

## Loan: Fee A Period

Lookup table for periodic fees.

Used when:
- Fees change over time
- Direct input is not desired

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

Defines counterpart accounts for:
- Loan balance
- Interest
- Fees
- Agio / disagio

Mandatory when counterparty posting is required.
