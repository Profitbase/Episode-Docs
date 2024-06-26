# Foreach Amazon S3 object name

Iterates over a list of all Amazon S3 object names in an Amazon Bucket. 

![img](../../../../images/flow/foreach-blob-name.png)

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Connection       | Required  | A SAS Uri to an Amazon S3 bucket.      |
| Amazon S3 object name prexix | Required  | The name of the object to filter. **Note!** The prefix is case sensitive. |
| Amazon S3 object name | Required | The name of the Flow variable that contains the current S3 object name in the list. |