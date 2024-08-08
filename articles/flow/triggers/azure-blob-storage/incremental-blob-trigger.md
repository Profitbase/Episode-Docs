# Incremental Blob trigger

Configures the flow to automatically run by periodically checking for new or modified blobs in an [Azure Blob Container](https://learn.microsoft.com/en-us/azure/storage/blobs/storage-blobs-introduction#containers).


<!--![topic](https://profitbasedocs.blob.core.windows.net/flowimages/topic-trigger.png)-->


## Properties


| Name           | Type     | Description                                      |
|----------------|----------|--------------------------------------------------|
| Title          |          |                                                  |
| Connection     | Required | Connection name and string.                      |
| Polling frequency| Optional | Schedule configuration of the trigger.         |
| Number of blobs | Optional |                                                 |
| Disabled       | Optional |                                                  |
| Blob name      | Optional |                                                  |
| Description    | Optional |                                                  |

