

# InVision 2022.5 change log

<br/>

We’ve just released version 2022.5 of InVision, our low-code platform to build business apps. In addition to a number of bug fixes, the most important feature of this version is the ability to deploy or upgrade Packages created on older versions of the platform. That will enable us to release new versions of the platform at a much higher cadence in the future, so expect a new version to drop about every 2 weeks starting January 2023.

<br/>

### Added

- The Dataflow Completed event now contains a Success property that lets the developer check whether the dataflow completed with success or not.
- Support for installing and upgrading Packages created on older versions of InVision. This feature will enable quicker releases of InVision, because we do not have to synchronize with products such as Planner, Risk or Consolidation.
- Support for running PowerShell scripts from Web Functions.

<br/>

### Fixed

- File Storage component displays progress/spinner when multiple files are uploaded.
- Improvements to stability when running Dataflows and Azure Service Bus is used as message broker.
- PowerShell syntax checker resets correctly after syntax errors have been fixed.
- PowerShell works when running on Linux containers.
- Package extensions are deployed correctly for Package deployments and upgrades. [#708](https://support.profitbase.com/platform/invision-beta/-/issues/708)
- Changes to custom actions in Subscreens were ignored after the initial setup of the Workbook.
- Fixed issue when hosted in Kubernetes that caused services to be terminated prematurely.
- Designer is able to refresh access token when long-running Package upgrades are executing. [#712](https://support.profitbase.com/platform/invision-beta/-/issues/712)
- Enable allowing Continue on Failure for Dataflows running before Work Process Version deletion. [#619](https://support.profitbase.com/platform/invision-beta/-/issues/619)
- Faster Package deployment.
- Fix for issue with duplication of dimension hierarchies. [#732](https://support.profitbase.com/platform/invision-beta/-/issues/732)
- Fix the issue with displaying TreeView in Form Schema. [#731](https://support.profitbase.com/platform/invision-beta/-/issues/731)

<br/>

### Changed/Enhanced

- The File Storage component raises the UploadCompleted event when all files in a batch have completed uploading, instead of once per file.
- User search is disabled when InVision is connected to a shared Azure Active Directory.
- Display email in search result when adding user to InVision. [#705](https://support.profitbase.com/platform/invision-beta/-/issues/705)

<br/>

### See Also

- [Change Log 2025.2](changelog25_2.md)
- [Change Log 2025.1](changelog25_1.md)
- [Change Log 2024.4](changelog24_4.md)
- [Change Log 2024.3](changelog24_3.md)
- [Change Log 2024.2](changelog24_2.md)
- [Change Log 2024.1](changelog24_1.md)
- [Change Log 2023.7](changelog23_7.md)
- [Change Log 2023.6](changelog23_6.md)
- [Change Log 2023.5](changelog23_5.md)
- [Change Log 2023.4](changelog23_4.md)
- [Change Log 2023.3](changelog23_3.md)
- [Change Log 2023.2](changelog23_2.md)
- [Change Log 2023.1](changelog23_1.md)
- [Change Log 2022.4](changelog22_4.md)
- [Change Log 2022.3 pt 2](changelog22_3_2.md)
- [Change Log 2022.3 pt 1](changelog22_3_1.md)
- [Change Log 2022.2](changelog22_2.md)
- [Change Log 2022.1](changelog22_1.md)
- [Change Log 5.2](changelog52.md)
- [Change Log 5.1](changelog51.md)
- [Change Log 5.0](changelog5.md)
- [Change Log 4.1](changelog41.md)
- [Change Log 4.0](changelog40.md)
