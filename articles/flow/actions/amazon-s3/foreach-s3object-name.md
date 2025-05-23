# For each S3 object name

Iterates over a list of all Amazon S3 object names in the Amazon Bucket.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/foreach-amaz.png)

**Example** ![img](../../../../images/strz.jpg)  
This flow validate that the number of products is exactly 17 before proceeding with processing individual product names. If the count is incorrect, it stops and logs an error. Otherwise, it continues processing the object names in a loop.

## Properties

| Name                      | Type     | Description                                                                                 |
| ------------------------- | -------- | ------------------------------------------------------------------------------------------- |
| Title       | Optional |  The title of the action.   |
| Connection                | Required | Specify the [connection](connecting-to-amazon-s3.md) to the Amazon S3 bucket. |
| Object name prefix filter | Optional | Prefix filter for object names. **Note!** The prefix is case sensitive.                     |
| Object name               | Required | The name of the object to read from.                                                        |
| Description               | Optional | Additional notes or comments about the action or configuration. |
