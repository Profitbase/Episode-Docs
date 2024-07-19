# Append to Blob

Appends a byte array to an [Azure Append Blob](https://learn.microsoft.com/en-us/rest/api/storageservices/understanding-block-blobs--append-blobs--and-page-blobs#about-append-blobs).  



![img](https://profitbasedocs.blob.core.windows.net/flowimages/azure-append-to-blob.png)

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Title             |  Required     |                                             |
| Connection       | Required  | A [SAS Uri](https://learn.microsoft.com/en-us/azure/storage/common/storage-sas-overview) to an Azure Blob container.       |
| Blob name        | Required  | The name of the blob to append to. If the blob does not already exist, it is created. |
| Blob data        | Required  | A byte array or stream input. |
| Description |Optional|                                             |

