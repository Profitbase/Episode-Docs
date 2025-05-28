# Measure facts
## Overview
This is a simple input tool for maintaining historical data for the driver based module. 

<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/salesfact.JPG)

Select a value in the “Dataset” and “Measure” filter at the top and click the “Refresh” button to enable the save button.

Add new rows as needed or paste selection. When pasting data, make sure to paste dimension ids. A dropdown will evaluate the id against the corresponding dimension and render the dimension description. If no description is rendered, just the id, this indicates that the id does not exist in the dimension.
<br/>

## Column Descriptions

- **Dataset:**<br/>
DatasetID. Mandatory.

- **Departm.:**<br/>
Department id. Mandatory.

- **Product:**<br/>
Product id. Mandatory.

- **Market**<br/>
Market id. Mandatory.

- **Supplier**<br/>
Supplier id. Optional. If no value is provided, the default value # is set

- **Dim1:**<br/>
Dim1 id. Optional. If no value is provided, the default value # is set

- **Dim2:**<br/>
Dim2 id. Optional. If no value is provided, the default value # is set

- **Dim3:**<br/>
Dim3 id. Optional. If no value is provided, the default value # is set

- **Dim4:**<br/>
Dim4 id. Optional. If no value is provided, the default value # is set

- **Cp Legal Entity:**<br/>
Counterpart legal entity id. Optional. If no value is provided, the default value # is set

- **Measure:**<br/>
The measure id. Mandatory.

- **Value 0..9:**<br/>
The value. Numeric. Value will default to 0 if no value is provided. Any amounts must be given in the home currency.

- **Year yyyy:**<br/>
4-digit year, for example 2020. Mandatory

- **Month 1-12:**<br/>
Month number, 1-12. Mandatory

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4.2 or later

 **Project**<br/>
Project id. Optional. If no value is provided, the default value # is set. 

 **Activity**<br/>
Activity id. Optional. If no value is provided, the default value # is set. 

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 6.1 or later

 **Employee**<br/>
Employee id. Optional. If no value is provided, the default value # is set. 

 **Attr1**<br/>
Attribute 1 id. Optional. If no value is provided, the default value * is set. 

 **Attr2**<br/>
Attribute 2 id. Optional. If no value is provided, the default value * is set. 
<br/>

Dimension combinations found in the source and not in the input module for either the last 12 months actuals or any of the (optional) historical reference columns, will automatically be processed into the module on forecast rollover. 

The module can also be updated manually by clicking the “Apply…” button in the: 

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5 or later

“Models” page of the “Driver based modelling” workbook.

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4.x

“Sales Forecast Setup” page of the “Sales Forecast Setup” workbook.

## How to`s

<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 6.1 or later

-  [Configure the Driver based module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V6.1/Planner%20Driver%20based%20module.pdf)<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5.4 or later

-  [Configure the Driver based module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.4/Planner%20Driver%20based%20module.pdf)<br/>
-  [Planner Data Requirements](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/V5.4/Planner%20Data%20Requirements.pdf)<br/>
<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5.2.4 or later

-  [Configure the Driver based module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/v5.2.4/Planner%20Driver%20based%20module.pdf)<br/>
-  [Planner Data Requirements](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/v5/Planner%20Data%20Requirements.pdf)<br/>
-  [Planner Data Requirements - import template](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/v5/Planner%20Data%20Requirements%20Template.xlsx)<br/>
<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5.0 or 5.1

-  [Configure the Driver based module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/v5/Planner%20Driver%20based%20module.pdf)<br/>
-  [Planner Data Requirements](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/v5/Planner%20Data%20Requirements.pdf)<br/>
-  [Planner Data Requirements - import template](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/v5/Planner%20Data%20Requirements%20Template.xlsx)<br/>
<br/>

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4.x

-  [Configure the Sales forecast module](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/Planner%20Sales%20Forecast%20module.pdf)<br/>
-  [Planner Data Requirements](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/Planner%20Data%20Requirements.pdf)<br/>
-  [Planner Data Requirements - import template](https://profitbasedocs.blob.core.windows.net/enduserhelp/files/Planner%20Data%20Requirements%20Template.xlsx)<br/>
<br/>
