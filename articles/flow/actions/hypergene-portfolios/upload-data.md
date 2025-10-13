# Upload data

Uploads data to Hypergene Portfolios for custom processing.

<br/>

## Properties
| Name            | Type            | Description              |
|-----------------|-----------------|--------------------------|
| Connection      | Required        | The [connection](./connection.md) to the Hypergene Portfolios subscription. |
| Data            | Required        | The data to upload. This can be a byte array, stream, or string. If you provide a string, Flow will automatically convert it to a UTF-8 encoded byte array when uploading. | 
| Upload setting  | Required        | The name of the predefined upload setting in Hypergene Portfolios. This setting tells the Portfolios server how to handle the uploaded data. Select the desired upload setting from the list. If the list is empty, you must first define an upload in Hypergene Portfolios before uploading data using Flow. |