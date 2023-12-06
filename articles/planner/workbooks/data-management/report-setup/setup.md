# Setup

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5.2 or later.

## Overview
This is a page for various setup, such as reporting currencies to be used, etc..
<br/>

![img](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/ReportSetupSetup.JPG)

## Equity account for Currency Translation differences

This is the account for currency exchange differences.

Currency conversion is done using average monthly exchange rate for profit and loss transactions and using end of month rate for balance type transactions. When these rates are different (they normally are for actual historical excange rates), there will be a calculation difference which is posted by default on an account called "FXadjust". This table defines the account to be used for this difference.

Note that only one group account is allowed for currency conversion differences.

## System fallback accounts

Profitbase Planner makes use of internal system accounts for financial postings. This table enables the mapping of customer accounts to the various system fallback accounts. If this mapping is not completed, account based financial reports may appear with some system fallback accounts entries rather than customer accounts.

## Curr.Rep (reporting currencies)

Profitbase EPM supports multiple reporting currencies. This table enables you to define the reporting currencies used. Report data will be aggregated to the various reports and report lines in the reporting currencies used.
