---
title: "How To Set Up a File Storage"
metaKeys: "how to, Set Up a File Storage"
folderOnly: "false"
pageIndex: 2
---

### Link to the video

Under [this](https://profitbasedocs.blob.core.windows.net/videos/File%20Storage%20-%20Basics.mp4) link you will find a video that shows how to create amd set upa  [File Storage](../../filestorage.md). 
<br/>

### Step by step


1. Open workbook interactions window, next step is to add a Execute Expression action to create the _state variable:

![pic](https://profitbasedocs.blob.core.windows.net/images/HTfileStorageSet%20(3).png)

2. Now we need to map context for the File Storage:

![pic](https://profitbasedocs.blob.core.windows.net/images/HTfileStorageSet%20(4).png)

3. And set up filter event - OnSelectionChanged first load data:

![pic](https://profitbasedocs.blob.core.windows.net/images/HTfileStorageSet%20(5).png)

4. Second, execute expression to connect the attachment to the filtered movie:

![pic](https://profitbasedocs.blob.core.windows.net/images/HTfileStorageSet%20(6).png)