# Create Parquet as a stream

Creates a Parquet file from a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) or [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) and returns the result as a [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream).

**Example**

Using data table as Source:

![img](https://profitbasedocs.blob.core.windows.net/flowimages/parquet-as-stream1.png)

<br/>

## Returns

[Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream)

<br/>

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Title       | Required |        |
| Source | Required  | Select from a [DataReader](https://learn.microsoft.com/en-us/dotnet/api/system.data.idatareader) or [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable). |
| Result variable name | Required |  |
| Description | Optional | |

<br/>

![img](https://profitbasedocs.blob.core.windows.net/flowimages/parquet-as-stream2.png)