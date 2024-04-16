# Read Blob as stream

Reads the contents of an Azure Blob as a [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream). Prefer using streaming over [Read Blob as byte array](read-blob-as-byte-array.md) if possible. Streaming is generally faster and uses less memory, because streaming doesn't require loading the entire blob into memory before you can start working with the data.
 
Once you have the blob contents, you must _load_ it using a compatible action in order to make use of the data.  
  
For example, a CSV file can be loaded using the [Get DataReader](../csv/get-datareader.md), [Load to DataTable](../csv/load-to-datatable.md), or [Read rows](../csv/read-rows.md) actions. Once loaded, you can start working with the data in the Excel file.

> [!CAUTION]
> Trying to load a Stream using an incompatible action will fail.

![img](../../../../images/flow/read-blob-as-stream.png)

## Returns

[Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream)

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Connection       | Required  | A [SAS Uri](https://learn.microsoft.com/en-us/azure/storage/common/storage-sas-overview) to an Azure Blob container.       |
| Blob name prefix | Optional  | To filter the list of blobs, specify a string for the [prefix parameter](https://learn.microsoft.com/en-us/azure/storage/blobs/storage-blobs-list#filter-results-with-a-prefix). **Note!** The prefix is case sensitive. |
| Result variable name | Required | The name of the Flow variable that contains the list of the blob names. |