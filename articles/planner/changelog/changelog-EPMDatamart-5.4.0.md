This document contains the new features and changes to the EPM Datamart release 5.4.0.

This package provide a datamart to share data between EPM applications and external producers and consumers. Import, export and currency exchange rates is functions provided here.

* **Change:** New Config setting to set Azure Hosted or on Premise ( https://support.profitbase.com/solutions/planner/-/issues/1621)
* **Change:** Data Import - Temp Table Name read-only. ( https://support.profitbase.com/solutions/planner/-/issues/1600)
  * Reduces the chance of error by multiple rulesets using the same temp table (may arise from copying a ruleset, or user input using a common word such as "ledger").
  * Guarantees that it is unique per ruleset.
  * Makes maintenance and clean up easier (clean up improved in 5.4.0).
  * One field less for the user to worry about.
  * Still readable if user needs it for debug purposes.
* **Change:** Data Import Destinations dropdown sorting updated to show most relevant tables first.
* **Change/Fix:** Data Import form disabled while saving / loading to prevent input while saving ( https://support.profitbase.com/solutions/planner/-/issues/1445)
* **Enhancement:** Data Import (Azure) greatly increased performance.
* **Enhancement:** Data Import - Azure method - Add support for more complex SQL expressions. Was previously limited to simple "Linq" expressions. Now supports more advanced SQL. ( https://support.profitbase.com/solutions/planner/-/issues/1412)
* **Enhancement:** Data Import - File Cleaning option ( https://support.profitbase.com/solutions/planner/-/issues/1620)
  * File Cleaning is now an option you can set per ruleset. If on, the source files will be overwritten by a cleaning routine.
  * This removes some ASCII symbols, whitespace at end of file, etc..
  * Deprecates this issue: https://support.profitbase.com/solutions/planner/-/issues/1575
* **Enhancement:** Add custom File Import Destinations ( https://support.profitbase.com/solutions/planner/-/issues/1608)
* **Enhancement:** Add Operation Launcher in Data Import / Export. It is now possible to configure Operations to be launchable from Data Import / Export.
* **Enhancement/Fix:** Data Import improved auto cast for import of empty values into numeric fields.
* **Enhancement:** Data Import Column Mapping (AutoCast) - Replace decimal separators (space or apostrophe) from csv with nothing for numeric fields. ( https://support.profitbase.com/solutions/planner/-/issues/1572)

  (Reduce further errors converting nvarchar to numeric problems)
* **Enhancement:** Data Import Auto Cast for column mapping improved to better handle decimals ( https://support.profitbase.com/solutions/planner/-/issues/1587)
  * Simpler formula that will handle more scenarios, whether using SQL import or CSV import.

    And will help seeing less of the annoying "Error converting data type varchar to numeric. "
* **Enhancement:** Data Import Column mapping - More space for SQL formulas ( https://support.profitbase.com/solutions/planner/-/issues/1586)
* **Enhancement:** Data Export performance increased. (Automatically fetches WorkProcessVersionID when ExportName is specified.)
* **Enhancement:** Optimize and enable finance actual data import and enable for reporting ( https://support.profitbase.com/solutions/planner/-/issues/1597)
* **Fix:** Data Import run as operation ignores "Auto Archive" setting ( https://support.profitbase.com/solutions/planner/-/issues/1619)
* **Fix:** Excel Export in DataMart Export (restored) ( https://support.profitbase.com/solutions/planner/-/issues/1609)
* **Fix:** Timeout increased for Import jobs run from operations ( https://support.profitbase.com/solutions/planner/-/issues/1583)
* **Fix:** Incorrect last modified date shown for destination in Data Import. ( https://support.profitbase.com/solutions/planner/-/issues/1584)
* **Fix:** Currency exchange rates - not generated after 2028 ( https://support.profitbase.com/solutions/planner/-/issues/1565)
* **Fix:** File Import of empty values into numeric fields now properly handled.
