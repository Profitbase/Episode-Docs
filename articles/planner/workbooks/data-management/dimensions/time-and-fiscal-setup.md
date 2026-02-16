# Time and fiscal setup

## Overview
In this page you can define the scope of the calendar as well as set a fiscal regime where fiscal and calendar years differ.  

![](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/TimeAndFiscalSetup.JPG)

## Calendar from-to

Define the from and to date of the calendar.  

- **From date**<br/>
The calendar from date. Mandatory.
- **To date**<br/>
The calendar to date. Mandatory.

## Fiscal calendar offset

By default, the fiscal and calendar years are expected to be the same. If your fiscal year differs (is offset) from the calendar year, you can configure this offset here.  

- **Fiscal start date**<br/>
The calendar start date of your fiscal year. Mandatory.
- **Fiscal year**<br/>
Which fiscal year does the Fiscal start date belong to. Mandatory.

A note on fiscal offset with respect to budget and forecast:

A version's start date will be set as a fiscal start date. As an example, in a solution where the fiscal year starts on November 1st, a version for the **fiscal** year 2026 is created with a new start date January 1st 2026.

![](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/FiscalOffsetExample.JPG)

Any historical reference columns defined, will have their from and to-dates defined according to a normal **calendar** regime:

![](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/FiscalHistorical.JPG)

The period filters presented to the user in for example the plan overview will relate to the **fiscal** period and display the **calendar** periods that corresponds to the fiscal period:

![](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/FiscalPlanOverview.JPG)
