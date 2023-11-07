---
title: "Upgrade notes EPM Planner 5.4.1"
metaKeys: "Changelog"
pageIndex: 1001
---

Supports upgrade to Planner 5.4.1 from Planner 5.2.x, 5.3.0, 5.4.0.

**NOTE: Upgrading from versions older than 5.2.0 is no longer supported!**

When upgrading to the next version after 5.4.1, upgrading from versions older than 5.2.1 will no longer be supported. It is therefore strongly recommended to keep your Planner version as up to date as possible.

Requirements: Profitbase InVision platform version 2023.5.

Notes:

- When upgrading to Planner 5.4.1, some workbooks in versions that are not upgraded may produce error messages and not render correctly due to the introduction of new languages. Make sure therefore to upgrade all the versions your users rely on.
- When upgrading to Planner 5.3.0, a new socalled extension package (EPM Finance Reports) is introduced. It will extend EPM Reporting and EPM PLanner with financial reporting capabilities in the for of the Finance Reports workbook. This extension package is automatically deployed when upgrading using the Package Management tool (recommended). If, however, upgrade is performed manually from individual files, the EPM Finance Reports extension package must manually be deployed to the solution containing EPM Reporting after EPM Reporting has been upgraded. It must also be deployed manually to the solution containing the EPM Planner blueprint after the EPM Planner package has been upgraded. In order for individual Planner versions to have its own Finance Reports workbook, process contents must be updated to include EPM Finance Reports. For processes that have EPM Finance Reports included as part of their content, the Finance Report workbook will be available within the versions created thereafter.
- When upgrading to Planner 5.2.4, there is a **breaking change** for customized pre- and post- pipeline scripts as the interface to these scripts have changed. This only applies to to solutions that have made use of these customization possibilities.
- Planner 5.2x makes use of a central dimension management and ledger repository. When upgrading to from a pre-5.2 version each upgraded versions will move the content and configuration from the version's dimensions to the primary dimension residing in the central repository.
It is thus recommended that the version containing the most correct versions of the dimensions is the LAST one to be upgraded. Alternatively you can publish dimension(s) from a given version to the primary dimension located in the EPM Reporting solution after the upgrade is done.
- It is highly recommended that all versions should either be upgraded or deleted (if no longer in use), regardless of their status
- When upgrading from version 5.2.3 or older, the schedules defined for scheduled operations in Operation Manager are removed by mistake (issue #1105). Make therefore sure to document any schedules prior to upgrading.

Involves packages:
- EPM Datamart (Package upgraded to: 5.3.3)
- EPM Common (Package upgraded to: 5.3.2)
- EPM Reporting (Package upgraded to: 1.0.7)
- EPM Finance Reports extension package (Package upgraded to 1.0.2)
- EPM Planner (Package upgraded to: 5.4.1)






