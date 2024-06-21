# Append to Amazon S3 object

Appends a byte array to an [Amazon S3 ](https://docs.aws.amazon.com/s3/?nc2=h_ql_doc_s3)object.  

The example below uses the SQL Server [Get DataReader](../sql-server/get-datareader.md), [DataReader chunker](../built-in/datareader-chunker.md), [Create CSV as byte array](../csv/create-csv-as-byte-array.md) and `Append to Amazon S3 object` actions to export a large number of rows from a SQL Server database to Amazon S3 bucket by splitting them into CSV files of 100 000 records each.

![img](../../../../images/flow/appendAmazon.png)

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Connection       | Required  | A ??? [SAS Uri](https://learn.microsoft.com/en-us/azure/storage/common/storage-sas-overview) to an Amazon S3 bucket.       |
| Bucket name        | Required  | The name of the bucket to append to. If the bucket does not already exist, it is created. |
| Bucket data        | Required  | A byte array  |


