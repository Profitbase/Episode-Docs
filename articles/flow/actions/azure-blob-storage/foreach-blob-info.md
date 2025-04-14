# For each Blob info

Iterates over a list of blob information in an Azure blob container. 

![img](https://profitbasedocs.blob.core.windows.net/flowimages/foreach-blob-info.png)


**Example** ![img](../../../../images/strz.jpg)  
This flow iterates through all blobs in an Azure blob container, checks if each blob was modified today, and if so, reads its content as a byte array.. Used actions: [For each Blob info](), [If](../built-in/if.md) and [Read Blob as byte array](read-blob-as-byte-array.md).


## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Title |   |  |
| Connection       | Required  | The [Azure Blob container connection](./azure-blob-container-connection.md). The currently supported options are `SAS URI` and `Connection string + container name`.    |
| Dynamic connection | Optional   | A connection dynamically created using the [Create Azure Blob container connection](./create-azure-blob-container-connection.md) action.    |
| Blob name prefix filter| Optional  | Prefix filter for blob properties **Note!** The prefix is case sensitive. |
| Blob info | Optional | The name of the Flow variable that contains the blob info. |
| Description | Optional | Additional notes or comments about the action or configuration.  |

