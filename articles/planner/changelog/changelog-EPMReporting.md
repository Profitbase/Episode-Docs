# EPM Reporting

## Package description

EPM Reporting package provide central management of dimensions, report setup and group account mapping.

## EPM Reporting versions

- [EPM Reporting 1.2.2](#epm-reporting-122) - Released 2025.02.24
- [EPM Reporting 1.1.1](#epm-reporting-112) - Released 2024.04.24
- [EPM Reporting 1.1.1](#epm-reporting-111) - Released 2024.02.21
- [EPM Reporting 1.1.0](#epm-reporting-110) - Released 2024.01.26
- [EPM Reporting 1.0.7](#epm-reporting-107)
- [EPM Reporting 1.0.6](#epm-reporting-106)

## Unreleased

- Nothing yet

## EPM Reporting 1.2.2

**Changes:**

**Fixes:**


## EPM Reporting 1.1.2

**Changes:**

- None

**Fixes:**

- Group account mapping - account name showing wrong language (#1658)
- Finance Reports optional columns may not show all columns (#1653)
- Finance Reports dropdown list man show (blank) elements due to defect in translations (#1649)

## EPM Reporting 1.1.1

**Changes:**

- None

**Fixes:**

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

![screenshot of report list](https://profitbasedocs.blob.core.windows.net/plannerimages/changelog-epm-reporting-rapporter.png)

Validation is changed to prevent users from deselecting "INPUT" report. (#997)

Changed: Functional: Yes; User interface: No; Data model/schema: No

- **Report names missing translations** This will cause report names to appear without a name and appear as "(Blank)" (#1444).

Changed: Functional: Yes; User interface: No; Data model/schema: No

## EPM Reporting 1.0.7

- **Improved language support**. Danish and Swedish introduced as new languages. Account dimension includes new Danish and Swedish language properties. Self-service setting table introduced in Report Setup  for maintaining solution specific language texts such as reports, report lines, etc. (#1363)

## EPM Reporting 1.0.6

- Error when mapping many accounts to report line - account mapping limited to 8000 bytes (#1260)
- Finance Reports: Error message when including counterparty column (Error: Failed to execute the query. Invalid column name 'CpLegalEntityID_Name'.) (#1194)
- Additional Dim Mapping missing dimension member name (#1252)
- "Forecast Start" label not showing on plan datasets. This is causing 2 rightmost columns in Cash Monthly to not show. (#1291)
