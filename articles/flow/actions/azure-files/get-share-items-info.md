# Get share items info

Gets a list of information about files or directories from an [Azure Files](https://azure.microsoft.com/en-us/products/storage/files) share.


## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Connection       | Required  | The [Azure Files connection](./connecting-to-azure-files.md) to a Share. |
| Directory | Optional | The directory to get information from. |
| Prefix    | Optional |   A optional file name prefix  to filter files with |
| Include directories |  | Check to include directories in addition to files. |
| Include files in sub directories | | If to traverse and includ items in sub folders. |
| Result variable name | Required | Name of the variable containing the information collected. | 
