# Changelog EPM Planner 5.4.0

This document contains the new features and changes to the EPM Planner release 5.4.0.

This package provide the financial planning function and can be organized in processes (e.g. Forecast) and one or more versions.

The top section contains an abstract of the new features and main changes. The bottom section contains a detailed list of GitLab issues registered for this release. Items marked with "Bug" contains bug fixes.

**Breaking Changes:**

These are changes that change the way Profitbase generate planner results or other changes that will require attention when upgrading and creating new version copying from existing versions.

- Pension calculation calculated for vacation month (where vacation month is determined from vacation pay due) by "copy" pension calculated from following month. This assumes salary is not payed in vacation month. This feature was implmented in Planner 5.1.0.

    The change in Planner version 5.4.0 is that there is a "Plus Vacation Mth" flag in PensionDueTerm to control this feature. (#659)

    The default for this flag is:
  - On - when upgrading solutions to make behaviour compatible with behaviour before Planner 5.4.0
  - Off - for new deployments

- Pension cost posting is changed to follow salary cost transaction date. In previous versions, pension cost posting was following the salary payment due. Use Finance Settings PensionDueTerm to control pension payment due. This change will only apply when salary accrued is in different month from salary posting. (#983)

**Changes:**

- **Plan overview: Display transactions in company's home currency in account drill to details report** Behavior of drill to detail report changed to always display transactions converted to the home currency (i.e. similar to the Account Details report) (#1275).
- Input sheet dimension drop down lists are sorted by Description (#634)
- Plan Overview performance improvement on summary nodes and included counterparty transactions on leaf-nodes. Update and save SalesAccountIC to ensure that counteraccounts are updated. (#1317).
- Improved functionality when legal entity association to department is changed. Historically, a change of legal entity association to a department has caused inconsistencies. The following improvements are made: Plan over view datastore is reloaded in stead of updated, taking into account only the current association. Input data is attempted updated with the current legal entity / currency functional data leaving the input numbers as is so long as this do not cause duplicates (new association assumed to be a correction to an incorrect association in the first place). The Audit report will report any duplicate department / legal entity combinations (#225)
- Driver based module - introduced Update method for updating data. To be used in cases when it is desirable to let the user control which input rows should exist, i.e. only existing input rows are updated, no new rows are inserted. Controlled with base setting DriverBasedLoadExternalSource (#1320)
- Comments from input included in account drill-to-details report, available from plan overview and input modules (#479)
- Personnel module - ability to control which cost columns the social cost override (OVR) input columns should apply to (#501).
- Option to **automatically adjust from and to dates of historic reference columns** when deploying a new version using the "Start fresh from new start date (reload data)" option. This deployment option is typically used when deploying a new version that constitutes a new plan year (i.e. no roll forward) using an existing version (typically this year's plan) as the source version so that relevant config and settings are copied. The deployment will reload data and in order to have as correct historic reference information as possible (controls content in input sheets in Account and Driver Based), a new base setting (AutoAdjustHistRefSetup) is introduced that will (if set to TRUE which is also the default) auto adjust the from and to dates of any historic reference columns used based on the difference between the start date of the source version and the new start date. This adjustment is done prior to the reload so that the reload is affected by the adjusted from and to dates (#1306).
- **Allocation functionality** included in a **preview** state which means it is function-complete but testing, usability development and documentation/help is not complete but will be completed in later version(s). Implementation projects that require allocation functionality may however start using the functionality and report back on functional fit and encountered issues. (#130)
- Plan overview - Dim1..Dim4 introduced as filters (#1245)
- Investments - investment amounts eligible for Plan Overview if asset account is mapped to a Plan Overview report line (#1055). It is also possible to input investments in year prior to the plan year so that depreciation from any investments planned in the year leading up to the plan year but is not yet booked as a fixed asset is included in the plan (#978)
- Built-in cell sum, count and average function for input sheets and reports enabled (#1319)

   **Improved customization options** (ref. [Customization Patterns](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.3/Planner%20Customization%20Patterns.pdf)document for details):

- Ability to execute custom script logic in FinanceAll dataflows (#1308) The FinanceAll dataflows (FinanceAllBaseline and FinanceAllScenario) source transactions from input modules and executes financial engines producing a complete future ledger. In some cases it may be desirable to introduce custom logic before the financial engines starts and after the financial engines have finished. One use case may be to add scenario data to the sales price list from say a driver-based model before the execution of financial engines if simulation on price is required.
- Ability to configure a custom button and a custom row context menu in Plan overview and input modules for Account, Personnel and Driver based. The custom buttons and row context menus can open a custom workbook and signal the dimensional context from the calling workbook. (#1217)
- EPM Datamart destination store for imported **plan data** accessible via synonym SYN_Datamart_pbTransdataSourceCMExternal. Use Data Import to import plan data from external sources that are to be included as transactions (i.e. no input) in the plan to this store. SQL Script ImportFrompbTransdataSourceCMExternal in EPM Planner can be used to import the data to a planner version identified by a ModuleExtensionID (create an operation and include script). (#1344)

**Bug fixes and GitLab reference list:**

- TaxPct table is not working with more than one line which means that different tax percent cannot be set for legal entities. Must use the same tax percent (average) for all legal entities. Fixed by settings on ranked in put configuration (in designer) (#1295)
- Plan overview: Counterparty transactions not visible on default department (#1196)
- Pension in vacation month handeled different in finance reports and plan overview (#1224)
- Finance settings: Rules with different value in key columns does not work in SalesAccountsIC table (#1243)
- Loan principal override error: Could not read .. RowCount (#1300)
- Input on Balansesheet account create transaction with wrong account type (#1304)
- Run dataflow (async) when opening workbooks where the user is likely to run a dataflow (#1326)
- Finance Reports when selecting preview dataset and report different from INPUT report may give wrong results for other PL type reports and no results for BAL type reports (#1331)
- Version manager -> Version properties - data can be loaded when no filter is selected (#721)
- Investment module, postings not deleted after reloading a new version from a new start date (#1318)
- Account module: Periodic comparison report has incorrect monthly offset, relevant for non-standard fiscal regimes (#1321)
- Incorrect currency conversion at group levels on historic columns in Plan Overview (#1334)
- Finance Advanced Input - error received when saving payroll data at non-leaf department level (#1337)
- Personal Autotransaction is calculating wrong numbers with use of Headcount (#1294)
- Fixed Assets "Declining" validation error (#1301)
- Deviation columns - missing column totals and introduce deviation columns in account details report (#1299)
- Account details report - unable to use planner-internal historical datasets (#1283)
- Double output from preview dataset in finance reports (#1244)
- Plan overview - some reportlines appear with 0s in plan periods although plan contains data (after moving department to another legal entity) (#1242)
- Incorrect calculation of social cost from Driver based models. Occurs when saving input in a given context (#1238)
- Finance Advanced Input -> Setup: When no model filter is selected, dimension configuration for all models are displayed (#1222)
- Insert new row only possible when hovering over existing rows or sum/inline filter row (#1204)
- Finance Reports (local to Planner) reports error when drilling from trial balance to details (#1341)
- Driver based models - roll over to new year caused year 2 numbers to be nulled (#1329)
- Import Fixed Assets from external source is not using Group Account mapping (#1346)
