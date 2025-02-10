# For each Blob info

Iterates over a list of blob information in an Azure blob container. 

![img](https://profitbasedocs.blob.core.windows.net/flowimages/foreach-blob-info.png)

<br/>

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Title |   |  |
| Connection       | Required  | The [Azure Blob container connection](./azure-blob-container-connection.md). The currently supported options are `SAS URI` and `Connection string + container name`.    |
| Dynamic connection | Optional   | A connection dynamically created using the [Create Azure Blob container connection](./create-azure-blob-container-connection.md) action.    |
| Blob name prefix filter| Optional  | Prefix filter for blob properties **Note!** The prefix is case sensitive. |
| Blob info | Optional | The name of the Flow variable that contains the blob info. |
| Description | Optional | Additional notes or comments about the action or configuration.  |

