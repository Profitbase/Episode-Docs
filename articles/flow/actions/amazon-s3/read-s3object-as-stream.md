# Read S3 object as stream

Reads the contents of an Azure Blob as a [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream). Prefer using streaming over [Read Blob as byte array] if possible. Streaming is generally faster and uses less memory, because streaming doesn't require loading the entire blob into memory before you can start working with the data.

Once you have the blob contents, you must _load_ it using a compatible action in order to make use of the data.

For example, a CSV file can be loaded using the [Open CSV file as DataReader](../csv/open-csv-file-as-datareader.md), [Read CSV file as DataTable](../csv/read-csv-file-as-datatable.md), or [Read rows from CSV file](../csv/read-rows-from-csv-file.md) actions. Once loaded, you can start working with the data in the CSV file.

> [!CAUTION]
> Trying to load a Stream using an incompatible action will fail.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/read-as-stream-amaz.png)

## Returns

[Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream)

## Properties

| Name                 | Type     | Description                                                                                 |
| -------------------- | -------- | ------------------------------------------------------------------------------------------- |
| Title                | |                                                                                             |
| Connection           | Required | Access key id, access key secret, bucket name and region connecting to an Amazon S3 bucket. |
| Object name          | Required | The name of the object to read from.                                                        |
| Result variable name | Required | The name of the Flow variable that contains the list of the object names.                   |
| Description          | Optional |  Additional notes or comments about the action or configuration. |
