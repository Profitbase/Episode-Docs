# Delete Blob

Deletes a blob from an Azure Blob container.

![img](../../../../images/flow/delete-blob.png)

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Connection       | Required  | A [SAS Uri](https://learn.microsoft.com/en-us/azure/storage/common/storage-sas-overview) to an Azure Blob container or connection string and container name.       |
| Blob name        | Required  | The name of the blob to delete.                        |
