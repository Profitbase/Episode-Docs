# Azure Blob container connection 

To connect to an Azure Blob container and perform actions, such as reading or uploading data, you need to create an Azure Blob container connection.

Flow currently supports connecting using `SAS URI` or `Connection string and container name`.

## Connection details

An Azure Blob container connection consists of the following fields:

| Field             | Description                                                          |
| ----------------- | -------------------------------------------------------------------- |
| Name   | A custom label for this connection. This name will be shown when selecting the connection in a Flow action.    |
| Connection type     | Select how you want to authenticate with Azure Blob Storage. Two options are available: **SAS URI** – A Shared Access Signature URL that grants temporary access to a blob container; **Connection String and Container Name** – Uses the full Azure Storage connection string combined with the name of a specific blob container.  |
| SAS URI (if selected) |  	A full **Shared Access Signature URI**, including the container path and token. You can generate this in the Azure Portal under Storage Account → Containers → Generate  SAS.    |
| Connection String (if selected) | The full Azure Storage connection string, available in the Azure Portal under Access keys. |
| Container Name (if selected) | The exact name of the blob container to access (e.g., invoices). Must match a container that exists under the storage account. |

## SAS URI
A [SAS URI](https://learn.microsoft.com/en-us/azure/storage/common/storage-sas-overview) (shared access signature URI) grants restricted access rights to Azure Storage resources. You can provide a shared access signature to clients who shouldn't be trusted with your storage account key but who need access to certain storage account resources, such as a container.

You can create a SAS URI through the `Azure portal` and then copy it to Flow.  

## Connection string and container name

You can use a connection string if you want to grant access to the entire storage account, or don't want the connection to expire (SAS URIs have an expiration date).  
If you use a connection string, we strongly recommend using a **SAS token** instead of the account key in the connection string, to limit access to just a specific container. If you use the account key in the connection string, you grant access to all containers in the storage account.

**Connection string for storage account (not recommended)**
```
DefaultEndpointsProtocol=https;AccountName=MY_ACCOUNT_NAME;AccountKey=PnECntHiVbh2/w6f7tYK2p3cerWIxQlWBgkg+Ue4l2+ZuuwofCXutYWK/K/cxRUVO5216JLsF4W/O7KLhfMs8w==;EndpointSuffix=core.windows.net
```

**Connection string with SAS token (recommended)**
```
DefaultEndpointsProtocol=https;AccountName=MY_ACCOUNT_NAME;SharedAccessSignature=sp=r&st=2025-02-10T19:26:04Z&se=2025-02-11T03:26:04Z&spr=https&sv=2022-11-02&sr=c&sig=kO%2BbYtYRdB5PkunJPQKB%2F7avaw1o8fqmrMkkoZdSSKs%3D;EndpointSuffix=core.windows.net
```





