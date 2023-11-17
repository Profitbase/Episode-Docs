---
title: "Edit dimensions"
metaKeys: ""
folderOnly: "false"
pageIndex: 1
---

**Applies to:** ![img](https://profitbasedocs.blob.core.windows.net/icons/yes-icon.png) Planner 5.2 or later

# Overview

This is the page where dimensions can be browsed, edited and published to versions.

Starting from Planner version 5.2, the concept of centralized dimension management was introduced. The central or default repository for a given dimension is what is called the Primary dimension. Data can be imported to the primary dimension from an external source or edited directly. Once a change is done to the primary dimension, it can be published to one or more versions.<br/>

Each Planner version does however contain it's own copy of the dimensions and the ability to edit the version-local copy. It is best practice to limit version-local editing of a dimension and to manage the primary dimension in stead.<br/>

By default, when opening the Edit dimensions page, the primary dimensions are in context. Select the appropriate dimension from the Select dimension drop down.<br/><br/>

![](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/EditDimension.JPG)

## Adding members to a dimension using the tree editor

To add a new root dimension member, click the “+” button at the top of the dimension tree<br/>
To add a new member as a child of another member, choose “Add” from the action menu of an existing item (hover the item to make the menu trigger appear).<br/>

## Adding members to a dimension by importing from clipboard/Excel

To import multiple members at the same time, click the Import button at the top of the dimension tree. This will display a table editor that lets you copy/paste data from Excel (or any other tab-delimited file).<br/>

Note that you need to use Ctrl-V to paste into the table. You cannot right-click a cell in the table editor.<br/>

## Importing dimension data from an external source

In many cases, dimensional data is imported from an external source such as an ERP system. If this is the case, import jobs will have been configured. Click the Import button, and select Import external data. This will open up a dialogue in which the appropriate import job can be selected (one for each dimension). Select the appropriate job and click execute.

![](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/ExecuteOperation.JPG)

Note that the import jobs must be configured to work in each individual solution for this option to function.

## Organizing dimension members

To organize dimension members in a hierarchical structure, you can do the following:<br/><br/>

Drag/drop nodes between levels.<br/>
Use the action menu which appears when you hover a node to add, delete, cut, paste, and clone members.<br/>
To move multiple items, hold down the Ctrl key while selecting multiple members. Then use the “Cut” and “Paste” options in the action menu to move the items as children to a different member.<br/>
To sort children of an item, open the action menu and choose one of the sorting options available. The sorting options are only available on items in the tree which have children.<br/><br/>

## Edit data in table mode

You can edit properties and dimension member names (including translations) using Table Edit mode. That enables users to quickly edit data for multiple dimension members using data grid functionality like drag-copy of cells and copy/paste. While in Table Edit mode, you cannot edit the tree in any way, and you cannot switch back to the Properties tab until you have saved any changes.<br/>

Note When you are in Table Edit mode, you must remember to save your changes before choosing a different dimension member from the tree, or else all your changes are lost.<br/>


## Preview dimension in different languages

If you want to preview how the dimension looks in different languages, use the “Globe” icon at the top of the dimension tree to switch between different languages you have enabled for the dimension.<br/>

## Publishing a dimension
The changes you make in the Dimension Editor are not fully applied until you have published the changes. That means that you can edit the data and hierarchy, save it, and continue working until you are satisfied with the result. Before applying those changes to the actual data model used by Data Stores, Filters, Tables, etc.<br/>

![](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/PublishDimension.JPG)

When you publish a dimension, it will always be published to the Solution which owns it. Additionally, you can optionally choose to publish the dimension to other Solutions and Work Process Versions as well. When you choose Solutions and/or Work Process Versions to publish to, the dimension will be published to dimensions in the target Solutions and Work Process Versions having the same name as the dimension being published. When publishing to target<br/><br/>
