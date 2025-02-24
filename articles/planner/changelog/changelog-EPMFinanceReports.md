# EPM Finance Reports

## Package description

EPM Finance Reports package contains the finance report as they are deployed across versions under "Finance Reports" separate meny using primary dimension data and inside a version using local dimensions data.

## EPM Finance Reports Versions

- [EPM Finance Reports 1.2.2](#epm-finance-reports-122) - Released 2025.02.24
- [EPM Finance Reports 1.1.1](#epm-finance-reports-111) - Released 2024.04.24
- [EPM Finance Reports 1.1.0](#epm-finance-reports-110) - Released 2024.01.26
- [EPM Finance Reports 1.0.2](#epm-finance-reports-102)
- [EPM Finance Reports 1.0.1](#epm-finance-reports-101)

## Unreleased

- Nothing yet.

## EPM Finance Reports 1.2.2

**Changes:**

**Fixes:**

## EPM Finance Reports 1.1.1

**Changes:**

- None

**Fixes:**

- Year total column sum of periodes shows wrong value (#1666)
- Trial Balance is changed to allow showing published data from Consolidation versions (#1650)
- Wrong values for OB column in reports when adjusting OB for and plan start periode is 1 (typical for Budget) (#1632)

## EPM Finance Reports 1.1.0

- **Show number by quarter in Finance Reports** This is an enhancement to Finance Compare- and Periods report (#1546).

Periods in a fiscal year can be displayed using month or quarter (new).

![image](https://profitbasedocs.blob.core.windows.net/plannerimages/changelog-epm-finance-reports-110-compare.png)

   Likewise the compare report can now compare quarters in addition to months.

![image](https://profitbasedocs.blob.core.windows.net/plannerimages/changelog-epm-finance-reports-110-quarter.png)

   Likewise drilldown to accounts is grouped by quarter.

Changed: Functional: Yes; User interface: No; Data model/schema: No

- **OB column missing numbers** when plan start date is the first day of year which is typical for budgeting. This issue applies for: Trial Balance Report and Year and Months drilldown to accounts. This error was introduced in EPM Finance Reports v1.0.2.(#1512)

Changed: Functional: Yes; User interface: No; Data model/schema: No

- **Cash Due report fails with error message** ""The column 'LegalEntityID_Name' was specified multiple times for 'R0'." when optional columns LegalEntity and CpLegalEntity is selected" (#1470)

Changed: Functional: Yes; User interface: No; Data model/schema: No

## EPM Finance Reports 1.0.2

- Minor change: Trial balance - drilldown to account from OB and Total columns removed.

## EPM Finance Reports 1.0.1

- "Cash Monthly" report have incorrect cash in January for version with start month 1 (#1282)
- "Cash Monthly" report is not loading on filter change if report is not already cashed. Navigate to other report and back to get report cashed and loaded. (#1286)
- Filters in top section of finance reports that are not relevant for the selected report page, are hidden but still active when moving cursor over where the filter was located. This is fixed and "hidden" filters can not be reached. (#1313)
- "Cash Due" report changed to allow multiple cash accounts and changed bottom row to CB. Note that that cash accounts is using CashLineOfCredit mapped accounts which will limit number of cash accounts to one per Legal Entity. This limitation will also affect Opening Balance (OB). (#1323)
- "Trial Balance" drilldown report - corrected bug for missing filter on selected scenario. (#1330)
- Inline filtering added to drill down reports available from Finance Report (Compare page, Year and Months page, Trial Balance page and Cash Due page) (#488)
- "Cash Due" report calculated wrong opening balance for next period (OB row).(#1347)
