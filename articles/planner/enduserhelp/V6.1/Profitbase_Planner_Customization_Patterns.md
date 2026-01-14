## Customization Patterns

Profitbase

08.09.2025

Version 2.3

---

## Abstract, intended audience and pre-requisites

This document aims to describe common customization patterns and best practices for making custom extensions to Profitbase Planner and is aimed at implementation partners.

An in-depth knowledge of the Profitbase InVision designer is required.

The following patterns are described:

Pattern 1 - Create a new Planner input module extension that will integrate with Planner’s Plan Overview, produce financial transactions of its own, and follow Planner’s versioning.

Pattern 2 - Create a new module that will follow Planner’s versioning only (subset of 1) and be present in the hamburger menu.

Pattern 3 – Customize the transaction pipeline.

Pattern 4 – Customize assumptions (lookup) measures for the Driver Based module.

Pattern 5 – Use a custom target store for data import.

Pattern 6 – Use a custom source for data export.

Pattern 7 – Add custom button and/or custom row context menu in standard Planner modules.

Pattern 8 – Import transactional plan data from an external source.

Pattern 9 – Register custom module with the Operation Manager.

Pattern 10 – Link processing of driver based models using a dynamic map of from/to departments.

---

## EPM Planner Custom Extension Template

This is a starter template that can should be used to rapidly set up a custom extension either for pattern 1 or 2 above.

The custom extension template must be deployed to a solution in which the EPM Planner package exists already.

The custom extension package is not self-contained as its workbook uses hierarchical filters that refer to dimensions in EPM Planner.

Once deployed, the following markup changes must therefore be done to the hierarchical filters that refer to source dimensions that reside in EPM Planner:

[IMAGE PLACEHOLDER: hierarchical filter markup]

Replace the ids in yellow with the content ids for the dimensions within EPM Planner with names as underlined in red in the image above.

You will find the id by locating the dimensions and right-click and select Copy id to clipboard:

[IMAGE PLACEHOLDER: copy dimension id]

Save the markup.

Assign yourself access to the workbook in the custom extension package.

Open the workbook by previewing it from the designer as it will not appear in the menu until the package is part of a process’ content.

[IMAGE PLACEHOLDER: preview workbook]

There is a basic list of todos listed in the workbook:

[IMAGE PLACEHOLDER: todo list]

The following two chapters explain patterns 1 and 2 more in-depth.

---

## Pattern 1 - Create a new Planner input module extension

NOTE: Before creating a new custom Planner input module extension, consider carefully if one or more driver-based models make up a “good enough” solution.

NOTE: Any customizations made as additions to the EPM Planner package should be contained in separate packages.

NOTE: Never use Planner objects directly in custom module workbooks.

---

### Register new Planner input module extension

A Planner input module extension comes in the form of a workbook and associated store(s) and worksheet(s).

Input module extensions are registered in @Object[ModuleExtensions,setting].dbObjectName.

Relevant attributes:

| Column | Description |
|------|-------------|
| ModuleExtensionID | The id of the module extension. |
| WorkbookID | Version specific workbook id. |
| WorkbookName | The workbook object name. |
| InUse | Published or not published. |
| ModuleExtensionID_Name | Default description. |
| ModuleExtensionID_Name_NO | Norwegian translation. |
| ModuleExtensionID_Name_EN | English translation. |
| WorkbookPixelHeight | Window height. |
| WorkbookPixelWidth | Window width. |
| WorkbookPixelLeftAdjustment | Left adjustment. |
| WorkbookPixelTopAdjustment | Top adjustment. |

Attributes in bold above are maintainable by the user.

---

### Plan overview interaction

The Plan overview workbook will launch the module and use query string variables:

DepartmentID  
ProjectID  
ActivityID  
FilterChoice  
ReportLineID  
MessageBackTo  
DirtyFlagRefresh  
RefreshSummary  
Back  

NOTE: The URL may or may not contain certain variables.

The relevant filter sources:

Department filter: @Object[Department,dim].dbObjectName  
Project filter: @Object[Project,dim].dbObjectName  
Activity filter: @Object[Activity,dim].dbObjectName  
Period filter: @Object[FctPeriodFilterSource,view].dbObjectName  

Other issues to consider:

IsAppReadonly()  

NoAccess message text code.

---

## Create custom financial transactions

Custom financial transactions are created in @Object[pbTransdataSourceCM,store].dbObjectName.

| Column | Description |
|------|-------------|
| LegalEntityID | Legal entity id |
| DepartmentID | Department id |
| DepartmentID_DCD | Department context id |
| AccountID | Account id |
| ProductID | Product id |
| MarketID | Market id |
| SupplierID | Supplier id |
| EmployeeID | Employee id |
| ProjectID | Project id |
| ActivityID | Activity id |
| Dim1 | Free dimension |
| Dim2 | Free dimension |
| Dim3 | Free dimension |
| Dim4 | Free dimension |
| CPLegalEntityID | Counterparty legal entity |
| CPDepartmentID | Counterparty department |
| CPAccountIDOvr | Counterparty account |
| CategoryID | Category id |
| TextInpID | Text id |
| Transdate | Transaction date |
| Amount | Amount |
| CurrencyForeignID | Currency |
| TransTypeID | Transaction type |
| Qty | Quantity |
| AccTypeID | PL |
| ModuleExtensionID | Module id |
| SYS_OriginID | Origin id |
| SYS_OriginColumnID | Origin column |
| SYS_TransGeneratorID | Generator id |
| SYS_OriginRowIdentity | Row identity |
| SYS_DataSetID | Obsolete |
| Financial override columns | Optional overrides |

The built-in transaction pipeline can be used or the data can be scripted.

---

## Actions to be performed post version deployment

This section is also relevant for Pattern 2.

The custom package should have its own post version deployment dataflow:

[IMAGE PLACEHOLDER: post deployment dataflow]

Package variables:

Profitbase_EPM_Planner_PostDeploymentAction  
Profitbase_EPM_Planner_RollOverDelta  
Profitbase_EPM_Planner_StoreReferenceDate  

WorkbookID must be updated post deployment.

---

## Pattern 2 - Create a new module that will follow Planner’s versioning only

This should be a subset of pattern 1.

---

## Pattern 3a – Customize the transaction pipeline and/or FinanceAll dataflow (Dataflow based)

Transaction pipelines can be customized with PRE and POST scripts.

Scripts must use context variables:

@ModuleExtensionID  
@DepartmentID  
@DepartmentColumnName  
@ActivityID  
@ActivityColumnName  
@ProjectID  
@ProjectColumnName  

Scripts should never be created in EPM Planner package.

FinanceAll dataflows can also be customized.

[IMAGE PLACEHOLDER: FinanceAll PRE script]  
[IMAGE PLACEHOLDER: FinanceAll POST script]

---

## Pattern 3b – Customize the transaction pipelines (flow based)

From Planner 6.1.x, pipelines are flow based.

Custom scripts must be connected to flow sub-flows:

Custom pre  
Custom post  

[IMAGE PLACEHOLDER: flow designer]

Use built-in transaction tables:

pbTransdataPLSourceFlow  
pbTransdataPLSourceHRFlow  
pbTransdataPLSourceDriverBasedFlow  

---

## Pattern 4 – Customize assumptions (lookup) measures for the Driver Based module

Custom assumption views may be created.

View must conform strictly to the standard format.

PBRowIdentity must persist across queries.

---

## Pattern 5 – Use a custom target store for data import

---

## Pattern 6 – Use a custom source for data export

---

## Pattern 7 – Add custom button/row context menu in standard Planner modules

Custom buttons and menus can be configured in ModuleExtensions.

[IMAGE PLACEHOLDER: custom button configuration]

Context passed includes filter values and row context.

---

## Pattern 8 – Import transactional plan data from an external source

Use pbTransdataSourceCM.

Import via Data Import and Operations.

Stored procedures may need recompilation.

---

## Pattern 9 – Register custom module with Operation Manager

Example SQL command:

[IMAGE PLACEHOLDER: SQL registration example]

---

## Pattern 10 – Link processing of driver based models using a dynamic map of from/to departments

Supported from Planner 6.1.0.

Custom pre script required.

[IMAGE PLACEHOLDER: dynamic department map]

---

## Data Architecture and Extensions

Profitbase Planner Architecture.pptx

Recommendation summary:

Use pbTransdataSourceCM for finance transactions.  
Use pbTransdataPL for P&L presentation.  
Use ReportAccountByMonth for postprocessing.  
Use SYN or CPV views where possible.  
Avoid direct table dependencies.  

Be aware that this document will be updated and extended.

---


