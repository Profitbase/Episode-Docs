# Append to Amazon S3 object

Appends a byte array to an [Amazon S3 ](https://docs.aws.amazon.com/s3/?nc2=h_ql_doc_s3)object.  


![img](../../../../images/flow/appendAmazon.png)

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Connection       | Required  | A SAS Uri to an Amazon S3 bucket.       |
| Bucket name        | Required  | The name of the bucket to append to. If the bucket does not already exist, it is created. |
| Bucket data        | Required  | A byte array  |


