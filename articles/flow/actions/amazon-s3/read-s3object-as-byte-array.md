# Read Amazon S3 object as byte array

Reads the contents of an Amazon S3 object into memory as a byte array. You can compare this to downloading a file.  Prefer using [streaming] over reading as byte array if possible. Streaming is generally faster and uses less memory, because streaming doesn't require loading the entire object into memory before you can start working with the data.

Once you have the object contents, you must _load_ it using a compatible action in order to make use of the data.  
  
For example, an Excel file can be loaded using the [Get DataReader](../excel/get-datareader.md), [Load to DataTable](../excel/load-to-datatable.md), or [Read rows](../excel/read-rows.md) actions. Once loaded, you can start working with the data in the Excel file.

> [!CAUTION]
> Trying to load a byte array using an incompatible action will fail.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/read-as-byte.png)

## Returns

[Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte) [array](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays)

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Title            | Required  |      |
| Connection       | Required  | A SAS Uri to an Amazon S3 object.        |
| Object name        | Required  | The name of the object to read from. |
| Result variable name | Required | The name of the Flow variable that contains the list of the object names. |
| Description | Optional | |