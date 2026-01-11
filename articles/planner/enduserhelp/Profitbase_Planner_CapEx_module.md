# Profitbase Planner – CapEx module

**Document:** Configuration and Operation – CapEx module  
**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Version:** 1.0  
**Date:** 12.10.2020  

---

## Change log

| Date | Version | Changed by | Changes |
|---|---|---|---|
| 29.05.2020 | 0.0 | TN | Initial content |
| 12.10.2020 | 1.0 | TN | Revised |

---

## 1. Abstract, intended audience and pre-requisites

This document is part of the *Profitbase Planner Configuration and Operation* series and describes configuration and usage of the **CapEx module**.

The CapEx module is a standard Profitbase Planner module and is used in both **Budget** and **Forecast**.

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

Deleted rows are removed only after saving.

### Ranked input

Ranked input allows selecting higher-level dimensional nodes:
- Higher rows = less specific
- Lower rows = more specific

Used across configuration and settings tables.

---

## 3. Principle of operation

The CapEx module provides an input sheet for planning investments.

Based on input, the module:
- Generates depreciation cost
- Maintains fixed asset balances
- Updates associated balance sheet accounts

---

## Plan by individual year and dataset

- Investments are entered per **year**
- Dataset selector switches between **Budget** and **Forecast**
- Data can be copied from previous years using **Copy data**
- Only investments after plan start date are included

Old data can be removed using **Delete data** from the Setup page.

---

## Flexible organizational input level

- Investments can be entered at any organizational level
- Each investment must be attached to a **Department**
- If entered at higher level:
  - Legal Entity and Department must be selected explicitly

Generated transactions can be inspected per row.

---

## Flexible input sheet

### Input columns

The input sheet can be simplified or expanded depending on contributor skill level.

Default inputs:
- Depreciation start date
- Depreciation rate

Alternative setup:
- Select **Asset group**
- Depreciation rates and accounts derived automatically

---

## Dimensionality

Mandatory dimensions:
- Department
- Individual investment

Optional dimensions:
- Asset group
- Activity
- Dim1–Dim4

If CapEx settings are defined by asset group, **AssetGroupID must be visible** in the input sheet.

---

## Investment status

Investment statuses control:
- Default status
- Inclusion in plan
- Filtering in reports

Only one status may be set as the initial default.

---

## 4. Module configuration

Configured in **CapEx workbook → Setup**.

### Publish module
- Check **Published** to expose to users
- Uncheck to take offline

---

## Column setup

Always-present columns:
- Text (investment description)
- Amounts per month

Optional columns:
- Asset account override
- Days of credit
- Depreciation start date override
- Depreciation rate override
- VAT override
- External reference
- Investment status

---

## Dimension setup

Available dimensions:
- Activity
- AssetGroup
- Dim1–Dim4

Each dimension supports:
- Visibility toggle
- Mandatory selection

---

## Investment status setup

Status fields:
- Status ID
- Descriptions (default / EN / NO)
- Initial value (single allowed)
- Include in plan flag

Only statuses marked **Include in plan** affect official reports.

---

## 5. Settings

Configured in **CapEx workbook → Settings**.

---

## Investment depreciation

Defines depreciation rules and accounts.

Key fields:
- Legal entity
- Dataset
- Asset group
- Valid from date
- Depreciation rate
- Straight-line or declining balance
- Full-year handling
- Residual value
- Depreciation and counter accounts

---

## Investment accounts

Defines asset and AP posting.

Fields:
- Fixed asset account
- Accounts payable account
- Optional agio/disagio account

---

## Declining balance stop value

Defines minimum residual value before:
- Remaining balance is depreciated in one operation

Fields:
- Legal entity
- Dataset
- Valid from date
- Stop value

---

## Notes and best practices

- Avoid overly granular asset groups unless required
- Keep AssetGroup visible if used in settings
- Validate depreciation logic using generated transactions
