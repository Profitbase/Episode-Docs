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
| Disabled       | Optional |                                                  |
| Blob name      | Optional |                                                  |
| Description    | Optional |                                                  |

