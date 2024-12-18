# Read file from share as stream

Reads the contents of a file in an [Azure Files](https://azure.microsoft.com/en-us/products/storage/files) share as a stream.

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Connection       | Required  | The [Azure Files connection](./connecting-to-azure-files.md) to a Share. |
| File name        | Required  | The name and full path to the file to download. |