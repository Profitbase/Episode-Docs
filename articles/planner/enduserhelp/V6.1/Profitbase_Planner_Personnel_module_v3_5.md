# Profitbase Planner – Personnel module

**Document:** Configuration and Operation – Personnel module  
**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Version:** 3.5  
**Date:** 26.05.2025  

---

## Change log

| Date | Version | Changed by | Changes |
|---|---|---|---|
| 29.05.2020 | 0.0 | TN | Initial content |
| 12.10.2020 | 1.0 | TN | Revised |
| 19.05.2021 | 2.0 | TN | Revised for Planner v5 |
| 07.07.2022 | 3.0 | TN | Revised for Planner v5.2 |
| 05.12.2022 | 3.1 | TN | Revised for Planner v5.2.4 |
| 24.02.2023 | 3.2 | TN | Revised for Planner v5.4.0 |
| 23.06.2023 | 3.4 | TN | Revised for Planner v5.4.1 |
| 26.05.2025 | 3.5 | TN | Revised for Planner 6.1.0 |

---

## 1. Abstract, intended audience and pre-requisites

The Personnel module is an operational input module used to plan FTEs (Full Time Equivalents), HCs (Headcounts), and payroll-related costs.

It transforms user input into P&L transactions for:
- Salary
- Vacation pay
- Employer payroll tax
- Pension cost
- Other personnel-related expenses

Target audience:
- Implementation partners
- Solution administrators

Pre-requisites:
- Profitbase Planner deployed
- User access to the solution

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

Row deletion is only finalized after saving.

### Ranked input

Ranked input allows selecting higher-level dimension members:
- Higher rows = less specific
- Lower rows = more specific

Used across settings and configuration tables.

---

## 3. Principle of operation

### Driver-based

The Personnel module is driver-based.

Drivers:
- FTE
- HC (Headcount)

All cost input is provided **per FTE or HC per month**.

Monthly P&L calculation:

```
Amount = Input value × FTE/HC × Periodic spread key
```

---

## Plan by individual and/or groups

Core dimensions:
- Department
- Employee

The Employee dimension may contain:
- Individuals
- Groups
- Mixed hierarchies

Using group levels is recommended to reduce configuration complexity.

---

## Salary calculation and distribution

Salary logic:
- Base monthly salary defined at plan start
- Annual raise defined by percentage and month
- Raise may be centrally controlled or locally overridden

Salary is distributed using the **Annual Salary spread key**.

Vacation pay handling:
- Vacation months use spread key values between 0 and 1
- Optional **Reduction vacation pay factor** applies when vacation does not equal one full month

---

## Dimensionality

Mandatory:
- Department
- Employee

Optional:
- Project
- Activity
- Counterparty
- Dim1–Dim4

---

## Attributes

- Up to **2 attributes** per row
- Attributes do not affect row uniqueness
- Used for:
  - Assumption lookups
  - Auto transactions
  - Categorization

---

## Change dimensionality of an input row

If enabled, row dimensionality can be changed using **Change dimensionality** from the row context menu.

---

## Planning horizon

- Defined globally in **Finance Settings**
- Applies to all input modules
- Long-term planning supports year-total input only

Long-term totals are distributed using next-year distribution patterns.

---

## Long-term planning

For years beyond next year:
- Input is done at department level
- Required values:
  - FTE or HC
  - Expected annual raise

---

## Plan roll forward actions

### Source data updates

On roll forward:
- New department/employee combinations are added automatically
- FTE, HC, and salary initialized from source fact data

Existing rows may be updated if configured.

---

### Calculations on roll forward

- New months inherit last known FTE/HC
- Salary and raise values shift forward by year
- Long-term values are adjusted accordingly

---

## 4. Module configuration

Configured in **Input Settings and Administration → Setup**.

---

## Publish and name module

Configurable options:
- Module name and translations
- Published flag
- Row context menu permissions
- Multi-department input
- Input row limits
- Auto-load and auto-submit behavior

---

## Select additional dimensionality

Optional dimensions can be enabled and configured as:
- Visible
- Mandatory
- Filter-enabled
- Default filter values

Special note:
- Counterparty dimension only creates counter-postings in Sales (IC) and Loan (IC) engines.

---

## Select and name input columns, set the driver

Configurable per column:
- Driver (FTE or HC)
- Visibility and editability
- Eligibility for:
  - Account mapping
  - Auto transactions
  - Central or local spread keys
  - Payroll overrides
  - Source fact data updates

Columns contributing to P&L **must be mapped to accounts**.

---

## Translations

Translations are maintained per column and UI label.

---

## Attach module to input report

The module can be attached to one or more **Plan Overview** report lines using:
- Ranked department selection
- Report line ID
- Input module

---

## Define input column to account mapping

Mapping dimensions:
- Department
- Employee
- Column name

Any column producing P&L transactions requires an account mapping.

---

## Period filters

Period filters are configured globally and control:
- Visible filters
- Default selection
- Sorting

---

## 5. Settings

Settings are maintained in **Input Settings and Administration**.

---

## Payroll settings

Payroll settings define rates and rules for social costs.

---

## Personnel: Accounts

Defines target accounts for:
- Employer tax
- Pension
- Vacation pay
- Employer tax on vacation pay

---

## Employer Payroll Tax %

Defines employer payroll tax rates by:
- Legal entity
- Department
- Dataset
- Account
- Effective date

---

## Vacation Pay %

Defines vacation pay rates using the same structure.

---

## Pension Employer %

Defines employer pension contribution rates.

---

## Pension Employee %

Defines employee pension contribution rates.

---

## Spread keys

Spread keys distribute per-FTE/HC values across months.

Defined by:
- Department
- Employee
- Column name

Avoid overly specific keys.

---

## General settings

Defines:
- Raise month
- Raise percentages (TY, NY, NY+1)
- Whether raises are locally editable
- Reduction vacation pay factor

---

## Auto transactions (optional)

Rule-based additional postings.

Supports:
- Conditions
- Operators
- Attribute filtering
- Optional target department override

---

## 6. Data management

### Employee dimension

- Maintained in the Dimensions workbook
- Centrally managed with version-specific publishing

---

### Fact source data

Source fact data contains:
- Current FTE
- Current HC
- Current monthly salary
- Optional additional cost columns
- Optional payroll override values
- Attribute values

New combinations are added automatically on plan roll forward.

Manual import supports:
- Adding new rows only
- Updating existing rows (if enabled)
