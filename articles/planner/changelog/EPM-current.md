# Profitbase EPM - current version

**Last updated:** October 3rd 2023

#### Planner 5.4.1

**Content**

- [EPM Planner 5.4.1](changelog-EPMPlanner-5.4.1.md) provides the financial planning function and can be organized in processes (e.g. Forecast) and one or more versions.
- [EPM Reporting 1.0.7](changelog-EPMReporting-1.0.7.md) provides central management of dimensions, report setup and group account mapping.
- [EPM Finance Report 1.0.2](changelog-EPMReporting-1.0.7.md) provides financial reporting capabilities. Extends EPM Reporting (central reporting) and EPM Planner (version specific reporting).
- [EPM Common 5.3.2](changelog-EPMCommon-5.3.2.md) provides the users and access management, work process and tasks capabilities and operations management and scheduling operations.
- [EPM Datamart 5.3.6](changelog-EPMDatamart-5.3.6.md)provides a datamart to share data between EPM applications and external producers and consumers. Import, export and currency exchange rates are functions provided here.

**Upgrade notes**

- [Read this before upgrading](readme-EPMPlanner-5.4.1.md)

**Known issues**

- The Finance Reports workbook accessed locally in a Planner version (relevant only if you have explicitly included the EPM Reporting package as part of your Planner process content) will fail (issue #1428). A patch can be applied to remedy this, contact Profitbase for details or consult the issue.
- Last accessed department not set automatically (Plan Overview, Account, Personnel, Driver Based) (issue #1439). A patch can be applied to remedy this, contact Profitbase for details or consult the issue.

**Patches**

#### Risk 1.1.1

**Content**

- [EPM Common 5.2.8](archive/changelog-EPMCommon-5.2.8.md) Guides and guide management added.
- [EPM Datamart 5.2.4](archive/changelog-EPMDatamart-5.2.4.md) provides a datamart to share data between EPM applications and external producers and consumers. Import, export and currency exchange rates are functions provided here.

**Known issues**

User Management missing a publish dataflow (fixed in future 1.1.2)
Workaround: execute operation to update users.
