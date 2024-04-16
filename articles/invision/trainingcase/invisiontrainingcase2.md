
# Solution Training Case

 
## Hello learner!

In this section, we will create together a solution. Under [this](https://profitbasedocs.blob.core.windows.net/videos/MovieMania.mp4) link you will find video that shows that process step by step.
In every part of that case you will also find [Documentation](../docs/index.md).

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/MovieManiaC.png)

<br/>

## Overview

This document is a guide to build a small Profitbase Solution. The idea is that the user should get a basic understanding of how to build a planning solution and the most common features of Profitbase LOW CODE.

Using this simple example, we want to show you how the Invision LOW CODE can be easy and fun. The goal of this guide is to build a small solution for a movie collection with ranks and short descriptions using many useful components.
<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/solutionTrainingCase.png)

<br/>

## 1. Creating and setting up the Workbook

> In this section you will find instruction on how to create solution, [Structure Folders](../docs/bestpractice/structuringsolution.md), and setup [Access Control](../docs/accesscontrol/index.md).  
> See also [Interface Introduction Video](https://profitbasedocs.blob.core.windows.net/videos/Getting%20Started%20-%20Interface%20Introduction.mp4), [Access Control Videos](../videos/accesscontrol.md).


1. Create new solution:
   
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(1).png)

<br/>

2. Create [folder](../docs/bestpractice/structuringsolution.md) and [Workbook](../docs/workbooks.md):
   
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(2).png)

<br/>

3. Add page and set up the selected properties:

![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(3).png)

<br/>

4. Add your [Access Group](../docs/accesscontrol/accessgroups.md) in [Workbook Permissions](../docs/accesscontrol/howto/wbacess.md):

![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(4).png)

<br/>

5. Remember to publish your changes:

![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(5).png)

<br/>

## 2. Themes and styling

<br/>

> In this section you will find instruction on how to change logo and edit System Theme Variables, without using css styles. [Here](../videos/themesandstyles.md) you will find more about [Themes and styling](../docs/workbooks/themesandstyles.md). 

<br/>

1. Open Assets tab and drop your logo to the Image Library.
   
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(6).png)

<br/>

2. Open Themes and Styles tab, create new theme, click edit theme images, and find your logo in the dropdown list.
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(7).png)

<br/>

3. Choose your theme for the workbook.
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(8).png)

<br/>

4. You can overwrite System Theme Variables in the Main Theme section. Here you will also find sections for [Accesibility](../docs/accessibility/accessibility.md) and Style Sheets. 
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(9).png)
<br/>

## 3. Dimension

<br/>

> In this section you will find instruction on how to create a [Dimension](../docs/dimensions.md).  
> See also [Dimension Videos](../videos/dimensions.md) and [step by step documentation](../docs/dimensions/howto.md).

<br/>

1. Right-click on the folder and add a new item.
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(10).png)

<br/>

2. Add columns in the Schema tab.
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(11).png)

<br/>

3. Add or automap Attributes.
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(12).png)

<br/>

4. Create a Hierarchy and add Attributes to it. 
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(13).png)

<br/>

5. Add data and Publish.
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(14).png)

<br/>

## 4. Filter

<br/>

> In this section you will find instruction on how to create a [Filter](../docs/filters/index.md).  
> See also [Filter Videos](../videos/filters.md), and [step by step documentation](../docs/filters/howto.md).

<br/>

1. Right-click on the folder and add a new item.
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(15).png)

<br/>

2. Find a Dimension in the table resources and drag and drop it into the filter container.
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(16).png)

<br/>

3. Find the filter in the resources and place it in the workbook.
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(17).png)

<br/>

4. Set up the Loading event for the Workbook or Page.
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(18).png)

<br/>

## 5. Table View

<br/>

> In this section you will find instruction on how to create and customize a [Table View](../docs/tableview.md).  
> See also [Table View Videos](../videos/tableview.md) and [step by step documentation](../docs/tableview/howto.md).
<br/>

1. Right-click on the folder and add a new item.
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(19).png)

<br/>

2. Find the table view in the resources and place it in the workbook.
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(20).png)

<br/>

3. Set up the Loading event for the Workbook or Page.
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(21).png)

<br/>

4. Write a query in the data sourde declaring filter in the first line.
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(22).png)

<br/>

5. Bind the filter in the table view properties.
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(23).png)

<br/>

6. Set up the OnSelectionChanged event for the filter.
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(24).png)

<br/>

7. Add columns in the data grid tab for the table view.
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(25).png)

<br/>

1. Set up properties.
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(26).png)

<br/>

## 6. Custom Cell Renderer

<br/>

> In this section you will find instruction on how to customize cells using [Custom Cell Renderer](../docs/worksheets/howto/customcellrenderer.md).
> See also [Custom Cell Renderer Video](https://profitbasedocs.blob.core.windows.net/videos/Table%20View%20-%20Custom%20Cell%20Renderer.mp4) and [step by step documentation](../docs/tableview/howto/tableview-custom-cell.md).
<br/>


1. Find column that you want to customize, open renderer window and write your code.
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(27).png)

<br/>

2. To help you we created also some samples that you can use.
  
![pic](https://profitbasedocs.blob.core.windows.net/images/MovMania%20(28).png)



<br/>

## 7. Table 

<br/>

> In this section you will find instruction on how to create a [Table](../docs/tables.md).  
> See also [Table Videos](../videos/tables.md) and [step by step documentation](../docs/tables/howto.md).
<br/>

1. Right-click the selected folder in the Solution Explorer to add a new item, choose a Table:

![pic](https://profitbasedocs.blob.core.windows.net/images/MovManiaTab%20(1).png)

2. Add columns by drag and drop or using "Add column" option:

![pic](https://profitbasedocs.blob.core.windows.net/images/HTtb%20(2).png)

3. Choose the data type:

![pic](https://profitbasedocs.blob.core.windows.net/images/MovManiaTab%20(2).png)

4. Add the data:

![pic](https://profitbasedocs.blob.core.windows.net/images/MovManiaTab%20(3).png)

<br/>


## 8. Form Schema 

<br/>

> In this section you will find instruction on how to create a [Form Schema](../docs/forms.md).  
> See also [Form Schema Videos](../videos/formschemas.md) and [step by step documentation](../docs/forms/formschemas/howto.md).
> 
<br/>

1. Right-click the selected folder in the Solution Explorer to add a new item, choose a Form Schema:

![pic](https://profitbasedocs.blob.core.windows.net/images/MoviemaniaFS%20(1).png)

2. Create the Grid:

![pic](https://profitbasedocs.blob.core.windows.net/images/MoviemaniaFS%20(2).png)

3. Create a Model and bind it, remember to use the filter property:

![pic](https://profitbasedocs.blob.core.windows.net/images/MoviemaniaFS%20(3).png)

4. Style Form Schema with CSS:

![pic](https://profitbasedocs.blob.core.windows.net/images/MoviemaniaFS%20(4).png)

5. Add Form Schema to the Workbook:

![pic](https://profitbasedocs.blob.core.windows.net/images/MoviemaniaFS%20(5).png)

6. Check "is Action Link Column" box in properties of the Table View column:

![pic](https://profitbasedocs.blob.core.windows.net/images/MoviemaniaFS%20(6).png)

7. Add OnTapped event in the in the Table View:

![pic](https://profitbasedocs.blob.core.windows.net/images/MoviemaniaFS%20(7).png)

8. Add Load action and [SetParamValue](../docs/workbooks/programmingmodel/instructions/setparamvalue.md) to conect the data:

![pic](https://profitbasedocs.blob.core.windows.net/images/MoviemaniaFS%20(8).png)