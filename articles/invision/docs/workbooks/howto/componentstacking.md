
# How To Stack Components

This topic covers an advanced subject that you normally don't have to think about when developing a UI, but it can be useful in some scenarios if you need to stack components on top of each other (z-index) within the same area of the screen, and conditionally show them.

## How to change Z-Index

#### Set the Z-index on individual components

1. Change Z-Index for every component separately or disable it:

![pic](https://profitbasedocs.blob.core.windows.net/images/HTCompStack%20(1).png)

2. In this example, buttons have higher Z-Index than the table:


![pic](https://profitbasedocs.blob.core.windows.net/images/HTCompStack%20(2).png)

##### Order components by z-index

1. With a Page or Section selected, go to the **Layout Pane** tab in the **Properties** window on the left,

![pic](https://profitbasedocs.blob.core.windows.net/images/HTCompStack%20(3).png)

2. Go to the **Z-Index order** and press Edit.  
Here you will find a list of all components on the page or section.

![pic](https://profitbasedocs.blob.core.windows.net/images/HTCompStack%20(4).png)

3. If you have placed multiple components in the same grid area, dragging them up and down the list will change the z-index ordering and determine which component is displayed topmost.
