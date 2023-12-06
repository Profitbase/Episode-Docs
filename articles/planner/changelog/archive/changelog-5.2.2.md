# Changelog 5.2.2

The top section contains an abstract of the new features and main changes. The bottom section contains a detailed list of GitLab issues registered for this release. Items marked with "Bug" contains bug fixes.

**General**
This covers enhancements and changes applicable from platform and overall configuration.


**EPM Planner**
This package provide the financial planning function and can be organized in processes (e.g. Forecast) and one or more versions.

Changes:

- Ability to control context menu (Add / Delete row) #992
- Driver based models - ability to execute formula in offset period #950
- Plan overview - ability to add multiple comments per row #944
- Personnel module - ability to detail general settings on the Employee dimension #906
- Account, Personnel and Driver based modules - ability to drill to individual planned transaction from account details report #888
- Menu element Access Control removed as this is just a subset of User Management. Use User Management (with the solution picker) in stead #1046

**EPM Reporting Master**
This package provide central management of dimensions, report setup and group account mapping.

Changes:

- Report setup - ability to detail mapping to report lines by more than the account dimension #131
- Report Trial Balance - drilldown report to view detailed for account and period #1026
- Report Cash Due - new report with drilldown to show cash payments due from simulation modules #1026


**EPM Datamart**
This package provide a datamart to share data between EPM applications and external producers and consumers. Import, export and currency exchange rates is functions provided here.

Changes:

- Data import & export - new File import page with ability to import financial trial balance, etc. from local csv file
- Data import & export - ability to add / (soft) delete system rule sets
- All webfunctions adapted to match new requirements from .NET and connections. Needed from invision platform version: 2022.?

**EPM Common**
This package provide the users and access management, work process and tasks capabilities and operations management and scheduling operations.

Changes:

- Operation manager - ability to attach operations to workbook
- Operation manager - ability to add / (soft) delete system operations
- Process admin - new configuration to limit number of emails sent per batch.
- Process admin - new configuration to include a custom message with tasks.

**Known issue**

The following breaking change:

Duplicate export view Export_Master_CurrencyExchangeRatesMonthly and synonym SYN_Master-CurrencyExchangeRatesMonthly removed. If your solution makes use of these, switch to using export source CurrencyExchangeRatesMonthly instead which points to SYN_Datamart_CurrencyExchangeRatesMonthly #1013

**Bug fixes and GitLab reference list**

- Finance Settings - OB due for vacation pay got better documentation on how to set up payment for this year and next year based on accrued last year (=OBYear) and accrued year-to-date (=OB this period) to be paid next year. #893
- Finance Reports reports: "Year and Months" and "Trial Balance" may appear empty when selecting certain currencies #1007
- Error: Finance Reports Year and Months - Pressing Ikon to get details per account #1006
- Personnel - incorrect validation error if Dim1 is set mandatory #991
- Selection from ranked input tables - issues when dimension members are partially equal #990
- Missing levels in employee dim when publish from primary dim #986
- Data Export Error on Synonyms aimed at SQL Views #984
- Personell module: Error message in Spread to periods popup #959
- Driverbased model copy does not include calc order #957
- Posting days does not kick in from accrued settings #948
- Opening Balance is generated wrong when pbTransdatahistory does not contain data in AmountForeign Field #945
- Operation manager: Operation on a non active process #933
- Operation History log is not correct #880
- Operation manager right side activity monitor interaction not working as expected #817
- Duplicate workbooks available in Go to task dropdown #581
- Operation Manager: Script with arguments fails in scheduled operations #1040
- Operation side table grows out of control in common 5.20, 5.2.1 #1038
- Deleting Process and operations # 1031
- Error when trying to override an assumption in a driver based model. #1021
- Missing table for intercompany/elimination #1005
- Data Export of Synonyms aimed at SQL Views with Export Name set - Export Name skipped #999
- Pension employees does not calculate through engine #987
- Driver based modelling: Refresh button does not refresh #960
- Personell module: Error message in Spread to periods popup #959
- Driverbased model copy does not include calc order #957
- Finance report to improve controll of cash flow #1026
- Finance reports cannot have Employee dim available #1039
