# Get Blob info

Gets detailed information for a specific blob in an Azure Blob container. Use this action if you need properties of a particular blob in a container.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/get-blob-info.png)



## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Title |   |  |
| Connection       | Required  | The [Azure Blob container connection](./azure-blob-container-connection.md). The currently supported options are `SAS URI` and `Connection string + container name`.    |
| Dynamic connection | Optional   | A connection dynamically created using the [Create Azure Blob container connection](./create-azure-blob-container-connection.md) action.    |
| Blob name | Required | The name of the blob from the list. |
| Result variable name | Required | The name of the Flow variable that contains the list of the blob properties. |
| Description | Optional | Additional notes or comments about the action or configuration.  |




