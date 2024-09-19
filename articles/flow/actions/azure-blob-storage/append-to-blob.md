# Append to Blob

Appends a byte array or Stream to an [Azure Append Blob](https://learn.microsoft.com/en-us/rest/api/storageservices/understanding-block-blobs--append-blobs--and-page-blobs#about-append-blobs).  



![img](https://profitbasedocs.blob.core.windows.net/flowimages/azure-append-to-blob.png)

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Title             |       |                                             |
| Connection       | Required  | The Azure Blob Container Connection. Choose either 1. A [SAS URI](https://learn.microsoft.com/en-us/azure/storage/common/storage-sas-overview) to an Azure Blob container or 2. A Storage account connection string and container name.       |
| Blob name        | Required  | The name of the blob to append to. If the blob does not already exist, it will be created. |
| Blob data        | Required  | A byte array or stream input. |
| Description |Optional|  Additional notes or comments about the action or configuration. |

