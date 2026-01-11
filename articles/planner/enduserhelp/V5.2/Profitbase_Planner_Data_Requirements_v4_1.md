# Profitbase Planner – Data Requirements

**Document:** Data Requirements  
**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Version:** 4.1  
**Date:** 20.09.2023  

---

## Change log

| Date | Version | Changed by | Changes |
|---|---|---|---|
| 22.09.2020 | 1.0 | TN | Initial version |
| 07.10.2020 | 1.1 | TN | Update to ledger fact |
| 15.10.2020 | 1.2 | TN | Added URL to import template |
| 27.10.2020 | 1.3 | TN | Clarification LegalEntityID vs DepartmentID |
| 04.11.2020 | 1.4 | TN | Switching from demo to customer data |
| 11.11.2020 | 1.5 | TN | Account dimension revision |
| 16.11.2020 | 1.6 | TN | Legal Entity & Department revision |
| 17.02.2021 | 1.7 | TN | Planner 4.2 update |
| 18.05.2021 | 2.0 | TN | Planner 5.0 |
| 27.07.2021 | 2.1 | TN | Demo data removal |
| 14.09.2021 | 2.2 | TN | Personnel fact revision |
| 07.08.2022 | 3.0 | TN | Planner 5.2 |
| 23.06.2023 | 4.0 | TN | Planner 5.4.1 |
| 20.09.2023 | 4.1 | TR | Ledger fact correction |

---

## 1. Purpose and scope

This document defines the **minimum required dimensions, reports, and transaction data** needed to run Profitbase Planner, as well as **optional data** depending on enabled functionality.

Target audience:
- Implementation partners
- Technical consultants
- Solution architects

Planner is delivered with demo data for reference. Production environments must replace demo data with customer-specific data.

---

## 2. Minimum data requirements

With minimum data, only the following modules are available:
- Account
- CapEx
- Loan

### Required dimensions
- Legal Entity
- Department
- Account
- Currency
- Time

### Required fact data
- Finance ledger (actuals or historical)
- Currency exchange rates

---

## 2.1 Legal Entity dimension (parent/child – recommended)

| Column | Description | Mandatory |
|---|---|---|
| ID | Legal entity ID | Yes |
| Name | Legal entity name | Yes |
| ParentID | Parent node | Optional |
| FunctionalCurrencyID | Home currency | Yes |
| OperationTypeID | Main or Elimination | Yes |
| DefaultDepartmentID | Default department | Optional |

IDs must match those used in ledger data.

---

## 2.2 Department dimension

| Column | Description | Mandatory |
|---|---|---|
| ID | Department ID | Yes |
| Name | Department name | Yes |
| ParentID | Parent node | Optional |
| LegalEntityID | Owning legal entity | Yes |

Best practice:
- DepartmentID must differ from LegalEntityID.
- Prefix DepartmentID if needed.

---

## 2.3 Account dimension

| Column | Description | Mandatory |
|---|---|---|
| ID | Account ID | Yes |
| Name | Account name | Yes |
| ParentID | Parent node | Optional |
| SignFactor | Sign handling | Yes |
| AccTypeID | PL or BAL | Yes |
| AllowInput | True/False | Yes |

Planner requires **one corporate account dimension**.

---

## 2.4 Report setup

Reports are maintained in the **Report Setup** workbook.

Reports either:
- Map account ranges
- Calculate from other report lines

### INPUT report
Mandatory.
Used by Plan Overview to launch input modules.

---

## 2.5 Sign factor

Applies at:
- Account level (data sign inversion)
- Report line level (presentation sign)

---

## 2.6 Ledger fact data

Supported formats:
1. Trial balance + opening balance (periodic)
2. Ledger transactions

### Mandatory columns (transaction format)

| Column | Mandatory |
|---|---|
| AccountID | Yes |
| LegalEntityID | Yes |
| DepartmentID | Yes |
| DatasetID | Yes |
| TransTypeID | Yes |
| AmountFunctional | Yes |
| CurrencyFunctionalID | Yes |
| TransDate | Yes |
| AccTypeID | Yes |

---

## 2.7 Currency exchange rates

- Historical rates imported automatically
- Future rates maintained in Planner
- External sources supported

---

## 2.8 Time dimension

Generated automatically per version.
Regenerated on:
- Version creation
- Version roll-forward

---

## 3. Optional data requirements

Required if using:
- Personnel
- Driver Based
- CapEx (advanced)
- Fixed Assets

### Optional dimensions
Product, Market, Supplier, Project, Activity, AssetGroup, Employee, Dim1–Dim4

---

## 3.2 Personnel fact

Mandatory:
- DepartmentID
- EmployeeID
- FTE
- HC
- MonthlySalary

Supports overrides and attributes.

---

## 3.3 Driver based fact

Used for:
- Sales quantities
- Prices
- Other drivers

Grain:
Department × Product × Market × Time × Measure

---

## 4. Integration

Integration via **Data Import & Export** workbook.

Rules:
- Always use database **synonyms**
- Never reference physical tables directly

Examples:
- `SYN_Datamart_AccountExternalPC`
- `SYN_Datamart_pbTransdataHistory`

---

## 5. Switching from demo to customer data

Steps:
1. Empty demo data (non-production only)
2. Import customer data
3. Create new version

---

## 6. Data quality audit

Severity levels:
- Error (blocking)
- Warning
- Information

Run QA report after imports.

---

## 7. Legacy fixed wide formats

Supported for backward compatibility only.
**Strongly discouraged** for new implementations.
