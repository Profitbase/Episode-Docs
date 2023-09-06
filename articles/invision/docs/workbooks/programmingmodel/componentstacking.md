---
title: "Component Stacking"
metaKeys: "Component Stacking (Z-Index), Selected Pane, Toggle ZIndex Stacking Disabled "
folderOnly: "false"
pageIndex: 1
---

**Component Stacking (Z-Index)**

Using the grid layout system of [Workbooks](../../workbooks.md), you would normally place components in separate, non-overlapping areas of the user interface. There may be times, however, that you want multiple components to occupy the same area and partially overlap each other, or toggle which component is topmost at any given time based on the state of the Workbook.

To do this, you need to change the Component Stacking configuration of the [Page](../pages.md) or Section (left, right, top) that the components are hosted in.

1.	With a Page or Section selected, go to the **Layout Pane** tab in the **Properties** window on the left,

2.	Go to the **Z-Index order**-Edit.  
Here you will find a list of all components on the page or section.

3.	If you have placed multiple components in the same areas, dragging them up and down the list will change which one is displayed topmost and so on. 

4.	If you want to dynamically change the order in which the components are stacked, you need to right-click each of the components and choose "Toggle ZIndex Stacking Disabled". This will make it possible for you to alter the z-index property by applying and removing CSS classes to the components, for example by calling the [AddCssClass(…)](), [RemoveCssClass(…)](), and [ToggleCssClass(…)]() functions in ExecuteExpression actions.


