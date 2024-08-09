# Get S3 object names

Gets a list of all object names in the Bucket container where, the S3 object is for example `myfile.txt`.

Use this action if you need a list of all the object names in a Bucket. If you only need to iterate over the objects in a bucket _one by one_, consider using the [Foreach S3 object name](foreach-s3object-name.md) action instead.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/bucket3.png)

## Properties

| Name                      | Type     | Description                                                                                 |
| ------------------------- | -------- | ------------------------------------------------------------------------------------------- |
| Title                     | |                                                                                             |
| Connection                | Required | Access key id, access key secret, bucket name and region connecting to an Amazon S3 bucket. |
| Object name prefix filter | Optional | Prefix filter for object names. **Note!** The prefix is case sensitive.                     |
| Result variable name      | Required | The name of the Flow variable that contains the list of the objects names.                  |
| Description               | Optional |                                                                                             |

<br/>

![img](https://profitbasedocs.blob.core.windows.net/flowimages/bucket2.png)

<br/>

Object name prefix filter:

![img](https://profitbasedocs.blob.core.windows.net/flowimages/bucket4.png)
