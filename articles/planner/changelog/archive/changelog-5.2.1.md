# Changelog 5.2.1

The top section contains an abstract of the new features and main changes. The bottom section contains a detailed list of GitLab issues registered for this release. Items marked with "Bug" contains bug fixes.

**General**
This covers enhancements and changes applicable from platform and overall configuration.

**EPM Planner**
This package provide the financial planning function and can be organized in processes (e.g. Forecast) and one or more versions.

Changes:
- Improved integration with Tasks workbook
- Finance settings - addition of Audit page for self-checking data quality and consistency within version #848
- Finance settings - addition of Advanced page with ability to handle debit/credit miscellaneous postings #437
- Driver based models - ability to navigate directly to details view #924
- Driver based models - ability to disable Periods button per model #902
- Driver based models - list of models access controlled #554
- Driver based models - ability for deviation columns to inherit formatting from model setup  #860
- Driver based models - basic settings such as assumptions, distribution keys, etc. available in separate page in Input settings and administration workbook to allow users responsible access without having access to the Driver based modelling workbook #877
- Account - ignore distribution of totals (use if year-totals are planned to be 0) #759
- Support for subscription based planning - extension to custom transaction table and engine interface #905

**EPM Reporting Master**
This package provide central management of dimensions, report setup and group account mapping.

Changes:
- Improved integration with Tasks workbook
- Dimensions - ability to delete all dimension data from the Dimensions workbook
- Operation Manager - New operations added to support deletion of all dimension data
- Report Setup - improved validation with regard to special characters + - * / and overlapping accounts  #917 #915
- New report to show details on cash due by period. This show all types of cash including OB due postings and short-term cash interest. #373

**EPM Datamart**
This package provide a datamart to share data between EPM applications and external producers and consumers. Import, export and currency exchange rates is functions provided here.

Changes:
- Improved integration with Tasks workbook
- New workbook selector treeview in task popups
- Data Import & Export - improved collation handling for data export
- Data Import & Export - more flexible column mapping for import / export in cases where destination has more columns
- Data Import & Export - addition of Audit page for self-checking data quality and consistency related to data imported to Profitbase standard formats #806
- Ability to export currency exchange rates #903

**EPM Common**
This package provide the users and access management, work process and tasks capabilities and operations management and scheduling operations.

Changes:
- Improved integration with Tasks workbook
- New workbook selector tree-view in task popups
- New link icon in Operation Manager for import/export jobs; navigates to the appropriate ruleset.

**Known issue**
- Depending on the time zone and daylight savings time, a new version with a selected start date as the first day of a month may get a start date equal to the last day of the previous month. The workaround is to select a start date as the 2nd day of the month. #936

**Bug fixes and GitLab reference list**
- Finance Reports: Year and Month report will not show actual part of plan dataset in drilldown. #939
- Finance Reports: Error in compare showing 2x amount for Compare report #938
- Finance all baseline truncates and therefore deletes scenarios #937
- 5.2.1 - Data import from blob fails #930
- Driverbased module - error when navigating to a different department with details popup. #925
- Cash monthly in forecast periods != january #921
- Finance Reports - Scenario Trend and Trend report - Formula size max length violated #919
- Finance Reports - error message related to year filter for Year- month report. #918
- Report Setup - on first page and saving data to report different than INPUT, will reload INPUT on save #916
- Driver Based Modelling: Unused extra dimension creates two input rows #904
- ExternalDriverBasedFactFromLedger should also ignore excluded dimension members #900
- FixedAssets does not process the last change to plan overview on save #892
- 5.2 test finance reports #891
- Misc missing departmentID_DCD #885
- Task form - goto drop down - incorrect workbook name at aggregate node#884
- Workflow readwrite on the Ended state #881
- 5.2 finance reports label #869
- Bug - driver calculation #861
- Sum row in depreciation report in the CapEx module does not sum all rows. #858
- Finance settings, setup, DaysOfCredit Method: Monthly does not work #782
- Process task - assigment of duplicate email #779
- Planner 5.1.1 on 2022.1 - Placeholders are fixed in invision, causing minor layout issues #741
- Finance Reports: Cash due posting by period for plan data. #373
