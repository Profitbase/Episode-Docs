# Profitbase Planner – Account module

**Document:** Configuration and Operation – Account module  
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

This document is part of the *Profitbase Planner Configuration and Operation* documentation set
and describes configuration and usage of the **Account module**.

The Account module is a standard Profitbase Planner module and exists in two variants:
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

Deleted rows are only removed after saving.

### Ranked input

Ranked input allows selecting higher-level dimensional nodes:
- Higher rows = less specific
- Lower rows = more specific

Used consistently across configuration tables.

---

## 3. Principle of operation

### Plan by year totals or by month

Input mode is controlled by the **Periods** toggle.

**Year-total input**
- Automatically distributed to months
- Distribution logic:
  1. User-entered monthly values
  2. Central distribution key (if defined)
  3. Even distribution

**Monthly input**
- Monthly values are summed to yearly total
- Monthly pattern becomes future distribution

---

## Dimensionality

Mandatory dimensions:
- Department
- Account

Optional dimensions:
- Dim1–Dim4

---

## Historical references and deviation calculations

Forecast version includes:
- Last 12 months of actuals by default

Optional additions:
- Up to 5 historical reference columns
- Simple deviation columns based on formulas

Historical data is sourced from:
- `ReportAccountByMonthHistorical`

---

## Long-term forecast

- Supports up to **5 additional years**
- Year-total input only
- Automatically distributed using next-year forecast distribution

During forecast roll-forward:
- Next-year+1 totals are converted to monthly values automatically

---

## 4. Module configuration

### Publish and name module

Configured in **Input Settings and Administration → Setup**.

Key fields:
- Input module
- Dataset (Budget | Forecast)
- Published flag
- Module name (default, EN, NO)

Unpublished modules can still be edited via admin action link.

---

## Select additional dimensionality

Additional dimensions:
- Dim1
- Dim2
- Dim3
- Dim4

For each dimension:
- Visibility in input sheet
- Mandatory selection flag

---

## Select, name, and define historical reference columns

Configured per process (Budget or Forecast).

Available columns:
- Historic1–Historic5

Each reference defines:
- Dataset source
- Date range
- Column labels
- Visibility in summary and account detail views

---

## Select, name, and define deviation columns

Available columns:
- Deviation1–Deviation2

Deviation formulas use:
- Internal column IDs
- Operators: + - * /

Example:
```
Deviation = Historic1 - Historic2
```

---

## Attach module to input report

The Account module is the default module.

It is automatically attached to:
- All report lines not explicitly attached to another module

---

## 5. Module settings

Settings are configured per process:
- Budget settings
- Forecast settings

### Distribution keys

Defined by:
- Department
- Account

Rules:
- Use ranked input
- Avoid overly specific keys
- Prefer higher-level aggregation

---

## Distribution key helper

The **View Historic Distribution** helper:
- Displays historical monthly distributions
- Allows copying historic patterns into distribution keys

Useful for aligning forecasts with past behavior.

---

## Override distribution using historic data

Allows generating distribution keys directly from historical data.

Configuration requires:
- Department selection
- Account selection
- Dataset
- Relative year range

Use carefully to avoid excessive key granularity.

---

## Auto transactions (optional)

Auto transactions generate additional transactions based on rules.

Rule components:
- Department
- Account
- Value
- Operator
- Optional condition
- Target account

Supported operators:
- ==
- >=
- >
- <=
- <
- &&
- ||

Target department is always inherited from the source transaction.
