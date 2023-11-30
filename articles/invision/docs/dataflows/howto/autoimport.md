
# How to Automate Import of Data to Dimension

## Link to the video

Under [this link](https://profitbasedocs.blob.core.windows.net/videos/Automating%20Import%20of%20Data%20to%20Dimension.mp4) you will find video that shows how to automate import of data to dimension. [Here](../../dimensions.md) you will find [Documentation](../../dimensions.md).
<br/>


## Step by step


1. Create a table containing the columns you want to import into the dimension. The columns in the staging table must match the dimension table columns by name and data type:

![pic](https://profitbasedocs.blob.core.windows.net/images/htDIMautData%20(1).png)

1. Create a Dataflow Item and add the Import dimension members task from the Dimension Tasks in the toolbox:

![pic](https://profitbasedocs.blob.core.windows.net/images/htDIMautData%20(2).png)

3. Specify the name of the staging table and the name of the dimension:

![pic](https://profitbasedocs.blob.core.windows.net/images/htDIMautData%20(3).png)

4. Create a Dataflow and run the Dataflow Item:

![pic](https://profitbasedocs.blob.core.windows.net/images/htDIMautData%20(4).png)
