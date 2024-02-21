This document contains the new features and changes to EPM Reporting package release 1.1.0 and EPM Finance Reports 1.1.0.

EPM Reporting package provide central management of dimensions, report setup and group account mapping.

EPM Finance Reports package contains the finance report as they are deployed across versions under "Finance Reports" separate meny using primary dimension data and inside a version using local dimensions data.

The top section contains an abstract of the new features and main changes. The bottom section contains a detailed list of GitLab issues registered for this release. Items marked with "Bug" contains bug fixes.

## EPM Reporting 1.1.0

- **Forecast Export including actuals part**. A new view CPV_Export_Planner_ReportAccountByMonthAllYear is created that will enable export of the actual periods together with plan periods. This data set contains:
  - Actual periods for the periods before plan start date
  - Plan start opening balance marked TransdateID = '0' for plan start date. Normally this is the equal to actual Year-to-date, however it is possible to adjust plan opening balance. This is important to be aware of when consuming this export
  - Plan output for periods after and including the plan start period.

This is an enhancement responding to several user requests (#1332).

Changed: Functional: Yes; User interface: No; Data model/schema: No

- **Error message "Cannot insert the value NULL into 'ReportID'"** This error messaged is caused by deselecting the mandatory "INPUT" report in Report Setup.

![pic](https://profitbasedocs.blob.core.windows.net/plannerimages/Reporting110ChangeLogImage1.JPG)

Validation is changed to prevent users from deselecting "INPUT" report. (#997)

Changed: Functional: Yes; User interface: No; Data model/schema: No

- **Report names missing translations** This will cause report names to appear without a name and appear as "(Blank)" (#1444). 

Changed: Functional: Yes; User interface: No; Data model/schema: No

## Changes to package EPM Finance Reports 1.1.0:

- **Show number by quarter in Finance Reports** This is an enhancement to Finance Compare- and Periods report (#1546). 

Periods in a fiscal year can be displayed using month or quarter (new). 

![pic](https://profitbasedocs.blob.core.windows.net/plannerimages/Reporting110ChangeLogImage2.JPG)

   Likewise the compare report can now compare quarters in addition to months.

![pic](https://profitbasedocs.blob.core.windows.net/plannerimages/Reporting110ChangeLogImage3.JPG)

   Likewise drilldown to accounts is grouped by quarter.

Changed: Functional: Yes; User interface: No; Data model/schema: No

- **OB column missing numbers** when plan start date is the first day of year which is typical for budgeting. This issue applies for: Trial Balance Report and Year and Months drilldown to accounts. This error was introduced in EPM Finance Reports v1.0.2.(#1512)

Changed: Functional: Yes; User interface: No; Data model/schema: No

- **Cash Due report fails with error message** ""The column 'LegalEntityID_Name' was specified multiple times for 'R0'." when optional columns LegalEntity and CpLegalEntity is selected" (#1470)

Changed: Functional: Yes; User interface: No; Data model/schema: No
