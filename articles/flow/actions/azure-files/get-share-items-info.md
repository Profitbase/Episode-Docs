# Get Share Items Info

Retrieves a list of information about files or directories from an [Azure Files](https://learn.microsoft.com/en-us/azure/storage/files/storage-files-introduction) share.

![img](../../../../images/flow/Get-share-items-info.png)

**Example** ![img](../../../../images/strz.jpg)  
Example above retrieves all files from a share (Get Share Items Info), checks conditions to filter relevant files ([Foreach](../built-in/foreach.md)), and safely removes matched file ([Delete file](delete-file.md)).


## Properties

| Name                           | Type      | Description |
|--------------------------------|-----------|-------------|
| Connection                     | Required  | The [Azure Files connection](./connecting-to-azure-files.md) to a share. |
| Directory                      | Optional  | The directory to retrieve information from. |
| Prefix                         | Optional  | An optional file name prefix to filter files. |
| Include directories            | Boolean   | Whether to include directories along with files. |
| Include files in subdirectories | Boolean   | Whether to traverse and include items in subfolders. |
| Result variable name           | Required  | The name of the variable containing the collected information. |
