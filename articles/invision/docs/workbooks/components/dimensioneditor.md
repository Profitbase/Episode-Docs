# Dimension editor

Dimension editor is a full-screen component to edit dimensions.

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/HTdimEd%20(10).png)

## Build the dimension and edit dimension data 

To build the dimension and edit data, you need to use the Dimension Editor in a Workbook.

<br/>

![Dimension](https://profitbasedocs.blob.core.windows.net/images/DimNy4.png)

<br/>

1.	In the Designer, check the “Primary Dimension” in the toolbar. That will make the dimension appear in the Primary dimensions dropdown in the Workbook Dimension Editor.
2.	Create a new Workbook.
3.	In the Toolbox, choose the Resources tab and drag/drop the **Dimension Editor** onto a page.
4.	Open the Workbook and choose a dimension from the list of available ones.

<br/>

**Adding members to a dimension using the tree editor**

-	To add a new root dimension member, click the “+” button at the top of the dimension tree
-	To add a new member as a child of another member, choose “Add” from the action menu of an existing item (hover the item to make the menu trigger appear).

<br/>

**Adding members to a dimension by importing from clipboard/Excel**

To import multiple members at the same time, click the Import button at the top of the dimension tree. 
This will display a table editor that lets you copy/paste data from Excel (or any other tab-delimited file). 

**Note** that you need to use **Ctrl-V** to paste into the table. You cannot right-click a cell in the table editor.

<br/>

![Dimension](https://profitbasedocs.blob.core.windows.net/images/DimNy5.png)

<br/>

**Organizing dimension members**

To organize dimension members in a hierarchical structure, you can do the following:

-	Drag/drop nodes between levels.
-	Use the action menu which appears when you hover a node to add, delete, cut, paste, and clone members.
-	To move multiple items, hold down the Ctrl key while selecting multiple members. Then use the “Cut” and “Paste” options in the action menu to move the items as children to a different member.
-	To sort children of an item, open the action menu and choose one of the sorting options available. The sorting options are only available on items in the tree which have children.

<br/>

## Dimension Composition


<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/dimChLog3.png)

<br/>

Dimension Composition is a tool to generate a dimension based on the property and property value of members from source dimensions.

You compose a dimension by adding levels and picking members from other dimensions based on their properties. That makes it easy to use different structures for input while still having one uniform reporting structure without having to maintain the same dimension members in multiple dimensions.

<br/>

1. Check out **"Allow Composition"** box in the Options tab, to enable composition for a dimension.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/dimChLog2.png)

<br/>

1. Open the Dimension Composition window in the Dimension Editor and create a new Dimension.

<br/>


![img](https://profitbasedocs.blob.core.windows.net/images/dimChLog.png)


## See Also

* [Dimension](../../dimensions.md)
* [How To use Dimension Editor](../../dimensions/howto/dimeditor.md)
  
<br/>
 
 

## Videos

- [Dimension Editor](https://profitbasedocs.blob.core.windows.net/videos/Dimension%20-%20Dim%20Editor.mp4)
- [Dimension Composition](https://profitbasedocs.blob.core.windows.net/videos/Dimension%20-%20Dimension%20Composition.mp4)
- [Dimension Editor - Enable support for multiple languages](https://profitbasedocs.blob.core.windows.net/videos/Dim%20Translations%20Members.mp4")
- [Dimension Editor - Configure Translation of Dimensions Name](https://profitbasedocs.blob.core.windows.net/videos/Dim%20Translations%20Name.mp4)
- 
<br/>