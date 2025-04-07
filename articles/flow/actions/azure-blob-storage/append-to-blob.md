# Append to Blob

Appends a byte array or Stream to an [Azure Append Blob](https://learn.microsoft.com/en-us/rest/api/storageservices/understanding-block-blobs--append-blobs--and-page-blobs#about-append-blobs).  

![img](https://profitbasedocs.blob.core.windows.net/flowimages/azure-append-to-blob.png)  

**Example** ![img](../../../../images/strz.jpg)  
This flow example shows a process that reads data from a database, splits records into multiple chunks, converts each chunk into CSV format, and appends it to a blob storage.  
Actions used in the flow are: SQL Server [Get DataReader](../sql-server/get-datareader.md), [DataReader chunker](../built-in/datareader-chunker.md), [Create CSV file as byte array](../csv/create-csv-file-as-byte-array.md) and [Append to Blob](). 

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Title             |       |                                             |
| Connection       | Required  | The [Azure Blob container connection](./azure-blob-container-connection.md). The currently supported options are `SAS URI` and `Connection string + container name`.    |
| Dynamic connection | Optional   | A connection dynamically created using the [Create Azure Blob container connection](./create-azure-blob-container-connection.md) action.    |
| Blob name        | Required  | The name of the blob to append to. If the blob does not already exist, it will be created. |
| Blob data        | Required  | A byte array or stream input. |
| Description |Optional|  Additional notes or comments about the action or configuration. |

