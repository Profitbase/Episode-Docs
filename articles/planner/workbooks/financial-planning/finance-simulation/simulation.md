---
title: "Simulation"
metaKeys: ""
folderOnly: "false"
pageIndex: 1
---

## Overview
Simulation is used to calculate how the finance general ledger will develop into the future. Simulation is based on user input and parameter settings. User input is different transactions on expected sales, purchase, payroll and expenses. Finance settings cover parameters on which accounts to use and different rates to be applied to input.

A baseline is always calculated and is normally done by a scheduled task.

Here you can simulate "Best" and "Worst" scenarios which will be separate datasets to complement the existing "Base" case.

On the upper left of the screen you will find instruction on how to perform the scenario simulation.

<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/finance-simulation.jpg)

1. **Execute Budget Scenario**<br/> 
This button will start the scenario simulation for the Budget dataset based on Budget input and settings. 
2. **Execute Forecast Scenario**<br/> 
This button will start the scenario simulation for the Forecast dataset based on Forecast input and settings. 
3. **Select table**<br/> 
Here you can select which scale factor table to work with. Ticking on table will show the table content and enable edit to the right.
4. **Scale Factor Tables**<br/> 
Here you can edit the content and set the scale factor for simulation.

**Note:** Only the "Best" and "Worst" is simulated here based on the scale factors set below.

The columns from left for right until and including the "From Date" are key columns that will be used to match the input transactions. For scale factor the "Baseline" is always 1.0 while the "Best" and "Worst" can be set to any factor. The factor is applied to the input source transactions amount to change the amount to: Amount * Scale Factor to be applied according to selected keys.

Example from picture above for Sales Source Factor: 

Best case is to increase the sales by 20% (Best = 1.2) and worst case is that sales decrease by 10% (Worst= 0.9). This will be applied for Legal Entity = "Profitways", alle datasets (both Budget and Forecast), sales accounts, services product and Oil&Gas market. Note that using a scale factor of 0 and a FromDate you can simulate shut-down permanent or adding a new FromDate row to open after shut-down.

<br/>

## Descriptions

The scale factor tables are described below and columns that are key columns is marked with (k).

#### Sales: Source Factor
Set the scale factor to scale sales input.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **Product (k)**<br/>
Identify product or group of products for which the setting is valid.
- **Market (k)**<br/>
Identify market for which the setting is valid.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **Baseline**<br/>
This is the normal case which apply the source transactions input as-is (i.e. Amount * 1.0).
- **Best**<br/>
Set a number to scale the sales input to the factor that represent and increase in sales (i.e. should normally be set to factor > 1.0).
- **Worst**<br/>
Set a number to scale the sales input to the factor that represent and decrease in sales (i.e. should normally be set to factor < 1.0).
- **Comments**<br/>
Free text sting to help document settings.
<br/>

#### Salary: Source Factor
Set the scale factor to scale salary input.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **Employee (k)**<br/>
Employee or employee type from the Employee dimension.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **Baseline**<br/>
This is the normal case which apply the source transactions input as-is (i.e. Amount * 1.0).
- **Best**<br/>
Set a number that represent a decrease in total salary cost.
- **Worst**<br/>
Set a number that represent an increase in total salary cost.
- **Comments**<br/>
Free text sting to help document settings.
<br/>

#### Expense: Source Factor
Set the scale factor to scale expense input.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **SupplierID (k)**<br/>
Identify the supplier as criteria when matching setting row.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **Baseline**<br/>
This is the normal case which apply the source transactions input as-is (i.e. Amount * 1.0).
- **Best**<br/>
Set a number that represent a decrease in total expense.
- **Worst**<br/>
Set a number that represent an increase in total expense.
- **Comments**<br/>
Free text sting to help document settings.
<br/>

#### Purchase: Source Factor
Set the scale factor to scale purchase input.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **Dataset (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'.
- **Account (k)**<br/>
Named group of accounts from Account dimension or individual accounts.
- **SupplierID (k)**<br/>
Identify the supplier as criteria when matching setting row.
- **Product (k)**<br/>
Identify product or group of products for which the setting is valid.
- **From Date (k)**<br/>
The date from which the setting is valid from.
- **Baseline**<br/>
This is the normal case which apply the source transactions input as-is (i.e. Amount * 1.0).
- **Best**<br/>
Set a number that represent a decrease in purchase cost.
- **Worst**<br/>
Set a number that represent an increase in purchase cost.
- **Comments**<br/>
Free text sting to help document settings.
<br/>
