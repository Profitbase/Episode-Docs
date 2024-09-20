# Create Parquet file as stream

Creates a Parquet file from a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) or [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) and returns the result as a [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream).

**Example**

Using data table as Source:

![img](https://profitbasedocs.blob.core.windows.net/flowimages/parquet-as-stream1.png)

<br/>

## Returns

[Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream)

<br/>

## Properties

| Name                 | Type     | Description                                                                             |
| -------------------- | -------- | ------------------- |
| Title                |          |                                                           |
| Source               | Required | Specifies the source of the data, which can either be a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) or [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable). |
| Result variable name | Required | The name of the variable you can use to reference the Stream in other actions.                                               |
| Description  | Optional |   Additional notes or comments about the action or configuration.  |

<br/>

![img](https://profitbasedocs.blob.core.windows.net/flowimages/parquet-as-stream2.png)
