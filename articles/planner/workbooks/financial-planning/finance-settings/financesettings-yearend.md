# Year-End Alloc.
## Overview
This page contains setting year-end allocations for dividend, group contribution and withholding tax payments. All amounts is entered as positive values. All transactions for group contribution is using the currency of the paying legal entity.

## Functional Description
Year end allocation post end of year dispositions and perform financial close as described below.


### Fiscal Year related to Payment Due Date
Normal payment for dividends, goup contribution and tax, is the next fiscal year. Based on the combination of fiscal year and due date, the model automatically posts the associated provision.
When payment according to the normal occurs the year after the fiscal year, the provision is posted on the last day of the fiscal year. 
When payment takes place in the same year as the selected fiscal year, provision and payment are posted on the same date. The latter is typically the case for extraordinary dividends.

### Posting combinations types
There are readymade combinations (dropdown list) for how to post on part and counterpart.

- Dividend
- Dividend with counterpart financial income
- Dividend with counterpart reduced investment
- Group contribution (Subsiduary / Parent) cost with counterpart financial income
- Group contribution (Subsiduary / Parent) cost with counterpart financial income (deferred tax)
- Group contribution (Subsiduary / Parent) cost with counterpart reduced investment
- Group contribution (Subsiduary / Subsiduary) with counterpart increased paid-in capital
- Group contribution (Parent / Subsiduary) increased investment with counterpart increased paid-in capital
- Group contribution (Parent / Subsiduary) increased investment with counterpart reduced uncovered loss
- Corporate tax payments amounts

<br/>

### Dividends
Dividends are recorded as a disposition with no tax effect for the paying party.
For the recipient, the choices are Financial income or to reduce the Investment, both without tax effect (*).
For any extraordinary dividends throughout the year: Set Fiscal Year to the same year as the due date.

(*) In Norway, a recipient with an ownership share of <90% is liable to tax for 3% of the dividend:
For ownership of <90%: set TaxPctOvr = eg 0.66% (22% tax on 3% of dividend = 0.66% on entire dividend)

### Group Contribution - Subsiduary to Parent
Group contribution is entered as a disposition, with a consequent reduction of Payable tax.
For recipient, the options are:<br/>
A) Financial income, with consequent change in selected Payable or Deferred tax
B) Reduction of Investment (after deduction Change Deferred tax)


### Group Contribution - Subsiduary to Subsiduary
For the paying party, it is recorded as a disposition, with a consequent reduction of payable tax. 
For the recipient, group contributions (after deduction Change Deferred tax) are entered as an increase in Contributed Equity.

### Group Contribution - Parent to Subsiduary
For the paying party, group contributions (after deduction of Change Payable tax) are entered as an increase in Investment.
For recipient, the options are:
A) Increase in Contributed Equity (after deduction Change Deferred tax)
B) Reduction of Uncovered loss (after deduction Change Deferred tax)

### Corporate tax payments
This is to manually post tax payment due amounts.

### Year End Closing
This part is a separate function that can be enabled using the "EngineID" (ID="YearEndTransfer") settings (see below).

A simple byt automatic closing is performed here. Profit (or loss) is transferred to the balance sheet as change in earned equity.

If the fiscal year result is negative, any negative allocated tax (from Tax) will be zeroed (reversed).
Final 'final tax settlement' (calculated tax payable + - change in tax due - manually paid advance tax) is due at the selected 'FinalDueDate'. The same end date applies, whether you owe or have tax to your credit.

## Descriptions

Each table and columns are described below.

Key columns used for matching when looking up correct setting is marked (k).

### Year End Alloc.: YearEnd Due
This table defines the legal parties, posting type, time and amounts for year-end allocations.

**Caution:** The system will allocate amounts as instructed. It will not not prevent you from allocating more amounts than is available. 

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **TaskID**<br/>
Dropdown list to select type of posting for allocation. The different types are described above.
- **Cp LegalEntity**<br/>
Counterpart Legal Entity to define the receiving party.
- **Fiscal Year**<br/>
Amount to be paid will be taken from the selected fiscal year.
- **Due Date**<br/>
Payment date. 
- **Amount**<br/>
Payment amount input as positive number.
- **Comments**<br/>
Free text string to help document settings.
<br/>

### Year End Alloc.: YearEnd Tax %
This table set the tax percent to be used for year end transactions.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **From Fical Year (k)**<br/>
Tax % is valid from and including this selected fiscal year.
- **Tax %**<br/>
Tax % entered as decimal number (100% = 1.0)
- **Final DueDate**
Last due date for final tax settlement.
- **Comments**<br/>
Free text string to help document settings.
<br/>

### Year End Alloc.: YearEnd Accounts
This is to select accounts used for posting year end allocations.

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **From Fical Year (k)**<br/>
This setting is valid from and including this selected fiscal year.
- **Dividen (cost)**<br/>
Cost account for dividend.
- **GrpContrib (cost)**<br/>
Cost account for group contribution.
- **Investment (asset)**<br/>
Asset account for investment.
- **Dividend (income)**<br/>
Income account for dividend.
- **GrpControb (income)**<br/>
Income account for group contribution.
- **Equity Paid-in**<br/>
Acount for equity paid-in.
- **Equity Uncov.Loss**<br/>
Account for equity uncovered loss.
- **Comments**<br/>
Free text string to help document settings.
<br/>

### Year End Alloc.: YearEnd Due - Accounts

Columns:

- **Legal Entity (k)**<br/>
Legal Entity applicable.
- **From Fical Year (k)**<br/>
This setting is valid from and including this selected fiscal year.
- **Dividend Payable**<br/>
Account for dividend payable.
- **GrpContrib Payable**<br/>
Account for group contribution payable.
- **Transfer to Equity**<br/>
Account for transfer to other equity.
- **EquityRetainedEarnings**<br/>
Account for equity - retained earnings.
- **Tax Payable**<br/>
Account for tax payable.
- **Dividend Receivable**<br/>
Account for dividend receeivable.
- **GrpContrib Receivable**<br/>
Account for group contribution receivable.
- **Tax Deferred**<br/>
Account for deferred tax.
- **Tax Def (change)**<br/>
Account for change in deferred tax (disposition).
- **AgioDis**<br/>
Account for agio/disagio calculation.
- **Comments**<br/>
Free text string to help document settings.

### Year End Alloc.: EngineID
This table enables or disable using the year end allocation. The year end allocation contains two parts:

- YearEndDue - year end dividends, group contribution and tax payments
- YearEndTransfer - year end closing to transfer year earings to balance and final tax settlement.

Columns:

- **ID (k)**<br/>
Dataset is one of 'Forecast' or 'Budget'. Valid in: ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 4 or earlier.
- **Description**<br/>
Describe the two options.
- **IsDisabled**<br/>
If thicked the respective calculation and postings will not be done.

<br/>