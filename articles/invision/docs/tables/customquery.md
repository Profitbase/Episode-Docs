---
title: "Custom Query"
metaKeys: "Custom Query, load data, Sync with Designer, View Standard,  "
pageIndex: 6
---

### Custom Query Description

<br/>

You can override the SQL query used for loading data to a Worksheet by creating a custom SQL query for that purpose. You can set it up from the Query tab in the Worksheet Designer.

<br/>

To get started defining a custom SQL query for a Worksheet, enable **Use Custom Query** to **LOAD DATA** in the Query designer and press **Sync with Designer**. Pressing Sync with Designer will insert the standard query generated based on the Worksheet Layout into the query editor, allowing you to modify the query used for loading data to the Worksheet.

<br/>

As long as **Use Custom Query to load data** is enabled, the query defined in the custom query editor will be used for loading data to the worksheet. If you decide to revert to using the standard way or loading data, you can safely disable the option without loosing the custom query.

<br/>

If you decide to use a custom query to load data, you need to ensure that the columns in the data set returned from the custom query matches the columns defined in the Worksheet Layout by name, data type and count. When you’re in the custom query designer, you can press **View Standard Query** to view the query generated based on the Worksheet Layout. This makes it easier to ensure that the columns in the custom query matches the expected columns for the grid schema. 

<br/>

When using custom queries for Worksheets, remember to include any **_PBComment** columns from the Data Store, otherwise the end user will not be able to view, add or edit cell comments.

<br/>

![Custom Query](https://profitbasedocs.blob.core.windows.net/images/Custom%20Query.png)

<br/>

### Videos

* [Worksheet](../../videos/worksheet.md)
* [Custom Query](https://profitbasedocs.blob.core.windows.net/videos/Worksheet%20-%20Custom%20Query.mp4)
* [Workbook Events - Sending Messages Between Workbooks](https://profitbasedocs.blob.core.windows.net/videos/Workbook%20Interactions%20-%20Sending%20Messages%20Between%20Workbooks.mp4)