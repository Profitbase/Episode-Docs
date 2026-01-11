# Profitbase Planner – Personnel module

**Document:** Configuration and Operation – Personnel module  
**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Version:** 3.0  
**Date:** 07.07.2022  

---

## Change log

| Date | Version | Changed by | Changes |
|---|---|---|---|
| 29.05.2020 | 0.0 | TN | Initial content |
| 12.10.2020 | 1.0 | TN | Revised |
| 19.05.2021 | 2.0 | TN | Revised for Planner v5 |
| 07.07.2022 | 3.0 | TN | Revised for Planner v5.2 |

---

## 1. Abstract, intended audience and pre-requisites

The Personnel module is an operational input module used to plan **FTE (Full Time Equivalent)** and **HC (Headcount)** and related personnel costs.

Input from contributors is transformed into P&L transactions and returned to the **Plan Overview** workbook as a work-in-progress P&L.

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

Ranked input allows selecting high-level dimension members.

Rules:
- Less specific rows must be placed higher
- More specific rows must be placed lower

Row order determines precedence.

---

## 3. Principle of operation

The Personnel module provides an input sheet for planning:
- FTE
- HC
- Payroll-related costs such as salary, vacation pay, employer tax and pension

### Driver-based

The module uses **FTE or HC as drivers**.

All input values are provided **per FTE/HC per month**.

Calculation logic:
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
- Use employee hierarchy groups to differentiate payroll settings.

---

## Salary calculation and distribution

Key rules:
- Salary is always driven by FTE
- Base monthly salary is defined at plan start
- Annual raise defined by:
  - Percentage
  - Raise month

Raise settings:
- Centrally maintained
- Optional local overrides

Salary distribution:
- Uses **Annual Salary spread key**

Vacation pay:
- Vacation months use spread key values between 0 and 1
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

## Change dimensionality of an input row

If enabled:
- Right-click dimensional column
- Select **Change dimensionality**
- Choose new dimension values

---

## Planning horizon

Defined in **Finance Settings**.

Applies to all input modules.

Long-term planning:
- Year-total input only
- Long-term totals distributed using next-year patterns

---

## Long-term planning

For years beyond next year:
- Input is done at department level
- Required inputs:
  - FTE or HC
  - Expected annual salary raise

Next-year detailed plan is used as scaling base.

---

## Plan roll forward actions

### Source data
- New department/employee combinations added automatically
- FTE and salary initialized from source fact data

### Calculations
- New months inherit last known FTE/HC
- Salary and raise values shift forward annually
- Long-term values adjusted accordingly

---

## 4. Module configuration

Configured in **Input Settings and Administration → Setup**.

---

## Publish and name module, control row context menu

Configurable options:
- Published flag
- Insert / Delete / Change dimensionality permissions
- Multi-department input

---

## Select additional dimensionality

Optional dimensions support:
- Visibility
- Mandatory selection
- Filter usage

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

Override columns:
- Replace payroll settings for that row and cost type

---

## Attach module to input report

Configured in **Input Settings and Administration → Setup**.

Required:
- Department (ranked)
- Report line ID
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

## Additional input filters (slicers)

Standard:
- Department

Optional:
- Project
- Activity

Configured globally.

---

## Period filters

Configured globally.

Controls:
- Available filters
- Default filter
- Sorting

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
## Vacation Pay %
## Pension Employer %
## Pension Employee %

Rates defined by:
- Legal entity
- Department
- Dataset
- Account
- Effective-from date

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

Components:
- Department
- Employee
- Column name
- Operator and value
- Optional condition
- Target account
- Optional target department

---

## 6. Data management

### Employee dimension

Maintained in the **Dimensions** workbook and version-published.

---

### Fact source data

Contains:
- Current FTE
- Current HC
- Current monthly salary
- Optional additional personnel costs
- Optional override columns

New combinations are processed automatically on plan roll-forward.

Manual import supports:
- Adding new rows
- Updating existing rows (if enabled)
