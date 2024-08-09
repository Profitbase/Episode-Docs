# Read rows from CSV file

Iterates over rows in a CSV file.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/flowimages/readRows.png)

<br/>

## Properties

| Name                | Type      | Description                                      |
| ------------------- | --------- | ------------------------------------------------ |
| Title               |           |                                                  |
| File contents       | Required  | Select the file contents (Stream or byte array). |
| Data start row      | Optional  | Choose the row.                                  |
| Column mapping      | Required  | Configure row object.                            |
| Data import options | Optional  | Skip empty, fail.                                |
| Field parser        | Optional  | Custom field parser.                             |
| Row variable name   | Optional  | The name of the Row variable.                    |
| Row data type       | Read-only |                                                  |
| Description         | Optional  |                                                  |
