---
title: "Export data"
metaKeys: ""
folderOnly: "false"
pageIndex: 3
---

## Overview

This module is used to export data from Profitbase Planner to external sources, such as CSV files in Azure blob storages or any SQL database made available.
<br/>

Each export "ruleset" created can either be started manually from the Data Export module, or be used to generate an operation (todo: link to Operation Manager).
<br/>

The general principle for Data Export jobs is:
<br/>
<br/>
1 - Select a source within Profitbase Planner.
<br/>
2 - Column Mapping must be set up to match the correct columns between the source table or view, and the actual destination table. This step allows for SQL transform formulas.
<br/>
3 - Once the column mapping has been set up, the "Execute Now" button will become active. This button will then do execute the export job and move the data using the column mapping rules to the destination table.
<br/>

![](img/DataExport.png)

<br/>

Buttons will become active once the required information has been set up.

<br/>

#### Creating a new RuleSet for Data Export
<br/>
Click an existing RuleSet in the list to open it.
<br/>
Click the "Add ruleset" button above the list to create a new ruleset.
<br/>
Each section for the ruleset will be described below.
<br/>

<br/>

##### DATA EXPORT RULESET

<br/>
<b>Ruleset name:</b> A short name for the data import job, so it can easily be identified in the list.
<br/>
<b>Data Source:</b> Current options are defined by a Profitbase Planner admin. Typically, these will be Views or Tables accessed via a synonym. A preview button will show up to 200 rows of that data. Click the arrow behind preview, to view the "Create Table Statement": this is useful if you need to create a copy of that table somewhere. For instances hosted by Profitbase, an export to Excel is also available.
<br/>
<b>Select Export Name:</b> If the source contains a column called "ExportName" (compound views), selection is mandatory.
<br/>
<b>SQL WHERE clause on source: (Optional):</b> Filter the source with custom SQL code. Do not specify the keyword "WHERE", just the conditions.
<br/>
<b>Connection:</b> Select a [Connection](/planner/workbooks/data-management/connections) from the list. Changing this field will trigger an automatic save.
A "Test Connection" button is available, and will also be automatically triggered when loading a ruleset with a connection. A "browse" button will be enabled for valid Azure Blob connections, to view the files.

<br/>

##### CONFIGURE DESTINATION: AZURE BLOB STORAGE - CSV FILE (Option 1)

<br/>
<b>File name:</b> The file will be created with that name. If a file exists with the same name, it will be overwritten.
<br/>
<b>Column delimiter:</b> The symbol used inside the CSV file to separate the columns. Typical values are either <b>,</b> or <b>;</b>
<br/>
<b>Text qualifier:</b> The symbol used inside the CSV file to wrap data strings. Most common is <b>"</b>
<br/>
<b>Date Format:</b> Leave as default, or enforce a transform format for all dates and datetimes.
<br/>

<br/>

##### CONFIGURE DESTINATION: DIRECT SQL (Option 2)

<br/>
<b>Destination table:</b> Select from the list of tables on the destination. If the connection fails, this list will be empty.
<br/>
<b>Select delete method:</b> Select from the list of options:
<br/>
 - Append all: All data will be added to the destination.
 <br/>
 - Replace all: All data in the destination will be replaced. "Truncate" will be faster but require elevated permissions.
 <br/>
 - Custom SQL: Write the SQL where clause to select what data will be removed from the destination.
 <br/>
 - Stored Procedure: Select from the list of stored procedures found on the destination.
<br/>

##### COLUMN MAPPING

<br/>
Mandatory step to perform the copy of data from the SQL temporary table to the final destination.
<br/>
This will tell the system which column to put where, as the column names don't necessarily match.
<br/>
Here is a basic example:
<br/>

![](img/ColumnMappingExample.PNG)

<br/>
EmployeeID will be imported as-is.
<br/>
If the Employee name is "Lisa", it will be replaced with "Nico". This can be used to add any logic, and may even reference other columns.
<br/>
EmploymentType_Name will be left to NULL for all rows in the destination, regardless of imported data (no string delimiters).
<br/>
EmploymentType will be "Programmer" for all rows in the destination, regardless of imported data (note the string delimiters).
<br/>
ModifyType and PBRowIdentity will be ignored.
<br/>
After the column mapping has been saved, a summary will be displayed in the final section:
<br/>

![](img/ColumnMappingExample_result.PNG)

<br/>
Clicking auto-cast, will use any mappings set up, and automatically add a transform formula. If transforms have already been added, they will be wrapped in this additional casting.

<br/>

##### (Optional) Creating Operations to automate Data Exports

To run an export job, click the "Execute Now" button.
<br/>
This will perform all the steps above, which consists of one step, a dataflow with an argument (the export ruleset GUID).
<br/>
If you wish to automate this job or just expose it to the "Operation Manager" module of the Profitbase Planner, the "Create Operation" button will create an operation with the same name as the ruleset, under the application "EPMDataMart" and the category "Data Export".
<br/>

## Related Pages

[Data Import](/planner/workbooks/administration/data-import/import-data)
[Scheduled Operations](/planner/workbooks/administration/OperationManager/ScheduledOperations)
[Operations](/planner/workbooks/administration/OperationManager/Operations)
