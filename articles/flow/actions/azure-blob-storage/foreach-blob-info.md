# Foreach Blob info

Iterates over a list of blob information in an Azure blob container. 

![img](https://profitbasedocs.blob.core.windows.net/flowimages/foreach-blob-info.png)

<br/>

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Title |   |  |
| Connection       | Required  | The Azure Blob Container Connection. Choose either 1. A [SAS URI](https://learn.microsoft.com/en-us/azure/storage/common/storage-sas-overview) to an Azure Blob container or 2. A Storage account connection string and container name.       |
| Blob name prefix filter| Optional  | Prefix filter for blob properties **Note!** The prefix is case sensitive. |
| Blob info | Optional | The name of the Flow variable that contains the blob info. |
| Description | Optional | Additional notes or comments about the action or configuration.  |

<br/>

## Add a condition - if

Read more about [Condition - If here](../built-in/if.md).

![img](https://profitbasedocs.blob.core.windows.net/flowimages/foreach-blob-info2.png)

<br/>

## Add a function 

Read more about [Function here](../built-in/function.md)

![img](https://profitbasedocs.blob.core.windows.net/flowimages/foreach-blob-info3.png)


![img](https://profitbasedocs.blob.core.windows.net/flowimages/foreach-blob-info4.png)