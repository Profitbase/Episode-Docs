---
title: "Sales details"
metaKeys: ""
folderOnly: "false"
pageIndex: 2
---

### Overview
This is the the Sales detail view in which the complete model for a given dimensionality (dimensionality subject to configuration) can be viewed and adjusted.

<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/SalesForecastDetailView.jpg)

1. **Periods button** <br/>
The Periods button toggles the input mode between a year-total input and a periodic input. Any year-total input will automatically be distributed to the periods. Input made to periods will automatically be summed to the year-total.
Note that the current year (this year) will consist of a set of actual periods that are read only and a set of plan periods that are editable. The cut off between actuals and plan is visualized with a red vertical line as show in the example.
2. **Year filter** <br/>
The year filter allows you to select the year to plan for. Note that the years available will vary from this year and next year (default) to an additional 5 years beyond next year depending on the solution configuration.

<br/>


### Video
![Introduction](https://profitbasedocs.blob.core.windows.net/enduserhelp/videos/ForecastSalesInput.mp4)<br/>

<br/>

### Column Descriptions 

- **Measure**<br/>

The measure is the identifier of each individual model-row.

As this is the details view, all measures associated with the current model are displayed.

- **Function column**<br/>

The function column contains icons depending on the nature of the measure:

(todo)

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





