# Profitbase Planner – Account module

**Document:** Configuration and Operation – Account module  
**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Version:** 3.4  
**Date:** 24.06.2023  

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

---

## 1. Abstract, intended audience and pre-requisites

The Account module is an operational input module used to plan costs and revenues directly on accounts.

Input provided by contributors is transformed into P&L transactions and returned to the Plan Overview workbook as a work-in-progress P&L.

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

Row deletion must be saved to take effect.

### Ranked input

Ranked input allows high-level selection of dimension members.

Rules:
- Less specific rows must be placed higher
- More specific rows must be placed lower

Row order determines precedence.

---

## 3. Principle of operation

### Plan by year-totals or by month

Input mode is controlled by the **Periods** button.

**Year-total input**
- Automatically distributed to months using:
  1. User-entered monthly values
  2. Central distribution key tied to the account
  3. Even distribution

**Monthly input**
- Monthly values are summed to a yearly total
- Monthly pattern becomes the future distribution key

Default distributions can be restored per row using **Restore default key**.

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

Enabling Currency foreign allows multi-currency planning.

---

## Change dimensionality of an input row

If enabled, dimensionality can be changed by:
- Right-clicking a dimensional column
- Selecting **Change dimensionality**
- Choosing new dimension values

---

## Historical references and deviation calculations

- Preset with last 12 months of actuals
- Up to 5 historical reference columns supported
- Up to 2 deviation columns supported

Deviation formulas may reference:
Historic1–Historic5, YTD, ROY, TY, NY, L12M, N12M, NYPlus1–NYPlus5

Example:
```
[NY] - [TY]
```

---

## Planning horizon

Defined globally in **Finance Settings**.

Long-term planning:
- Year-total input only
- Long-term totals distributed using next-year patterns

---

## Plan roll forward actions

- Long-term totals for NY+1 are distributed to months using next-year distribution on rollover

---

## 4. Module configuration

Configured in **Input Settings and Administration → Setup**.

---

## Publish and name module, control row context menu

Configurable options:
- Published flag
- Row context menu permissions:
  - Insert
  - Delete
  - Change dimensionality
- Multi-department input
- Input row limit
- Auto-load on filter change
- Auto-submit data

---

## Select additional dimensionality

Optional dimensions support:
- Visibility
- Mandatory selection
- Group source data
- Input module filters
- Plan Overview filters

Grouping source data controls aggregation of historical reference data.

---

## Select, name, and define historical reference columns

Historical source:
- `ReportAccountByMonthHistorical`

Configurable:
- Dataset
- Date range
- Visibility in summary, input, and reports

---

## Select, name, and define deviation columns

Deviation columns support simple arithmetic:
- + − * /

Supported internal references:
Historic1–Historic5, YTD, ROY, TY, NY, L12M, N12M, NYPlus1–NYPlus5

---

## Select / unselect optional columns

Optional columns related to:
- Actuals last 12 months
- Year-to-date
- Rest of year

Visibility can differ between summary and input.

---

## Translations

Translations are managed in **Input Settings and Administration → Translations**.

---

## Attach module to input report

The Account module is the default input module.

Any report line not explicitly attached to another module will use the Account module.

---

## Period filters

Configured globally in **Input Settings and Administration → Setup**.

Controls:
- Available filters
- Default filter
- Sorting

---

## Disabling the Periods button

The Periods button can be disabled using:
```
AccountPeriodsButton = DISABLED
```

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

Monthly distribution is calculated as:
```
Month weight / Sum of all month weights
```

---

## Distribution key helper

The **View Historic Distribution** helper:
- Displays historical monthly distributions
- Supports aggregation via ranked input
- Allows copying values into distribution keys

---

## Override distribution using historic data

Historic distributions can be converted into distribution keys.

Use with care:
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

Supported operators:
==, >=, >, <=, <, &&, ||

---

## 6. High-level planning with the Account module

High-level planning is achieved by aggregating historical data.

Requirements:
- Disable grouping mandates in Base settings
- Define:
  - Default account per INPUT report line
  - Default department per legal entity

Historical data is aggregated to defaults while still allowing later detailed expansion.
