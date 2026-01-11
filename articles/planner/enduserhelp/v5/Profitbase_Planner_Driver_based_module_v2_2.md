# Profitbase Planner – Driver based module

**Document:** Configuration and Operation – Driver based module  
**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Version:** 2.2  
**Date:** 04.10.2021  

---

## Change log

| Date | Version | Changed by | Changes |
|---|---|---|---|
| 29.05.2020 | 0.0 | TN | Initial content |
| 12.10.2020 | 1.0 | TN | Revised |
| 19.05.2021 | 2.0 | TN | Revised for Planner v5 |
| 11.08.2021 | 2.1 | TN | Added deviation columns |
| 04.10.2021 | 2.2 | TN | Revised for v5 final |

---

## 1. Abstract, intended audience and pre-requisites

This document describes configuration and operation of the **Driver based module** in Profitbase Planner.

Planner input modules are used by contributors to prepare parts of the Profit & Loss (P&L).  
Input is transformed into P&L transactions and returned to the Plan Overview.

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

Editable cells use white background.

### Ranked input

Ranked input allows selecting higher-level dimension members:
- Less specific rows higher
- More specific rows lower

Row order controls precedence.

---

## 3. Principle of operation

### Driver based models

The module uses a **driver-based principle**.

- Multiple models may exist
- Each model defines one or more **driver measures**
- Other measures:
  - Take direct input
  - Lookup assumptions
  - Are calculated from other measures

Measures render as rows in the model.

Icons indicate:
- Distribution
- Assumption lookup
- Calculation (auto or manual)

---

### Distribution logic

Year-total input is automatically distributed to months:

1. User-entered monthly pattern
2. Central distribution key
3. Even distribution

---

### Dimensionality

Mandatory:
- Department

Default:
- Product
- Market

Optional:
- Supplier
- Project
- Activity
- Counterparty
- Dim1–Dim4

Dimensions may be excluded per model.

---

### Historical references

- Last 12 months of actuals included by default
- Up to 5 additional historical reference columns

---

### Planning horizon

Defined globally in **Finance Settings**.

Long-term planning:
- Year-total input only
- Distributed using next-year pattern

---

### Plan roll forward actions

#### Source data
- New combinations from driver fact data added automatically
- Last 12 months actuals refreshed

#### Long-term plan
- NY+1 totals converted to monthly values using next-year distribution

---

## 4. Model configuration

Configured in **Driver based modelling workbook → Models**.

Multiple input models can coexist.

---

## Input models

### Create a model
- Click **New**
- Define model ID and name
- Optionally copy model and/or data

### Process a model
- Re-generates P&L transactions
- Required after structural or mapping changes

### Delete a model
Options:
- Delete data only
- Delete model and settings

### Publish a model
- Published models are user-editable
- Unpublished models are admin-only

---

## Edit input model properties

Each model defines a list of measures.

Key properties:
- Driver
- Input
- Lookup
- Calculation
- Total across periods (Sum | Average)
- Rollup behavior (Sum | Average)
- Format and style
- Sorting and calculation order
- Exclude from transactions

---

## Define calculations

Two calculation types:

### Cell calculations
- Simple arithmetic (+ − * /)
- Executed automatically
- Syntax: `[MeasureID]`

### Button-click calculations
- SQL-based
- Executed manually via **Recalculate**
- Marked with red border

---

## Define dimensionality

For each dimension:
- Visibility
- Mandatory selection
- Member exclusion per model

---

## Historical reference columns

Available:
- Historic1–Historic5

Each defines:
- Dataset
- Date range
- Visibility
- Naming

---

## Deviation columns

Available:
- Deviation1–Deviation2

Supported references:
- Historic1–Historic5
- YTD, ROY, TY, NY
- L12M, N12M
- NYPlus1–NYPlus5

Example:
```
[NY] - [TY]
```

---

## Optional columns

Optional columns related to:
- Actuals L12M
- Year-to-date
- Rest of year

---

## Measures

Measures are defined centrally.

Properties include:
- Assumption eligibility
- Currency handling
- Format
- Ownership

Measures must be marked **In use** to be selectable.

---

## Attach module to input report

Modules are attached to **Plan Overview** report lines.

Configuration uses:
- Ranked department selection
- Report Line ID
- Input module

---

## Additional input filters (slicers)

Optional slicers:
- Project
- Activity

Configured globally in **Input Settings and Administration**.

---

## Period filters

Configured globally.

Controls:
- Available filters
- Default filter
- Sorting

---

## Access to models

Access can be limited per model to specific access groups.

---

## 5. Settings

### Assumptions

- Defined per measure
- Shared across models
- Dimension-aware
- Support long-term values

---

### Distribution keys

Defined by:
- Department
- Product
- Market
- Measure

Avoid overly specific keys.

---

### Measure to account mapping

Any measure generating P&L **must be mapped to an account**.

---

### Auto transactions (optional)

Rule-based additional postings.

Supports:
- Conditions
- Operators
- Target account

---

### Advanced – engine interface (optional)

Allows:
- Mapping measures to specific transaction columns
- Excluding measures from financial engines

Advanced topic. Use with caution.

---

## 6. Data management

### Dimensions

Product, Market, Supplier may be maintained locally or centrally.

Deleting members with data leaves orphaned rows.

---

### Source fact data

Maintained in **Measure fact (driver)**.

Mandatory columns:
- Department
- Product
- Market
- Year
- Month
- Value

Optional:
Project, Activity, Supplier, Counterparty, Dim1–Dim4.

Values must be in home currency.

New combinations are processed automatically on plan rollover.
