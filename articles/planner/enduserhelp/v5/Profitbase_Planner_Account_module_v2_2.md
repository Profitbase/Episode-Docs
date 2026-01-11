# Profitbase Planner – Account module

**Document:** Configuration and Operation – Account module  
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
| 18.08.2021 | 2.1 | TN | Revised for Planner v5 |
| 04.10.2021 | 2.2 | TN | Revised for Planner v5 final |

---

## 1. Abstract, intended audience and pre-requisites

The Account module is an operational input module used to plan costs and revenues directly on accounts.
Input provided by contributors is transformed into P&L transactions and returned to the Plan Overview.

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

Ranked input allows selection of higher-level dimension members.
Less specific rows should be placed higher; more specific rows lower.
Row order controls precedence.

---

## 3. Principle of operation

### Plan by year-totals or by month

Input mode is controlled by the **Periods** button.

**Year-total input**
- Distributed to months using:
  1. User-entered monthly pattern
  2. Central distribution key tied to the account
  3. Even distribution

**Monthly input**
- Monthly values are summed to yearly total
- Monthly pattern becomes the future distribution key

Distribution keys can be viewed per row.

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

## Historical references and deviation calculations

- Preset with last 12 months of actuals
- Up to 5 historic reference columns can be added
- Up to 2 deviation columns can be defined

Deviation formulas may reference:
Historic1–Historic5, YTD, ROY, TY, NY, L12M, N12M, NYPlus1–NYPlus5

Example:
```
[NY] - [TY]
```

---

## Planning horizon

Defined in **Finance Settings** and applies to all input modules.

Long-term planning:
- Year-total input only
- Distributed using next-year patterns

---

## Plan roll forward actions

- Long-term totals for NY+1 are distributed to months using next-year distribution on rollover

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

## Select additional dimensionality

Optional dimensions can be configured with:
- Visibility
- Mandatory selection
- Group source data
- Default values

Grouping source data controls aggregation of historical references.

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

Deviation columns perform arithmetic between existing columns.
Supported operators: + − * /

---

## Select / unselect optional columns

Optional columns related to:
- Actuals last 12 months
- Year-to-date
- Rest of year

Visibility can differ between summary and input.

---

## Attach module to input report

The Account module is the default module.
It is attached to any report line not explicitly attached to another module.

---

## Additional input filters (slicers)

Optional slicers:
- Project
- Activity

Configuration is global to all input modules and Plan Overview.

---

## Period filters

Configured globally.
Controls available filters, default selection, and sorting.

---

## Disabling the Periods button

The Periods button can be disabled via:
`AccountPeriodsButton = DISABLED`

When disabled:
- Only year-total input is allowed
- Next 12 months period filter cannot be used

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
- Supports aggregation via ranked input
- Allows copying values into distribution keys

---

## Override distribution using historic data

Historic distributions can be converted into distribution keys.
Use with care, as this generates many specific keys.

User monthly input always overrides keys.

---

## Auto transactions (optional)

Rule-based additional postings.

Rule components:
- Source department
- Source account
- Operator and value
- Optional condition
- Target account

Logical operators supported:
- &&
- ||

---

## 6. High-level planning with the Account module

High-level planning is enabled by aggregating historical data.

Requirements:
- Disable grouping mandates in Base settings
- Define:
  - Default account per INPUT report line
  - Default department per legal entity

Historical data is aggregated to defaults while still allowing later detail expansion.
