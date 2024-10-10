# Profitbase EPM - current version

**Last updated:** October 10th 2024

## Planner 6.0.1

**Content:**

- [EPM Planner 6.0.1](changelog-EPMPlanner.md) provides the financial planning function and can be organized in processes (e.g. Forecast) and one or more versions.
- [EPM Reporting 1.1.2](changelog-EPMReporting.md) provides central management of dimensions, report setup and group account mapping.
- [EPM Finance Report 1.1.1](changelog-EPMFinanceReports.md) provides financial reporting capabilities. Extends EPM Reporting (central reporting) and EPM Planner (version specific reporting).
- [EPM Common 5.4.0](changelog-EPMCommon.md) provides the users and access management, work process and tasks capabilities and operations management and scheduling operations.
- [EPM Datamart 5.4.0](changelog-EPMDatamart.md)provides a datamart to share data between EPM applications and external producers and consumers. Import, export and currency exchange rates are functions provided here.

**Upgrade notes:**

- [Read this before upgrading](readme-EPMPlanner.md)

**Known issues:**

- Driverbased model: Double values in historic ref columns and plan proposal when using another version as source (#1660) A fix can be applied, check issue or contact Profitbase for details.

## Risk 1.1.1

**Content:**

- [EPM Common](changelog-EPMCommon.md) Guides and guide management added.
- [EPM Datamart](changelog-EPMDatamart.md) provides a datamart to share data between EPM applications and external producers and consumers. Import, export and currency exchange rates are functions provided here.

**Known issues:**

User Management missing a publish dataflow (fixed in future 1.1.2)
Workaround: execute operation to update users.
