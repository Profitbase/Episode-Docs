---
title: "Change Log 2023.1"
metaKeys: "2022.5 of InVision, deploy or upgrade Packages, Dataflow Completed event, installing and upgrading Packages,  PowerShell scripts from Web Functions, File Storage, Dataflows and Azure Service Bus, extensions, Kubernetes, Work Process Version deletion, deployment, dimension hierarchies, displaying TreeView in Form Schema, UploadCompleted,  "
pageIndex: 4
---

This release is a small service release that adds a few improvements to Workbooks, Forms, Web Functions and Table Views. We also move the platform from .NET 6 to .NET 7, which results in better performance in some key area.

<br/>

### Workbook

#### New API for executing Web Functions from Workbooks.

Up until now, you had to use the generic Web API action to execute a Web Function, using HttpGet, HttpPost, HttpPut, or HttpDelete. This works fine, but you’d have to know the exact API endpoint (URL) to use, which shouldn’t be necessary.

The new API is easier to use because you only need to provide the name of the Web Function. Note that if you want to call web functions in other Solutions, you need to keep using the Http-methods (HttpGet, HttpPost, etc) and provide the full address to the web function.

[Read more here](../docs/forms/formschemas/functions/callingfunctions.md)

<br/>

![img](<https://profitbasedocs.blob.core.windows.net/images/changelog23(1).png>)
Use the Execute function to run the Web Function called “UpdateCustomer”

<br/>

#### New API for executing SQL Scripts from Workbooks

If you wanted to execute a SQL script from a Workbook before 2023.1, you had to drag it onto a page from the toolbox and call the Execute action on the script. Although this is easy to do and provides a discoverable API, it has the drawback that it takes up space on the design surface of a Page. This often leads to developers creating a “SYS”-page where they put all their SQL scripts just so they can call them.

2023.1 introduces the Execute SQL Script action, so you can execute SQL Scripts without having to add them to a Page.

[Read more here](../docs/sqlscripts/howto/runSqlScriptFromWorkbook.md)

![img](<https://profitbasedocs.blob.core.windows.net/images/changelog23(2).png>)
Use the Execute function to run the SQL Script called “SubmitChanges”

<br/>

### Forms

#### Access Control options when displaying dimensions in Forms

If you want to display a dimension in a Form, you can now choose between 3 options when it comes to access control.

- **None** – No access control is applied. The user will see every dimension member.
- **Standard** – Users only see the dimension members that they have access to.
- **Custom** – The API returns every member of the dimension with a property describing the access level granted for each item. It is up to the solution developer to decide how to enforce access control when rendering the UI (for example hiding or making an item non-selectable).

[Read more here](../docs/forms/formschemas/data/dimensionmodels.md)

<br/>

### Table View

- Changed the look of the TableView filter area to make it easier to use.
- Fixed an issue that caused the checkbox / row selection column in Table Views to disappear after a data reload unless a layout reload was requested.
- The Table View now re-renders correctly when the Re-render action is executed.

### Platform enhancements

- We upgraded from .NET 6 to .NET 7, which is the latest version of .NET.
- We upgraded SignalR from version 1.1.0 to 7.0.
- All nuget packages (backend) upgraded to latest versions.
- All npm packages (frontend) upgraded to latest versions.
- Fixed an issue that prevented Workbooks from loading in IFrames after the access token was refreshed (which happens every ~1 hour).

### Misc fixes

- Fixed an issue that prevented Solution developers from reordering sibling custom context menu items in Table Views, Worksheets and Tables.
- Fixed an issue with dropdowns displayed in popups, where users had to select a value twice for the selection to apply.

#### See Also

- [Change Log 2023.4](changelog23_4.md)
- [Change Log 2023.3](changelog23_3.md)
- [Change Log 2023.2](changelog23_2.md)
- [Change Log 2022.5](changelog22_5.md)
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
