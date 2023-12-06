# Account mapping

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5.2 or later.

## Overview
This is the page for defining the mapping between report lines and accounts.

Select a report in the left margin in order to display and edit the associated report lines.  

If you need to create a new report or maintain the properties of an existing one, click the Add.. link in the upper right corner in the left margin. This takes you to [Reports](reports.md)

When changes are done and saved, click the Publish button to publish these changes to relevant versioned solutions. Clicking Publish will reveal a pop-up in which versions can be selected.
<br/>

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/AccountMapping.JPG)

# Column Descriptions

- **Report Line ID**<br/>
Readonly on this page, see [Report lines](report-lines.md) for details.
- **Report Line**<br/>
Readonly on this page, see [Report lines](report-lines.md) for details.
- **Formula**<br/>
Readonly on this page, see [Report lines](report-lines.md) for details.
- **Sign Factor**<br/>
Readonly on this page, see [Report lines](report-lines.md) for details.
- **Accounts (from-to, acc1, acc2..)**<br/>
Set this account mapping to determine which account to be aggregated to this reporting line. Expression can be intervals: Start and end accounts separated by dash ("-") and single accounts separated by comma (","). For example 3000-31999,3200,3210,3500-3599.<br/>
As an alternative method, the account selector in the right margin may be used. Click the Edit link for the report line in question to reveal the accounts available for selection. Accounts already mapped are marked and the report line id that they are mapped to is show. Tick / un-tick accounts as appropriate and click the Save mapping button. Note that the selections made will overwrite the content in the "Accounts (from-to, acc1, acc2, ..) cell. 
- **Default Account ID** (from Planner 5)<br/>
Default account. This is the default account which allows one account to represent the report line. <br/>
- **Edit**<br/>
Activates alternative mapping of mapping accounts to report line. The mapper is displayed in the right margin. See also explanation above.