# Profitbase Planner – Sales by GM module

**Document:** Configuration and Operation – Sales by GM module  
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

This document is part of the *Profitbase Planner Configuration and Operation* series and describes configuration and usage of the **Sales by GM** module.

Planner modules are input modules used in Budget and Forecast processes to build the Profit & Loss statement.  
The Sales by GM module is a **standard module** and is **specific to the Budget process**.

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

Deleted rows are only removed after saving.

### Ranked input
Ranked input allows selecting higher-level dimensional nodes.

- Higher rows = less specific
- Lower rows = more specific

Used across settings and configuration tables.

---

## 3. Principle of operation

The Sales by GM module lets users plan:
- Sales amounts
- Gross Margin %
- Additional sales-driven income or cost

Based on input, the module generates:
- Sales transactions
- Cost of Goods Sold (COGS) transactions

### Plan by year totals or by month

Input mode is controlled by the **Periods** toggle.

**Year-total input behavior**
- Automatically distributed across months
- Distribution logic:
  1. Monthly values entered by user
  2. Central distribution key (if defined)
  3. Even distribution

**Monthly input**
- Monthly values are summed to yearly total
- Monthly pattern becomes the distribution key

### GM% handling

- Default input is yearly GM%
- Can be overridden per month
- COGS calculation:

```
COGS = Sales * ((100 - GM%) / 100)
```

---

## Dimensionality

Mandatory dimensions:
- Department
- Product
- Market

Optional dimensions:
- Supplier
- Dim1–Dim4

---

## Additional input columns driven by sales

Up to **5 additional input columns** can be defined.

Characteristics:
- Entered as % of sales
- Inherit monthly distribution from sales
- Generate P&L transactions if mapped to accounts

---

## 4. Module configuration

### Publish and name module

Configured in **Input Settings and Administration → Setup**.

Key fields:
- Input module
- Dataset (Budget | Forecast)
- Published
- Module name (default, EN, NO)

### Define dimensionality

Configured on the **Setup** page.

Mandatory:
- Department
- Product
- Market

Optional:
- Supplier
- Dim1–Dim4

Each dimension has:
- Visibility flag
- Mandatory selection flag

---

## Select and name input columns

Configured under **Sales by GM – Column setup**.

Available columns:
- Misc1–Misc5

For each column:
- Visibility in input sheet
- Eligibility for auto-transactions
- Eligibility for account mapping

Any column contributing to P&L **must be mapped to an account**.

---

## Attach module to input report

Modules are attached to report lines in the **Forecast summary report**.

Configuration fields:
- Department (ranked input)
- Report Line ID
- Input module

Different modules may attach to different parts of the department hierarchy.

---

## Define input column to account mapping

Configured in **Budget settings**.

Mapping required for:
- Sales
- COGS
- Any additional P&L-relevant input columns

Mapping dimensions:
- Department
- Product
- Market

Each input column maps to a single target account.

---

## 5. Settings

### Distribution keys

Defined per:
- Department
- Product
- Market

Rules:
- Use ranked input
- Avoid overly specific keys
- Used for distributing year totals to months

### Auto transactions (optional)

Auto transactions generate additional transactions based on rules.

Examples:
- 10% surcharge
- Conditional costs

Rule components:
- Department
- Product
- Market
- Value
- Operator
- Optional condition
- Target account

Supported operators:
- ==
- >=
- <=
- &&
- ||

Target department is always inherited from the source transaction.
