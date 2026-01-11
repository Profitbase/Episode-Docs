# Profitbase Planner Data Requirements

**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Document version:** 1.7  
**Date:** 17.02.2021

---

## Change log

| Date | Version | Changed by | Changes |
|---|---|---|---|
| 22.09.2020 | 1.0 | TN | Initial version |
| 07.10.2020 | 1.1 | TN | Update to ledger fact |
| 15.10.2020 | 1.2 | TN | Added URL to import template |
| 27.10.2020 | 1.3 | TN | Clarification regarding LegalEntityIDs and DepartmentIDs |
| 04.11.2020 | 1.4 | TN | Added chapter on switching from demo to customer’s data |
| 11.11.2020 | 1.5 | TN | Revision to Account dimension |
| 16.11.2020 | 1.6 | TN | Revision to Legal Entity and Department dimensions |
| 17.02.2021 | 1.7 | TN | Revised for Planner 4.2 (Project and Activity dimensions) |

---

## 1. Planner Data Requirements

This document defines the minimum dimension, report, and transaction data required to run Profitbase Planner, as well as optional data depending on functionality used.

The intended audience is implementation partners configuring the solution and establishing integrations with external sources.

Planner is delivered with demo data. Dimensions and some fact data can be maintained in Planner, but are often imported from external systems.

---

## 2. Minimum data requirements

Minimum required dimensions:

- Legal Entity
- Department
- Account
- Currency
- Time
- Report setup

Required transaction data:

- Ledger fact (actuals and optional historical datasets)
- Currency exchange rates

---

## 2.1 Legal Entity dimension

Mandatory columns:

| Column | Description |
|---|---|
| LegalEntityID | Primary key, company code |
| LegalEntityID_Name | Name |
| FunctionalCurrencyID | Home currency |
| OperationTypeID | Main or Elimination |
| DefaultDepartmentID | Optional default department |
| LegalEntityL1–L3 IDs and Names | Hierarchy levels |

Hierarchy must be fully populated. Padding by repeating values is allowed.

---

## 2.2 Department dimension

Mandatory columns include DepartmentID, Department name, LegalEntityID, and hierarchy levels L1–L6.

Department IDs must match ledger data and should not collide with LegalEntity IDs.

---

## 2.3 Account dimension

Mandatory columns:

- AccountID
- Account name
- SignFactor
- AccTypeID (PL or BAL)
- AllowInput
- Account group hierarchy (L1–L3)

A single corporate account dimension is required.

---

## 2.4 Report setup

Reports map account ranges or calculate values using formulas.

### INPUT report

Mandatory report used as entry point for Budget and Forecast workbooks.

Each account may only appear once in the INPUT report.

---

## 2.5 Sign factor

Sign factor can be applied at:

- Account level (e.g. revenue stored as negative, shown as positive)
- Report line level

---

## 2.6 Ledger fact

Mandatory columns:

- AccountID
- SYS_DatasetID (Actual, BudgetHist, ForecastHist)
- LegalEntityID
- DepartmentID
- TransTypeID
- CurrencyForeignID
- AmountForeign
- Transdate
- AccTypeID

Optional dimensions include Product, Market, Supplier, Employee, Dim1–Dim4, Project, Activity.

Ledger data is imported from external sources.

---

## 2.7 Currency exchange rates

Historical rates are imported by default from Profitbase (ECB-based).

Future rates are maintained inside Planner.

---

## 2.8 Time dimension

Generated automatically based on Finance Settings.

Regenerated on forecast roll-forward and new budget creation.

---

## 3. Optional data requirements

Used for modules:

- Personnel
- Sales
- CapEx

Optional dimensions:

- Product
- Market
- Supplier
- Employee
- Asset Group
- Dim1–Dim4
- Project, Activity (v4.2+)

---

## 3.2 Personnel fact

Stores current FTE and salary per department and employee.

Supports optional dimensions and additional measures such as bonus and overtime.

---

## 3.3 Sales forecast fact

Stores historical sales measures by Department, Product, Market, etc.

Data can be imported or maintained via Source Fact Data workbook.

---

## 4. Integration

Integrations are done at database level via staging tables.

Planner supports switching from internal sources to external sources for dimensions and facts using SQL scripts and operations.

---

## 5. Switching from demo to customer data

Steps:

1. Empty demo data (never in production)
2. Import or input customer data
3. Re-initialize Planner
