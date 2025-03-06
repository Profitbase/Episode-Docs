# Get Blob names

Gets a list of all blob names in an Azure Blob container. The blob name is the name of the blob object, for example `myfile.txt`.
Use this action if you need a list of all the blob names in a container. If you only need to iterate over the blobs in a container _one by one_, consider using the [For each blob name](foreach-blob-name.md) action instead.

![img](../../../../images/flow/get-blob-names.png)


**Example** ![img](../../../../images/strz.jpg)

A company stores customer invoices as PDFs in an Azure Blob Storage container. This flow retrieves all invoice file names, processes each invoice, and updates a database with relevant details. Used actions: 1. **Get Blob names** 2. [For each Blob name](foreach-blob-name.md) 3. [Function](../built-in/function.md).



## Returns
[List](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<[string](https://learn.microsoft.com/en-us/dotnet/api/system.string)>

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Connection       | Required  | The [Azure Blob container connection](./azure-blob-container-connection.md). The currently supported options are `SAS URI` and `Connection string + container name`.    |
| Dynamic connection | Optional   | A connection dynamically created using the [Create Azure Blob container connection](./create-azure-blob-container-connection.md) action.    |
| Blob name prefix | Optional  | To filter the list of blobs, specify a string for the [prefix parameter](https://learn.microsoft.com/en-us/azure/storage/blobs/storage-blobs-list#filter-results-with-a-prefix). **Note!** The prefix is case sensitive. |
| Result variable name | Required | The name of the Flow variable that contains the list of the blob names. |


