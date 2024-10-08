# Upload Blob

Uploads a byte array or [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream) to an [Azure Blob](https://learn.microsoft.com/en-us/azure/storage/blobs/) container.

![img](../../../../images/flow/upload-to-asb-blob.png)

<br/>

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Connection       | Required  | The Azure Blob Container Connection. Choose either 1. A [SAS URI](https://learn.microsoft.com/en-us/azure/storage/common/storage-sas-overview) to an Azure Blob container or 2. A Storage account connection string and container name.       |
| Blob name        | Required  | The name of the blob (file)  |
| Blob data        | Required  | The data to upload. It must be a byte array or [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream) |
| Overwrite if blob already exists | Optional | If not checked, the action will fail if a blob with the same name already exists. |

