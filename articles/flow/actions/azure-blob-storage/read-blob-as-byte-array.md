# Read Blob as byte array

Reads the contents of an Azure Blob into memory as a byte array. You can compare this to downloading a file.  Prefer using [streaming](read-blob-as-stream.md) over reading as byte array if possible. Streaming is generally faster and uses less memory, because streaming doesn't require loading the entire blob into memory before you can start working with the data.

Once you have the blob contents, you must _load_ it using a compatible action in order to make use of the data.  
  
For example, an Excel file can be loaded using the [Get DataReader](../excel/get-datareader.md), [Load to DataTable](../excel/load-to-datatable.md), or [Read rows](../excel/read-rows.md) actions. Once loaded, you can start working with the data in the Excel file.

> [!CAUTION]
> Trying to load a byte array using an incompatible action will fail.

![img](../../../../images/flow/read-blob-as-byte-array.PNG)

## Returns

[Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte) [array](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays)

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Connection       | Required  | A [SAS Uri](https://learn.microsoft.com/en-us/azure/storage/common/storage-sas-overview) to an Azure Blob container.       |
| Blob name prefix | Optional  | To filter the list of blobs, specify a string for the [prefix parameter](https://learn.microsoft.com/en-us/azure/storage/blobs/storage-blobs-list#filter-results-with-a-prefix). **Note!** The prefix is case sensitive. |
| Result variable name | Required | The name of the Flow variable that contains the list of the blob names. |