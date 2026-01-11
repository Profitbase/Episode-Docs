# Profitbase Planner – Customization Patterns

**Document:** Customization Patterns  
**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Version:** 0.5  
**Date:** 27.11.2023  

---

## Change log

| Date | Version | Changed by | Changes |
|---|---|---|---|
| 31.10.2021 | 0.1 | TN | Initial content |
| 30.11.2021 | 0.2 | TN | Extended for Planner 5.1 |
| 27.10.2022 | 0.3 | TN | Revised for Planner 5.2.4 |
| 01.06.2023 | 0.4 | TN | Revised for Planner 5.4.0 |
| 27.11.2023 | 0.5 | TN | Clarification Pattern 4 |

---

## Abstract, intended audience and pre-requisites

This document describes common customization patterns and best practices for extending Profitbase Planner.

It is aimed at **implementation partners**.  
An in-depth knowledge of the Profitbase InVision Designer is required.

---

## Customization patterns overview

The following patterns are described:

1. Create a new Planner input module extension  
2. Create a new module following Planner versioning only  
3. Customize the transaction pipeline / FinanceAll dataflow  
4. Customize assumptions (lookup) measures for the Driver Based module  
5. Use a custom target store for data import  
6. Use a custom source for data export  
7. Add custom button / row context menu in standard modules  
8. Import transactional plan data from an external source  

---

## EPM Planner Custom Extension Template

A starter template exists for patterns 1 and 2.

Key rules:
- Must be deployed to a solution where EPM Planner already exists
- Not self-contained
- Uses hierarchical filters referencing Planner dimensions

After deployment:
- Replace dimension IDs with Planner content IDs
- Republish workbook access
- Preview workbook from Designer

---

## Pattern 1 – Create a new Planner input module extension

Before creating a custom module, **always evaluate Driver Based models first**.

Rules:
- Customizations must live in separate packages
- Never use Planner objects directly in custom workbooks
- Always reference Planner data via custom objects

### Module registration

Registered in:
```
@Object[ModuleExtensions,setting].dbObjectName
```

Key attributes:
- ModuleExtensionID
- WorkbookID (version specific)
- WorkbookName (must be unique)
- Published flag
- Localized names
- Window size and position

---

## Plan Overview interaction

Context passed via query string:
- DepartmentID
- ProjectID
- ActivityID
- FilterChoice
- ReportLineID
- MessageBackTo
- Back

Custom modules must handle missing context values gracefully.

---

## Create custom financial transactions

Transactions are written to:
```
@Object[pbTransdataSourceCM,store].dbObjectName
```

Minimum required context:
- ModuleExtensionID
- DepartmentID (DepartmentID_DCD)

If scripting is used:
- Existing slice must be deleted before insert
- Slice is normally ModuleExtensionID + Department

---

## Post-version deployment actions

Controlled via package variables:
- Profitbase_EPM_Planner_PostDeploymentAction
- Profitbase_EPM_Planner_RollOverDelta
- Profitbase_EPM_Planner_StoreReferenceDate

Custom packages must handle:
- Initialization
- Roll forward
- Pure copy

---

## Pattern 2 – Versioned module only

Subset of Pattern 1.

Used when:
- Module follows Planner versioning
- No transaction generation required

---

## Pattern 3 – Customize transaction pipelines

Transaction pipelines for Account, Personnel and Driver Based modules can be extended.

Registered in:
```
@Object[CustomPipelineScripts,setting].dbObjectName
```

Rules:
- Scripts must exist in custom packages
- Missing scripts fail silently
- Scripts must handle dynamic context slicing

From Planner 5.4.0:
- FinanceAll pipelines support PRE and POST scripts

---

## Pattern 4 – Custom assumptions for Driver Based module

Custom assumption source:
- Implemented as a view matching `FctSalesInputAssumptions`
- Registered via `DriverBasedCustomAssumptionView`

Rules:
- View must persist PBRowIdentity
- One measure uses either standard or custom assumptions
- Ranked input logic applies

---

## Pattern 5 – Custom import targets
## Pattern 6 – Custom export sources

Enabled by:
- Creating synonyms to tables or views
- Automatically exposed in import/export UI

---

## Pattern 7 – Custom buttons and row context menus

Supported in:
- Account
- Personnel
- Driver Based
- Plan Overview

Configured via ModuleExtensions settings.

Context passed depends on module type.

---

## Pattern 8 – Import transactional plan data

Flow:
1. Import to Datamart target
2. Import to Planner CM store
3. Reload PL source (and AFP if needed)

Data must be identified by ModuleExtensionID.

---

## Data architecture and best practices

Recommendations:
- Use pbTransdataSourceCM for finance source data
- Use pbTransdataPL for reporting
- Prefer views over direct table access
- Minimize external dependencies
