---
title: "Edit"
metaKeys: ""
folderOnly: "false"
pageIndex: 1
---

### Overview
This page allows for adjusting opening balances for Forecast and Budget dataset and with start date as controlled by the roll-forward process.
<br/>

![](https://profitbasedocs.blob.core.windows.net/plannerimages/opening-balance-edit.jpg)

To edit opening balance, you can follow the 3 steps below:

1. **OB Data** <br/>
Select the dataset and the Opening Balance date in the dropdown list. This selection will filter the data in the table below and set the context for optional generate opening balances (using the button describe below).

2. **Generate OB Data** <br/>
This button will generate a new opening balance dataset for the selected "OB Data" (describe above). A new opening balance will be generated from actual historical data and merged with existing balance overrides (from previous edits).

3. **Description** <br/>
Data is rendered in this table. Depending on the Legal Entity filter to the left, the table will in summary mode or input mode:

Summary mode is when Legal Entity filter is on a level above a legal entity. In this case the table will aggregate opening balances from underlying legal entities and the override columns will show the final amounts to be used.

The table will be in input-mode when a legal entity is selected. In this case the override columns will be enabled for input to adjust the balance. To override a balance, you enter the new total amount to be used instead of the generated balance amount.
<br/>

Note that override values will survive when you re-generate the balance from the source (i.e. push "Generate OB Data" after adding overrides).

The source data is historic actual general ledger transactions.

During simulation these values are deployed according to [Finance Settings OBDue](../finance-settings/obdue.md).

Providing the balance for the last 3 month helps the system to deal with due payments on the balance. Providing the last full year balance help the system to apply e.g. vacation pay based on last year actual.


### Column Descriptions

- **Account**<br/>
Account id and description.
- **Currency**<br/>
The functional currency for the legal entity.
- **Year OB**<br/>
This is the opening balance amount for the last full year.
- **YYYY OB Ovr.**<br/>
This is the override amount to replace the amount described in previous column.
- **YYYY-MM OB**<br/>
This is the opening balance amount for the period. There are 3 such columns which capture the 3 last months.
- **Month OB Ovr.**<br/>
This is the override amount to replace the amount described in previous column. Again, there are 3 such columns in pairs with amount and override amount.
- **Ovr. count**<br/>
Whenever you do an override these are marked (i.e. counted) in this column.
- **Cp LegalEntity:**<br/>
Counterparty legal entity.
- **Cp Department:**<br/>
Counterparty department.
- **Cp Account:**<br/>
Counterparty account.
- **Comments:**<br/>
Free text to help you document any changes.
<br/>

