# Profitbase Planner – Personnel module

**Document:** Configuration and Operation – Personnel module  
**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Version:** 3.4  
**Date:** 23.06.2023  

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

---

## 1. Abstract, intended audience and pre-requisites

The Personnel module is an operational input module used to plan **FTE (Full Time Equivalent)** and **HC (Headcount)** and to calculate payroll-related costs.

Input is transformed into P&L transactions for:
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

### Driver-based

The Personnel module is **driver-based**, using **FTE or HC** as the driver.

All user input is provided **per FTE/HC per month**.

Monthly P&L calculation:
```
Amount = Input value × FTE/HC × Periodic spread key
```

Periodic spread keys are used instead of distribution keys.

---

## Plan by individual and/or groups

Planning dimensions:
- Department
- Employee

The Employee dimension may contain:
- Individual employees
- Groups
- A combination of both

Best practice:
- Use employee group levels to control differentiated payroll settings.

---

## Salary calculation and distribution

Key concepts:
- Salary is always driven by FTE
- Base monthly salary is defined at plan start
- Annual salary raise is defined by:
  - Percentage
  - Raise month

Raise settings:
- Can be centrally controlled
- Can optionally be overridden locally

Salary distribution:
- Uses the **Annual Salary spread key**

Vacation pay:
- Vacation months should have spread key values between 0 and 1
- If vacation is not exactly one month, a **Reduction vacation pay factor** is applied

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

Attributes:
- Do **not** define row uniqueness
- Provide additional classification (e.g. employment type)
- Up to **two attributes** supported

---

## Change dimensionality of an input row

If enabled:
- Right-click a dimensional column
- Select **Change dimensionality**
- Choose new dimension members

---

## Planning horizon

Defined in **Finance Settings** and applies to all input modules.

Long-term planning:
- Year-total input only
- Long-term totals distributed using next-year patterns

---

## Long-term planning

For years beyond next year:
- Input is done at department level
- Required inputs:
  - FTE/HC
  - Expected annual salary raise

Next-year detailed plan is used as the scaling base.

---

## Plan roll forward actions

### Source data
- New department/employee combinations are added automatically
- FTE, HC, and salary initialized from source fact data

### Calculations
- New months inherit last known FTE/HC
- Salary and raise values are shifted forward annually
- Long-term values are adjusted accordingly

---

## 4. Module configuration

Configured in **Input Settings and Administration → Setup**.

---

## Publish and name module, control row context menu

Configurable options:
- Published flag
- Insert / Delete / Change dimensionality permissions
- Multi-department input
- Input row limit
- Auto-load on filter change
- Auto-submit data

---

## Select additional dimensionality

Optional dimensions support:
- Visibility
- Mandatory selection
- Filter usage
- Group source data

Note:
Counterparty dimension generates counter-postings only for **Sales (IC)** and **Loan (IC)** engines.

---

## Select and name input columns, set the driver

Each input column can be configured with:
- Driver (FTE or HC)
- Visibility and editability
- Eligibility for:
  - Auto transactions
  - Account mapping
  - Central spread keys
  - Local spread keys
- Override behavior for payroll costs

Any override value **replaces** payroll settings for that row and column.

---

## Translations

Maintained in **Input Settings and Administration → Translations**.

---

## Attach module to input report

Configured in **Input Settings and Administration → Setup**.

Required:
- Department (ranked input)
- Report Line ID
- Input module

---

## Define input column to account mapping

Any column generating P&L transactions **must be mapped to an account**.

Mapping dimensions:
- Department
- Employee
- Column name
- Account

---

## Period filters

Configured globally and apply to:
- All input modules
- Plan Overview

---

## 5. Settings

Maintained in **Input Settings and Administration → Payroll settings**.

---

## Personnel: Accounts

Defines target accounts for:
- Employer payroll tax
- Pension
- Vacation pay
- Employer tax on vacation pay

---

## Employer Payroll Tax %

Defines payroll tax rates by:
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

Defined by:
- Department
- Employee
- Column name

Rules:
- Use ranked input
- Avoid overly specific keys

---

## General settings

Defines:
- Raise month
- Raise percentages (TY, NY, NY+1)
- Local override permissions
- Reduction vacation pay factor

---

## Auto transactions (optional)

Rule-based additional postings.

Rule components:
- Department
- Employee
- Column name
- Operator and value
- Optional condition
- Target account
- Optional target department
- Optional attributes

---

## 6. Data management

### Employee dimension
Maintained in the **Dimensions** workbook.

---

### Fact source data

Contains:
- Current FTE
- Current HC
- Current monthly salary
- Optional additional personnel costs
- Optional override columns
- Optional attributes

New combinations are added automatically on plan roll-forward.

Manual import supports:
- Adding new rows
- Updating existing rows (if enabled)
