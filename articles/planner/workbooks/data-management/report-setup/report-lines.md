---
title: "Report lines"
metaKeys: ""
folderOnly: "false"
pageIndex: 2
---

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5.2 or later.

# Overview
This is the page for maintaining report lines and their main properties, such as visual appearance, etc..  

Select a report in the left margin in order to display and edit the associated report lines.  

If you need to create a new report or maintain the properties of an existing one, click the Add.. link in the upper right corner in the left margin. This takes you to [Reports](../../data-management/report-setup/reports.md)

When changes are done and saved, click the Publish button to publish these changes to relevant versioned solutions. Clicking Publish will reveal a pop-up in which versions can be selected.
<br/>

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/ReportLines.JPG)

- **Profitbase EPM (mandatory)**

This is to create and edit the report lines for each report, including styling and formulas for sub-totals.

The important things that can be done here are:
- Create an ID for the report line. Best practice here is to use a prefix from the report id and then a fixed length string that sorts as you want the rows to appear in the report. Please ensure to keep gaps in the sequence to allow for inserts at a later stage. Keep IDs short to avoid formula expressions to become unreadable.
- Insert rows for subtotals and define formulas as arithmetic operations (+-*/) using the row IDs.
- Select which rows should have graph series.
- Select the format to be used for the numbers on the row.
- Select the style for the row
- Define the sign factor for the row. This is to tell how to present numbers as positive or negative considering that numbers are aggregated from account values with positive or negative representation. Sales for example is normally booked as negative number but you may want to present sales income as a positive number. In this case you use -1.0 as Sign Factor. Default sign factor is 1.0.  
<br/>

- **Profitbase Financial Reporting Matrix (optional)**

Various options regarding Profitbase Financial Reporting Matrix. Relevant only if you use Profitbase FRM.  

For details on the formatting options, please refer to Profitbase Financial Reporting Matrix documentation.

- **Profitbase legacy reporting (optional)**

Various options regardingf legacy Profitbase reporting. Relevant only if you use Profitbase legacy reporting.

### Column Descriptions

- **Report Line ID**<br/>
ID text string to uniquely identify the report line. Recommended naming convention is to use a prefix that identifies the report followed by the part to identify the line. All IDs should have the same length and the IDs determine the sorting sequence of the report lines. Note that the example above allows for inserting lines between the IDs without extending or changing the names of other report lines.
- **Report Line**<br/>
Descriptive text for the report line.
- **Formula**<br/>
For subtotal or other calculated report lines, type the arithmetic expression containing report line IDs and operations (+, -, *, /, (...)).
- **Graph Series**<br/>
Dropdown to select which report lines that can be displayed as a trendline in the trend reports.
- **Format**<br/>
Dropdown to select how to format the numbers in the report.
- **Style**<br/>
Dropdown to select how to style the row.
- **Sign Factor**<br/>
Set this factor normally to -1.0 or 1.0 to change sign on report line.
Sign factor is relevant in two scenarios:<br/>
   1.	**Account** sign factor (see [Account](../../data-management/dimensions.md)). A sign factor of -1 tied to an account will:<br/>
   o	Switch the sign of any historical data<br/>
   o	Switch the sign of any input data<br/>
   This would typically apply to income accounts booked with a credit sign that one would like to see and input as a positive amount in an input form.<br/>
   2.	**Report line** sign factor (**this field**): a report line nets a range of accounts or is a calculation of other report lines.<br/>
   The report line sign factor indicates whether this net amount should be presented "as is" (sign factor +1) or with the opposite sign (sign factor -1) in this particular report.<br/>
   Note that any report lines that act as calculations of other report lines will perform that calculation based on the values displayed, i.e. after the sign factor has been applied. The sign factor will not change the sign of a calculation formula.<br/>

