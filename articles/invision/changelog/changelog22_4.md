---
title: "Change Log 2022.4"
metaKeys: ""
pageIndex: 6
---

Here is our 2022.4 release with added capabilities to Dimensions, File Storage, TableView, and Package Management. Additionally, we’ve fixed many issues and added a brand new Stepper component.

## New Features & fixes

<br/>

### Dimensions

<br/>

#### Extension properties

Extension properties enable partners and customers to extend dimensions in installed Packages (for example, Planner) with custom properties. That makes it possible to use standard dimensions for custom Power BI reporting or EPM custom extensions.  
Custom properties will not be removed when the dimension is upgraded during a Package upgrade.

<br/>

#### Dimension Composition

You can use Dimension Composition to build a dimension from other dimensions. You compose a dimension by adding levels and picking members from other dimensions based on their properties. That makes it easy to use different structures for input while still having one uniform reporting structure without having to maintain the same dimension members in multiple dimensions.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/dimChLog.png)

To enable composition for a dimension, set the **“Allow Composition”** flag in the **Options** tab in the **Designer**.

<br/>

#### Launch Dimension Editor with current Solution selected

You can now configure the Dimension Editor Workbook component to automatically pre-select the Solution that the Workbook belongs to, so that the dimensions displayed to the user when they navigates to the page are dimension from the current Solution and not Primary Dimensions.

<br/>

#### Bug fixes

- Fixed issue causing permissions set for a dimension member were not removed from the system when the dimension member was deleted. This caused access control to lock out all users not having explicit grant permissions, while based on the visible permission set, all users should have full access to the entire dimension.

- Fixed an issue where the Publish Dimension dialog showed the Version status as a numeric value instead of as text.

<br/>

### File Storage

<br/>

#### File click actions

The developer can specify what happens when a user clicks a file in a File Storage Workbook component. Available options are:

- **Download** – When a user clicks a file, it will be download to the browser.

- **Raise an event** – When a user clicks a file, an event is raise. That enables the developer to perform a custom action when a file is clicked.

- **Open** – When a file is clicked, it will be open in the browser.

- **None** – This enables users to view which files are in the File Storage but not access them.

<br/>

### Table View

<br/>

#### Pr-row selectability

Developers can now write JavaScript that evaluates whether or not specific rows are selectable by the user in TableView components. That provides developers fine-grained control over whether or not a row can be selected by a user based on business logic and application state.

<br/>

#### Manual trigger re-render of TableView

TableView now supports manually triggering re-rendering at any time. A typical use case for when you want to trigger a re-render is when some application state outside the TableView has changed, and you want this state to be reflected in the TableView.

<br/>

#### Bug fixes

- Fixed issue with sorting of negative numbers.

<br/>

### Stepper

We’ve added a brand-new UI component that makes it easy to guide a user through a series of steps to accomplish a task. Each step can be fully customized to contain any business logic and UI components.

<br/>

![stepper](https://profitbasedocs.blob.core.windows.net/images/stepper.png)

<br/>

### Package Management

<br/>

Package Management has several new features and enhancements, including:

- Detection of circular references/dependencies,

- Status displays correctly when updates are available for dependencies,

- The Package Manager loads information about a package a lot faster,

- Display the package as having an “upgrade available” if there’s at least one package in a solution that’s not up to date,

- Solution backups are properly cleaned up.

<br/>

### Ranked Input Tables

<br/>

#### Bug fixes/enhancements

- Ranked Input Tables now automatically sync with the associated dimensions when doing a Save or running Compile from Dataflows. If the source dimension has changed (been restructured), we will scan for dimension members and update the Ranked Input rows accordingly. If we cannot find a reference to the dimension members of a Ranked Input row, the row is deleted from the Ranked Input Table.

<br/>

### Filters

<br/>

#### Enable Search on TreeView (hierarchical) filters

This feature enables users to enter a search term on hierarchical filters to find matching items. This feature is enabled by default but can be turned off from the Designer.

<br/>

### Misc

- **Excel export:** Fixed issue with Excel export from tables, where periods (.) in the table name caused the Excel export to fail,
- **Infrastructure:** Fixed issue with RabbitMQ, where queues would fill up and cause RabbitMQ to use a lot of CPU,
- **Accessibility:** Fix high contrast issue in Work Process Version Manager ([#681](https://support.profitbase.com/platform/invision-beta/-/issues/681)),
- **Dataflow:** Fix the issue where the Dataflow log would not size correctly in a popup having a layout of only one row and column,
- **Access Control:** Fix the issue which made the “…”-menu disappear behind a scroll area if the description of an Access Group was long.

<br/>

#### See Also

- [Change Log 2023.4](changelog23_4.md)
- [Change Log 2023.3](changelog23_3.md)
- [Change Log 2023.2](changelog23_2.md)
- [Change Log 2023.1](changelog23_1.md)
- [Change Log 2022.5](changelog22_5.md)
- [Change Log 2022.3 pt 2](changelog22_3_2.md)
- [Change Log 2022.3 pt 1](changelog22_3_1.md)
- [Change Log 2022.2](changelog22_2.md)
- [Change Log 2022.1](changelog22_1.md)
- [Change Log 5.2](changelog52.md)
- [Change Log 5.1](changelog51.md)
- [Change Log 5.0](changelog5.md)
- [Change Log 4.1](changelog41.md)
- [Change Log 4.0](changelog40.md)
