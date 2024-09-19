# Foreach Blob name

Iterates over a list of all blob names in an Azure blob container. The blob name is the name of the blob object, for example `myfile.txt`. 

![img](../../../../images/flow/foreach-blob-name.png)

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Connection       | Required  | The Azure Blob Container Connection. Choose either 1. A [SAS URI](https://learn.microsoft.com/en-us/azure/storage/common/storage-sas-overview) to an Azure Blob container or 2. A Storage account connection string and container name.       |
| Blob name prefix | Optional  | To filter the list of blobs, specify a string for the [prefix parameter](https://learn.microsoft.com/en-us/azure/storage/blobs/storage-blobs-list#filter-results-with-a-prefix).**Note!** The prefix is case sensitive. |
| Blob name | Required | The name of the Flow variable that contains the current blob name in the list. |