# Read Parquet file as DataTable

Loads the contents of a Parquet file into memory as a [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) object.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/flowimages/parquet-load-to-datatable.png)

<br/>

## Properties

| Name                | Type     | Description                                      |
| ------------------- | -------- | ------------------------------------------------ |
| Title               |          |                                                  |
| File contents | Required       |  The contents of the file, provided as either a stream or a byte array. |
| Column mapping      | Required | Defines the mapping between the column names in the Parquet file, and the `column names` (CustomerID, Amount, etc) in the target DataTable. |
| Table variable name | Optional | The name of the DataTable variable.              |
| Description         | Optional |  Additional notes or comments about the action or configuration. |

<br/>

### Column mapping:

![img](https://profitbasedocs.blob.core.windows.net/flowimages/column-mapping.png)
