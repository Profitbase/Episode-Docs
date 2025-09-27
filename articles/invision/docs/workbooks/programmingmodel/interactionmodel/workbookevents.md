
# Workbook Events

## Loading
 The `Loading` event is raised when the TOC (Table of Contents) of the Workbook has finished loading, but _before_ pages and components are initially rendered. The TOC describes which component the Workbook contains and their initial configuration (no data). 

 Use this event to load state to the Workbook that is required by the initial rendering or pages and components. To make Workbooks display quickly to the user on initial render, try to keep the amout of work performed in this event as small as possible.  

<br/>

## Loaded
The `Loaded` event runs _after_ all components has rendered once. To make Workbooks display quickly to the user, we recommend loading initial business data in this event instead of the `Loading` event.  

<br/>

## Message Received

 The `Message Received` event is raised when the Workbook receives a message from an external application. The received message can be addressed to the user, the Workbook, or a combination of the two.

<br/>

## Work Process Version Closed  
The `Work Process Version Closed` event is raised when the Work Process version that the Workbook belongs to is closed. You can handle this event if you need to perform custom business logic when a Work Process version closes while the Workbook is open, such as disabling buttons.  

<br/>

> [!NOTE]
> If you want to run action is parallel instead of sequentially, enable the **"Run Actions in Parallel"** checkbox.


## See Also

* The topic about [Sending messages between Workbooks](sendingmsgbetween.md) for details. 
