# Connecting to Azure Files

When adding an [Azure Files](https://learn.microsoft.com/en-us/azure/storage/files/storage-files-introduction) action, select an [existing connection](../../workspaces/workspace-objects.md) or create a new one.

## Connection details

An Azure Files connection consists of the following fields:

| Field             |          | Description                                                              |
| ----------------- | -------- | ------------------------------------------------------------------------ |
| Connection name   | Required | Name of the connection.                                                  |
| Connection type   | Required | Select either 'Connection String and Share name' or 'SAS URI for Share'. |
| Default directory | Optional | Use this option to limit the scope of the connection to a specific root directory. **NOTE!** This directory must already exist. Use this option only if you want to limit the scope of which directories actions using this connection can use.  |


<br/>

### Additional properties for 'Connection String and Share name'

| Field             |          | Description                                      |
| ----------------- | -------- | ------------------------------------------------ |
| Connection String | Required | The connection string for the Azure Files Share. |
| Share name        | Required | The Azure Files Share name.                      |

![img](https://profitbasedocs.blob.core.windows.net/flowimages/connectionAzFile.png)

<br/>

### Additional properties for 'SAS URI for Share'

| Field   |          | Description                            |
| ------- | -------- | -------------------------------------- |
| SAS URI | Required | An valid SAS URI for a specific Share. |

![img](https://profitbasedocs.blob.core.windows.net/flowimages/connectionAzFile2.png)

<br/>

## Mounting an Azure File share to a local drive letter

You can assign and conect a drive letter on your local machine to an Azure File Share.

Click [here](https://learn.microsoft.com/en-us/azure/storage/files/storage-how-to-use-files-windows) for instructions on mounting or using UNC paths.
