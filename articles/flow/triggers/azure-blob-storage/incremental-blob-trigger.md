# Incremental Blob trigger

Configures the flow to automatically run by periodically checking for new or modified blobs in an [Azure Blob Container](https://learn.microsoft.com/en-us/azure/storage/blobs/storage-blobs-introduction#containers).


<!--![topic](https://profitbasedocs.blob.core.windows.net/flowimages/topic-trigger.png)-->


## Properties


| Name           | Type     | Description                                      |
|----------------|----------|--------------------------------------------------|
| Title          |          |                                                  |
| Connection     | Required | [Azure Blob container connection](../../actions/azure-blob-storage/azure-blob-container-connection.md)               |
| Polling frequency| Optional | Schedule configuration of the trigger.         |
| Number of blobs | Optional |                                                 |
| Disabled       | Optional | Boolean value indicating whether the trigger is disabled (true/false).|
| Blob name      | Optional |                                                  |
| Description    | Optional |  Additional notes or comments about the trigger's purpose or configuration.  |

