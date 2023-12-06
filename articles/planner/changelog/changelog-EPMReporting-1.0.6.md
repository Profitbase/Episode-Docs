# Changelog EPM Reporting 1.0.6

This document contains the new features and changes to EPM Reporting package release 1.0.6 and EPM Finance Reports 1.0.1.

This package provide central management of dimensions, report setup and group account mapping.

The top section contains an abstract of the new features and main changes. The bottom section contains a detailed list of GitLab issues registered for this release. Items marked with "Bug" contains bug fixes.

### Gitlab Issues

Package EPM Reporting 1.0.6:

- Error when mapping many accounts to report line - account mapping limited to 8000 bytes (#1260)
- Finance Reports: Error message when including counterparty column (Error: Failed to execute the query. Invalid column name 'CpLegalEntityID_Name'.) (#1194)
- Additional Dim Mapping missing dimension member name (#1252)
- "Forecast Start" label not showing on plan datasets. This is causing 2 rightmost columns in Cash Monthly to not show. (#1291)

Package EPM Finance Reports 1.0.1:

- "Cash Monthly" report have incorrect cash in January for version with start month 1 (#1282)
- "Cash Monthly" report is not loading on filter change if report is not already cashed. Navigate to other report and back to get report cashed and loaded. (#1286)
- Filters in top section of finance reports that are not relevant for the chosen report page, are hidden but still active when moving cursor over where the filter was located. This is fixed and "hidden" filters can not be reached. (#1313)
- "Cash Due" report changed to allow multiple cash accounts and changed bottom row to CB. Note that that cash accounts is using CashLineOfCredit mapped accounts which will limit number of cash accounts to one per Legal Entity. This limitation will also affect Opening Balance (OB). (#1323)
- "Trial Balance" drilldown report - corrected bug for missing filter on selected scenario. (#1330)
- Inline filtering added to drill down reports available from Finance Report (Compare page, Year and Months page, Trial Balance page and Cash Due page) (#488)
- "Cash Due" report calculated wrong opening balance for next period (OB row).(#1347)
