# Azure Blob container connection 

To connect to an Azure Blob container and perform actions, such as reading or uploading data, you need to create an Azure Blob container connection.

Flow currently supports connecting using `SAS URI` or `Connection string and container name`.

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





