# Create directory

Creates a new directory in a [Azure Files](https://learn.microsoft.com/en-us/azure/storage/files/storage-files-introduction) share.

![img](../../../../images/flow/create-directory-flow.png)


**Example**

In this example a company wants to transfer reports from their Azure Blob Storage to Azure File Share. Used actions: 1. Create directoryn2. [Read Blob as byte array](../azure-blob-storage/read-blob-as-byte-array.md) 3. [Upload file to a share](upload-file.md).

| Name                        | Type      | Description |
|-----------------------------|-----------|--------------------------------------------------------|
| Title                       | Required  | The title of the action, displayed as "Create Destination Folder in File Share". |
| Connection                  | Required  | The [Azure Files connection](./connecting-to-azure-files.md) to a Share. |
| Directory                   | Required  | The path of the directory to be created (e.g., "/MyFolder"). |
| Raise exception on failure  | Optional  | Checkbox option to raise an error if the directory creation fails. |
| Description                 | Optional  | Additional details or notes about the action. |
