# Personnel
## Overview
This is the the Personnel input module and is where any detailed planning per employee/employee category takes place.

The Personnel module uses a driver-based principle in which FTEs (Full Time Equivalents) and HCs (Headcounts) are the drivers.

Any user input is thus provided per FTE or HC per month.

<br/>

![](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/PersonnelOverview.JPG)

1. **Back button** <br/>
This button is active when the module is launched from the Plan overview workbook. Clicking the Back button will launch the Plan overview workbook in the same browser window. If there are unsaved changes made in the Personnel module, a prompt will appear requesting confirmation.
2. **Year filter** <br/>
The year filter allows you to select the year to plan for. Note that the years available will vary from this year and next year (default) to an additional 5 years beyond next year depending on the solution configuration.
3. **FTE page** <br/>
The FTE page allows for editing FTEs per period.
4. **Headcount page** <br/>
The Headcount page allows for editing HCs per period.
5. **Change Spread to periods** <br/>
The "Change" link in the Spread to periods column takes you to a pop-up window in which to control the spread of the "per FTE per month" input values.
6. **Workflow** <br/>
The workflow enables you to set the state of the plan for the department selected. Setting the state to Finished will by default disable any further input (depends on user's access level).
7. **Attachment button** <br/>
The attachment button will display the number of attachments associated with this input page in the current filter context. The current filter context is the selection made in the organizational filter (leftmost section) and the optional filters that are found in the rightmost section (subject to configuration).

To add a new attachment, click the attachment button and drag-then-drop the attachment from the file system onto the drop zone in the attachment dialogue.

To delete an attachment, click the attachment button, select the attachment and the click the Delete button (bin icon) within the attachment dialogue. <br/>

8. **FTE/HC report** <br/>
The FTE/HC report display the sum of FTEs and HCs planned per period and is updated as input data is saved.

<br/>

9. **Account report** <br/>
The account report display the financial effect of the input made and is updated as input data is saved.
Note that for forecasting, the current year (this year) will consist of a set of actual periods that are read only and a set of plan periods that are editable. The cut off between actuals and plan is visualized with a red vertical line as show in the example.

<br/>

10. **Filters section(s) left and right** <br/>
In the left section, the mandatory Department filter is displayed. The content of this filter is normally access controlled. In the right section, additional context filters (Product, Market, Activity, Project, depending on the solution configuration) are displayed. Make filter selections to narrow down the data displayed. From Planner 5.3 onwards, a Net filters check box is available that allows you to narrow down the filter member to those available in the data grid.<br/>

<br/>


## Video
![Introduction](https://profitbasedocs.blob.core.windows.net/enduserhelp/videos/PersonnelInput.mp4)<br/>

<br/>

## Column Descriptions

Note that some of the columns may have headings that differ from the example depending on the solution configuration and the year selected if in a forecast context. For columns of this kind, a reference to the image example shown is mentioned in the below description.

- **Employee**<br/>

The main planning dimension for personnel related planning. The employee dimension may contain individuals and/or employee categories as shown in the example.. Right-click and select one of the "Insert new row.." options to add new rows.

- **Financial report - "$" icon**<br/>

The Financial report icon will trigger the reports for the row clicked. Clicking the icon for the sum row, will trigger the reports for all rows.

- **Hist. FTE**<br/>

The current FTE for the employee/employee category of the given row. This value is loaded from the Personnel fact source that is either maintained in Planner or sourced from an external source depending on the solution configuration.

- **FTE (Rest yyyy)** <br/>

Average FTE planned. Note that FTE may vary per month, thus the value presented is an average. Note also, that the periods associated with the value will vary depending on process and year:

For a budget (a one year process), the value is the average FTE for the year budgeted.
For a forecast (a multi-year process that rolls forward regularly) the value for this year is the average of the plan months representing the rest of the year. For next year and any years thereafter, the value is the average for the year.

- **Hist. Mth. Salary** <br/>

The current monthly salary for the employee/employee category of the given row. This value is loaded from the Personnel fact source that is either maintained in Planner or sourced from an external source depending on the solution configuration.

- **Base Mth. Salary** <br/>

The Base monthly salary is the (average) monthly salary at the start of the plan period. From Planner version 5.3 onwards, you can right-click an input cell and select Validate financial simulation to see the financial impact of the input value. The results is presented in a separate pop-up window.

- **Raise (yyyy)** <br/>

The salary raise may be set centrally in which case it is not editable or may be a local adjustment in which case it is editable.

- **Salary (Rest yyyy)** <br/>

Calculated salary.

For a budget (a one year process), the value is calculated salary for the year budgeted.
For a forecast (a multi-year process that rolls forward regularly) the value for this year is the calculated salary for the plan months representing the rest of the year. For next year and any years thereafter, the value is the calculated salary for the year

- **Additional input columns depending on configuration (Overtime, Bonus, Free Car and Training in the example)** <br/>

Input fields, depending on configuration, for additional per-FTE-per-month cost.

- **Spread to periods** <br/>

Column containing a "Change" link that takes you to a pop-up window in which you can change the spread of the per-FTE-per-Month value to the plan periods. If no specific spread key is defined, the value will be spread to each plan period with a value equal to the input value.

- **Comment** <br/>
Input field enabling textual comments to be associated with the input for a specific line.

<br/>

## How to`s

<br/>

> [Create new task](../../workbooks/process-and-tasks/tasks/create-edit-task.md)<br/>



