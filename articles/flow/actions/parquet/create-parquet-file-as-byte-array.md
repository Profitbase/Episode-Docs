# Create Parquet file as a byte array

Creates a Parquet file from a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) or [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) and returns the result as a byte array.

<br/>

**Example**

Return value used:

![img](https://profitbasedocs.blob.core.windows.net/flowimages/parquet-as-byte-array1.png)

<br/>

## Returns

Returns the Excel file serialized as a [byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte) [array](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays)

<br/>

## Properties

| Name                 | Type     | Description                                                                                                                                                                          |
| -------------------- | -------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| Title                |          |                                                                                                                                                                                      |
| Source               | Required | Specifies the source of the data, which can either be a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) or [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable). |
| Result variable name | Optional | The name of the variable you can use to reference the byte array in other actions.  |
| Description          | Optional |  Additional notes or comments about the action or configuration. |

<br/>

![img](https://profitbasedocs.blob.core.windows.net/flowimages/parquet-as-byte-array2.png)
