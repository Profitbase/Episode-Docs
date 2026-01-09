# SIE file parser


This action parses an [Standard Import Export (SIE)](https://sie.se/in-english/) file and retuns an object with information and collections that can be used by other actions. 
Use this action to extract opening/closing balances, transactions, vouchers etc. from an SIE file.

The Swedish SIE (Standard Import och Export) file format is an open, text-based standard for transferring accounting data between different software systems in Sweden, acting as a de facto standard for companies, accountants, and auditors to exchange financial information like balances, transactions, and account details, with different types (SIE 1, 2, 3, 4) for varying data levels.


![img](/images/flow/sie-file-parser.png)

<br/>

**Example** ![img](/images/strz.jpg)

The example above shows how a SIE is read from [Fortnox REST API](../fortnox/get-sie-file-stream.md), and parsed with the **SIE file parser**. From the parsed result object, an [SIE DataReader](../sie/datareader.md) action is then used to get values to be [inserted into an SQL Server table](../sql-server/insert-data.md).

<br/>

## Properties

| Name            | Type     | Description          |
|-----------------|----------|----------------------|
| Title           | Optional | The title or name of the action.  |
| Source          | Required | A Stream containing SIE file content. |
| Parser options  | Optional | Optional settings about source file and parsing settings (see below). | 
| Result variable name | Required | The name of the variable that contains the output from this action. | 
| Description     | Optional | Additional notes or comments about the action. |

<br/>

### Parser options

| Name            | Description          |
|-----------------|----------------------|
| Allow Missing Date | Check to allow missing dates in e.g. transactions. |
| Allow Unbalanced Voucher | Check to allow incomplete / unbalanced Vouchers | 
| Throw Errors | If parsing should throw errors or just complete. |
| Encoding | Select the source encoding format (default: ISO-8859-1). |
| Date Format | Enter the source date format (default: yyyyMMdd). |

<br/>

## Result 

This action returns an **SIEResultObject**. 

<br/>

### Object properties

| Property | SIE tag | Type | Description |
|----------|---------|------|-------------|
| Format | #FORMAT | string | SIE file format version. | 
| GeneratedDate | #GEN | DateTime | Date when the SIE file was generated. |
| GeneratedName | #GEN | string | Name of the user who generated the SIE file (signature). |
| Description | #PROSA | string |  Description of the SIE file content. |
| ChartOfAccountType | #KPTYP | string | Type of chart of accounts. |
| PeriodToDate | #OMFATTN | DateTime | Date for period of period end balance  (date up to and including). |
| TaxationYear | #TAXAR | Integer | Tax year for the exported data. |
| Currency | #VALUTA | string | Currency code for the exported data. |
| Company | #FNAMN | SieCompany | Company the data originates from. | 

<br/>

### Object collections

| Collection | SIE tag | Of type | Description |
|------------|---------|---------|-------------|
| OpeningBalance | #IB | SiePeriodValue | Opening balance for balance sheet account. |
| ClosingBalance | #UB | SiePeriodValue |  Closing balance for balance sheet account. |
| OpeningBalanceForObject | #OIB | SiePeriodValue |  Opening balance for object. | 
| ClosingBalanceForObject | #OUB | SiePeriodValue | Closing balance for object. |
| PeriodBudget | #BUDGET | SiePeriodValue |  Budget for account for the period. |
| PeriodBalance | #PSALDO | SiePeriodValue | Period saldo for account for the period. |
| ProfitLossBalance | #RES | SiePeriodValue | Profit/loss account balance for the period. |
| Transactions | #TRANS | SiePeriodValue | Transaction items |
| FinancialYears | #RAR | SieBookingYear | Financial year from which the exported data is retrieved. |
| Account | #KONTO | SieAccount | Account information. |
| Dimensions | #DIM | SieDimension | Dimensions. |
| SubDimensions | #UNDERDIM | SieDimension | Sub-dimensions. |
| Vouchers | #VER | SieVoucher | Voucher information. |

