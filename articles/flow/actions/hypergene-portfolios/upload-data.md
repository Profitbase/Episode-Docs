# Upload data

Uploads data to Hypergene Portfolios for custom processing.

![img](/images/flow/portfolios-upload-data.png)  

**Example** ![img](../../../../images/strz.jpg)  
The example above illustrates how to upload project expenses from an Azure SQL database to Hypergene Portfolios. It uses the SQL Server [Load to DataTable](../sql-server/load-to-datatable.md) action to fetch data from the Azure SQL database, then creates a CSV file using [Create CSV as stream](../csv/create-csv-file-as-stream.md) and finally uploads the CSV file to Hypergene Portfolios using the [Upload data](#upload-data) action.

<br/>

## Properties
| Name            | Type            | Description              |
|-----------------|-----------------|--------------------------|
| Connection      | Required        | The [connection](./connection.md) to the Hypergene Portfolios subscription. |
| Data            | Required        | The data to upload. This can be a byte array, stream, or string. If you provide a string, Flow will automatically convert it to a UTF-8 encoded byte array when uploading. | 
| Upload setting  | Required        | The name of the predefined upload setting in Hypergene Portfolios. This setting tells the Portfolios server how to handle the uploaded data. Select the desired upload setting from the list. If the list is empty, you must first define an upload in Hypergene Portfolios before uploading data using Flow. |

<br/>

## Best practices using the Upload data action
When uploading data to Hypergene Portfolios using Flow, we recommend the following:  
- Upload data in CSV format. Use the [Create CSV as stream](../csv/create-csv-file-as-stream.md) or [Create CSV as byte array](../csv/create-csv-file-as-byte-array.md) actions to create the CSV file from tabular or string data.  
- Use the following settings when creating CSV files to upload to Hypergene Portfolios.  
    - Header row: `true` (default)
    - Column delimiter: `, (Comma)` (default)
    - Row delimiter: `\r\n` (default)
    - Quote character: `" (Double quote)` (default)
    - Quote all fields: `false` (default)
    - Date format: `yyyy-MM-dd` (default)
    - Number decimal separator: `. (Period)` (default)