---
title: "Changelog EPM Datamart 5.3.0 & 5.3.1"
metaKeys: "Changelog"
pageIndex: 83
---

This document contains the new features and changes to the EPM Datamart release 5.3.0.

This package provide a datamart to share data between EPM applications and external producers and consumers. Import, export and currency exchange rates is functions provided here.

The top section contains an abstract of the new features and main changes. The bottom section contains a detailed list of GitLab issues registered for this release. Items marked with "Bug" contains bug fixes.

**Changes:**

- Revised GUI with the aim of simplifying the process, reducing errors, and implementing wishes expressed by users.
- Connection list implemented instead of defining the connection properties for each import/export ruleset. Each connection is defined once, and then re-used. Helps to simplify GUI and reduce typing errors.
- Button to browse Azure storage and download files.
- Test Connection button added for Azure blob connections.
- Alternative (faster) methods available to instances hosted by Profitbase for import, export (#1272).
- Excel export for instances hosted by Profitbase (#789)
- Column mapping improved to better handle different scenarios (#1312)
- Operations created from a data import job only require 1 step, making it easier to use (#961)
- New options for data import "replace all": "Keep existing data if no rows loaded" and "Abort if rows decrease" (#1343)
- Implemented use of WebFunctions API (new feature, invision 2023.3) for much greater stability in "asynchronous" functions.
- New helper features in data import SQL server (external) browser popup: auto-collate and button to use the suggested query.
- Data export to Azure Blob (CsV): new dropdown to select date format output.


**Bug fixes and Gitlab issues**

- Typing error in Currency Exchange Rates Comments field - changed to "Historical override" (#1293)
- Tables missing from source dropdown in data export, list will now include previously filtered out tables (#1219)
- Collation issues resolved (#1298).
- Data Export Column Mapping - Cannot select destination for certain source columns (when there are less destination columns than source columns) (#1312)
- CSV Import New Data button disabled for new import rulesets (known issues 5.2.5) (#1259)

***Changelog EPM Datamart 5.3.1***

**Bug fixes and Gitlab issues**

* Data Import fails when hosted by Profitbase and using SQL to SQL import - **Critical** (https://support.profitbase.com/solutions/planner/-/issues/1354)
* Date Error popup on some client PCs when loading or saving import rulesets. (https://support.profitbase.com/solutions/planner/-/issues/1350)
* Data Import / Export errors when hosted in offline setup(https://support.profitbase.com/solutions/planner/-/issues/1358)
