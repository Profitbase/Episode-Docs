# Profitbase Planner – Account module

**Document:** Configuration and Operation – Account module  
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
| 18.08.2021 | 2.1 | TN | Revised for Planner v5 |
| 04.10.2021 | 2.2 | TN | Revised for Planner v5 final |
| 07.07.2022 | 3.0 | TN | Revised for Planner v5.2 |
| 05.12.2022 | 3.1 | TN | Revised for Planner v5.2.4 |
| 24.02.2023 | 3.2 | TN | Revised for Planner v5.4.0 |
| 24.06.2023 | 3.4 | TN | Revised for Planner v5.4.1 |
| 26.05.2025 | 3.5 | TN | Revised for Planner 6.1.0 |

---

## 1. Abstract, intended audience and pre-requisites

The Account module is an operational input module used to plan costs and revenues directly on accounts.

It transforms user input into P&L transactions that are processed and shown in the Plan Overview.

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

Row deletion is finalized only after saving.

### Ranked input

Ranked input allows selecting higher-level dimension members:
- Higher rows = less specific
- Lower rows = more specific

Row order determines precedence.

---

## 3. Principle of operation

### Plan by year-totals or by month

Input mode is controlled by the **Periods** button.

**Year-total input**
- Automatically distributed to months
- Distribution priority:
  1. User-entered monthly values
  2. Central distribution key tied to the account
  3. Even distribution

**Monthly input**
- Monthly values are summed to yearly total
- Monthly pattern becomes the future distribution key

Distribution keys can be viewed and restored per row.

---

## Dimensionality

Mandatory:
- Department
- Account

Optional:
- Project
- Activity
- Counterparty
- Currency foreign
- Dim1–Dim4

Multi-currency planning is enabled by showing the Currency foreign dimension.

---

## Change dimensionality of an input row

If enabled, dimensionality can be changed via row context menu:
- Right-click dimensional column
- Select **Change dimensionality**
- Choose new dimension members

---

## Historical references and deviation calculations

Default:
- Last 12 months of actuals

Controlled by base setting:
- `AccountIgnoreActualsL12M` (default FALSE)

Optional:
- Up to 5 historical reference columns
- Up to 2 deviation columns

Deviation formulas may reference:
- Historic1–Historic5
- YTD, ROY, TY, NY
- L12M, N12M
- NYPlus1–NYPlus5

---

## Planning horizon

- Defined globally in **Finance Settings**
- Applies to all input modules
- Long-term planning supports year-total input only

Long-term totals are distributed using next-year patterns.

---

## Plan roll forward actions

- Long-term year totals are converted to monthly values
- Distribution is inherited from next-year plan

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

Optional dimensions can be configured with:
- Visibility
- Mandatory selection
- Filter usage
- Default filter values
- Source data grouping

Grouping source data aggregates historical references.

---

## Select, name, and define historical reference columns

Historical data source:
- `ReportAccountByMonthHistorical`

Configurable per column:
- Dataset
- Date range
- Visibility in summary, input, and reports

---

## Select, name, and define deviation columns

Deviation columns support simple arithmetic formulas.

Examples:
```
[NY] - [TY]
[Historic1] - [Historic2]
```

---

## Select / unselect optional columns

Optional columns related to:
- Actuals last 12 months
- Year-to-date
- Rest of year

Visibility can be controlled separately for summary and input.

---

## Translations

Translations are maintained in **Input Settings and Administration → Translations**.

---

## Attach module to input report

The Account module is the default module.

It is attached to any report line not explicitly attached to another module.

---

## Period filters

Period filters are configured globally and control:
- Available filters
- Default selection
- Sorting

---

## Disabling the Periods button

The Periods button can be disabled via:
- `AccountPeriodsButton = DISABLED`

When disabled:
- Only year-total input is allowed
- Period filter for next 12 months cannot be used

---

## 5. Module settings

Settings are maintained in **Input Settings and Administration → Settings**.

---

## Distribution keys

Defined by:
- Department
- Account

Rules:
- Use ranked input
- Avoid overly specific keys

Distribution weight determines monthly allocation.

---

## Distribution key helper

The **View Historic Distribution** helper:
- Displays historical monthly distributions
- Supports aggregation using ranked input
- Allows copying values into distribution keys

---

## Override distribution using historic data

Historic distributions can be converted into distribution keys.

Use carefully:
- Generates many specific keys
- User monthly input always overrides keys

---

## Auto transactions (optional)

Rule-based additional postings.

Rule components:
- Source department
- Source account
- Operator and value
- Optional condition
- Target account
- Optional target department

---

## 6. High-level planning with the Account module

High-level planning is supported by aggregating historical data.

Requirements:
- Disable grouping on selected dimensions
- Provide default:
  - Account per report line
  - Department per legal entity

Historical data is aggregated to defaults while still allowing later detail expansion.
