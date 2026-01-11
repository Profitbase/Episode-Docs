# Profitbase Planner – Account module

**Document:** Configuration and Operation – Account module  
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
| 18.08.2021 | 2.1 | TN | Revised for Planner v5 |
| 04.10.2021 | 2.2 | TN | Revised for Planner v5 final |
| 07.07.2022 | 3.0 | TN | Revised for Planner v5.2 |

---

## 1. Abstract, intended audience and pre-requisites

The Account module is an operational input module used to plan values directly on **accounts**.
It is part of the Profitbase Planner Configuration and Operation document series.

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

Editable cells are shown with a white background.

### Ranked input

Ranked input allows selecting high-level dimension members.
Less specific rows must be placed higher, more specific rows lower.
Row order defines precedence.

---

## 3. Principle of operation

### Plan by year-totals or by month

Input can be done as:
- Year totals
- Monthly values

Controlled by the **Periods** button.

Year-total input is distributed to months using:
1. User-entered monthly values
2. Central distribution key tied to the account
3. Even distribution

Monthly input defines the distribution used for future year-total input.

Default distribution can be restored via **Restore default key**.

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
- Currency foreign (optional visibility)

Currency foreign is always mandatory logically, but visibility is configurable.

---

### Change dimensionality of an input row

If enabled:
- Right-click a dimensional column
- Select **Change dimensionality**
- Choose new dimensional members

---

### Historical references and deviation calculations

Defaults:
- Last 12 months of actuals

Optional:
- Up to 5 historical reference columns (Historic1–Historic5)
- Up to 2 deviation columns (Deviation1–Deviation2)

Deviation formulas support:
YTD, ROY, TY, NY, L12M, N12M, NYPlus1–NYPlus5.

---

### Planning horizon

Defined globally in **Finance Settings**.

Long-term planning:
- Year-total input only
- Totals distributed using next-year distribution

---

### Plan roll forward actions

- Next-year+1 totals distributed using next-year pattern
- Historical references refreshed automatically

---

## 4. Module configuration

Configured in **Input Settings and Administration → Setup**.

---

## Publish and name module, control row context menu

Configurable:
- Published
- Insert row
- Delete row
- Delete only if no actuals
- Change dimensionality

---

## Select additional dimensionality

Optional dimensions can be enabled and configured with:
- Visibility
- Mandatory selection
- Group source data

Grouping source data aggregates historical references.

---

## Historical reference columns

Configured in **Account – Historic Reference Columns**.

Properties:
- Dataset
- Date range
- Visibility (summary, input, report)

---

## Deviation columns

Configured in **Account – Deviation Columns**.

Formulas reference internal column IDs, e.g.:
```
[NY] - [TY]
```

---

## Optional columns

Optional columns related to:
- Last 12 months actuals
- Year-to-date
- Rest of year

Visibility configurable per workbook.

---

## Attach module to input report

The Account module is the default module.
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

Configured globally in **Period filters** table.

Controls:
- Visibility
- Default filter
- Sorting

---

## Disable Periods button

Configured via **Distributed Input Settings** by setting:
```
AccountPeriodsButton = DISABLED
```

---

## 5. Module settings

Configured in **Input Settings and Administration → Settings**.

---

## Distribution keys

Defined by:
- Department
- Account

Uses ranked input.
Avoid overly specific keys.

---

## Distribution key helper

Allows viewing historic distributions to assist setup.

---

## Override distribution using historic data

Historic transaction distributions can be converted into distribution keys.

Use with caution:
- Can generate very specific keys
- Users can always override via monthly input

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

High-level planning is supported by:
- Grouping source data
- Using default values

Requirements:
- Default account per INPUT report line
- Default department per legal entity

Historical data is aggregated accordingly, while still allowing detailed planning if needed.
