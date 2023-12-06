# Audit

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5.2 or later.

## Overview

<br/>
This page contains an audit report that should be used to assess the data quality of data within the given version. Click the "Run audit" button to execute the report.

If the report yields no result rows, everyting is fine.

If the report yields result rows, issues exist, please see below for a description of the report's columns.
<br/>

## Descriptions

The report contains an in-line filter row on top that enables you to filter out certain rows of data. Type in the filter row and use the tab key (exit from cell) to execute filter.

The report contains the following columns:

- **Severity**<br/>
The severity of the issue found (Error | Warning | Information)
- **Object Name**<br/>
The solution object (table, dimension, setting, etc.) to which the issue is related.
- **Column Name**<br/>
The column name to which the issue is related.
- **Input module**<br/>
The input module (if relevant) to which the issue is related.
- **Audit text**<br/>
A description of the issue itself. Note that the audit text will always be presented in English.<br/>

##Audit checks made

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

- **Financial plan data**<br/>

- Any financial plan transaction data stemming from any of the plan input modules that are not associated with a report line. Any such case are reported with severity Error.
- Missing currency exchange rates. Any such cases reported with severity Error.
- Missing or non-published Input report (report used in Plan overview). Any such cases reported with severity Error.
- Accounts mapped to multiple report lines for Input report without any additional dimension mapping defined. Any such cases reported with severity Error.
- Accounts present in the financial engine source (stemming from input modules) that are not mapped to a financial engine. Any such cases reported with severity Error.
- Accounts present in the payroll financial engine source (stemming from input modules) that are not mapped to the Payroll financial engine. Any such cases reported with severity Warning.
- System fallback accounts that are not mapped to actual accounts (and thus renders in reports with system names). Any such cases reported with severity Warning.
