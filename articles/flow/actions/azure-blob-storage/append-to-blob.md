# Append to Blob

Appends a byte array or Stream to an [Azure Append Blob](https://learn.microsoft.com/en-us/rest/api/storageservices/understanding-block-blobs--append-blobs--and-page-blobs#about-append-blobs).  



![img](https://profitbasedocs.blob.core.windows.net/flowimages/azure-append-to-blob.png)

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Title             |       |                                             |
| Connection       | Required  | The [Azure Blob container connection](./azure-blob-container-connection.md). The currently supported options are `SAS URI` and `Connection string + container name`.    |
| Dynamic connection | Optional   | A connection dynamically created using the [Create Azure Blob container connection](./create-azure-blob-container-connection.md) action.    |
| Blob name        | Required  | The name of the blob to append to. If the blob does not already exist, it will be created. |
| Blob data        | Required  | A byte array or stream input. |
| Description |Optional|  Additional notes or comments about the action or configuration. |

