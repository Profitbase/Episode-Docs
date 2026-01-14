# Data Requirements

Profitbase

09.09.2025

Version 5.6

---

## Planner Data Requirements

This document defines the minimum dimension, report and transaction data that is required to run the Planner solution as well as optional data required depending on the Planner functionality used.

It also describes how external data can be imported to Profitbase Planner.

The intended audience of this document is implementation partners configuring the solution initially and establishing integrations with external sources. The reader is expected to be familiar with Planner capabilities and functionality.

Planner is deployed with initial (demo-only) data that will make Planner functional upon deployment and that may act as examples for data that is required. This applies to all data described in this document.

Planner is self-contained with respect to dimensions and some fact data in the sense that these can be input and maintained in Planner. In practice, however, some of the dimensions and ledger transaction data will typically be imported from external sources or from files.

Planner dimensions may be maintained in the “Dimensions” workbook in the “Edit dimensions” page by selecting the appropriate dimension:

[IMAGE PLACEHOLDER: Dimensions workbook]

Editing is done directly in the hierarchy allowing for a dynamic number of levels depending on the actual need. Changes are saved using the save button.

Note that certain dimensions, such as Legal Entity, Department and Account has requirements with respect to properties that must have values for Planner to work.

Note also that dimension management is by default centralized to the primary dimensions.

Each version has its own copy of the dimensions.

Import-from-clipboard functionality is available using the Import icon.

The currency exchange rates may be maintained in the “Currency Exchange Rates and Calendar” workbook:

[IMAGE PLACEHOLDER: Currency Exchange Rates workbook]

Fact data may be maintained in the “Source fact data” workbook within a specific version:

[IMAGE PLACEHOLDER: Source fact data workbook]

Similarly, fixed assets may be maintained in the “Finance Settings” workbook within a specific version:

[IMAGE PLACEHOLDER: Finance Settings workbook]

File import to the standard Planner dimension and fact formats is available in “Data Import & Export” in the “File Import” page:

[IMAGE PLACEHOLDER: File import page]

A more generic import option is available in the “Data Import” page.

---

## Minimum data requirements

The following are the minimum data requirements and limits the use of input modules to the Account, CapEx and Loan modules only.

### Required dimensions

Legal Entity dimension – the formal company structure.

Department dimension – the structure within each Legal Entity used for providing plan input and accounting transactions.

Account dimension – the structure used to determine the type of transactions relative to a finance fiscal regime.

Planner requires a common account dimension for all companies.

The recommended import format for dimensions is the parent/child format.

Report Setup – setup of one or more reports containing report lines mapping to ranges of accounts.

Currency dimension – defines the currencies used.

Time dimension – contains calendar with days, months and years.

### Required transaction data

Ledger fact – Actual and other historical finance transactions from the general ledger.

Ledger fact data is required in order for opening balances to be generated.

Ledger fact data is typically imported from an external source.

As an alternative, a finance trial balance with opening balance per fiscal year can be used.

Currency Exchange rates – historic rates should match the ERP system.

---

## Legal Entity Dimension

### Parent/child format (recommended)

| # | Column name | Description | Mandatory / Optional | Comment |
|---|------------|-------------|----------------------|---------|
| 1 | ID | ID for the Legal entity | M | Primary Key |
| 2 | Name | Name for the Legal entity | M | |
| 3 | ParentID | ID for the parent node | O | NULL places at root |
| 4 | FunctionalCurrencyID | Home currency | M | |
| 5 | OperationTypeID | Main or Elimination | M | |
| 6 | DefaultDepartmentID | Default department | O | |

---

## Department Dimension

### Parent/child format (recommended)

| # | Column name | Description | Mandatory / Optional | Comment |
|---|------------|-------------|----------------------|---------|
| 1 | ID | ID for the Department | M | Primary Key |
| 2 | Name | Name for the Department | M | |
| 3 | ParentID | ID for parent node | O | |
| 4 | LegalEntityID | Legal entity id | M | |

---

## Account Dimension

### Parent/child format (recommended)

| # | Column name | Description | Mandatory / Optional | Comment |
|---|------------|-------------|----------------------|---------|
| 1 | ID | Account ID | M | Primary Key |
| 2 | Name | Account name | M | |
| 3 | ParentID | Parent account | O | |
| 4 | SignFactor | Transaction sign | M | |
| 5 | AccTypeID | PL or BAL | M | |
| 6 | AllowInput | Allow planning input | M | |

Planner requires a common group account dimension.

---

## Account dimension hierarchy

The hierarchy is used for finance settings, not reporting.

The default hierarchy consists of three levels: L1, L2 and L3.

---

## Report setup

Reports are defined in the Report Setup workbook.

Reports either map to account ranges or calculate across report lines.

Ranges are comma-separated.

Formulae use arithmetic operations between ReportLineIDs.

---

## The INPUT report

Used for the Plan Overview workbook and module launching.

An INPUT report must always be present.

---

## Sign factor

Account sign factor switches the sign of historical and input data.

Report line sign factor controls presentation sign.

---

## Ledger fact – Actual and historical datasets

Ledger fact can be imported directly or via trial balance format.

---

## Finance trial balance and OB (periodic format)

| # | Column name | Description | Mandatory / Optional |
|---|------------|-------------|----------------------|
| 1 | LegalEntityID | Legal entity id | M |
| 2 | DepartmentID | Department id | M |
| 3 | AccountID | Account id | M |
| 4 | AccTypeID | PL or BAL | M |
| 5 | DatasetID | Actual/Budget/Forecast | M |
| 6 | FiscalYearNo | Fiscal year | M |
| 7 | Measure | Amount or Qty | M |
| 8 | RowIsYTD | YTD or periodic | M |
| 9 | CurrencyID | Currency | O |
| 10 | OB | Opening balance | O |
| 11 | P01-P12 | Period values | O |

---

## Ledger fact (transaction format)

Mandatory columns include:

AccountID  
SYS_DatasetID  
LegalEntityID  
DepartmentID  
TransTypeID  
CurrencyFunctionalID  
AmountFunctional  
Transdate  
AccTypeID  
FiscalPeriod  

Optional dimensional columns may be included.

---

## Currency Exchange Rates

Historical rates are imported by default from Profitbase sources.

Future rates are managed in Planner.

[IMAGE PLACEHOLDER: Exchange rate tables]

---

## Time dimension

The time dimension is generated in the Finance Settings workbook.

Planning horizon is selected from predefined options.

---

## Optional data requirements

Relevant for Personnel, Driver based, CapEx and Fixed Assets modules.

Optional dimensions include Product, Market, Project, Activity, Supplier, Asset Group, Dim1–Dim4 and Employee.

---

## Personnel fact

Contains FTE, HC and salary data.

Multiple optional attributes may be included.

[IMAGE PLACEHOLDER: Personnel fact input]

---

## Driver based fact

Maintained in the Source Fact Data workbook.

Supports measures such as Sales Quantity.

[IMAGE PLACEHOLDER: Driver based fact]

---

## Fixed assets

Maintained in the Finance Settings workbook.

[IMAGE PLACEHOLDER: Fixed assets]

---

## Integration

Integration is done via the Data Import & Export workbook.

Database synonyms prefixed with SYN_Datamart_ must be used.

---

## Switching from demo to customer’s data

Includes emptying demo data and importing customer data.

Operations must never be executed in production systems.

---

## Data quality audit

Planner provides QA reports for identifying errors and warnings.

[IMAGE PLACEHOLDER: Data quality audit]

---

## Dimension legacy format (fixed wide)

Included for legacy purposes only.

### Legal Entity dimension (fixed wide)

[LEGACY TABLE PRESERVED AS IN SOURCE]

---

### Department dimension (fixed wide)

[LEGACY TABLE PRESERVED AS IN SOURCE]

---

### Account dimension (fixed wide)

[LEGACY TABLE PRESERVED AS IN SOURCE]

---

Page 13 of 13  
Profitbase Planner Data Requirements
