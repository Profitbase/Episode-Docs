# Profitbase Planner – Driver based module

**Document:** Configuration and Operation – Driver based module  
**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Version:** 3.6  
**Date:** 09.09.2025  

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
| 05.12.2022 | 3.1 | TN | Revised for v5.2.4 |
| 24.02.2023 | 3.2 | TN | Revised for v5.4.0 |
| 24.06.2023 | 3.4 | TN | Revised for v5.4.1 |
| 14.05.2025 | 3.5 | TN | Revised for v6.1.0 |
| 09.09.2025 | 3.6 | TN | Revised for v6.1.1 |

---

## 1. Abstract, intended audience and pre-requisites

This document describes configuration and operation of the **Driver based module**, the most flexible and generic planning module in Profitbase Planner.

The module is used to model driver-based logic where one or more measures act as drivers and other measures depend on them through calculations, assumptions, or direct input.

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

Editable fields are shown with white background.

### Ranked input

Ranked input allows selecting higher-level dimension members:
- Higher rows = less specific
- Lower rows = more specific

This concept is used throughout configuration tables.

---

## 3. Principle of operation

### Driver based models

A driver based model consists of:
- One or more **driver measures**
- Additional measures that:
  - Take direct input
  - Lookup assumptions
  - Are calculated from other measures

Measures render as rows in the model.

Icons indicate measure behavior:
- Distribution
- Assumption lookup
- Calculation (auto or manual)

---

### Distribution logic

Year-total input is automatically distributed to months using:
1. User-entered monthly values
2. Central distribution keys
3. Even distribution

Distribution logic applies consistently across modules.

---

### Dimensionality

Mandatory:
- Department

Default (normally mandatory):
- Product
- Market

Optional:
- Employee
- Supplier
- Project
- Activity
- Counterparty
- Dim1–Dim4

Dimensions can be excluded per model.

---

### Historical references

- Last 12 months of actuals included by default
- Up to 5 historical reference columns supported

---

### Planning horizon and roll forward

- Planning horizon is defined globally in Finance Settings
- Long-term planning supports year-total input only
- On roll forward:
  - New source combinations are added
  - Long-term year totals are distributed using next-year patterns

---

## 4. Model configuration

Configured in **Driver based modelling workbook → Models**.

Multiple input models can coexist and be published independently.

---

## Input models

### Create a model
- Click **New**
- Define model ID and name
- Optionally copy structure and/or data from an existing model

### Process a model
- Regenerates P&L transactions
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
- Rollup behavior
- Period aggregation (sum or average)
- Formatting and display order

Measures not intended to generate transactions can be excluded.

---

## Define calculations

Two calculation types:

### Cell calculations
- Simple arithmetic (+ − * /)
- Executed automatically
- Formula syntax: `[MeasureID]`

### Button-click calculations
- SQL-based
- Executed manually
- Support period offsets

Manual calculations are marked visually.

---

## Define dimensionality

For each dimension:
- Visibility
- Mandatory selection
- Filter usage
- Default filter values
- Source data grouping

Dimension members can be excluded per model.

---

## Define attributes

- Up to 2 attributes per model
- Attributes are not part of row uniqueness
- Used for assumption lookups and auto transactions

Each attribute supports:
- Visibility
- Editability
- Mandatory flag
- Update from source data

---

## Historical reference columns

Available:
- Historic1–Historic5

Each defines:
- Dataset
- Date range or relative date expression
- Visibility and naming

---

## Deviation columns

Available:
- Deviation1–Deviation2

Deviation formulas can reference:
- Historic columns
- YTD, TY, NY, NYPlus1–NYPlus5
- L12M, N12M

Example:
```
[NY] - [TY]
```

---

## Measures

Measures are defined centrally.

Properties include:
- Assumption eligibility
- Currency handling
- Historical fact source
- Plan proposal source

Measures can source history from:
- Manual input
- External driver facts
- General ledger
- Actualized plan data

---

## Attach module to input report

Modules are attached to:
- Plan Overview report lines

Configuration uses:
- Ranked department selection
- Report line ID
- Input module

---

## Period filters and navigation

- Period filters are global
- Default filter and visibility configurable
- Drivers view and details view supported
- Optional direct navigation to details

---

## Access and input control

- Limit access per model
- Control row context menu options
- Enable multi-department input
- Set row limits
- Control auto-load and auto-submit behavior

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
- Optional target department override

---

## Advanced configuration

### Engine interface

Allows:
- Mapping measures to specific transaction columns
- Overriding default amount mapping
- Excluding measures from financial engines

---

### Linked models

Allows chaining models so that processing one triggers others.

Supports:
- Execution order
- Same or mapped department context

---

## 6. Data management

### Dimensions
- Centrally managed
- Version-specific publishing supported

---

### Source fact data

Used for:
- Last 12 months actuals
- Historical reference columns

Mandatory fields:
- Department
- Product
- Market
- Year
- Month
- Value (home currency)

New combinations are added automatically on roll forward.

---

## Using Personnel fact source

Driver-based models can:
- Use Personnel fact as plan proposal source
- Control whether input values are updated from source data
