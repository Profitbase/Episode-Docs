# Profitbase Planner – CapEx module

**Document:** Configuration and Operation – CapEx module  
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
| 20.05.2021 | 2.0 | TN | Revised for Planner v5 |
| 07.07.2022 | 3.0 | TN | Revised for Planner v5.2 |
| 06.12.2022 | 3.1 | TN | Revised for Planner v5.2.4 |
| 24.02.2023 | 3.2 | TN | Revised for Planner v5.4.0 |

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

Editable fields have white background.

### Ranked input

Ranked input allows selection of higher-level dimension members.

Rules:
- Less specific rows must be higher
- More specific rows must be lower

Row order determines precedence.

---

## 3. Principle of operation

The CapEx module provides an input sheet to plan investments and automatically:
- Generates depreciation costs
- Maintains balance sheet asset accounts
- Maintains depreciation counter accounts

---

## Plan by individual year

- Investments are entered **per year**
- Year selected via year filter
- **Copy data…** copies investments from a previous year
- **Delete data…** removes historical investment data from Setup

Only investments after plan start are included.

---

## Flexible organizational input level

- Investments can be entered at any organizational level
- Each investment must be attached to a **Department**

Behavior:
- If department is selected, it is assumed automatically
- If input is done above department:
  - Legal entity and department columns become mandatory

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

**Important:**  
If CapEx settings are refined by asset group, **AssetGroupID must be visible** in the input sheet.

---

## Investment status

Investment statuses control:
- Default status for new investments
- Inclusion in plan
- Filtering

Only one status may be marked as **Initial value**.

---

## 4. Module configuration

Configured in **Input Settings and Administration → Setup** and **CapEx workbook → Setup**.

---

## Publish and name module, control row context menu

Configurable options:
- Published
- Insert row
- Delete row
- Delete only if no actuals
- Change dimensionality
- Multi-department input (always true)
- Input row limit
- Auto-load on filter change

---

## Setup of the CapEx module

Configured in **CapEx workbook → Setup → Input model**.

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
- Visibility
- Mandatory selection
- Filter usage
- Filter selection mandatory

Note on counterparty:
Counterparty dimensions only generate counter-transactions in Sales (IC) and Loan (IC).

---

## Investment status setup

Defines:
- InvestmentStatusID
- Translations
- Initial value (single)
- Include in plan flag

Only statuses marked **Include in plan** affect official reports.

---

## 5. Settings

Defined in **CapEx workbook → Setup → Settings**.

---

## Investment Depreciation

Defines depreciation rules and posting accounts.

| Column | Description |
|---|---|
| Legal entity | Mandatory, ranked |
| Asset group | Mandatory, ranked |
| From date | Effective-from |
| Depr % | Depreciation rate |
| Declining | Declining or straight line |
| Y1 = full year | Full-year depreciation |
| Residual value | Residual value |
| Account | Depreciation account |
| CAccount | Counter account |
| Comments | Optional |

If settings are refined by asset group, AssetGroupID must be visible in input.

---

## Investment Accounts

Defines asset and AP posting.

| Column | Description |
|---|---|
| Legal entity | Mandatory |
| Asset group | Mandatory |
| Fixed asset | Asset account |
| AP | Accounts payable |
| AgioDis | Optional |
| Comments | Optional |

---

## Declining Balance StopValue

Defines minimum residual value before remaining balance is depreciated in one operation.

| Column | Description |
|---|---|
| Legal entity | Mandatory |
| From date | Effective-from |
| Stop value | Minimum residual value |
| Comments | Optional |
