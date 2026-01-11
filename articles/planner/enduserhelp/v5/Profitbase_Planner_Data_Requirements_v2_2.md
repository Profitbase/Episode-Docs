# Profitbase Planner – Data Requirements (v2.2)

**Document:** Data Requirements  
**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Version:** 2.2  
**Date:** 14.09.2021  

---

## Change log

| Date | Version | Changed by | Changes |
|---|---|---|---|
| 22.09.2020 | 1.0 | TN | Initial version |
| 07.10.2020 | 1.1 | TN | Update to ledger fact |
| 15.10.2020 | 1.2 | TN | Added URL to import template |
| 27.10.2020 | 1.3 | TN | Clarification regarding LegalEntityIDs and DepartmentIDs |
| 04.11.2020 | 1.4 | TN | Switching from demo to customer data |
| 11.11.2020 | 1.5 | TN | Account dimension revision |
| 16.11.2020 | 1.6 | TN | Legal Entity and Department revisions |
| 17.02.2021 | 1.7 | TN | Project and Activity dimensions |
| 18.05.2021 | 2.0 | TN | Planner v5 |
| 27.07.2021 | 2.1 | TN | Removal of demo data |
| 14.09.2021 | 2.2 | TN | Revised Personnel fact |

---

## 1. Planner Data Requirements

This document defines the minimum dimension, report, and transaction data required to run Profitbase Planner, as well as optional data depending on enabled functionality.

The intended audience is implementation partners responsible for setup and integration.

Planner is delivered with demo data, which must be replaced with customer data during implementation.

---

## 2. Minimum data requirements

### Required dimensions

- Legal Entity  
- Department  
- Account  
- Currency  
- Time  
- Report setup  

### Required fact data

- Ledger fact (Actual and optional historical datasets)
- Currency exchange rates

---

## 2.1 Legal Entity dimension

Mandatory columns:

| Column | Description |
|---|---|
| LegalEntityID | Primary key, company code |
| LegalEntityID_Name | Legal entity name |
| FunctionalCurrencyID | Home currency |
| OperationTypeID | Main or Elimination |

Optional:
- DefaultDepartmentID
- Hierarchy levels (L1–L3 IDs and names)

All hierarchy levels must be filled, padding is allowed.

---

## 2.2 Department dimension

Mandatory columns:

- DepartmentID
- DepartmentID_Name
- LegalEntityID
- Hierarchy levels L1–L6 (IDs and names)

DepartmentIDs must not collide with LegalEntityIDs.

---

## 2.3 Account dimension

Mandatory columns:

- AccountID
- AccountID_Name
- SignFactor
- AccTypeID (PL or BAL)
- AllowInput
- AccountGroupL1–L3 IDs and names

Planner requires a single corporate account dimension.

---

## 2.4 Report setup

Reports define account mappings or calculations.

### INPUT report

- Mandatory
- Entry point for all input modules
- Each account may only appear once

---

## 2.5 Sign factor

Applied at:
- Account level
- Report line level

Used to normalize debit/credit conventions.

---

## 2.6 Ledger fact

Mandatory columns:

| Column | Description |
|---|---|
| AccountID | Account |
| SYS_DatasetID | Actual / Budget / Forecast |
| LegalEntityID | Legal entity |
| DepartmentID | Department |
| TransTypeID | Transaction type |
| CurrencyForeignID | Transaction currency |
| AmountForeign | Amount |
| Transdate | Transaction date |
| AccTypeID | PL / BAL |

Optional dimensions:
Product, Market, Supplier, Employee, Project, Activity, Dim1–Dim4.

---

## 2.7 Currency exchange rates

- Historical rates imported via operation
- Future rates maintained in Planner

---

## 2.8 Time dimension

- Generated automatically from Finance Settings
- Re-generated on version roll forward

---

## 3. Optional data requirements

Relevant for:
- Personnel module
- Driver based module
- CapEx / Fixed Assets

Optional dimensions:
Product, Market, Supplier, Employee, Project, Activity, AssetGroup, Dim1–Dim4.

---

## 3.2 Personnel fact

Stores current:
- FTE
- Monthly salary
- Optional payroll components

Used by the Personnel module.

---

## 3.3 Driver based fact

Stores historical driver values.

Mandatory:
- DepartmentID
- ProductID
- MarketID
- MeasureID
- Value
- Year, Month

---

## 3.4 Fixed assets

Maintained in Finance Settings or imported from external source.

---

## 4. Integration

Integrations are done at database level via Datamart synonyms.

Use only `SYN_Datamart_*` objects.

---

## 5. Switching from demo to customer data

Steps:

1. Empty demo data (never in production)
2. Import customer data
3. Create a new version
