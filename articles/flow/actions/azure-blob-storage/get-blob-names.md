# Get Blob names

Gets a list of all blob names in an Azure Blob container.
<br/>

![pic](https://profitbasedocs.blob.core.windows.net/flowimages/azblobname.png)


<br/>

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Connection       | Required  | A SAS Uri connection to an Azure Blob container.       |
| Blob name prefix | Optional  | To filter the list of blobs, specify a string for the [prefix parameter](https://learn.microsoft.com/en-us/azure/storage/blobs/storage-blobs-list#filter-results-with-a-prefix). Note that prefixes are **case sensitive**. |
| Result variable name | Required | The name of the Flow variable that contains the list of the blob names. |


