# Delete S3 object

Deletes a S3 object from a bucket.

![img](../../../../images/flow/delete-amazonS3obj.png)

**Example** ![img](../../../../images/strz.jpg)  
This flow scans a list of object names and checks for files that include “2015” in their names. If such files are found, they are deleted.

## Properties

| Name        | Type     | Description                                                                                 |
| ----------- | -------- | ------------------------------------------------------------------------------------------- |
| Title       | Optional |  The title of the action.   |
| Connection  | Required | Specify the [connection](connecting-to-amazon-s3.md) to the Amazon S3 bucket. |
| Object name | Required | The name of the object to delete.                                                           |
| Description | Optional |  Additional notes or comments about the action or configuration. |
