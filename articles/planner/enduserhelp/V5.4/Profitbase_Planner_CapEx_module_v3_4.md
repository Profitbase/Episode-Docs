# Profitbase Planner – CapEx module

**Document:** Configuration and Operation – CapEx module  
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
| 20.05.2021 | 2.0 | TN | Revised for Planner v5 |
| 07.07.2022 | 3.0 | TN | Revised for Planner v5.2 |
| 06.12.2022 | 3.1 | TN | Revised for Planner v5.2.4 |
| 24.02.2023 | 3.2 | TN | Revised for Planner v5.4.0 |
| 24.06.2023 | 3.4 | TN | Revised for Planner v5.4.1 |

---

## 1. Abstract, intended audience and pre-requisites

This document describes configuration and operation of the **CapEx module** in Profitbase Planner.

Target audience:
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

The CapEx module provides an input sheet for planning investments.

Based on input, the module:
- Generates depreciation cost
- Maintains balance sheet asset accounts
- Maintains associated counter accounts

---

## Plan by individual year

- Investments are entered per **year**
- Year is selected via filter
- **Copy data** copies investments from a previous year
- **Delete data** removes historical data via the Setup page

Only investments after the plan start date are included.

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

Default behavior:
- Depreciation rate and depreciation start date are input fields

Alternative behavior:
- Contributor selects **Asset group**
- Depreciation rates and accounts are derived automatically

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

If settings are refined by asset group, **AssetGroupID must be visible** in the input sheet.

---

## Investment status

Investment statuses control:
- Default value for new investments
- Inclusion in plan
- Filtering in CapEx and Plan Overview

Only one status may be marked as **Initial value**.

---

## 4. Module configuration

Configured in **Input Settings and Administration → Setup** and **CapEx workbook → Setup**.

---

## Publish and name module, control row context menu options

Configurable options:
- Published flag
- Insert / Delete / Change dimensionality permissions
- Multi-department input (always true)
- Input row limit
- Auto-load on filter change
- Auto-submit data

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

---

## Dimension setup

Available dimensions:
- Project
- Activity
- AssetGroup
- Dim1–Dim4

Each dimension supports:
- Visibility
- Mandatory selection
- Filter usage

---

## Translations

Maintained in **Input Settings and Administration → Translations**.

---

## 5. Settings

Settings are defined in **CapEx workbook → Setup → Settings**.

---

## Investment Depreciation

Defines depreciation rules and posting accounts.

| Column | Description |
|---|---|
| Legal entity | Mandatory, ranked |
| Asset group | Mandatory, ranked |
| From date | Effective-from date |
| Depr % | Depreciation rate |
| Declining | Declining balance or straight line |
| Y1 = full year | Full-year depreciation |
| Residual value | Residual value |
| Account | Depreciation account |
| CAccount | Counter account |
| Comments | Optional |

---

## Investment Accounts

Defines asset and AP posting.

| Column | Description |
|---|---|
| Legal entity | Mandatory, ranked |
| Asset group | Mandatory, ranked |
| Fixed asset | Asset account |
| AP | Accounts payable |
| AgioDis | Optional agio/disagio |
| Comments | Optional |

---

## Declining Balance StopValue

Defines minimum residual value before remaining balance is depreciated in one operation.

| Column | Description |
|---|---|
| Legal entity | Mandatory, ranked |
| From date | Effective-from date |
| Stop value | Minimum residual value |
| Comments | Optional |
