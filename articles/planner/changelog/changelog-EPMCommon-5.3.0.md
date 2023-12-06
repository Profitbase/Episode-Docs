# Changelog EPM Common 5.3.0 & 5.3.1

This document contains the new features and changes to EPM Common package release 5.3.0 & 5.3.1 (bug fix).

This package provide the users and access management, work process and tasks capabilities and operations management and scheduling operations.

The top section contains an abstract of the new features and main changes. The bottom section contains a detailed list of GitLab issues registered for this release. Items marked with "Bug" contains bug fixes.

**Changes:**

- **Revised GUI for Operation Manager workbook** related to the Operations and Scheduled Operations pages:

     - Actions button that was previously displayed in the upper right corner has been removed and replaced by specific buttons for Add operation / Add System Operation (global to page) and Execute and Steps buttons on individual operations
     - Less often used actions available via clickable 3-dot (...) menu on individual operations
     - Steps and Version Execution mode that were previously displayed automatically when expanding an operation are now accessible only via the (...) menu in individual pop-up windows

- General optimization: removal of unused libraries, code improvements.
- Optimized side panel with "Activity Monitor".
- New warning icon for operations with missing steps or missing objects.


**Bug fixes and GitLab reference list**

- Operations missing steps - Operations "Actuals Incomplete - update solution" and "Account(s) added - update solution" are missing two steps that will affect correct loading of actuals to Plan Overview (#1207)
- Operations no longer required to have a unique name (#773)
- Deleting system Scheduled operation kept the schedule on (#1274)
- Multiple fixes and improvements to always display consistent time stamps across time zones and servers (#1246 , #1247 )

**Bug fixes in EPM Common 5.3.1:**

- Synonym in wrong table. (#1365 (closed))
- Changed date format displayed in operation list for last run time (#1377 (closed))
