
## How to Automate Import of the Primary Dimension

### Link to the video

Under [this link](https://profitbasedocs.blob.core.windows.net/videos/Dimension%20-%20Import%20Primary%20Dimension.mp4) you will find video that shows how to automate import of the primary dimension. [Here](../../dimensions.md) you will find [Documentation](../../dimensions.md).
<br/>


### Step by step


1. Create the dimension in another Solution (usually a versioned Solution):

![pic](https://profitbasedocs.blob.core.windows.net/images/primDim%20(0).png)

2. Create a Dataflow and Dataflow Item in the target solution. The primary dimension is imported into the target:

![pic](https://profitbasedocs.blob.core.windows.net/images/primDim%20(1).png)

3. Add the Import Primary Dimension task from the Dimension Tasks in the toolbox:

![pic](https://profitbasedocs.blob.core.windows.net/images/primDim%20(2).png)

4. Specify the name of the primary dimension and optionally the name of the target dimension. If no target dimension is specified, it is assumed to equal the name of the primary dimension:

![pic](https://profitbasedocs.blob.core.windows.net/images/primDim%20(3).png)

5. Add the Dataflow Item to the Dataflow:

![pic](https://profitbasedocs.blob.core.windows.net/images/primDim%20(4).png)

6. Run it:

![pic](https://profitbasedocs.blob.core.windows.net/images/primDim%20(6).png)
