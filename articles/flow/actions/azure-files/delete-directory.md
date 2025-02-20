# Delete directory

Deletes a directory from an [Azure Files](https://learn.microsoft.com/en-us/azure/storage/files/storage-files-introduction) share.


![img](../../../../images/flow/delete-directory-in-file.png)

**Example** ![img](../../../../images/strz.jpg)

The example above demonstrates a file processing and cleanup operation. This flow retrieves a file from shared storage, converts its content to a JSON string, and then cleans up by deleting the associated directory.  Used actions: 1. [Read file from share as stream](read-file-as-stream.md) 2. [Read JSON file as string](../json/read-json.md) 3. Delete directory.

</br>

## Properties

| Name                     | Type      | Description                                                 |
|--------------------------|-----------|-------------------------------------------------------------|
| Title                    | Optional  | The name of the action.                                      |
| Connection               | Required  |  The [Azure Files connection](./connecting-to-azure-files.md) to a Share.   |
| Directory                | Required  | The path to the directory to delete (e.g., /MyFolder).            |
| Delete all content       | Optional  | If checked, deletes all content within the directory.        |
| Raise exception on failure | Optional  | If checked, triggers an exception if the deletion fails.     |
| Description              | Optional  | Additional information about the action.                     |
