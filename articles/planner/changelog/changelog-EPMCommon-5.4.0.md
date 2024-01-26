This document contains the new features and changes to EPM Common package release 5.4.0.

This package provide the users and access management, work process and tasks capabilities and operations management and scheduling operations.

The top section contains an abstract of the new features and main changes. The bottom section contains a detailed list of GitLab issues registered for this release. Items marked with "Bug" contains bug fixes.

**Changes:**

- Preview of ability to automate version deployment, the idea being to simplify rolling forecast scenarios ( #1563)

  Implemented as a new page to the Version manager workbook.

  NOTE: this functionality is available as a preview with limited functionality. The following limitations apply:
  1. Scheduled versions have to be created beforehand using the standard user interface. They must exist and hold a Draft (0) status.
  2. The scheduled version must be configured with a source version identical to the current version of the same process and hold an Open (6) status at the time of deployment. The source version will automatically be closed when the new version is deployed, and the new version becomes the current version. This makes this functionality useful for automating rolling forecast scenarios.
  3. The Deploy On Schedule operation will have to be set up manually as a step in a scheduled operation in order to automate the schedule.
- **Change:** Activity page removed from Operations. ( https://support.profitbase.com/solutions/planner/-/issues/1448)
- **Change:** Slightly darker color for disabled cells throughout the system. ( https://support.profitbase.com/solutions/planner/-/issues/528)
- **Enhancement:** New configuration in Common - Max lock time for operations ( https://support.profitbase.com/solutions/planner/-/issues/1596)
  * If the Operation never terminates properly for any reason (worker, network, system crash, etc...),

    it remains "locked" skipping the next run.

    (By design, this behavior is to prevent simultaneous runs.)

    A new setting allows a time limit to be set, for how long the operation should remain blocked.
  * Defaults to 40 minutes.
- **Enhancement:** Improve navigation between Scheduled Operations, Operations, Import Export jobs. ( https://support.profitbase.com/solutions/planner/-/issues/1592)
- **Enhancement:** Categories can be hidden, but operations remain active if scheduled. ( https://support.profitbase.com/solutions/planner/-/issues/1404)
  * Even if the category is hidden, the operations will be listed if a schedule exists.
- **Fix:** (Operation) Average run time is off by as many steps as there are in the job ( https://support.profitbase.com/solutions/planner/-/issues/1590)
- **Fix:** Scheduled Operations warning icon showing when everything is ok in some cases ( https://support.profitbase.com/solutions/planner/-/issues/1585)
- **Fix:** Ad hoc Task in driverbased modules was not preselecting the workbook ( https://support.profitbase.com/solutions/planner/-/issues/1473)
- **Fixes / Enhancements:** Guides: ( https://support.profitbase.com/solutions/planner/-/issues/1415)
  * Added validation for guide name.
  * Delete guide steps: order sequence maintained.
  * Fall back to English when no translations exist was missing in certain elements.
  * Bug when creating new guide (if using save and go to steps, steps would not save properly)
  * Guide creation - step text not saved if input not done in "correct" order ( https://support.profitbase.com/solutions/planner/-/issues/1411)
