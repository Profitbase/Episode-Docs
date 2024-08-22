# Azure Blob trigger

Configures the flow to automatically run by periodically fetching a list of all blob names in an [Azure Blob Container](https://learn.microsoft.com/en-us/azure/storage/blobs/storage-blobs-introduction#containers).


<!--![topic](https://profitbasedocs.blob.core.windows.net/flowimages/topic-trigger.png)-->



## Properties


| Name           | Type     | Description                                      |
|----------------|----------|--------------------------------------------------|
| Title          |          |                                                  |
| Connection     | Required | Connection name and string.                      |
| Polling frequency| Optional | Schedule configuration of the trigger.         |
| Blob name prefix filter | Optional | Prefix filter for blob names.           |
| Disabled       | Optional | Boolean value indicating whether the trigger is disabled (true/false).|
| Blob name      | Optional |                                                  |
| Description    | Optional | Additional notes or comments about the trigger's purpose or configuration.  |

