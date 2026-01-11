# Profitbase Planner – CapEx module

**Document:** Configuration and Operation – CapEx module  
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
| 20.05.2021 | 2.0 | TN | Revised for Planner v5 |
| 07.07.2022 | 3.0 | TN | Revised for Planner v5.2 |
| 06.12.2022 | 3.1 | TN | Revised for Planner v5.2.4 |
| 24.02.2023 | 3.2 | TN | Revised for Planner v5.4.0 |
| 24.06.2023 | 3.4 | TN | Revised for Planner v5.4.1 |
| 26.05.2025 | 3.5 | TN | Revised for Planner 6.1.0 |
| 09.09.2025 | 3.6 | TN | Revised for Planner 6.1.1 |

---

## 1. Abstract, intended audience and pre-requisites

This document is part of the *Profitbase Planner Configuration and Operation* series and describes configuration and operation of the **CapEx module**.

The intended audience is:
- Implementation partners
- Solution administrators

Pre-requisites:
- Profitbase Planner deployed
- User access to the solution

The CapEx module is included as a standard Profitbase Planner module.

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

Ranked input allows high-level dimensional selection:
- Higher rows = less specific
- Lower rows = more specific

Row order controls precedence.

---

## 3. Principle of operation

The CapEx module provides an input sheet for planning investments.

Based on the input, the module:
- Generates depreciation cost
- Maintains fixed asset balances
- Updates associated balance sheet accounts

---

## Plan by individual year

- Investments are entered per **year**
- Year is selected via filter
- **Copy data** can be used to copy investments from a previous year
- **Delete data** removes historical investment data via the Setup page

---

## Flexible organizational input level

- Investments can be entered at any organizational level
- Each investment must be attached to a **Department**
- If entered above department level:
  - Legal entity and department must be explicitly selected

Generated transactions can be inspected per row.

---

## Flexible input sheet

### Input columns

The input sheet can be configured based on contributor maturity.

Default behavior:
- Depreciation rate and depreciation start date are input fields

Alternative behavior:
- Contributor selects **Asset group**
- Depreciation rates and accounts are derived automatically from settings

---

## Dimensionality

Mandatory:
- Department
- Individual investment

Optional:
- Project
- Activity
- Asset group
- Dim1–Dim4

If CapEx settings are refined by asset group, **AssetGroupID must be visible** in the input sheet.

---

## Change dimensionality of an input row

If enabled, dimensionality can be changed via row context menu:
- Right-click dimensional column
- Select **Change dimensionality**
- Set new dimension values

---

## Investment status

Investment statuses control:
- Default value on new investments
- Inclusion in plan
- Filtering in CapEx and Plan Overview

Only one status may be marked as **Initial value**.

---

## 4. Module configuration

Configured in **Input Settings and Administration → Setup**.

---

## Publish and name module

Configurable options:
- Module name and translations
- Published flag
- Row context menu permissions:
  - Insert
  - Delete
  - Change dimensionality
- Input row limits
- Auto-load behavior on filter change

---

## Setup of the CapEx module

Configured in **CapEx workbook → Setup → Input model**.

---

## Column setup

Always-present columns:
- Investment description (Text)
- Amounts per month

Optional columns:
- AccountID (asset account override)
- DaysOfCredit
- DepreciationDateOvr
- DepreciationPctOvr
- ExternalRefID
- InvestmentStatusID
- VatPctOvr

Visibility controls whether a column is shown and editable.

---

## Dimension setup

Available dimensions:
- Project
- Activity
- AssetGroup
- Dim1–Dim4

For each dimension:
- Visibility
- Mandatory selection
- Filter usage
- Default filter value

Note:
- Counterparty dimensions only generate counter-postings in Sales (IC) and Loan (IC) engines.

---

## Translations

Translations are maintained in **Input Settings and Administration → Translations**.

---

## 5. Settings

Settings are defined in **CapEx workbook → Setup → Settings**.

---

## Investment Depreciation

Defines depreciation rules and posting accounts.

| Column | Description |
|---|---|
| Legal entity | Mandatory, ranked input |
| Asset group | Mandatory, ranked input |
| From date | Effective-from date |
| Depr % | Depreciation rate |
| Declining | Declining balance or straight line |
| Y1 = full year | Full-year depreciation flag |
| Residual value | Residual value |
| Account | Depreciation account |
| CAccount | Counter account |
| Comments | Optional |

---

## Investment Accounts

Defines asset and AP posting.

| Column | Description |
|---|---|
| Legal entity | Mandatory, ranked input |
| Asset group | Mandatory, ranked input |
| Fixed asset | Asset account |
| AP | Accounts payable |
| AgioDis | Optional agio/disagio |
| Comments | Optional |

---

## Declining Balance StopValue

Defines minimum residual value before:
- Remaining balance is depreciated in one operation

| Column | Description |
|---|---|
| Legal entity | Mandatory, ranked input |
| From date | Effective-from date |
| Stop value | Minimum residual value |
| Comments | Optional |
