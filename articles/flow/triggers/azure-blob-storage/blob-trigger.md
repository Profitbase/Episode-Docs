# Azure Blob Trigger

Configures the Flow to automatically run by periodically fetching a list of all blob names in an [Azure Blob Container](https://learn.microsoft.com/en-us/azure/storage/blobs/storage-blobs-introduction#containers).  
This trigger is useful for automating processes that depend on new or updated files being available in a specific container.

<br/>

## When to use this trigger vs. the Incremental Blob trigger

- Use **Azure Blob Trigger** when:
  - You need to regularly **list all blobs** in a container or within a specific prefix.
  - You want to process **every file**, regardless of when it was added or modified.
  - You’re running scheduled jobs that depend on scanning a whole folder/container.
  - You need a simple way to fetch files by prefix without tracking changes.

- Use **Incremental Blob Trigger** when:
  - You only want to process **new or modified** files since the last run.
  - You’re working with large containers where scanning all blobs each time is inefficient.
  - You want to **limit batch size** (using *Number of blobs*) to control throughput.
  - Your workflow depends specifically on reacting to updates or new uploads.
  
<br/>

![img](/images/flow/blob-trigger.png)

**Example**![img](../../../../images/strz.jpg)  
This Flow monitors for updated files in Azure Blob Storage. [If](../../actions/built-in/if.md) the blob name matches UC003_Products, the file is [read](../../actions/azure-blob-storage/read-blob-as-byte-array.md) and its content is loaded into a [DataTable](../../actions/sql-server/load-to-datatable.md).

<br/>

![img](/images/flow/blob-trigger2.png)

<br/>

## Properties

| Name                   | Type     | Description |
|------------------------|----------|-------------|
| Title              | Optional | A custom label for this trigger. This name will appear when selecting the trigger in a Flow. |
| Connection         | Required | An [Azure Blob container connection](../../actions/azure-blob-storage/azure-blob-container-connection.md). |
| Polling frequency  | Optional | Defines how often the container should be checked for blobs (e.g., every 5 minutes, hourly). |
| Blob name prefix filter | Optional | Limits the trigger to only run for blobs with names starting with the specified prefix. |
| Blob name          | Optional | A specific blob name to listen for. If set, the trigger will only run when this blob is present. |
| Disabled           | Optional | Boolean value indicating whether the trigger is disabled (`true`/`false`). |
| Description        | Optional | Notes or comments about the trigger’s purpose or configuration. |

<br/>

## Returns

This trigger returns a list of blob names that can be iterated over using a For Each action. 
<br/>

## Example

Suppose you want to run a Flow every time new invoice files are uploaded to the `invoices` container.  
You can configure the trigger as follows:

- **Title:** `Invoices trigger`  
- **Connection:** Connection to your Azure Blob container  
- **Polling frequency:** Every 60 minutes  
- **Blob name prefix filter:** `invoices/`  

Whenever a new blob with a name starting with `invoices/` is found, the Flow will automatically start, enabling you to process the file contents (e.g., extract data and save it to a Profitbase Data Store).
