# Profitbase Planner – Data Requirements

**Document:** Data Requirements  
**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Version:** 5.6  
**Date:** 09.09.2025  

---

## Change log

| Date | Version | Changed by | Changes |
|---|---|---|---|
| 22.09.2020 | 1.0 | TN | Initial version |
| 07.10.2020 | 1.1 | TN | Update to ledger fact |
| 15.10.2020 | 1.2 | TN | Added URL to import template |
| 27.10.2020 | 1.3 | TN | Clarification regarding LegalEntityID and DepartmentID |
| 04.11.2020 | 1.4 | TN | Switching from demo to customer data |
| 11.11.2020 | 1.5 | TN | Account dimension revision |
| 16.11.2020 | 1.6 | TN | Legal Entity and Department revisions |
| 17.02.2021 | 1.7 | TN | Project and Activity dimensions |
| 18.05.2021 | 2.0 | TN | Planner v5 |
| 27.07.2021 | 2.1 | TN | Removal of demo data |
| 14.09.2021 | 2.2 | TN | Personnel fact revised |
| 07.08.2022 | 3.0 | TN | Planner v5.2 |
| 23.06.2023 | 4.0 | TN | Planner v5.4.1 |
| 20.09.2023 | 4.1 | TR | Ledger fact correction |
| 19.01.2024 | 5.5 | TR | FiscalPeriod mandatory |
| 09.09.2025 | 5.6 | TN | ExternalDriverBasedFact updates |

---

## 1. Planner Data Requirements

This document defines the **minimum and optional data requirements** for running Profitbase Planner.

Target audience:
- Implementation partners
- Technical consultants

Planner is delivered with demo data. During implementation, demo data must be replaced with customer data.

---

## 2. Minimum data requirements

Minimum required dimensions:
- Legal Entity
- Department
- Account
- Currency
- Time
- Report setup

Required fact data:
- Ledger fact (Actual and optional historical datasets)
- Currency exchange rates

---

## 2.1 Legal Entity dimension (parent/child)

| Column | Description | Mandatory |
|---|---|---|
| ID | Legal entity ID (company code) | Yes |
| Name | Legal entity name | Yes |
| ParentID | Parent node | Optional |
| FunctionalCurrencyID | Home currency | Yes |
| OperationTypeID | Main or Elimination | Yes |
| DefaultDepartmentID | Default department | Optional |

LegalEntityIDs must match general ledger data.

---

## 2.2 Department dimension (parent/child)

| Column | Description | Mandatory |
|---|---|---|
| ID | Department ID | Yes |
| Name | Department name | Yes |
| ParentID | Parent node | Optional |
| LegalEntityID | Owning legal entity | Yes |

DepartmentIDs must match ledger data and should not collide with LegalEntityIDs.

---

## 2.3 Account dimension (parent/child)

| Column | Description | Mandatory |
|---|---|---|
| ID | Account ID | Yes |
| Name | Account name | Yes |
| ParentID | Parent node | Optional |
| SignFactor | Transaction sign | Yes |
| AccTypeID | PL or BAL | Yes |
| AllowInput | Allow planning input | Yes |

Planner requires a **single corporate account dimension**.

---

## 2.4 Report setup

Reports map:
- Account ranges, or
- Calculations across report lines

### INPUT report
- Mandatory
- Entry point for all planning
- Each account must appear once unless split by dimension

---

## 2.5 Sign factor

Applied at:
- Account level
- Report line level

Used to normalize debit/credit conventions.

---

## 2.6 Ledger fact

Supported formats:
- Trial balance + OB (periodic)
- Transaction format

### Mandatory transaction columns

| Column | Description |
|---|---|
| AccountID | Account |
| SYS_DatasetID | Actual / Budget / Forecast |
| LegalEntityID | Legal entity |
| DepartmentID | Department |
| TransTypeID | Opening or regular |
| AmountFunctional | Amount |
| CurrencyFunctionalID | Currency |
| Transdate | Date |
| AccTypeID | PL / BAL |
| FiscalPeriod | YYYYMM |

Optional dimensions:
Product, Market, Supplier, Employee, Project, Activity, Dim1–Dim4, Counterparty.

---

## 2.7 Currency exchange rates

- Historical rates imported via operation
- Future rates maintained in Planner

---

## 2.8 Time dimension

- Generated automatically from Finance Settings
- Re-generated on roll forward

---

## 3. Optional data requirements

Used when enabling:
- Personnel module
- Driver Based module
- CapEx / Fixed Assets

Optional dimensions:
Product, Market, Supplier, Employee, Project, Activity, AssetGroup, Dim1–Dim4

---

## 3.2 Personnel fact

Stores:
- FTE
- HC
- Monthly salary
- Optional payroll components

Used by Personnel module.

---

## 3.3 Driver based fact

Stores historical values for driver-based measures.

Mandatory:
- DepartmentID
- ProductID
- MarketID
- MeasureID
- Value
- Year, Month

Optional:
EmployeeID, ProjectID, ActivityID, Dim1–Dim4, Attr1–Attr2.

---

## 3.4 Fixed assets

Maintained in Finance Settings or imported from external source.

---

## 4. Integration

Integration methods:
- File Import (CSV)
- Data Import (SQL / Blob)

Use **SYN_Datamart_*** synonyms only.

---

## 5. Switching from demo to customer data

Steps:
1. Empty demo data (never in production)
2. Import customer dimensions and facts
3. Create new version

---

## 6. Data quality audit

Planner provides:
- Validation on import
- Audit report with severity:
  - Error
  - Warning
  - Information

Audit should return zero rows before go-live.

---

## 7. Legacy fixed wide formats

Supported for:
- Legal Entity
- Department
- Account

**Not recommended**. Parent/child format should always be used.
