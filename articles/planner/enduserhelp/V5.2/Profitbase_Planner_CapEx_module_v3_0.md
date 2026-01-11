# Profitbase Planner – CapEx module

**Document:** Configuration and Operation – CapEx module  
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
| 20.05.2021 | 2.0 | TN | Revised for Planner v5 |
| 07.07.2022 | 3.0 | TN | Revised for Planner v5.2 |

---

## 1. Abstract, intended audience and pre-requisites

This document is part of the *Profitbase Planner Configuration and Operation* series and describes configuration and operation of the **CapEx module**.

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

- Investments are entered **per year**
- Year is selected using the year filter
- **Copy data…** copies investments from a previous year
- **Delete data…** removes historical investment data via Setup

Only investments after the plan start date are included.

---

## Flexible organizational input level

- Investments can be entered at any organizational level
- Each investment must be attached to a **Department**

Behavior:
- If entered at department level, the department is assumed automatically
- If entered above department level:
  - Legal entity and department columns become visible
  - Valid values must be selected explicitly

Generated transactions can be inspected per input row.

---

## Flexible input sheet

### Input columns

Default behavior:
- Depreciation rate and depreciation start date are input directly

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
- AssetGroup
- Dim1–Dim4

**Important rule**  
If CapEx settings are refined by asset group, **AssetGroupID must be visible** in the input sheet.

---

## Investment status

Investment statuses control:
- Default status for new investments
- Inclusion in plan
- Filtering in CapEx and Plan Overview

Only one status may be marked as **Initial value**.

---

## 4. Module configuration

Configured in **Input Settings and Administration → Setup** and **CapEx workbook → Setup**.

---

## Publish and name module, control row context menu

Configurable options:
- Published flag
- Insert row permission
- Delete row permission
- Change dimensionality permission

Restrictions can optionally depend on whether rows contain actuals.

---

## Setup of the CapEx module

Module-specific configuration is done in the **CapEx workbook → Setup → Input model** tab.

---

## Column setup

Always present:
- Text (investment description)
- Amounts per month

Optional columns:
- AccountID (asset account override)
- DaysOfCredit
- DepreciationDateOvr
- DepreciationPctOvr
- ExternalRefID
- InvestmentStatusID
- VatPctOvr

Visibility controls whether columns are shown and editable.

---

## Dimension setup

Available dimensions:
- Project
- Activity
- AssetGroup
- Dim1–Dim4

Each dimension supports:
- Visibility in input worksheet
- Mandatory selection

---

## Investment status setup

Defines:
- InvestmentStatusID
- Descriptions (default / EN / NO)
- Initial value (single allowed)
- Include in plan flag

Only statuses marked **Include in plan** affect official reports.

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

**Note**  
If settings are refined by asset group, AssetGroupID must be visible in the input sheet.

---

## Investment Accounts

Defines asset and accounts payable posting.

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
