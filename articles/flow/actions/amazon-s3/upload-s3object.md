# Upload Amazon S3 object

Uploads a byte array or [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream) to an Amazon S3 bucket.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/uppload-s3obj.png)

**Example**

This setup ensures that data is either appended to an existing file or a new file is uploaded. If the flow is connected to an external data pipeline or storage system, it should work efficiently.


<br/>

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Title            |   |      |
| Connection       | Required  | Access key id, access key secret, bucket name and region connecting to an Amazon S3 bucket.       |
| Object name        | Required  | The name of the object (file)  |
| Object data        | Required  | The data to upload. It must be a byte array or [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream) |
| Overwrite if object already exists | Optional | If not checked, the action will fail if a object with the same name already exists. |
| Description | Optional | Additional notes or comments about the action or configuration. |

