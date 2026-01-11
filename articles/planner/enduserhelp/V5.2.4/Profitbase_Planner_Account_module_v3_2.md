# Profitbase Planner – Account module

**Document:** Configuration and Operation – Account module  
**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Version:** 3.2  
**Date:** 24.02.2023  

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

---

## 1. Abstract, intended audience and pre-requisites

The Profitbase Planner Configuration and Operation series describes configuration and operation of individual Planner modules.

Planner modules are operational input modules used by contributors to prepare their part of the Profit & Loss.

Modules are accessed from the **Plan Overview** workbook. User input is transformed into P&L transactions and fed back to Plan Overview as a work-in-progress P&L.

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

Editable fields have white background.

### Ranked input

Ranked input allows selecting higher-level dimension members.

Rules:
- Less specific rows must be higher
- More specific rows must be lower

Row order determines precedence.

---

## 3. Principle of operation

### Plan by year-totals or by month

Input modes:
- Year totals
- Monthly values

Controlled via the **Periods** button.

Year totals are distributed to months using:
1. User-defined monthly input
2. Central distribution key tied to the account
3. Even distribution

Monthly input defines the distribution used for future year-total input.

Default distribution can be restored using **Restore default key**.

---

### Dimensionality

Mandatory:
- Department
- Account

Optional:
- Project
- Activity
- Counterparty
- Dim1–Dim4
- Currency foreign

Currency foreign is logically mandatory, but visibility is configurable.

---

### Change dimensionality of an input row

If enabled:
- Right-click a dimensional column
- Select **Change dimensionality**
- Choose new dimension members

---

### Historical references and deviation calculations

Defaults:
- Last 12 months of actuals

Optional:
- Historic1–Historic5
- Deviation1–Deviation2

Deviation formulas support:
YTD, ROY, TY, NY, L12M, N12M, NYPlus1–NYPlus5.

---

### Planning horizon

Defined in **Finance Settings**.

Long-term planning:
- Year-total input only
- Totals distributed using next-year distribution

---

### Plan roll forward actions

- Next-year+1 totals distributed using next-year patterns
- Historical references refreshed

---

## 4. Module configuration

Configured in **Input Settings and Administration → Setup**.

---

## Publish and name module, control row context menu

Configurable options:
- Published
- Insert row
- Delete row
- Delete only if no actuals
- Change dimensionality

---

## Select additional dimensionality

Optional dimensions support:
- Visibility
- Mandatory selection
- Filter usage
- Group source data

Grouping source data aggregates historical references.

Currency foreign:
- Always mandatory
- Visibility controls whether planning is multi-currency

Counterparty note:
Only Sales (IC) and Loan (IC) engines generate counter transactions.

---

## Historical reference columns

Configured in **Account – Historic Reference Columns**.

Properties:
- Dataset
- Date range
- Visibility in summary, input, report

---

## Deviation columns

Configured in **Account – Deviation Columns**.

Formulas reference internal column IDs:
```
[NY] - [TY]
```

---

## Optional columns

Optional columns related to:
- L12M actuals
- YTD
- ROY

Visibility configurable.

---

## Attach module to input report

Account module is the default module.

Any report line not explicitly mapped to another module uses Account.

---

## Additional input filters (slicers)

Standard:
- Department

Optional:
- Project
- Activity

Configured globally.

---

## Period filters

Configured globally in **Period filters**.

Controls:
- Visibility
- Default filter
- Sorting

---

## Disabling the Periods button

Configured via **Distributed Input Settings**:
```
AccountPeriodsButton = DISABLED
```

If disabled:
- Only year-total input is allowed
- Period filter for next 12 months cannot be used

---

## 5. Module settings

Configured in **Input Settings and Administration → Settings**.

---

## Distribution keys

Defined by:
- Department
- Account

Ranked input is used.

Guideline:
Avoid overly specific keys.

---

## Distribution key helper

Allows viewing historic distributions to assist setup.

---

## Override distribution using historic data

Historic distributions can be converted into distribution keys.

Use with caution:
- Can generate many specific keys
- Users can override via monthly input

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

High-level planning is enabled by:
- Grouping source data
- Default dimensional values

Requirements:
- Default account per INPUT report line
- Default department per legal entity

Historical data is aggregated, while still allowing later detail expansion.
