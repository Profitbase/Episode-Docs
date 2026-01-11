# Profitbase Planner – Personnel module

**Document:** Configuration and Operation – Personnel module  
**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Version:** 2.1  
**Date:** 14.09.2021  

---

## Change log

| Date | Version | Changed by | Changes |
|---|---|---|---|
| 29.05.2020 | 0.0 | TN | Initial content |
| 12.10.2020 | 1.0 | TN | Revised |
| 19.05.2021 | 2.0 | TN | Revised for Planner v5 |
| 14.09.2021 | 2.1 | TN | Revised Personnel fact |

---

## 1. Abstract, intended audience and pre-requisites

The Personnel module is an operational input module used to plan FTEs (Full Time Equivalents) and payroll-related cost.

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

Row deletion takes effect only after saving.

---

## Ranked input

Ranked input allows selecting higher-level dimension members.

Rules:
- Less specific rows should be placed higher
- More specific rows should be placed lower

---

## 3. Principle of operation

### Driver-based

The Personnel module is driver-based, with **FTE** as the driver.

All user input is provided **per FTE per month**.

Monthly P&L calculation:

```
Amount = Input value × FTE × Periodic spread key
```

---

## Plan by individual and/or groups

Planning dimensions:
- Department
- Employee

The Employee dimension may consist of:
- Individuals
- Groups
- A combination of both

Using group levels is recommended to simplify differentiated settings.

---

## Salary calculation and distribution

Salary logic:
- Base monthly salary defined at plan start
- Annual salary raise defined by percentage and raise month
- Raise can be centrally controlled or locally overridden

Salary distribution uses the **Annual Salary spread key**.

Vacation pay handling:
- Spread key values between 0 and 1 for vacation months
- Optional **Reduction vacation pay factor** applies when vacation is not exactly one month

---

## Planning horizon

- Defined in **Finance Settings**
- Applies to all input modules

Long-term planning:
- Supports year-total input only
- Long-term totals are distributed using next-year patterns

---

## Long-term planning

For years beyond next year:
- Input is done at department level
- Required:
  - FTE per year
  - Expected annual salary raise

---

## Plan roll forward actions

### Source data

On roll forward:
- New department/employee combinations are added automatically
- FTE and monthly salary are initialized from source fact data

### Calculations

- New months inherit last known FTE
- Salary and raise values are shifted forward yearly
- Long-term values are adjusted accordingly

---

## 4. Module configuration

Configured in **Input Settings and Administration → Setup**.

---

## Publish and name module

Configurable fields:
- Input module name
- Published flag
- Default / EN / NO descriptions

---

## Select and name input columns

Configurable properties per column:
- Visibility in input worksheet
- Eligibility for:
  - Auto transactions
  - Account mapping
  - Central spread key
  - Local spread key

Override (ovr) columns:
- Control visibility and naming only
- Override payroll settings when used

---

## Attach module to input report

The module can be attached to one or more **Plan Overview** report lines.

Configuration fields:
- Department (ranked input)
- Report Line ID
- Input module

---

## Define input column to account mapping

Any input column generating P&L transactions **must be mapped to an account**.

Mapping dimensions:
- Department
- Employee
- Column name
- Account

---

## Additional input filters (slicers)

Optional slicers:
- Project
- Activity

Configuration is global to:
- All input modules
- Plan Overview

---

## Period filters

Period filter configuration is global.

Controls:
- Available filters
- Default filter
- Sorting

---

## 5. Settings

Settings are maintained in **Input Settings and Administration → Payroll settings / Settings**.

---

## Personnel: Accounts

Defines target accounts for:
- Employer payroll tax
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

Spread keys distribute per-FTE values across months.

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
- Whether raise values are locally editable
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

---

## 6. Data management

### Employee dimension

Maintained in the **Dimensions** workbook.

---

### Fact source data

Contains:
- Current FTE
- Current monthly salary
- Optional additional personnel costs
- Optional payroll override columns

New combinations are automatically added on plan roll forward.

Manual import supports:
- Adding new rows
- Updating existing rows (if enabled)
