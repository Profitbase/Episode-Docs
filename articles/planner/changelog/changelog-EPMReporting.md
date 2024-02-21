# EPM Reporting

This document contains the new features and changes to EPM Reporting package release 1.1.0 and EPM Finance Reports 1.1.0.

EPM Reporting package provide central management of dimensions, report setup and group account mapping.

EPM Finance Reports package contains the finance report as they are deployed across versions under "Finance Reports" separate meny using primary dimension data and inside a version using local dimensions data.

The top section contains an abstract of the new features and main changes. The bottom section contains a detailed list of GitLab issues registered for this release. Items marked with "Bug" contains bug fixes.

## Content

- [EPM Reporting 1.1.1](epm-reporting-111)
- [EPM Reporting 1.1.0](epm-reporting-110)
- [EPM Financial Reports 1.1.0](epm-financial-reports-110)
- [EPM Reporting 1.0.7](epm-reporting-107)
- [EPM Financial Reports 1.0.2](epm-reports-102)
- [EPM Reporting 1.0.6](epm-reports-106)
- [EPM Financial Reports 1.0.1](epm-reports-101)

## EPM Reporting 1.1.1

**Bug fixes and GitLab reference list:**

- Timefunction filter - Norwegian characters is replaced by ? (#1635)
- Historical numbers disapers in report lines (not trial balance) after publish changes in reports (#1634)

## EPM Reporting 1.1.0

- **Forecast Export including actuals part**. A new view CPV_Export_Planner_ReportAccountByMonthAllYear is created that will enable export of the actual periods together with plan periods. This data set contains:
  - Actual periods for the periods before plan start date
  - Plan start opening balance marked TransdateID = '0' for plan start date. Normally this is the equal to actual Year-to-date, however it is possible to adjust plan opening balance. This is important to be aware of when consuming this export
  - Plan output for periods after and including the plan start period.

This is an enhancement responding to several user requests (#1332).

Changed: Functional: Yes; User interface: No; Data model/schema: No

- **Error message "Cannot insert the value NULL into 'ReportID'"** This error messaged is caused by deselecting the mandatory "INPUT" report in Report Setup.

![image](uploads/3507b910e41af6648914497d24af1713/image.png)

Validation is changed to prevent users from deselecting "INPUT" report. (#997)

Changed: Functional: Yes; User interface: No; Data model/schema: No

- **Report names missing translations** This will cause report names to appear without a name and appear as "(Blank)" (#1444).

Changed: Functional: Yes; User interface: No; Data model/schema: No

## EPM Finance Reports 1.1.0

- **Show number by quarter in Finance Reports** This is an enhancement to Finance Compare- and Periods report (#1546).

Periods in a fiscal year can be displayed using month or quarter (new).

![image](uploads/650db01fad9019c7dc22337b1ed812a5/image.png)

   Likewise the compare report can now compare quarters in addition to months.

![image](uploads/2e2335305c953908485c7c89765d7206/image.png)

   Likewise drilldown to accounts is grouped by quarter.

Changed: Functional: Yes; User interface: No; Data model/schema: No

- **OB column missing numbers** when plan start date is the first day of year which is typical for budgeting. This issue applies for: Trial Balance Report and Year and Months drilldown to accounts. This error was introduced in EPM Finance Reports v1.0.2.(#1512)

Changed: Functional: Yes; User interface: No; Data model/schema: No

- **Cash Due report fails with error message** ""The column 'LegalEntityID_Name' was specified multiple times for 'R0'." when optional columns LegalEntity and CpLegalEntity is selected" (#1470)

Changed: Functional: Yes; User interface: No; Data model/schema: No

## EPM Reporting 1.0.7

- **Improved language support**. Danish and Swedish introduced as new languages. Account dimension includes new Danish and Swedish language properties. Self-service setting table introduced in Report Setup  for maintaining solution specific language texts such as reports, report lines, etc. (#1363)

## EPM Finance Reports 1.0.2

- Minor change: Trial balance - drilldown to account from OB and Total columns removed.

## EPM Reporting 1.0.6

- Error when mapping many accounts to report line - account mapping limited to 8000 bytes (#1260)
- Finance Reports: Error message when including counterparty column (Error: Failed to execute the query. Invalid column name 'CpLegalEntityID_Name'.) (#1194)
- Additional Dim Mapping missing dimension member name (#1252)
- "Forecast Start" label not showing on plan datasets. This is causing 2 rightmost columns in Cash Monthly to not show. (#1291)

## EPM Finance Reports 1.0.1

- "Cash Monthly" report have incorrect cash in January for version with start month 1 (#1282)
- "Cash Monthly" report is not loading on filter change if report is not already cashed. Navigate to other report and back to get report cashed and loaded. (#1286)
- Filters in top section of finance reports that are not relevant for the chosen report page, are hidden but still active when moving cursor over where the filter was located. This is fixed and "hidden" filters can not be reached. (#1313)
- "Cash Due" report changed to allow multiple cash accounts and changed bottom row to CB. Note that that cash accounts is using CashLineOfCredit mapped accounts which will limit number of cash accounts to one per Legal Entity. This limitation will also affect Opening Balance (OB). (#1323)
- "Trial Balance" drilldown report - corrected bug for missing filter on selected scenario. (#1330)
- Inline filtering added to drill down reports available from Finance Report (Compare page, Year and Months page, Trial Balance page and Cash Due page) (#488)
- "Cash Due" report calculated wrong opening balance for next period (OB row).(#1347)
