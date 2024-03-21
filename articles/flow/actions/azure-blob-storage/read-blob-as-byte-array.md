# Read Blob as byte array

Reads the contents of an Azure Blob into memory as a byte array.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/flowimages/readblol.png)

<br/>


## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Connection       | Required  | A SAS Uri connection to an Azure Blob container.       |
| Blob name prefix | Optional  | To filter the list of blobs, specify a string for the [prefix parameter](https://learn.microsoft.com/en-us/azure/storage/blobs/storage-blobs-list#filter-results-with-a-prefix).  
**Note!** Currently, Azure considers the prefix as case sensitive. |
| Result variable name | Required | The name of the Flow variable that contains the list of the blob names. |