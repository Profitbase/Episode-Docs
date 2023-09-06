---
title: "File Storage"
metaKeys: "File Storage"
folderOnly: "false"
pageIndex: 5
---



File Storage is a flexible system to let users work with attachments in the [Workbook](../../workbooks.md).

The component has built-in features for uploading, downloading, deletion and selection of files.

Each component can have different context as described in link below.
[How to create a File Storage](../../filestorage/howto/creatingfilestorage.md)

<br/>

![File Storage](https://profitbasedocs.blob.core.windows.net/images/FileStorage_Panel.PNG)

<br/>


### Actions

* **Load Data**

Call this action to load or refresh data.

<br/>

### Events

* **Upload Completed**

This event is raised when a user uploads a file. The @Event payload contains the following data:

```
{
“Data”: {
  “FileReferenceId”: “<reference id>”,
  “StorageName”: “<name of file storage>”
  “FileName”: “<file name>”,
  “MimeType”: “<file’s mime type>”

}
}
```

<br/>

* **File Deleted**

This event is raised when a user deletes a file. The @Event payload contains the same data as described above.


<br/>

### Properties

<br/>

#### Behavior

* **File selection**

The developer can specify whether the user can select one or more files.

* **Single** 

* **Multiple**  

<br/>

* **File click actions**

The developer can specify what happens when a user clicks a file in a File Storage Workbook component. Available options are:

* **Download** – When a user clicks a file, it will be downloaded to the browser.

* **Raise an event** – When a user clicks a file, an event is raise. That enables the developer to perform a custom action when a file is clicked.

* **Open** – When a file is clicked, it will be open in the browser.

* **None** – This enables users to view which files are in the File Storage but not access them.

<br/>

#### See Also

- [File Storage](../../filestorage.md)

<br/>

### Videos

* [File Storage](../../../videos/filestorage.md)
* [File Click Action](https://profitbasedocs.blob.core.windows.net/videos/File%20Storage%20-%20File%20Click%20Actions.mp4)


<br/>