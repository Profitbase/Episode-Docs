# Connecting to Azure Files

When adding a [Azure Files](https://azure.microsoft.com/en-us/products/storage/files) action, select an [existing connection](../../workspaces/workspace-objects.md) or create a new one. 

## Connection details

An Azure Files connection consists of the following fields:

| Field                         |       | Description                               |
|-------------------------------|------------------|-------------------------|
| Connection name   |       Required      | Name of the connection.        |
| Connection type   |       Required      | Select 'Connection string and Share name'. More options to come..  |
| Share name        |       Required      | The Azure Files Share name.    |
| Default directory |       Optional      | An optional directory on the share |


## Mounting an Azure File share to a local drive letter

Click [here](https://learn.microsoft.com/en-us/azure/storage/files/storage-how-to-use-files-windows) for instructions. 