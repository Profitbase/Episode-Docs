# Advanced

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5.2 or later.

## Overview


## Descriptions

Each table and columns are described below.

Key columns used for matching when looking up correct setting is marked (k).

### Advanced: Misc. postings
This module allows you to post miscellaneous debit/credit postings that are required to make up the complete virtual ledger such as tax, bookkeeping of profit/loss, etc.

Due to the nature of the module, both an account and a counter account is involved even for transactions within the same legal entity (double entry accounting).

Account - Counter Account can be any combination of P&L and Balance accounts (to/from).

The module does also handle intercompany transactions and will in those cases require information on the counterpart's legale entity id, department id and account id.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable, select from drop down.
- **Department (k)**<br/>
Department applicable, select from drop down.
- **SimItem (k)**<br/>
SimItem TO DO - description.
- **Text**<br/>
Textual description of transaction.
- **Account (k)**<br/>
Account applicablefor the transaction (select from list).
- **Counter Account (k)**<br/>
Counter Account applicable for the transaction, select from list.
- **Transdate (k)**<br/>
The transaction date for the transaction.
- **Curr. foreign (k)**<br/>
The currency of the transaction.
- **Amount (k)**<br/>
The amount (in currency foreign) of the transaction.
- **Agio Disagio curr. exch. rate**<br/>
The exchange rate to be used for any agio/disagio calculations.
- **Project**<br/>
The Project applicable for the transaction (optional), select from list.
- **Activity**<br/>
The Activity applicable for the transaction (optional), select from list.
- **Dim1**<br/>
The Dim1 applicable for the transaction (optional), select from list.
- **Dim2**<br/>
The Dim2 applicable for the transaction (optional), select from list.
- **Dim3**<br/>
The Dim3 applicable for the transaction (optional), select from list.
- **Dim4**<br/>
The Dim4 applicable for the transaction (optional), select from list.
- **Cp Legal Entity**<br/>
The counterpart legal entity applicable for the transaction (optional), select from list. Applicable for intercompany transactions only
- **Cp Department**<br/>
The counterpart department  applicable for the transaction (optional), select from list. Applicable for intercompany transactions only
- **Cp SimItem**<br/>
The counterpart SimItem TO DO applicable for the transaction (optional), select from list. Applicable for intercompany transactions only
- **Cp Account**<br/>
The counterpart's account applicable for the transaction (optional), select from list. Applicable for intercompany transactions only
- **Cp Counter Account**<br/>
The counterpart's counter account applicable for the transaction (optional), select from list. Applicable for intercompany transactions only
