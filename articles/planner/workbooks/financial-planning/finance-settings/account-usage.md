---
title: "Account Usage"
metaKeys: ""
folderOnly: "false"
pageIndex: 9
---

### Overview
This page gives an overview of accounts usage in different settings tables. This report page is intended for debugging purposes.

Instructions for use:

1. You can click on column header to sort; for example sorting on Account as shown in picture above.
2. Click on settings table in the "Settings Name" column. For example for Account = "5010" and Settings Name = "PensionEmployerPct" to bring up the display of 3 records in Settings Details.
<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/finance-settings-account-usage.jpg)

1. **Account Usage**<br/>
This table list all accounts in all settings tables. The Settings Name column provide a drilldown to see content for this account and setting table.
2. **Setting Details**<br/>
This table will show the details on selected row in Account Usage table.
<br/>

### Descriptions
#### Account Usage

- **Legal Entity:**<br/>
Legal Entity ID. Note that wildcard for all Legal Entities (*) may be used here.
- **Name:**<br/>
Legal Entity name.
- **Dataset:**<br/>
Dataset ID. Note that wildcard for all datasets (*) may be used here.
- **Account:**<br/>
Account ID.
- **Account Description:**<br/>
Account name.
- **Acc Key:**<br/>
Account key is the system internal account.
- **Settings Name:**<br/>
Name of settings table. This is an action column to trigger display in Setting details to the right.

<br/>

#### Setting Details
This table shows the column name and values from the selected combination of account and settings table in the table to the left.

- **Name**<br/>
Display the name of the column from the setting table.
- **Value**<br/>
Display the value from the row in the setting table

Note that this table may show several records which are sorted to show same columns together for comparison.

