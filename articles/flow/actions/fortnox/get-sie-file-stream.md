# Get SIE file stream

This action retrives an [Standard Import Export (SIE)](https://sie.se/in-english/) file and retuns it as an stream. 
Use this action to retrive opening/closing balances, transactions, vouchers etc. from Fortnox.

The Swedish SIE (Standard Import och Export) file format is an open, text-based standard for transferring accounting data between different software systems in Sweden, acting as a de facto standard for companies, accountants, and auditors to exchange financial information like balances, transactions, and account details, with different types (SIE 1, 2, 3, 4) for varying data levels.


![img](/images/flow/fortnox-get-sie.png)

<br/>

**Example** ![img](/images/strz.jpg)

The example above shows how a SIE is read from Fortnox and parsed with the [SIE file parser](../sie/file-parser.md). From the parsed result object, an [SIE DataReader](../sie/datareader.md) is used to get values to be [inserted into an SQL Server table](../sql-server/insert-data.md).

<br/>

## Properties

| Name            | Type     | Description            |
|---------------- | -------- | ---------------------- |
| Title           | Optional | The title or name of the request.                              |
| Connection      | Required | The [Fortnox Connection](./connection.md) used to make an authenticated request to Fortnox REST API. |
| Dynamic connection | Optional | Use this option of you needs to use a connection from the [Create Connection](./create-connection.md) action. |
| SIE type        | Required | Specifies the SIE type (1-4). |
| Finasncial year index | Required | Index of the financial year. |
| Result variable name | Required | Name of the variable returning the file stream. |
| Description     | Optional | Additional notes or comments about the action or configuration. |

<br>

## Returns  
[Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream)

<br/>

## Related documentation

- [SIE file specification](https://sie.se/in-english/)
- [Fortnox SIE Rest API documentation](https://apps.fortnox.se/apidocs#tag/fortnox_Sie)