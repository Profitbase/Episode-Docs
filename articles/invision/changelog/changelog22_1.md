
# InVision 2022.1 change log

<br/>

## New Features

<br/>

### Application Services / Infrastructure

- **Fix:** Azure Service Bus topic was automatically deleted after 24 hours of idle time, causing dataflows to not run.
- **Enhancement:** Tasks such as Version deployment, cloning Solutions, Package deployments, and upgrades are now queued. It means that if more than one of these tasks are submitted, they will be queued and executed in the order they arrive.

<br/>

### Access Control

- Explore which Workbooks and Pages users and access group have access to.
- Explore which dimensions and dimension members users and access groups have access to.
- Support for the description of Access Groups.

<br/>

### Data Pool

- Synonyms are now automatically taken when objects are deployed as part of Package deployments and upgrades, unless they are already in use.

<br/>

### Dataflow

- Support for Global Parameters. This enables multiple Data Flow Activities to automatically receive the same argument without having to explicitly map the argument to each Activity.

[Global Parameters](../docs/dataflows/parametrization/globalparameters.md) are passed to nested/child Dataflows during execution. See [her](../docs/dataflows/parametrization/globalparameters.md).

<br/>

### Dimensions and Dimension Editor

- Dimension Editor Workbook component which enables editing dimensions (structure and data):

  - Add and delete dimensions members.
  - Move dimension members using drag/drop and cut/paste.
  - Supports multi-select.
  - Sort nodes by drag/drop or use sorting functions (“sort children by …”).
  - Preview dimension in for different languages.
  - Edit properties and translations in either “Property mode” or “Table mode”.

- Create a central repository of primary dimensions.
- Publish dimensions to one or more Solutions and/or Work Process Versions. This enables customers to work with “master dimensions” and publish them to select Versions.
- Open and edit dimensions in specific Solutions (Work Process Versions). This enables customers to have different dimension structures in different Solutions and Work Process Versions.
- New dimension type:

  - Existing dimension types are renamed to Linked Dimension and Strict Wide Dimension.
  - Support for converting Strict Wide Dimension (previously called Dimension) to the new Dimension (enabling parent-child editing).

- You can use dataflows to import primary dimensions into a Solution. This enables automation of importing data from the primary dimension repository to active Work Process Versions.
- You can ad-hoc import data from the UI (spreadsheet import) or use Dataflows (load from SQL tables).

<br/>

### Filter

- Users can now click a “go-to” button on items in the selected items list of TreeView filters to quickly jump to the node in the tree
- Support for [slicing hierarchical filters](../docs/workbooks/components/filter/filterslicing.md) based on a list of leaf-level members.

<br/>

### Forms

- [TreeView](../docs/forms/formschemas/controls/treeview.md) with support for rendering dimensions. Access Control not supported.
- Support for [camera](../docs/forms/formschemas/controls/camera.md).

<br/>

### Macros

- Support for [localization API](../docs/macros/writingmacros/macroexpansionprovider.md). Developers can now get information about the preferred language of the logged in user.
- Support for [dimension metadata API](../docs/macros/writingmacros/macroexpansionprovider.md).

<br/>

### Packages and upgrades

- You can now [specify dependencies](../docs/package/develop-package/create-package/define-package.md) for a Package. This simplifies Package deployment and upgrades for customers, because when you deploy or upgrade a Package, dependencies are automatically deployed/upgraded first.
- New **Package Management tool** in Designer which enables partners and customers to easily get information the Packages which are installed and upgrade them without having to open any Solutions.
- Support for specifying Packages as **non-upgradable**. Use this feature for development when you want to ensure that the Package you are working on does not get upgraded from the Package Management tool. **Note** that this property only applies to packages that has been deployed.
- Support for **typing/categorization of Packages**. A Package can (and should) now be categorized as either Product or Library. By doing this, it will appear in different lists in the Package Management tool, making it easier for customers / partners choose the correct Package(s) to upgrade (which in most cases should be Packages marked as Products).

<br/>

### Profitbase Store

- v2 API which supports the new Package deployment and upgrade experience.

<br/>

### Tables

- Support for macros in Custom Load Data queries.

<br/>

### TableView

- Support for [SelectionChanged API](../docs/workbooks/components/tableview.md).
- Support for [ActionLink column](../docs/workbooks/components/tableview.md) .
- **Fix:** Action menu items did not display text.

<br/>

### Workbook

- **Display mode:** Ability to remove header and/or page navbar from the Workbook. This behavior can be configured in the Workbook Properties panel (Hide Header, Hide Navbar) or using query string parameters in the url. (https://my.domain.com/workbooks/123?appheader=false&navbar=false)

<br/>

### Views

- Support for [macros](../docs/macros.md).

<br/>

### Worksheet

- Support for macros in Custom Load Data queries.
- Selecting item from dimension member dropdown while filter is applied. Now updates the row correctly.

<br/>

### Work Process

- **Fix:** Prevent user from deleting Work Process Version which is used as data source for another Version.
- **Fix:** Version status is not changed if “Version change dataflow” does not complete successfully.
- **Feature:** Option to run “Post delete Dataflow” for Work Process Version.
- **Enhancement:** Enable editing Version properties after Version has been deployed.
- **Feature:** “Mutually exclusive boolean property” enables setting a true/false Version property which is mutually exclusive for all Versions within a Work Process (for example IsCurrentVersion).
- **Enhancement:** Create new Version from older source Version. Developers can add SQL Scripts to Packages to run adapter logic when data is copied from older versions of Packages to the newer one (during Version deployment.md). Check how to do it [here](../docs/package/develop-package/create-package/define-package.md).
- **Fix:** Statuses in Versions list page is updated correctly during version status changes.
- **Fix:** Partially deployed Solutions are deleted on Version Deployment rollback.

<br/>

### Misc

- **Fix:** Transaction Pipeline - Transaction pipeline Producer ignored conditional expression.
- **Fix:** Rollover + change tracking: Fixed issue that caused change history to get lost when rollover was executed.
- **Fix:** Spreadsheet - Filter did not trigger when tabbing out of filter row quickly.
- **Macros:** Added support for **localization** API.

<br/>

### Breaking changes

- **pbSimSolutionLangText** has been scheduled for deprecation and will be removed in the next version **(v2022.2)**. Use **pbSimLangText** for custom translations or **SYS_LangText** for system translations.

<br/>

### See Also


- [Change Log 2025.3](changelog25_3.md)
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
- [Change Log 2022.5](changelog22_5.md)
- [Change Log 2022.4](changelog22_4.md)
- [Change Log 2022.3 pt 2](changelog22_3_2.md)
- [Change Log 2022.3 pt 1](changelog22_3_1.md)
- [Change Log 2022.2](changelog22_2.md)
- [Change Log 5.2](changelog52.md)
- [Change Log 5.1](changelog51.md)
- [Change Log 5.0](changelog5.md)
- [Change Log 4.1](changelog41.md)
- [Change Log 4.0](changelog40.md)
