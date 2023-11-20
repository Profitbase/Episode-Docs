---
title: "Planner"
metaKeys: "About Profitbase InVision, Application Development, platform, build flexible business solutions, components, business modules,  integrate, RESTful Web API, connecting directly to the SQL data storage, extended, custom, Profitbase InVision Designer, developer tool, Microsoft Visual Studio, features, code libraries, packages, prebuilt Solution components, Templates, Solution components"
folderOnly: "false"
pageIndex: 1
---

### About Profitbase Planner

Profitbase Planner is a financial planning tool covering the annual budgeting and rolling forecast processes.

This site contains the help needed for different users to use Profitbase Planner.

Profitbase Planner is made up of a set of Web pages that are organized in what we call [Workbooks](workbooks/workbooks.md).
Workbooks are grouped here on this site the same way as the navigation menu appearing in all workbooks. Workbook and data are subject to access restrictions depending on the user role. It means that users may only see a subset of the full menu in Workbooks. There are no access restrictions on this help site so any user will have access to it.

<br/>


![](https://profitbasedocs.blob.core.windows.net/plannerimages/menu.jpg)

<br/>

The picture above shows the menu present in all [workbooks](workbooks/workbooks.md) for navigating in Planner. Clicking the hamburger menu in the upper left corner opens up a side menu.
<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5 or later

Different work processes can be defined, such as budget, forecast and similar. For each work process, one or more versions can be created. A version is a self contained mini solution with regard to data and individual workbooks.

The hamburger menu will reflect the work processes and versions created.

<br/>

### About Profitbase Planner

Profitbase Planner provides the ability to do extensive and accurate planning for financial planning processes such as rolling forecast and budget. The main parts of Planner are:

- [Finance Settings](workbooks/financial-planning/finance-settings) to set up the financial settings and assumptions.
- [Input modules](modules/modules.md) to give users a convenient way to provide plan input on year and/or periods.
- Finance simulation engine that process input and apply the settings to calculate balance and accurate cashflow.
- [Finance Reports](workbooks/financial-planning/finance-reports.md) to inspect results form simulation.
- [Operation Manager](workbooks/administration/operation-manager.mdr) to run and schedule data processing flows.
- [Data Management](workbooks/data-management/data-management.md) for manage exchange rates, dimensions and transaction tables.
- [Administration](workbooks/administration/administration.md) to manager user access and configure input modules.

The success of most rolling Forecast solutions depends on how easy and efficient it is for the casual user to provide input. Planner, therefore, offers a rich set of Modules to make it convenient for users to provide input on:

- [Input on Account](modules/account.md) - traditional and easy but not necessarly easy for non-finance users.
- [Payroll input](modules/personnel.md) - allows for input on employee or employee category and headcount and percent of full-time. Here you can input additional cost for benefits.
- [CapEx](workbooks/financial-planning/capex.md) - a plan for investments.
- [Loan](workbooks/financial-planning/loan.md) - a plan for loans including ongoing loans.

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5 or later

- [Driver based](modules/driver-based.md) - driver-based planning. Here you can model to drive a set of income and cost inputs from one single input (e.g. quantity sold).

<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4.x

- [Sales Forecast](modules/sales-forecast.md) - driver-based forecast input. Here you can model to drive a set of income and cost inputs from one single input (e.g. quantity sold).
- [Sales Gross Margin budget input](modules/sales-gm.md) - allows to input sales and gross margin for budget.

The picture below shows an example of the Driver based input module:
<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/salesmodule.jpg)
<br/>

The picture above shows an example of product driver based input. At the top, you see the quantity which is the driver for everything below. However, the user may go to details in the middle part to add and override to extend the input. The table at the bottom shows the results from the input and details adjustments posted on financial accounts.

Input modules are optional and configurable to be able to cover most cases from simple on-account input to complex driver-based planning.

All input modules can be launched from - and contribute the profit and loss summary report (see picture above).
<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/summary.jpg)
<br/>

This input combined with the finance settings is what controls the outcome from finance simulation, which calculates and posts the balances to get a correct cash flow. In addition, one can do [finance scenario simulation](workbooks/financial-planning/finance-simulation.md) to "play" with input and create "Best" and "Worst" case results. Results from simulation can be inspected in Finance reports or exported for external consumption by external reporting tools.
<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/cashtotal.jpg)
<br/>

The picture above shows an example of a cash report. Simulated cash can be broken down to each operational activity to see effects from VAT terms, vacation pay terms, etc. As shown above, if the operation is not generating cash, you will be in trouble.

