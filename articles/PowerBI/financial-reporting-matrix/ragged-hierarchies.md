_**#Premium feature**_  

A ragged hierarchy is hierarchy with an uneven number of levels. This however, needs to be faked in Power BI, where tables / dimensions are column based. To fake ragged hierarchies, columns representing intermediate levels in dimensions tables are are usually padded with blanks or the value of the "parent column" is copied to the intermediate column. The effect of this when using a ragged hierarchy in a report, is that when you expand a row, the value of the expanded level is either blank or it matches the parent. This forces the user to expand multiple levels with the seemingly exact same value all the way to the lowest level.  

If you have a ragged hierarchy, you can enable the appropriate option (based on which padding technique you are using) to automatically hide intermediate (padded) levels from the user. For example, if the user expands the root level and level 1-3 are padded, we will automatically expand to level 4 and hide the intermediate levels. 

![ragged hierarchy](https://profitbasedocs.blob.core.windows.net/pbireportingmatrix/Ragged_hierarchy.PNG)  

#### Hide children matching parent names  
Enable this option if the intermediate columns are padded by copying the values in parent columns to children columns.  

#### Hide blank  
Enable this option if intermediate columns are padded with blank values.