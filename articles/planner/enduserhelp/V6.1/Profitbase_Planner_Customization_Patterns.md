# Profitbase Planner – Customization Patterns

**Document:** Customization Patterns  
**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Version:** 2.3  
**Date:** 08.09.2025  

---

## Change log

| Date | Version | Changed by | Changes |
|---|---|---|---|
| 31.10.2021 | 0.1 | TN | Initial content |
| 30.11.2021 | 0.2 | TN | Extended for Planner 5.1 |
| 27.10.2022 | 0.3 | TN | Revised for Planner 5.2.4 |
| 01.06.2023 | 0.4 | TN | Revised for Planner 5.4.0 (Patterns 3, 7, 8) |
| 09.12.2024 | 2.0 | TN | Updated for Planner 6.x |
| 08.09.2025 | 2.3 | TN | Revised for Planner 6.1.1 |

---

## 1. Abstract, intended audience and pre-requisites

This document describes common **customization patterns and best practices** for extending Profitbase Planner.

It is intended for **implementation partners** and assumes:
- Strong knowledge of the Profitbase InVision Designer
- Understanding of Planner’s data model and versioning

Customizations should always live in **separate packages**, never inside the core EPM Planner package.

---

## 2. Overview of customization patterns

The following patterns are described:

1. Create a new Planner input module extension (fully integrated)
2. Create a new module following Planner versioning only
3. Customize transaction pipelines  
   - 3a. Dataflow based  
   - 3b. Flow based
4. Customize assumptions (lookup) measures for Driver Based module
5. Use a custom target store for data import
6. Use a custom source for data export
7. Add custom button or row context menu to standard modules
8. Import transactional plan data from an external source
9. Register custom module with Operation Manager
10. Link processing of Driver Based models using dynamic department mapping

---

## 3. EPM Planner Custom Extension Template

A starter template exists for patterns **1** and **2**.

Key points:
- Must be deployed to a solution already containing EPM Planner
- Not self-contained
- Uses hierarchical filters referencing Planner dimensions

After deployment:
- Replace dimension IDs in markup with Planner dimension content IDs
- Re-publish workbook access
- Preview workbook in Designer (it will not appear in menu yet)

---

## 4. Pattern 1 – Create a new Planner input module extension

Before creating a custom module, always evaluate whether **Driver Based models** are sufficient.

Rules:
- Never use Planner objects directly in custom workbooks
- Always create custom objects referencing Planner data
- Custom packages must coexist with Planner blueprint solution

### Register module extension

Registered in:

```
@Object[ModuleExtensions,setting].dbObjectName
```

Key fields:
- ModuleExtensionID
- WorkbookID (version-specific, must be updated post-deployment)
- WorkbookName (must be unique)
- Published flag
- Localized names
- Window size and positioning

---

## Plan Overview interaction

Planner launches custom modules using query string context:
- DepartmentID
- ProjectID
- ActivityID
- Period filter
- ReportLineID
- MessageBackTo
- Back flag

Custom modules must handle missing context variables gracefully.

---

## Create custom financial transactions

Transactions are inserted into:

```
@Object[pbTransdataSourceCM,store].dbObjectName
```

Minimum required context:
- ModuleExtensionID
- DepartmentID (via DepartmentID_DCD)

Transactions may be:
- Scripted manually
- Passed through built-in transaction pipeline

When scripting:
- Explicitly delete existing slice before insert
- Slice by ModuleExtensionID and Department

---

## Post-version deployment actions

Custom packages must handle:
- Initialization
- Roll-forward
- Pure copy

Controlled via package variables:
- Profitbase_EPM_Planner_PostDeploymentAction
- Profitbase_EPM_Planner_RollOverDelta
- Profitbase_EPM_Planner_StoreReferenceDate

WorkbookIDs must be updated to match version context.

---

## 5. Pattern 2 – Versioned module only

Subset of Pattern 1.

Used when:
- Module follows Planner versioning
- No transaction generation required

---

## 6. Pattern 3 – Customize transaction pipelines

### 3a. Dataflow based (pre 6.1)

Custom PRE and POST scripts can be registered for:
- Account
- Personnel
- Driver Based
- FinanceAll pipelines

Scripts must:
- Live in custom packages
- Use context variables
- Handle higher-level dimension slicing

---

### 3b. Flow based (6.0+)

From Planner 6.1.x, pipelines are **flow-only**.

Customization is done by:
- Adding SQL actions to `Custom pre` or `Custom post` sub-flows
- Sub-flows are upgrade-safe

Built-in transaction tables should be used:
- pbTransdataPLSourceFlow
- pbTransdataPLSourceHRFlow
- pbTransdataPLSourceDriverBasedFlow

---

## Social cost handling in custom pipelines

Preferred approach:
- Store rates on source transactions
- Let Planner render social costs dynamically

Supported overrides include:
- VacationPayPctOvr
- EmployerTaxPctOvr
- PensionEmployerPctOvr

---

## 7. Pattern 4 – Custom assumptions for Driver Based module

Custom assumption source can be defined by:
- Creating a view matching `FctSalesInputAssumptions`
- Registering it via setting `DriverBasedCustomAssumptionView`

Rules:
- View must be stable across queries
- PBRowIdentity must persist
- A measure can use either standard or custom assumptions, not both

---

## 8. Pattern 5 & 6 – Custom import/export sources

Custom targets or sources are enabled by:
- Creating synonyms to tables or views
- Exposing them automatically in import/export UI

---

## 9. Pattern 7 – Custom buttons and row context menus

Supported in:
- Account
- Personnel
- Driver Based
- Plan Overview

Configured via `ModuleExtensions` settings:
- Enable/disable
- Target workbook
- Optional query string parameters

Context is passed automatically depending on module type.

---

## 10. Pattern 8 – Import transactional plan data

Used for:
- External plan data inclusion
- No user input involved

Flow:
1. Import to Datamart target
2. Execute Operation:
   - Import to CM store
   - Reload PL source

Custom transactions must include social cost rows explicitly.

---

## 11. Pattern 9 – Register module with Operation Manager

Required for:
- Scheduling operations
- Automation

Registration is done via SQL insert into:
```
SYN_Common_ProcessVersion
```

---

## 12. Pattern 10 – Link Driver Based model processing

Available from Planner 6.1.0.

Uses:
- ModuleExtensionLinkDepartmentMap
- Custom PRE pipeline scripts
- Dynamic mapping driven by user input

---

## 13. Data architecture and best practices

Recommendations:
- Use `pbTransdataSourceCM` for finance source data
- Use `pbTransdataPL` for reporting
- Use `ReportAccountByMonth` for post-processing
- Avoid deletes outside controlled pipelines
- Prefer views over direct table access

Minimize external dependencies to reduce upgrade risk.
