# Changelog EPM Planner 5.4.1

This document contains the new features and changes to the EPM Planner release 5.4.1.

This package provide a datamart to share data between EPM applications and external producers and consumers. Import, export and currency exchange rates is functions provided here.

The top section contains an abstract of the new features and main changes. The bottom section contains a detailed list of GitLab issues registered for this release. Items marked with "Bug" contains bug fixes.

**Breaking Changes:**

These are changes that is likely to cause existing configurations to present different content after upgrading a solution.

- **Generating OB** The way Opening Balance (OB) is generated is changed and may cause e.g. Trial Balance to not sum to 0. This may also require to revisit configuation and customization involving OB. (#1011)

  Posting on internal AccountKeyID 'EquityEarningsYTD' is now removed when generating OB. 

  The following now applies for OB:

  Generating OB for beginning of year (fiscal period 1): OB is generated from previous years actuals. It is assumed that last years results is posted to balance (so that each sum of balance and sum of Profit & Loss is 0). If this is not the case, trial balance will not sum to 0 for OB. Users then have two options: 1) Ignore that trial balance for OB is not 0 or 2) Adjust OB by posting the difference (e.g. on balance account for other equity).

  When generating OB for forecast periods after beginning of year (fiscal period > 1): OB is generated including YTD for Profit & Loss accounts. Note that an opening balance is required for the planner posting engines to deal with due payments from e.g. receivables, payables, etc. configured in OB Due under Finance Settings.

  When generating OB for subsequent forecast years: Solution will close previous year and transfer results or loss to balance (default for new solutions). This is the default for new deployed solutions. For upgrade of existing solution and to maintain compatibility, the mechanism is not in effect by default. Users can use Year End Alloc in Finance Settings to configure how a profit should be used.

**Changes:**

- **Support for year end closing introduced**. This includes year end transfer of current year's profit/loss to the balance at year end (possible to disable) and an optional setup of rules related to year end due of tax, dividend, etc. For compatibility reasons, this functionality is disabled but can be switched on in the new page Year End Alloc. in the Finance Settings workbook. (#311)

- **Improved language support**. Danish and Swedish introduced as new languages. Account dimension includes new Danish and Swedish language properties. Self-service setting tables for maintaining solution specific language texts such as input module heading, measures, etc as well as reports, report lines, etc. 

  Translations tabs are found in workbooks Report Setup (dimensions, reports, report lines) and Input Settings and Administration (module specific texts). NO and EN texts are copied to the new translation table during upgrade and the NO and EN columns are closed.

  Note that some administrative workbooks such as Data Import & Export, Operations, etc. still supports English and Norwegian only. (#1363)

- **Improvements Personnel module** (#1056 #1382)

  Attributes introduced to personnel module and associated source fact. Previously, dimensionality could be used for defining a row in the personnel module. This is often ok, but in some cases, it is not possible as changing such a value from the source will introduce a new key and duplicate the input row. 

  A new type of column, attribute, is therefore introduced (Attr1, Attr2). Attributes are **updated** from source and not part of the dimensional key.

  Ability to control which fields are updated from source fact. Previously, all fields were updated when choosing to update existing data.

  Ability to define auto transaction rules based on attributes. Previously, dimensionality for department and employee alone was used.

  Ability to sort employees in input sheet drop down list so that new (dummy) employees appear at the top.

- **Ability to save input data without submitting** Introduce setting that allows for Save without submit in input modules Account, Personnel and Driver based. In some cases, submitting takes too long.

  Default is Auto submit data

  If Auto submit data is switched off, the Save button saves input data only and a Submit button appears the the user will have to click once the changes are done and saved. The Submit button will update reports. (#1387)

- Allocation - transaction report include Legal entity, account details report will show which allocation rule that has produced the data (#1373)

- Account drill to details report - details from the employee dimension is hidden and data is aggregated to other dimensionality present and any input comments are hidden. This applies to access from Plan Overview and modules other than Personnel as data may be sensitive (#1407)

**Bug fixes and GitLab reference list:**

- Incorrect button heading when adding custom button to driver based models (#1393)

- Auto transactions is not working for non-summable measures in driver based models (#1389)

- Additional dimension mapping cause double report lines (#1388)

- Bad performance in Account details and Account details drilldown report (#1359 #1384)

- Financial engine source - filter out transactions where accountid is null (#1381)

- Personnel module: changes in setting table require double save to take effect (#1355)

- Allocation transaction is deleted when Finance baseline is executed (#1400)

- Transaction pipelines for Account, Personnel and Driver based will truncate it's target table before piping data if run out of context, e.g. from an operation (#1399)

- Account details drill to detail report - employee information displayed when accessing report from Plan Overview (#1406)