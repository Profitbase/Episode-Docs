---
title: "Changelog 5.2.0"
metaKeys: "About Profitbase InVision, terminology, Concepts Clarification, Platform ,Customer solution, Product, EPM suite, Business module, Base package, Configuration, Modification, Custom, Work Process/process, Version, Task, Settings, Calculation, Planning vs budget/forecast, Sandbox, Planner, Standard Planner, Extended Planner, Simulation, Sensitivity, Analysis, Assumption, Blueprint, Blueprint solution, Package, Template, Data Mart, Data Pool, Compound View, InVision Solution, Platform upgrade, Package upgrade, Synonym, Cloning of solution, Partner, Implementation, Referral, Full, InVision "
pageIndex: 99
---
This document contains the new features and changes to Planner release 5.2.0.

The top section contains an abstract of the new features and main changes. The bottom section contains a detailed list of GitLab issues registered for this release. Items marked with "Bug" contains bug fixes.

**General**  
This covers enhancements and changes applicable from platform and overall configuration.

- Administrative functions is not available under the same menu group. #847
- New default user groups has been introduced with much more granular control than previously.

**EPM Planner**  
This package provide the financial planning function and can be organized in processes (e.g. Forecast) and one or more versions.

Changes:  

- Account - restore default distribution key for multiple rows. #735

- Auto-transactions in driver based models can post to other departments. #306

- Use FTE and Headcount (new measure) to control employee related cost. Headcount is new measure that can be set similar to FTE. These measures can be used as scaling factor for employee benefits cost. #384

- Plan proposal changes for replacing data when importing. #758

- Changes to account dimension - removed AccountGroupID column/property. Note that this version supports parent child type dimensions and hence fixed levels is not longer an issue. #760

- Internal: @SYS_DataSetID is not longer part of the data context. This is because versioning provides a more flexible way to deal with different datasets. #749

- Setting for reporting and default reporting currency. #812

- Source fact data for driver-based models viewer enhancements. #796

- Access control ability on Project and Activity dimensions #664


**EPM Reporting Master**  
This package provide central management of dimensions, report setup and group account mapping.

Changes:  

- Dimension Management changed and enhanced to allow parent child and properties editing and import. The concept now is to manage dimensions centrally and publish (means copy) to versions.

- Group account mapping used to map company accounts to common set of group accounts. #846

- Currency conversion improvements applicable to actual and plan data reporting.

- The report "Cash Monthly" is changed to show adjustment made due to Plan Opening Balance when plan start date is after the first fiscal period. #870

- This version implements central management of reports and dimensions. Report setup and dimensions can be "published" to other versions.

**Warning!**  
>Different dimension content in different plan versions will affect how data is aggregated, filtered and presented and hence may make comparing data confusing.

- Report showing periods and trial balance report need to deal with the mix of actual data and plan data. These reports is presenting actual data in periods before plan start period and plan data in periods after. All plan data must have an opening balance which is normally generate from actual to year-to-date. However this balance can be changed manually. Using Timefunction = month will sum the OB and monthly change columns to "Total" column. Using Timefunction = year-to-date will include plan OB and periods sum to  "CB" column. #777, #828

**EPM Datamart**  
This package provide a datamart to share data between EPM applicaitons and external producres and consumers. Import, export and currency exchange rates is functions provided here.

Changes:  

- Data import now have predefined operations for all dimension and transactions types.

- Data export got more options to deal with replacing data in destination table and test destination connection. #752 #704

**EPM Common**  
This package provide the users and access management, work process and tasks capabilities and operations management and scheduling operations.

Changes:  

- Default roles for Planner access

- Improvements to internal communications (Web-functions) to avoid e.g. listing wrong steps in selected operation.

- More information available when scheduled operations fails.

- Manage workbook and data permissions from "Users and Group" workbook. #810

**Bug fixes and GitLab reference list**  

- Tasks - go to drop down incorrect in upgraded solution - #876 Bug
- 5.2 - Simplify workbook menu - #847
- Cash monthly Total column for top row show wrong value when plan start is into the year - #870 Bug
- 5.2 - Operations will not execute in deployed solution - #866 Bug
- INPUT report must be used for mapping accounts to reportline in the Account module - #827 Bug
- 5.2 - Report Setup publish to version dialogue - missing buttons for executing - #867 Bug
- Validation error personell input - #862
- 5.2 finance reports label - #869 - Bug
- Auto transactions - ability to target alternative department (other than source department) - #306
- Cash report with wrong cash total in version 5.1.3 - #815 Bug
- Dimension Manager - Department dimension - deleted member added to version dimension after publish - #863
- Planner Tax calculation does not include the profit ytd when plan start is into the year. - #791 Bug
- Finance Reports Trial Balance showing Balances (YTD) - confusing when looking at department level and company due to shortterm finance interest - #777
- Finance reports, difference betweene YTD and month view on department level - #828 Bug
- V5: Salary additional columns affected by FTE or not - #384
- Add Power BI reportline mapping column to Report Setup - #415
- Project and activity dimension (dimension expansion in general) - #339
- Data export - Timeout on delete when using Replace all - #752
- 5.1.0 - data export test connection - #704
- 5.2 Operations - issues - #845 Bug
- Data export - export name requirement only if source is cpv view - #814 Bug
- Cashflow report, CashTotalOverview, adding up OB from multiple years - #754 Bug
- OBDue OB value causing duplicates when TextID used to split payment - full OB value on both. #629 Bug
- 5.2 - Implement Account mapping - legal entity specific chart of account to common chart of account - #846
- Plan proposal, account and driver based, delete when not matched by source - #758
- Planner5.2: Account dimension rework - remove AccountGroupID from Account dimension and dependencies - #760
- 5.2 Remove @SYS_DataSetID data context filter from financial engines - #749
- Finance all scenario - #813
- Enable setting default reporting currency - #812
- Make Workbooks and Data Permissions available from the Users and Groups workbook - #810
- Source fact data enhancement - show but not edit measures loaded from external fact - #796
- Access control on Project and Activity dimensions - #664
- Measure dropdown filtering from driverbased model - #795
- Delete process still available in Version attributes and process administration++ - #799
- Import Export - 5.1.2 Enhancements - #717
- Loan Principal override - #698 Bug
- Loan principal override from date - #699
- Account - restore default distribution key for multiple rows - #735
- Plan Overview different from Finance Reports due to missing Employment Tax on pension for vacation month - #967
