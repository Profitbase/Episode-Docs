
## Change Tracking

Change Tracking logs changes made by identities when editing data in [Worksheets](../worksheets.md). [Change Tracking](howto/changetracking.md) does not record changes made by system processes or [Data Flows](../dataflows/index.md). If you need to log all changes made by Data Flows or scripts, you can use the Change Data Capture feature in SQL Server.

For Change Tracking to work, you need to enable it for the [Data Store](../datastores.md) or Data Store Group. You can enable or disable Change Tracking from the Properties tab in the Data Store or Data Store Group designer. 

In addition to enabling Change Tracking for a Data Store, you need to specify which columns should be change tracked. To enable Change Tracking for a Data Store column, you need to set its **Track** **Changes** property to **True**.

When Change Tracking is enabled for a column added to a Worksheet, the user can right-click a cell in the column to view the changelog for that particular cell.

When Change Tracking is enabled for a Data Store, a Change Tracking Table is created in the database. The Change Tracking table has the same name as the Data Store table with a "CHNG" postfix, so for example if the Data Store table is called "Store_Budget_20150101115318", the associated Change Tracking table is called "Store_Budget_20150101115318_CHNG".

The Change Tracking table contains information about which row and column were changed, the new value, who changed, what time it was changed, and the type of change operation performed (Insert, Update or Delete). 

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/change%20tracking.png)


### Column:
<br/>

**PBRowIdentity**  
The id of the row that the changed value belongs to.

**ColumnID**  
The metadata id of the column that was changed.

**ColumnName**  
The name of the column that the changed value belongs to.

**OpType**  
The type of operation,  
**0** = Insert (new value),  
**1** = Update (value was changed),  
**2** = Delete (the value was deleted). Entries with OpType = 2 means that the entire row was deleted.

**Data**  
What the value was changed to.

**PBLastChangedBy**  
Who made the change.

**PBLastChanged**  
When the change was committed to the database.  

<br/>

### Videos
* [Data Stores](../../videos/datastores.md)
* [Change Tracking](https://profitbasedocs.blob.core.windows.net/videos/DS%20change%20tracking.mp4)