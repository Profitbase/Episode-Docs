# Profitbase Planner – Driver based module

**Document:** Configuration and Operation – Driver based module  
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
| 11.08.2021 | 2.1 | TN | Added deviation columns |
| 04.10.2021 | 2.2 | TN | Revised for v5 final |
| 09.12.2021 | 2.3 | TN | Revised for v5.1 |
| 07.07.2022 | 3.0 | TN | Revised for v5.2 |

---

## 1. Abstract, intended audience and pre-requisites

The Driver based module is an operational input module used to plan values based on **drivers**
such as quantities, volumes, prices, or FTE.

Input provided by contributors is transformed into P&L transactions and returned to the
**Plan Overview** workbook as a work-in-progress P&L.

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

Ranked input allows high-level selection of dimension members.

Rules:
- Less specific rows must be placed higher
- More specific rows must be placed lower

Row order determines precedence.

---

## 3. Principle of operation

### Driver based models

The module uses a **driver-based principle**.

- Multiple models may exist
- Each model defines one or more **driver measures**
- Other measures may:
  - Take direct input
  - Lookup assumptions
  - Be calculated from other measures

Measures render as rows in the model.

Icons indicate:
- Distribution
- Assumption lookup
- Calculation (automatic or button-click)

---

### Distribution logic

Year-total input is automatically distributed to months using:
1. User-entered monthly values
2. Central distribution keys
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

---

### Historical references

- Last 12 months of actuals included by default
- Up to 5 historical reference columns supported

---

### Planning horizon

Defined globally in **Finance Settings**.

Long-term planning:
- Year-total input only
- Long-term totals distributed using next-year patterns

---

### Plan roll forward actions

**Source data**
- New combinations from source fact data are added automatically
- Last 12 months of actuals refreshed

**Long-term plan**
- NY+1 totals distributed using next-year distribution

---

## 4. Model configuration

Configured in **Driver based modelling workbook → Models**.

Multiple input models may coexist.

---

## Input models

### Create a new model
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
- Published models are editable by users
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
- Filter usage
- Member exclusion per model

---

## Historical reference columns

Available:
- Historic1–Historic5

Configurable per column:
- Dataset
- Date range
- Visibility
- Naming

---

## Deviation columns

Available:
- Deviation1–Deviation2

Supported references:
Historic1–Historic5, YTD, ROY, TY, NY, L12M, N12M, NYPlus1–NYPlus5

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

Modules are attached to **Plan Overview** report lines
using ranked department selection.

---

## Period filters and navigation

Configured globally.

Options include:
- Period filter visibility
- Default filter
- Periods button
- Direct navigation to details view

---

## Access control

Access can be limited per model to specific access groups.

---

## Row context menu options

Configurable:
- Insert
- Delete
- Change dimensionality

---

## 5. Settings

### Assumptions

- Defined per measure
- Shared across models
- Dimension-aware
- Roll forward automatically

---

### Distribution keys

Defined by:
- Department
- Product
- Market
- Activity
- Project
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
- Optional target department

---

### Advanced – engine interface (optional)

Allows:
- Mapping measures to specific transaction columns
- Excluding measures from financial engines

Advanced topic. Use with caution.

---

## 6. Data management

### Dimensions

Dimensions are centrally managed and version-published.

---

### Source fact data

Maintained in **Source fact data** workbook.

Mandatory columns:
- DepartmentID
- ProductID
- MarketID
- Year
- Month
- Value

Optional:
Project, Activity, Supplier, Counterparty, Dim1–Dim4.

Values must be in home currency.
