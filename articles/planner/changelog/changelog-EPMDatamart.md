# EPM Datamart

## Package description

This package provide a datamart to share data between EPM applications and external producers and consumers. Import, export and currency exchange rates is functions provided here.

## EPM Datamart Versions

- [EPM Datamart 5.4.0](#epm-datamart-540) - Released 2024.02.21
- [EPM Datamart 5.3.6](#epm-datamart-536)
- [EPM Datamart 5.3.4](#epm-datamart-534)
- [EPM Datamart 5.3.3](#epm-datamart-533)
- [EPM Datamart 5.3.2](#epm-datamart-532)
- [EPM Datamart 5.3.0](#epm-datamart-530)

## EPM Datamart 5.4.0

**Changes:**

- New Config setting to set Azure Hosted or on Premise ( <https://support.profitbase.com/solutions/planner/-/issues/1621>)
- Data Import - Temp Table Name read-only. ( <https://support.profitbase.com/solutions/planner/-/issues/1600>)
  - Reduces the chance of error by multiple rulesets using the same temp table (may arise from copying a ruleset, or user input using a common word such as "ledger").
  - Guarantees that it is unique per ruleset.
  - Makes maintenance and clean up easier (clean up improved in 5.4.0).
  - One field less for the user to worry about.
  - Still readable if user needs it for debug purposes.
- Data Import Destinations dropdown sorting updated to show most relevant tables first.
- Data Import form disabled while saving / loading to prevent input while saving ( <https://support.profitbase.com/solutions/planner/-/issues/1445>)

**Enhancement:**

- Data Import (Azure) greatly increased performance.
- Data Import - Azure method - Add support for more complex SQL expressions. Was previously limited to simple "Linq" expressions. Now supports more advanced SQL. ( <https://support.profitbase.com/solutions/planner/-/issues/1412>)
- Data Import - File Cleaning option ( <https://support.profitbase.com/solutions/planner/-/issues/1620>)
  - File Cleaning is now an option you can set per ruleset. If on, the source files will be overwritten by a cleaning routine.
  - This removes some ASCII symbols, whitespace at end of file, etc..
  - Deprecates this issue: <https://support.profitbase.com/solutions/planner/-/issues/1575>
- Add custom File Import Destinations ( <https://support.profitbase.com/solutions/planner/-/issues/1608>)
- Add Operation Launcher in Data Import / Export. It is now possible to configure Operations to be launchable from Data Import / Export.
- Data Import improved auto cast for import of empty values into numeric fields.
- Data Import Column Mapping (AutoCast) - Replace decimal separators (space or apostrophe) from csv with nothing for numeric fields. ( <https://support.profitbase.com/solutions/planner/-/issues/1572>)

  (Reduce further errors converting nvarchar to numeric problems)
- Data Import Auto Cast for column mapping improved to better handle decimals ( <https://support.profitbase.com/solutions/planner/-/issues/1587>)
  - Simpler formula that will handle more scenarios, whether using SQL import or CSV import.

    And will help seeing less of the annoying "Error converting data type varchar to numeric. "
- Data Import Column mapping - More space for SQL formulas ( <https://support.profitbase.com/solutions/planner/-/issues/1586>)
- Data Export performance increased. (Automatically fetches WorkProcessVersionID when ExportName is specified.)
- Optimize and enable finance actual data import and enable for reporting ( <https://support.profitbase.com/solutions/planner/-/issues/1597>)

**Bug fixes:**

- Data Import run as operation ignores "Auto Archive" setting ( <https://support.profitbase.com/solutions/planner/-/issues/1619>)
- Excel Export in DataMart Export (restored) ( <https://support.profitbase.com/solutions/planner/-/issues/1609>)
- Timeout increased for Import jobs run from operations ( <https://support.profitbase.com/solutions/planner/-/issues/1583>)
- Incorrect last modified date shown for destination in Data Import. ( <https://support.profitbase.com/solutions/planner/-/issues/1584>)
- Currency exchange rates - not generated after 2028 ( <https://support.profitbase.com/solutions/planner/-/issues/1565>)
- File Import of empty values into numeric fields now properly handled.

## EPM Datamart 5.3.6

**Changes:**

Mostly affects instances hosted by Profitbase/Microsoft Azure (.biz domains):

- Data Import Archive functionality restored.
- Data Import Blank Rows handled (<https://support.profitbase.com/solutions/planner/-/issues/1488>)
- Importing a large number of CSV files from Blob storage (<https://support.profitbase.com/solutions/planner/-/issues/1489>)
- Data Export improved efficiency. (<https://support.profitbase.com/solutions/planner/-/issues/1471>)
- Hosting environment for import export functions moved to more efficient deployment slot.

## EPM Datamart 5.3.4

**Bug fixes:**

- Import from Blob fails due to Azure Storage version being incompatible and mismatch in encryption of connection string sent to Azure Functions (<https://support.profitbase.com/solutions/planner/-/issues/1432>)

## EPM Datamart 5.3.3

**Changes:**

- <https://support.profitbase.com/solutions/planner/-/issues/1424>
- Preview popups of temp data and destination data, increase displayed rows from 200 to 1000.
- Client side filtering enabled for preview popups.
- Added option of (server side) data filtering for those 1000 rows.
- Column Mapping - New test button to validate and test formulas and mapping to find potential errors.
- Auto Cast button - Changed to "splitbutton" for more options (CAST, TRY_CAST)
- Auto Cast no longer wraps transform formulas that already start with CAST or TRY_CAST.
- "Full import test" - List up to 1000 rows that fail to import. Helper function to find bad rows from data source.
- Azure Function import - Added filter to make sure it only tries to import .CSV files. (Implemented before 5.3.3 release)

**Bug fixes:**

- Auto Cast bug fixed; caused wrong type to be used in some cases. (<https://support.profitbase.com/solutions/planner/-/issues/1421>)
- 5.3.2 Datamart Column Mapping collation error.  (<https://support.profitbase.com/solutions/planner/-/issues/1414>)
- 5.3.2 Datamart Data Import Error; New "EPM Assemblies". (<https://support.profitbase.com/solutions/planner/-/issues/1425>)

## EPM Datamart 5.3.2

**Changes:**

- Added logging for import & export jobs. Available under the "..." menu. (<https://support.profitbase.com/solutions/planner/-/issues/1351>)
- File Import: Improved handling of nullable and numeric fields (<https://support.profitbase.com/solutions/planner/-/issues/1353>)
- File Import - New dropdown to explicitly specify the incoming date format. (<https://support.profitbase.com/solutions/planner/-/issues/1307>)

**Bug fixes:**

- File Import context menu not active. (<https://support.profitbase.com/solutions/planner/-/issues/1352>)
- Fix for collation error in column mapping for data import.  (<https://support.profitbase.com/solutions/planner/-/issues/1376>)

## EPM Datamart 5.3.1

**Bug fixes:**

- Data Import fails when hosted by Profitbase and using SQL to SQL import - **Critical** (<https://support.profitbase.com/solutions/planner/-/issues/1354>)
- Date Error popup on some client PCs when loading or saving import rulesets. (<https://support.profitbase.com/solutions/planner/-/issues/1350>)
- Data Import / Export errors when hosted in offline setup(<https://support.profitbase.com/solutions/planner/-/issues/1358>)

## EPM Datamart 5.3.0

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

**Bug fixes:**

- Typing error in Currency Exchange Rates Comments field - changed to "Historical override" (#1293)
- Tables missing from source dropdown in data export, list will now include previously filtered out tables (#1219)
- Collation issues resolved (#1298).
- Data Export Column Mapping - Cannot select destination for certain source columns (when there are less destination columns than source columns) (#1312)
- CSV Import New Data button disabled for new import rulesets (known issues 5.2.5) (#1259)
