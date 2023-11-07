---
title: "Changelog EPM Datamart 5.3.3"
metaKeys: "Changelog"
pageIndex: 79
---

This document contains the new features and changes to the EPM Datamart release 5.3.3.

This package provide a datamart to share data between EPM applications and external producers and consumers. Import, export and currency exchange rates is functions provided here.

The top section contains an abstract of the new features and main changes. The bottom section contains a detailed list of GitLab issues registered for this release. Items marked with "Bug" contains bug fixes.

**Changes:**

* https://support.profitbase.com/solutions/planner/-/issues/1424
* Preview popups of temp data and destination data, increase displayed rows from 200 to 1000.
* Client side filtering enabled for preview popups.
* Added option of (server side) data filtering for those 1000 rows.
* Column Mapping - New test button to validate and test formulas and mapping to find potential errors.
* Auto Cast button - Changed to "splitbutton" for more options (CAST, TRY_CAST)
* Auto Cast no longer wraps transform formulas that already start with CAST or TRY_CAST.
* "Full import test" - List up to 1000 rows that fail to import. Helper function to find bad rows from data source.
* Azure Function import - Added filter to make sure it only tries to import .CSV files. (Implemented before 5.3.3 release)

**Bug fixes and Gitlab issues**

* Auto Cast bug fixed; caused wrong type to be used in some cases. (https://support.profitbase.com/solutions/planner/-/issues/1421)
* 5.3.2 Datamart Column Mapping collation error.  (https://support.profitbase.com/solutions/planner/-/issues/1414)
* 5.3.2 Datamart Data Import Error; New "EPM Assemblies". (https://support.profitbase.com/solutions/planner/-/issues/1425)