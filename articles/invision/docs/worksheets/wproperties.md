# Worksheet Properties"
metaKeys: "Worksheet Properties. Add Row Settings, Hide Grid Lines, Is Row Selector Visible, Is Row Locking Enabled, Is Summary Row Enabled, Allow Sorting, Inline Filtering, Allowed Input Level, Context Menu Options"
folderOnly: "false"
pageIndex: 13
---


**Add Row Settings**  
>Use this option to specify which filters must be set in order for new rows to be added to the Worksheet. 

<br/>

**Hide Grid Lines**  
>Specifies whether to show cell borders in the grid or not.

<br/>

**Is Row Selector Visible**  
>Specifies whether the header / selector is visible or not.

<br/>

**Is Row Locking Enabled**  
>Specifies whether the user can toggle row locking on and off from the context menu.

<br/>

**Is Summary Row Enabled**  
>Specifies whether the summary row for the grid is enabled for end users.

<br/>

**Allow Sorting**  
>Specifies whether to allow users to sort the contents of the grid by clicking the column headers.

<br/>

**Inline Filtering**  
>Specifies which (if any) custom filtering options to provide to end users in the grid.

<br/>

**Allowed Input Level**  
>Use this option to specify the level at which the selected filter values must exist in order to enable editing of the Worksheet.

<br/>

**Context Menu Options** 
 
* **Select All**
 
     Selects all rows and columns in the grid.

* **Export to Excel**

     Exports the entire contents of the grid to Excel.
 
* **Copy**

     Copies the selected cells to the application clipboard. To copy to the OS clipboard, use Ctrl+C.

* **Paste**

     Pastes the contents of the application clipboard into the grid. To paste from the OS clipboard, use Ctrl+V.

* **Insert row**

     Inserts a row above the right clicked row.

* **Insert row below**

     Inserts a row below the right clicked row.

* **Distribute value**

     Distributes a value to the selected cells, using the specified distribution method.

* **Factor multiplication**

     Multiplies the selected cells by a factor.

* **Reverse distribute evenly**

     Distributes the value of a cell evenly to the factors of its sum formula.

     For example, given the following formula ``@Total[] = @P01[] + @P02[]``, if you edit a cell in the Total column and do a reverse distribution, it will distribute the value evenly to P01 and P02.

* **Reverse distribute relatively**

     Distributes the value of a cell relatively to the factors of its sum formula.

* **Edit or view comments**

     Opens the comments dialog for the cell. This option is only available if comments are enabled for the underlying storage column.

* **View changes**

     Opens the dialog that displays the changes made to a cell. This option is only available if Change Tracking is enbled for the underlying storage and storage column.

<br/>

#### See Also


* [Context Menu Options Conditions](wproperties/contextmenuoptions.md)
* [Custom Action Conditions](columnproperties/customactionconditions.md)

<br/>
