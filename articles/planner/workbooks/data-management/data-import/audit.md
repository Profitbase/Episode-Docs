---
title: "Audit"
metaKeys: ""
folderOnly: "false"
pageIndex: 5
---

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5.2 or later

## Overview

This page allows you to audit the quality of imported data, such as checking that mandatory dimensional properties are set, etc..

If data is imported from external sources, you are strongly advised to audit the data.

Click the Run audit button to perform an audit. If the audit report is empty, all is good. If not, you should consider the different audit messages and act to remedy the problem if the severity warrants action.

![](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/ImportAudit.JPG)

## Column Descriptions

- **Severity**<br/>
The severity of the issue (Error | Warning | Information). If issues with severity Error exists, actions should be taken to remedy the issue.
- **Object Name**<br/>
The object name (table) that has the issue.
- **Column Name**<br/>
The column name within the object that has the issue.
- **Audit Text**<br/>
The audit text outlining the issue.

## Audit checks made

The basis for the checks made is the data requirements document:

-  [Planner Data Requirements](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.2/Planner%20Data%20Requirements.pdf)<br/>

Specifically, any mandatory dimensional properties as outlined in the document are checked:

- **Legal Entity dimension**<br/>
- Property CurrencyFunctionalID is checked to be set and to exist for all leaf nodes. An issue with severity Error is reported otherwise.
- Property OperationTypeID is checked to be set and valid for all leaf nodes. An issue with severity Error is reported otherwise.
- Property DefaultDepartmentID is checked to be set and valid for all leaf nodes. An issue with severity Information is reported otherwise.

- **Department dimension**<br/>
- Property Legal Entity is checked to be set and valid for all leaf nodes. An issue with severity Error is reported otherwise.

- **Account dimension**<br/>
- Property SignFactor is checked to be set and valid for all leaf nodes. An issue with severity Error is reported otherwise.
- Property AllowInput is checked to be set and valid for all leaf nodes. An issue with severity Error is reported otherwise.
- Property AccTypeID is checked to be set and valid for all leaf nodes. An issue with severity Error is reported otherwise.

- **Financial ledger data**<br/>
- Mandatory column LegalEntityID checked to be set and valid for all transactions.  An issue with severity Error is reported otherwise.
- Mandatory column DepartmentID checked to be set and valid for all transactions.  An issue with severity Error is reported otherwise.
- Mandatory column AccountID checked to be set and valid for all transactions.  An issue with severity Error is reported otherwise.
- Mandatory column CurrencyFunctionalID checked to be set and valid for all transactions.  An issue with severity Error is reported otherwise.
- Mandatory column SYS_DataSetID checked to be set and valid for all transactions.  An issue with severity Error is reported otherwise.
- Mandatory column TransTypeID checked to be set and valid for all transactions.  An issue with severity Error is reported otherwise.
- Mandatory column AccTypeID checked to be set and valid for all transactions.  An issue with severity Error is reported otherwise.
- Mandatory column Transdate checked to be set and valid for all transactions.  An issue with severity Error is reported otherwise.

- Optional column ProductID checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column MarketID checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column SupplierID checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column ProjectID checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column ActivityID checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column Dim1 checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column Dim2 checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column Dim3 checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column Dim4 checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column CPLegalEntityID checked to be valid if not null.  An issue with severity Warning is reported otherwise.

- A check is made to see if anyone legal entity's transactions are mapped to more than one functional currency. A legal entity is associated with only one functional currency. If multiple functional currencies are found, an issue with severity Error is reported.

- **Personnel fact data**<br/>

- A check is made to see if duplicate rows exists. If duplicate rows are found, an issue with severity Error is reported.

- Mandatory column DepartmentID checked to be set and valid for all transactions.  An issue with severity Error is reported otherwise.
- Mandatory column EmployeeID checked to be set and valid for all transactions.  An issue with severity Error is reported otherwise.
- Mandatory column Transdate checked to be set and valid for all transactions.  An issue with severity Error is reported otherwise.

- Optional column ProjectID checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column ActivityID checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column Dim1 checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column Dim2 checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column Dim3 checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column Dim4 checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column CPLegalEntityID checked to be valid if not null.  An issue with severity Warning is reported otherwise.

- **Driver based fact data**<br/>

- A check is made to see if duplicate rows exists. If duplicate rows are found, an issue with severity Error is reported.

- Mandatory column DepartmentID checked to be set and valid for all transactions.  An issue with severity Error is reported otherwise.
- Mandatory column EmployeeID checked to be set and valid for all transactions.  An issue with severity Error is reported otherwise.
- Mandatory column Transdate checked to be set and valid for all transactions.  An issue with severity Error is reported otherwise.

- Optional column ProductID checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column MarketID checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column SupplierID checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column ProjectID checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column ActivityID checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column Dim1 checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column Dim2 checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column Dim3 checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column Dim4 checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column CPLegalEntityID checked to be valid if not null.  An issue with severity Warning is reported otherwise.

- **Fixed assets**<br/>

- Mandatory column LegalEntityID checked to be set and valid for all transactions.  An issue with severity Error is reported otherwise.
- Mandatory column DepartmentID checked to be set and valid for all transactions.  An issue with severity Error is reported otherwise.
- Mandatory column AccountID checked to be set and valid for all transactions.  An issue with severity Error is reported otherwise.
- Mandatory column AssetCost checked to be set for all transactions.  An issue with severity Error is reported otherwise.
- Mandatory column StartDate checked to be set and valid for all transactions.  An issue with severity Error is reported otherwise.
- Mandatory column DepreciationPct checked to be set for all transactions.  An issue with severity Error is reported otherwise.
- Mandatory column IsDeclining checked to be set for all transactions.  An issue with severity Error is reported otherwise.

- Optional column AccountAgioDisagio checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column AccountDepreciation checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column AccountProfitLoss checked to be valid if not null.  An issue with severity Warning is reported otherwise.
- Optional column CounterAccount checked to be valid if not null.  An issue with severity Warning is reported otherwise.
