---
title: "Account"
metaKeys: ""
folderOnly: "false"
pageIndex: 10
---

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4.x, 5.0 or 5.1

# Overview
Here you can edit the Account dimension.

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/report-setup-account.JPG)

1. **Account** <br/>
This will filter accounts on the hierarchical node selected.

2. **Change Account Dimension** <br/>
This table is showing the list of accounts and some attributes to be edited here.

3. **Publish**<br/>
Push this button to apply changes to Account dimension.

Often accounts are imported from external source. In this case the priority between the local edits and external source are as follows:
- External source will have priority for Account Description and translations and will add new accounts.
- Local edits will have priority for "Allow Input", "Sign Factor" and "Acc. Type". Local edits can also add accounts and delete accounts.

If you choose to edit account description or translations and delete an account that is imported from external source, the edits will be overwritten, and the deleted account will be added from external source.

## Column Descriptions

- **Account**<br/>
The account identifier.
- **Account Description**<br/>
The descriptive name of the account.
- **Allow Input**<br/>
Set to true for accounts that will be available for user input.
- **Sign Factor**<br/>
Set this to tell how the sign on accounts will be used. For example, it is normal that sales account is using negative sign and as such Sign Factor will be -1.0.<br/>

   Sign factor is relevant in two scenarios:<br/>
   1.	**Account** sign factor (**this field**): a sign factor of -1 tied to an account will:<br/>
   o	Switch the sign of any historical data<br/>
   o	Switch the sign of any input data<br/>
   This would typically apply to income accounts booked with a credit sign that one would like to see and input as a positive amount in an input form.<br/>
   2.	**Report line** sign factor (see [Setup Report](setup-report.md)): a report line nets a range of accounts or is a calculation of other report lines.<br/>
   The report line sign factor indicates whether this net amount should be presented "as is" (sign factor +1) or with the opposite sign (sign factor -1) in this particular report.<br/>
   Note that any report lines that act as calculations of other report lines will perform that calculation based on the values displayed, i.e. after the sign factor has been applied. <br/>
- **EN: Account Description**<br/>
Text for English translation for Account Description.
- **NO: Account Description**<br/>
Text for Norwegian translation for Account Description.
- **Acc.Type**<br/>
Dropdown list to set the type of account ("Balance" or "Profit Loss") is the 12 period columns showing amounts.
- **Hierarcy level 3, 2, 1**<br/>
These are the 3 levels above the account starting on top with level 1, 2, 3 and account. For each level you need to define and identifier, description and language translations for Norwegian and English.<br/><br/>
If you do not want to use all levels in the structure you can "skip" levels by copying from a lower level to fill all levels between. No levels can be left empty.
