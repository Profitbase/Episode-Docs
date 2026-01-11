# Profitbase Planner – Customization Patterns

**Document:** Customization Patterns  
**Company:** Profitbase AS  
**Product:** Profitbase Planner  
**Version:** 0.4  
**Date:** 04.05.2023  

---

## Change log

| Date | Version | Changed by | Changes |
|---|---|---|---|
| 31.10.2021 | 0.1 | TN | Initial content |
| 30.11.2021 | 0.2 | TN | Extended for Planner 5.1 |
| 27.10.2022 | 0.3 | TN | Revised for Planner 5.2.4 |
| 01.06.2023 | 0.4 | TN | Revised for Planner 5.4.0 (Patterns 3, 7, 8) |

---

## Abstract, intended audience and pre-requisites

This document describes **common customization patterns and best practices** for extending Profitbase Planner.

Target audience:
- Implementation partners
- Advanced solution architects

Pre-requisites:
- Strong knowledge of Profitbase InVision Designer
- Understanding of Planner versioning and transaction pipeline

---

## Overview of patterns

1. Create a new Planner input module extension  
2. Create a new module that follows Planner versioning only  
3. Customize the transaction pipeline and/or FinanceAll dataflow  
4. Customize assumptions (lookup) measures for Driver Based module  
5. Use a custom target store for data import  
6. Use a custom source for data export  
7. Add custom button / row context menu in standard Planner modules  
8. Import transactional plan data from an external source  

---

## EPM Planner Custom Extension Template

A starter template exists for:
- Pattern 1
- Pattern 2

Rules:
- Must be deployed in a solution where EPM Planner already exists
- Must live in a **separate package**, never inside the Planner package
- Uses hierarchical filters that reference Planner dimensions

After deployment:
- Replace hardcoded dimension IDs with Planner dimension content IDs
- Re-publish workbook access
- Preview workbook from Designer (not visible in menu until added to process)

---

## Pattern 1 – Create a new Planner input module extension

**Use this only if Driver Based models are not sufficient.**

Key characteristics:
- Integrated with Plan Overview
- Produces its own financial transactions
- Fully versioned with Planner

Rules:
- Customizations must live in a separate package
- Never reference Planner objects directly
- Use custom objects referring to Planner data

### Register new Planner input module extension

Registered in:
```
@Object[ModuleExtensions,setting].dbObjectName
```

Key attributes:
- ModuleExtensionID
- WorkbookID (version-specific, must be updated post deployment)
- WorkbookName (must be unique)
- Published flag
- Translations
- Window sizing parameters

---

## Plan Overview interaction

Planner passes context via query string:
- DepartmentID
- ProjectID
- ActivityID
- FilterChoice
- ReportLineID
- MessageBackTo
- Back

Custom modules must:
- Handle missing context gracefully
- Respect read-only versions
- Respect Published flag
- Use SendMessage to refresh caller

---

## Create custom financial transactions

Custom transactions are written to:
```
@Object[pbTransdataSourceCM,store].dbObjectName
```

Mandatory fields include:
- LegalEntityID
- DepartmentID / DepartmentID_DCD
- AccountID
- Amount
- CurrencyForeignID
- TransDate
- AccTypeID = PL
- ModuleExtensionID

Overrides supported for many financial parameters.

If scripting:
- Explicitly delete existing slice before insert
- Slice must include ModuleExtensionID and Department context

---

## Post version deployment actions

Custom packages must implement their own **post version deployment dataflow**.

Supported actions:
- RollFwd
- Init
- Nothing

Important:
- WorkbookID must be updated to the version-specific ID
- Custom workbooks must be registered in SYN_Common_Workbook if used in tasks

---

## Pattern 2 – Module following Planner versioning only

Subset of Pattern 1:
- No custom transactions
- Follows Planner versioning lifecycle

---

## Pattern 3 – Customize transaction pipeline / FinanceAll

Supported from Planner 5.1+.

Custom PRE / POST scripts:
- Account pipeline
- Personnel pipeline
- Driver Based pipeline
- FinanceAllBaseline
- FinanceAllScenario

Scripts registered in:
```
@Object[CustomPipelineScripts,setting].dbObjectName
```

Rules:
- Scripts live in custom package
- Must handle dynamic context (multi-department input)
- Missing scripts are ignored silently

---

## Pattern 4 – Customize Driver Based assumptions

Override standard assumption table using:
```
DriverBasedCustomAssumptionView
```

Rules:
- View must conform to FctSalesInputAssumptions format
- Must include PBRowIdentity
- Either standard or custom per measure, never both
- Ranked specificity applies

---

## Pattern 5 – Custom target store for import

- Create synonym to expose additional import targets
- Supported from Planner 5.1+

---

## Pattern 6 – Custom source for export

- Create synonyms for additional exportable tables
- Supported from Planner 5.1+

---

## Pattern 7 – Custom buttons and row context menus

Supported from Planner 5.4.0.

Applicable to:
- Account
- Personnel
- Driver Based
- Plan Overview

Configured via ModuleExtensions:
- CustBtnEnabled
- CustBtnLaunchToWorkbookName
- CustRowContextMnuEnabled
- Query string parameters supported

Context passed:
- Filter context
- Row dimensional context
- Module-specific additions

---

## Pattern 8 – Import transactional plan data

Pattern:
1. Import to pbTransdataSourceCMExternal
2. Copy into pbTransdataSourceCM via Operation
3. Reload PL and AFP pipelines

ModuleExtensionID is mandatory for slicing.

---

## Data architecture and extension guidelines

Recommendations:
- Use pbTransdataSourceCM for source transactions
- Use pbTransdataPL for P&L presentation
- Use ReportAccountByMonth for post-processing
- Prefer SYN / CPV views
- Minimize external dependencies
- Avoid deletes where possible
