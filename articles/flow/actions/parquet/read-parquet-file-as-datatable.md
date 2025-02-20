# Read Parquet file as DataTable

Loads the contents of a Parquet file into memory as a [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) object.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/flowimages/parquet-load-to-datatable.png)

<br/>

## Properties

| Name                | Type     | Description                                      |
| ------------------- | -------- | ------------------------------------------------ |
| Title               |          |                                                  |
| File contents       | Required |  The contents of the file, provided as either a stream or a byte array. |
| Column mapping      | Optional | Defines a mapping between columns in the Parquet file, and the output format of the reader. You can also define this option to skip columns from the Parquet file, typically when you don't want to read all the data from the file. |
| Table variable name | Optional | The name of the DataTable variable.              |
| Description         | Optional |  Additional notes or comments about the action or configuration. |

<br/>

### Column mapping:

![img](https://profitbasedocs.blob.core.windows.net/flowimages/column-mapping.png)
