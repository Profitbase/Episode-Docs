---
title: "How to Check if Dataflow Succeeded using @Event.Data.Success condition"
metaKeys: "Automating Import of Data to Dimension, @Event.Data.Success condition"
folderOnly: "false"
pageIndex: 8
---


### Link to the video

Under [this link](https://profitbasedocs.blob.core.windows.net/videos/DF%20-%20Check%20if%20dataflow%20succeeded%20or%20not.mp4) you will find video that shows how to check if dataflow succeeded or not, using **@Event.Data.Success** condition.
<br/>


### Step by step


1. Create a Data Flow than Data Flow Item:

![pic](https://profitbasedocs.blob.core.windows.net/images/htDFcond%20(1).png)

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/htDFcond%20(2).png)

2. Place the Data Flow in the Workbook:

![pic](https://profitbasedocs.blob.core.windows.net/images/htDFcond%20(3).png)

3. Edit Events of the Data Flow:

![pic](https://profitbasedocs.blob.core.windows.net/images/htDFcond%20(4).png)

4. In the first event use a condition **@Event.Data.Success == true;**

![pic](https://profitbasedocs.blob.core.windows.net/images/htDFcond%20(5).png)

5. In the second event use a condition **@Event.Data.Success == false;**

![pic](https://profitbasedocs.blob.core.windows.net/images/htDFcond%20(6).png)

6. Hide the Execution Log:

![pic](https://profitbasedocs.blob.core.windows.net/images/htDFcond%20(7).png)