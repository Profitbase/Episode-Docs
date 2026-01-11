# Profitbase Planner – Sales Forecast module

**Document:** Configuration and Operation – Sales Forecast module  
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

This document is part of the *Profitbase Planner Configuration and Operation* series and describes configuration and usage of the **Sales Forecast module**.

The Sales Forecast module is a standard Profitbase Planner module and is **specific to the Forecast process**.

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

Ranked input allows selection of higher-level dimensional nodes:
- Higher rows = less specific
- Lower rows = more specific

Used consistently across configuration and settings tables.

---

## 3. Principle of operation

### Driver-based models

The Sales Forecast module is **driver-based**.

- Multiple models can exist in parallel
- Each model defines **one driving measure**
- Other measures depend on the driver via:
  - Direct input
  - Assumptions
  - Calculations

Examples of driving measures:
- Sales quantity
- Sales volume
- FTE

Measures render as rows within a model.

---

### Distribution logic

- Year-total input is automatically distributed to months
- Distribution priority:
  1. User-entered monthly values
  2. Central distribution keys
  3. Even distribution

Measures with distributions, assumptions, or calculations are visually marked in the UI.

---

## Dimensionality

Mandatory dimensions:
- Department
- Product
- Market

Optional dimensions:
- Supplier
- Dim1–Dim4

Dimensions are shared across models but can be excluded per model.

---

## Historical references

- Last 12 months of actuals included by default
- Up to 5 additional historical reference columns supported
- Historical data sourced from sales forecast source fact data

---

## Long-term forecast

- Supports up to **5 years beyond next year**
- Year-total input only
- Automatically distributed using next-year forecast distribution

On forecast roll-forward:
- Next-year+1 totals are converted to monthly values automatically

---

## Forecast roll forward

- Source fact data is refreshed on roll-forward
- New dimension combinations are automatically added to the model
- Historical actuals are updated

---

## 4. Model configuration

Configured in **Sales Forecast Setup workbook → Sales forecast setup**.

Multiple input models can be created, processed, and published.

---

## Input models

### Create a new model
- Click **New**
- Define model ID and name
- Optionally copy from existing model

### Process a model
- Re-generates P&L transactions
- Required after structural or mapping changes

### Delete a model
Options:
- Delete data only
- Delete model and settings

### Publish a model
- Published models are editable via Forecast Summary
- Unpublished models remain accessible via admin

---

## Edit input model properties

Each model defines a list of measures.

Key properties:
- Driver (one per model)
- Input
- Lookup (assumptions)
- Calculation
- Rollup behavior
- Formatting and display order

Model changes should be:
- **Applied** (structure)
- **Processed** (P&L impact)

---

## Define calculations

Two calculation types:

### Cell calculations
- Simple arithmetic (+ − * /)
- Executed automatically
- Refer to measures using `[MeasureID]`

### Button-click calculations
- SQL-based
- Executed manually via **Recalculate**
- Marked visually in the UI

---

## Define dimensionality

- Department, Product, Market are mandatory
- Optional dimensions can be added
- Dimension members can be excluded per model

---

## Define historical reference columns

Available columns:
- Historic1–Historic5

Each defines:
- Dataset
- Date range
- Visibility

---

## Define measures

Measures are managed centrally.

Properties include:
- Assumption eligibility
- Currency handling
- Rollup behavior
- Formatting

System measures are owned by `$System`.

---

## Attach module to input report

The Sales Forecast module can be attached to:
- One or more Forecast Summary report lines

Attachment is defined using:
- Ranked department selection
- Report line ID
- Input model

---

## 5. Settings

### Assumptions

- Used for lookup measures
- Shared across models
- Maintained per:
  - Measure
  - Legal entity
  - Product
  - Market
  - Currency

Supports:
- Monthly values
- Long-term values (NY+1 to NY+5)

---

### Distribution keys

Defined by:
- Department
- Product
- Market
- Measure

Used to distribute year totals into months.

---

### Measure to account mapping

Any measure generating P&L transactions **must be mapped to an account**.

Mapping dimensions:
- Department
- Product
- Market
- Measure

---

### Auto transactions (optional)

Auto transactions generate additional postings based on rules.

Rule components:
- Measure
- Value
- Operator
- Optional condition
- Target account

Target department is inherited from source.

---

## 6. Data management

### Dimensions

- Product, Market, Supplier can be maintained locally
- Group levels supported
- Publishing required after changes

### Source fact data

- Maintained via **Hist. fact data**
- Used for:
  - Last 12 months actuals
  - Historical references

Mandatory fields:
- Department
- Product
- Market
- Year
- Month

Values must be in home currency.

New combinations are automatically added on forecast roll-forward.
