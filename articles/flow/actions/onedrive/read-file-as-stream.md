# Read file as stream

Reads the contents of a file in OneDrive as a stream.

## Properties

| Name                  | Type      | Description        |
|-----------------------|-----------|--------------------|
| Connection            | Required  | The connection to the OneDrive account. |
| File                  | Required  | The path to the file, such as the `Path` property of a [OneDriveItem](./api-reference/onedrive-item.md).  |
| Result variable name  | Required  | The name of the variable containing the file stream. |

## Returns

A [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream) that provides access to the contents of the file. Use the stream as input to other actions, such as the [Get datareader](../excel/get-datareader.md) if you are fetcing an Excel-file from OneDrive.
