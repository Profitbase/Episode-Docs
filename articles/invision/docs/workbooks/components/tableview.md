
# Table View

[Table View](../../tableview.md) is used for displaying data in a read-only data grid. Compared to spreadsheet tables ([Worksheet](../../worksheets.md), [Table](../../tables.md), and [SQL Report](../../sqlreports.md)) which are used for editing data, Table View is used for displaying data in a nicely formatted way.

The component has built-in features for selection, sorting, filtering, formatting, and custom renderers.

[How to create a Table View object](tableview.md)

<br/>

![TbV](https://profitbasedocs.blob.core.windows.net/images/TbView1.png)

<br/>


## Actions

<br/>

**Load Data**
>
>Call this action to load or refresh data. 


<br/>


## Events
<br/>

**Cell Action Link Tapped**

>This event is raised when the user clicks a cell in an Action Link column. The @Event payload contains the following data:

<br/>

> [!NOTE]
> The “Data” property contains the fields and values of the clicked row, so it will be different for each Table View instance, depending on how the data source is defined.

```
{
    "Data": {
        "CustomerID": "C1",
        "CustomerName": "Customer 1",
        …        
    },
    "Sender": {
        "ColumnName": "name of the column of the clicked cell",
        "ActionName": "ActionLink"
    },
    "Selection": {
        "Rows": [],
        "Cells": []
    }
}
```

<br/>

**Custom Context Menu Action Executed**

>This event is raised a user clicks a context menu item. The @Event payload contains the following data:

<br/>

> [!NOTE]
> The “Data” property contains the fields and values of the clicked row. The Selection property contains the fields and values of the currently selected rows. These objects will be different for each Table View instance, depending on how the data source is defined.

```
{
    "Data": {
        "CustomerID": "C1",
        "CustomerName": "Customer 1",
        …
    },
    "Sender": {
        "ColumnName": "name of the column of the clicked cell",
        "ActionName": "name of the context menu item action"
    },
    "Selection": {
        "Rows": [
            {
                "RowData": {
                    "CustomerID": "C1",
                    "CustomerName": "Customer 1",
                    …                   
                },
                "Columns": [
                    "CustomerID",
                    "CustomerName",
                    …
                ]
            }
        ],
        "Cells": [
            {
                "RowData": "C1",
                "Column": "CustomerID"
            },
            {
                "RowData": "Customer 1",
                "Column": "CustomerName"
            }, 
        ]
    }
}
```

<br/>

**Custom**

>This event can be raised from custom renderers, for example if you render clickable content in cells. 
>
>The @Event payload contains a Data object which is provided by the renderer. 

<br/>

**Example:** The custom renderer raises a custom event passing an object with a key and value property.

```
function(eventArgs, services){
  …
    btn.onclick = () => services.eventDispatcher.raiseCustomEvent({key: “hello”, value: ”world”});
    …    
}

The @Event payload will contain the following data:

{
    “Data”: {
        “key”: “hello”,
        “value”: “world”
     }
}
```
<br/>

**Selection Changed**
>
>This event is raised when the row selection is changed by the user, for example when a user selects or deselects a row. 
>The @Event payload contains the following data:

<br/>

> [!NOTE]
> The “Data.SelectedItems and Data.ChangedItems” objects contain the fields and values of the clicked selected rows, so it will be different for each Table View instance, depending on how the data source is defined.

```
{
    "Data": {
        "SelectedItems": [
            {
                "CustomerID": "C1",
                "CustomerName": "Customer 1",
                …
        ],
        "ChangedItems": [
          {
                "CustomerID": "C1",
                "CustomerName": "Customer 1",
                …                
            }
        ],
        "Action": "select” | “deselect"
    }
}
```
<br/>

The **Action** specifies whether the user **selected** or **deselected** a row. Valid values are “select” and “deselect”

The **SelectedItems** contains the currently selected items.  
The **ChangedItems** contains the items which were affected by the last change (select or deselect).
<br/>

**Row Clicked**
>
>This event is raised when the user clicks on a row. The @Event payload contains the following data:

<br/>

> [!NOTE]
> The “Data.RowData” property contains the fields and values of the clicked row, so it will be different for each Table View instance, depending on how the data source is defined.

```

{
    "Data": {
        "RowData": {
            "CustomerID": "c3",
            "CustomerName": "Customer 3",
             …            
        }
    }
}

```

<br/>

### Videos

* [Table View](../../../videos/tableview.md)
* [Table View - Basics](https://profitbasedocs.blob.core.windows.net/videos/Table%20View%20-%20Basics.mp4)
* [Table View - Macro Expansion](https://profitbasedocs.blob.core.windows.net/videos/Table%20View%20-%20Macro%20Expansion.mp4)
* [Table View - Custom Cell Renderer](https://profitbasedocs.blob.core.windows.net/videos/Table%20View%20-%20Custom%20Cell%20Renderer.mp4)
* [Table View - Declaring Filter](https://profitbasedocs.blob.core.windows.net/videos/Table%20View%20-%20Declaring%20Filter.mp4)

