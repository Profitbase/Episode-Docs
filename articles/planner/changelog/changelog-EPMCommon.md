# EPM Common

## Package description

This package provide the users and access management, work process and tasks capabilities and operations management and scheduling operations.

## EPM Common Versions

- [EPM Common 5.4.0](#epm-common-540) - Released 2024.02.21
- [EPM Common 5.3.2](#epm-common-532)
- [EPM Common 5.3.1](#epm-common-531)
- [EPM Common 5.3.0](#epm-common-530)

## Unreleased

**Changes:**

**Fixes:**

- Limit file types allowed (.doc,.docx,.gif,.jpeg,.jpg,.pdf,.png,.ppt,.pptx,.txt,.xls,.xlsx) to upload and upload size to 100 mb (#1805)
- Limit number of files possible to upload and disable open option (#1826)

## EPM Common 5.4.0

**Changes:**

- Preview of ability to automate version deployment, the idea being to simplify rolling forecast scenarios ( #1563)

  Implemented as a new page to the Version manager workbook.

  NOTE: this functionality is available as a preview with limited functionality. The following limitations apply:
  1. Scheduled versions have to be created beforehand using the standard user interface. They must exist and hold a Draft (0) status.
  2. The scheduled version must be configured with a source version identical to the current version of the same process and hold an Open (6) status at the time of deployment. The source version will automatically be closed when the new version is deployed, and the new version becomes the current version. This makes this functionality useful for automating rolling forecast scenarios.
  3. The Deploy On Schedule operation will have to be set up manually as a step in a scheduled operation in order to automate the schedule.
- Activity page removed from Operations. ( <https://support.profitbase.com/solutions/planner/-/issues/1448>)
- Slightly darker color for disabled cells throughout the system. ( <https://support.profitbase.com/solutions/planner/-/issues/528>)

**Enhancements:**

- New configuration in Common - Max lock time for operations ( <https://support.profitbase.com/solutions/planner/-/issues/1596>)
  - If the Operation never terminates properly for any reason (worker, network, system crash, etc...),  it remains "locked" skipping  the next run. (By design, this behavior is to prevent simultaneous runs.) A new setting allows a time limit to be set, for how long the operation should remain blocked. Defaults to 40 minutes.
- Improve navigation between Scheduled Operations, Operations, Import Export jobs. ( <https://support.profitbase.com/solutions/planner/-/issues/1592>)
- Categories can be hidden, but operations remain active if scheduled. ( <https://support.profitbase.com/solutions/planner/-/issues/1404>)
  - Even if the category is hidden, the operations will be listed if a schedule exists.
- Guides: ( <https://support.profitbase.com/solutions/planner/-/issues/1415>)
  - Added validation for guide name.
  - Delete guide steps: order sequence maintained.
  - Fall back to English when no translations exist was missing in certain elements.
  - Bug when creating new guide (if using save and go to steps, steps would not save properly)
  - Guide creation - step text not saved if input not done in "correct" order ( <https://support.profitbase.com/solutions/planner/-/issues/1411>)
  
**Bug Fixes:**

- (Operation) Average run time is off by as many steps as there are in the job ( <https://support.profitbase.com/solutions/planner/-/issues/1590>)
- Scheduled Operations warning icon showing when everything is ok in some cases ( <https://support.profitbase.com/solutions/planner/-/issues/1585>)
- Ad hoc Task in driverbased modules was not preselecting the workbook ( <https://support.profitbase.com/solutions/planner/-/issues/1473>)

## EPM Common 5.3.2

**Changes:**

- Added logging for import & export jobs. Available under the "..." menu. (<https://support.profitbase.com/solutions/planner/-/issues/1351>)
- File Import: Improved handling of nullable and numeric fields (<https://support.profitbase.com/solutions/planner/-/issues/1353>)
- File Import - New dropdown to explicitly specify the incoming date format. (<https://support.profitbase.com/solutions/planner/-/issues/1307>)

**Bug fixes and Gitlab issues:**

- File Import context menu not active. (<https://support.profitbase.com/solutions/planner/-/issues/1352>)
- Fix for collation error in column mapping for data import.  (<https://support.profitbase.com/solutions/planner/-/issues/1376>)

## EPM Common 5.3.1

- Synonym in wrong table. (#1365 (closed))
- Changed date format displayed in operation list for last run time (#1377 (closed))

## EPM Common 5.3.0

**Changes:**

- **Revised GUI for Operation Manager workbook** related to the Operations and Scheduled Operations pages:

  - Actions button that was previously displayed in the upper right corner has been removed and replaced by specific buttons for Add operation / Add System Operation (global to page) and Execute and Steps buttons on individual operations
  - Less often used actions available via clickable 3-dot (...) menu on individual operations
  - Steps and Version Execution mode that were previously displayed automatically when expanding an operation are now accessible only via the (...) menu in individual pop-up windows

- General optimization: removal of unused libraries, code improvements.
- Optimized side panel with "Activity Monitor".
- New warning icon for operations with missing steps or missing objects.

**Bug fixes and GitLab reference list:**

- Operations missing steps - Operations "Actuals Incomplete - update solution" and "Account(s) added - update solution" are missing two steps that will affect correct loading of actuals to Plan Overview (#1207)
- Operations no longer required to have a unique name (#773)
- Deleting system Scheduled operation kept the schedule on (#1274)
- Multiple fixes and improvements to always display consistent time stamps across time zones and servers (#1246 , #1247 )
