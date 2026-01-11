# Profitbase Planner – CapEx module

**Document:** Configuration and Operation – CapEx module  
**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Version:** 2.0  
**Date:** 20.05.2021  

---

## Change log

| Date | Version | Changed by | Changes |
|---|---|---|---|
| 29.05.2020 | 0.0 | TN | Initial content |
| 12.10.2020 | 1.0 | TN | Revised |
| 20.05.2021 | 2.0 | TN | Revised for Planner v5 |

---

## 1. Abstract, intended audience and pre-requisites

This document describes configuration and operation of the **CapEx module**.

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
- **Ctrl + Z** undoes last unsaved change

### Row operations
- Insert row
- Insert row below
- Insert copy of row
- Delete row

Row deletion takes effect only after saving.

### Ranked input

Ranked input allows selecting higher-level dimension members.

Rules:
- Less specific rows should be placed higher
- More specific rows should be placed lower

Row order controls precedence.

---

## 3. Principle of operation

The CapEx module provides an input sheet for planning investments.

Based on input, the module:
- Generates depreciation cost
- Maintains balance sheet asset accounts
- Maintains related counter accounts

---

## Plan by individual year

- Investments are entered **per year**
- Year is selected via filter
- **Copy data** copies investments from a previous year
- **Delete data** removes historical investment data via Setup

Only investments after the plan start date are included.

---

## Flexible organizational input level

- Investments can be entered at any organizational level
- Each investment must be tied to a **Department**
- If entered above department level:
  - Legal Entity and Department must be selected explicitly

Generated transactions can be inspected per input row.

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
- Default value on new investments
- Inclusion in plan
- Filtering in CapEx and Plan Overview

Only one status may be marked as **Initial value**.

---

## 4. Module configuration

Configured in **CapEx workbook → Setup → Input model**.

---

## Publish module

- Check **Published** to expose module to users
- Uncheck to take the module offline

---

## Column setup

Always-present columns:
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

For each dimension:
- Visibility
- Mandatory selection

---

## Investment status setup

Status fields:
- InvestmentStatusID
- Descriptions (default / EN / NO)
- Initial value (single allowed)
- Include in plan flag

Only statuses marked **Include in plan** affect official reports.

---

## 5. Settings

Settings are maintained in **CapEx workbook → Setup → Settings**.

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

Defines minimum residual value before remaining balance is depreciated in one operation.

| Column | Description |
|---|---|
| Legal entity | Mandatory, ranked input |
| From date | Effective-from date |
| Stop value | Minimum residual value |
| Comments | Optional |
