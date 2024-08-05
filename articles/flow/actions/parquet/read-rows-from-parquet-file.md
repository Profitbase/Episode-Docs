# Read rows from Parquet file

Iterates over rows in a Parquet file.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/flowimages/parquet-read-rows.png)

<br/>

## Properties

| Name              | Type      | Description                                                                |
| ----------------- | --------- | -------------------------------------------------------------------------- |
| Title             |           |                                                                            |
| File contents     | Required  | Select the file contents (Stream or byte array).                           |
| Column mapping    | Required  | Configure row object.                                                      |
| Row variable name | Optional  | The name of the Row variable.                                              |
| Row data type     | Read-only | The name of the data type used to represent a row, for example 'Customer'. |
| Description       | Optional  |                                                                            |

<br/>

### Column mapping:

![img](https://profitbasedocs.blob.core.windows.net/flowimages/column-mapping.png)
