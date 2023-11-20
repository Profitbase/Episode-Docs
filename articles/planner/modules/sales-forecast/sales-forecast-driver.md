---
title: "Sales main driver"
metaKeys: ""
folderOnly: "false"
pageIndex: 1
---

### Overview
This is the Sales main driver view in which the driver can be adjusted and the financial effect of doing so can be viewed.

<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/SalesForecast.JPG)

1. **Back button** <br/>
This button is active when the module is launched from the Budget or Forecast summary workbook. Clicking the Back button will launch the summary workbook in the same browser window. If there are unsaved changes made in the Sales forecast module, a prompt will appear requesting confirmation.
2. **Periods button** <br/>
The Periods button toggles the input mode between a year-total input and a periodic input. Any year-total input will automatically be distributed to the periods. Input made to periods will automatically be summed to the year-total.
Note that the current year (this year) will consist of a set of actual periods that are read only and a set of plan periods that are editable. The cut off between actuals and plan is visualized with a red vertical line as show in the example.
3. **Year filter** <br/>
The year filter allows you to select the year to plan for. Note that the years available will vary from this year and next year (default) to an additional 5 years beyond next year depending on the solution configuration.
4. **Go to detail pop-up icon** <br/>
The pop-up icon in the leftmost column takes you to the details of the current row. 
5. **Workflow** <br/>
The workflow enables you to set the state of the plan for the department selected. Setting the state to Finished will by default disable any further input (depends on user's access level).
6. **Account report** <br/>
The account report display the financial effect of the input made and is updated as input data is saved.
Note that for forecasting, the current year (this year) will consist of a set of actual periods that are read only and a set of plan periods that are editable. The cut off between actuals and plan is visualized with a red vertical line as show in the example.

<br/>


### Video
![Introduction](https://profitbasedocs.blob.core.windows.net/enduserhelp/videos/ForecastSalesInput.mp4)<br/>

<br/>

### Column Descriptions 

- **Go to detail pop-up icon**<br/>

The column contains a pop-up icon that, when clicked, takes you to the detailed model for the current row.

- **Product, Market and possibly other dimensions depending on the configuration**<br/>

The main planning dimensions for sales forecast related planning are Product and Market. These act as categories for the sales forecast. 

Note that the heading of the individual dimensions may be set individually per model and may thus differ from the example.

Right-click and select one of the "Insert new row.." options to add new rows.

- **Measure**<br/>

The measure is the identifier of each individual model-row.

In the main driver view, the measure will always be the driving measure.

- **Financial report - "$" icon**<br/>

The Financial report icon will trigger the reports for the row clicked. Clicking the icon for the sum row, will trigger the reports for all rows.

- **FctActL12M**<br/>

The last 12 month actuals.

- **Act. YTD (2020 in the example)**<br/>

The actuals year-to-date, visible only if the year selected is this year.

- **For. YTG (2020 in this case)**<br/>

The forecast for the plan periods for the rest of the year (YTG - Year To Go), visible only if the year selected is this year.

- **Year (2020 in this case)**<br/>

The forecast year-total for the year selected.

Note that some measures are defined as summable over periods and will thus render the sum of the periods whereas other measures may be defined to average over periods and will thus render the arithmetic average.

- **Periods (Jan 20 - Dec 20 in this case)**<br/>

The individual periods. 

Note that some measure are defined as input measures and thus be editable while others may be lookups to central assumptions and calculations and thus not be editable.

The Periods button toggles the mode of any editable measure between editing the year-total and the individual periods.

- **Comment** <br/>
Input field enabling textual comments to be associated with the input for a specific line.

<br/>

### How to`s

<br/>

> [Create new task](../../workbooks/process-and-tasks/tasks/create-edit-task.md)<br/>



