_**#Premium feature**_ 

The primary use case for the **Hide empty rows** feature is when you add custom subtotal rows before or after rows that may be empty in the Power BI data model for different filter contexts. For example, ```Account X``` may be empty for ```Department A```, but not for ```Department B```. You usually don't want to show empty rows, so the default setting for the "Show items with no data" option for a field in the Rows bucket is "false". If you add a custom subtotal row relative to a row that is filtered out, the custom subtotal row will disappear because its anchor row does not exist in the data set coming from Power BI.  

To work around this issue, you can turn on "Show items with no data" for the field(s) in the Rows bucket so they are loaded from the data model, and then enable the **Hide empty rows** feature in the visual. This will hide the rows from the data model that is empty, but custom subtotal rows added relative to them will still appear.

![hide empty rows](https://profitbasedocs.blob.core.windows.net/pbireportingmatrix/Hide_empty_rows.PNG)

#### Always show custom rows  
Toggle this option off to hide custom rows that are empty.

#### Always show JSON rows  
Toggle this option off to hide rows defined using the JSON row format that are empty. The JSON row format is usually used for specifying a fixed report format, so that for example a P&L always contains a fixed set of items regardless of whether they are empty or not.  

#### Condition  
Use this field to specify a custom condition for hiding empty rows. 
For example, the following condition will hide an empty row if its row header is "Sales".  
```
RowHeader() == "Sales"
```  
 
Another example is if you always want empty rows to be visible on the root level, but hide them on any sub levels. You can use the RowLevel() function for this purpose.  
```
RowLevel() >= 1
```

You can also combine multiple condition using the logical operands &&, ||.
The following condition will hide empty rows if the row header equals "Sales" and the row is at level 1 or greater. (Row levels are 0-indexed, so rows at the root level are at level 0)
```
RowHeader() == "Sales" && RowLevel() >= 1
```