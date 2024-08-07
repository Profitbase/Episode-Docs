# Load Parquet file to DataTable

Loads the contents of a Parquet file into memory as a [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) object.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/flowimages/parquet-load-to-datatable.png)

<br/>

## Properties

| Name                | Type     | Description                                      |
| ------------------- | -------- | ------------------------------------------------ |
| Title               |          |                                                  |
| File contents       | Required | Select the file contents (Stream or byte array). |
| Column mapping      | Required | Configure row object.                            |
| Table variable name | Optional | The name of the DataTable variable.              |
| Description         | Optional |                                                  |

<br/>

### Column mapping:

![img](https://profitbasedocs.blob.core.windows.net/flowimages/column-mapping.png)