# Foreach Amazon S3 object name

Iterates over a list of all Amazon S3 object names in the Amazon Bucket. 

![img](https://profitbasedocs.blob.core.windows.net/flowimages/foreach-amaz.png)

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Title            | Required  |      |
| Connection       | Required  | Access key id, access key secret, bucket name and region connecting to an Amazon S3 bucket.        |
| Object name prefix filter       | Optional  | Prefix filter for object names. **Note!** The prefix is case sensitive.  |
| Object name        | Required  | The name of the object to read from. |
| Description | Optional | |