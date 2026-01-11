# Profitbase Planner – Personnel module

**Document:** Configuration and Operation – Personnel module  
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

This document is part of the *Profitbase Planner Configuration and Operation* series and describes configuration and usage of the **Personnel module**.

The Personnel module is a standard Profitbase Planner module and exists in two variants:
- Budget
- Forecast

This document applies to both variants, with examples mainly taken from the Forecast version.

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

Deleted rows are removed only after saving.

### Ranked input

Ranked input allows selecting higher-level dimensional nodes:
- Higher rows = less specific
- Lower rows = more specific

Used consistently across configuration and settings tables.

---

## 3. Principle of operation

The Personnel module provides an input sheet for planning **FTEs (Full Time Equivalents)** and related personnel cost.

It generates P&L transactions for:
- Salary
- Employer payroll tax
- Vacation pay
- Pension cost
- Other payroll-related expenses

---

## Driver-based logic

The module is **driver-based**, with FTE as the driver.

All input is provided as:
- Value per FTE
- Per month

Monthly P&L amount calculation:

```
Amount = Input value × FTE × Spread key
```

---

## Plan by individual and/or groups

Planning dimensionality:
- Department
- Employee

The Employee dimension may include:
- Individual employees
- Employee groups
- Mixed hierarchies

Using group levels is recommended to simplify settings differentiation.

---

## Salary calculation and distribution

Key concepts:
- Base monthly salary defined at plan start
- Annual salary raise defined by percentage and month
- Salary spread controlled by **Annual Salary spread key**

Vacation pay handling:
- Spread key values between 0 and 1 for vacation months
- Optional **Reduction vacation pay factor** applied when vacation does not equal one full month

---

## Long-term forecast

For years beyond next year:
- Input is done at department level
- Required inputs:
  - FTE per year
  - Expected annual salary raise

Monthly distribution is inherited from next-year forecast.

---

## Forecast roll forward

### Source data
- New department/employee combinations are added automatically
- FTE and salary initialized from source fact data

### Calculations on roll forward
- FTE carried forward month-to-month
- Salary and raise values shifted forward yearly
- Long-term forecast values updated accordingly

---

## 4. Module configuration

### Publish and name module

Configured in **Input Settings and Administration → Setup**.

Fields:
- Input module name
- Dataset (Budget | Forecast)
- Published flag
- Default / EN / NO names

---

## Select and name input columns

Configurable columns include:
- Salary
- Bonus
- Overtime
- Free car
- Training
- Other personnel costs

Each column supports:
- Visibility in input sheet
- Eligibility for auto transactions
- Eligibility for account mapping
- Eligibility for central and local spread keys

---

## Attach module to input report

The module can be attached to:
- One or more Forecast Summary report lines

Configuration uses:
- Ranked department selection
- Report line ID
- Input module

---

## Define input column to account mapping

Any input column contributing to P&L **must be mapped to an account**.

Mapping dimensions:
- Department
- Employee
- Column name

---

## 5. Settings

Settings are maintained in **Input Settings and Administration**.

---

## Payroll settings

Defines social cost calculations.

### Personnel: Accounts
Maps payroll-related costs to target accounts:
- Employer tax
- Pension
- Vacation pay
- Employer tax on vacation pay

---

### Employer payroll tax %
Defines employer tax rates by:
- Legal entity
- Department
- Dataset
- Account
- Effective date

---

### Vacation pay %
Defines vacation pay rates using the same structure.

---

### Pension employer %
Defines employer pension contribution rates.

---

### Pension employee %
Defines employee pension contribution rates.

---

## Spread keys

Spread keys distribute per-FTE input over months.

Defined by:
- Department
- Employee
- Input column

Avoid overly specific keys to reduce maintenance.

---

## General settings

Defines:
- Raise month
- Whether raise can be overridden locally
- Budget and Forecast raise percentages
- Reduction vacation pay factor

---

## Auto transactions (optional)

Allows generating additional transactions based on rules.

Rule components:
- Department
- Employee
- Input column
- Operator and value
- Optional condition
- Target account

---

## 6. Data management

### Employee dimension
- Maintained in Dimensions workbook
- Supports hierarchies and grouping

---

### Fact source data

Contains:
- Current FTE
- Current monthly salary
- Optional additional cost fields

Mandatory fields:
- Department
- Employee

New combinations are automatically processed during forecast rollover.
