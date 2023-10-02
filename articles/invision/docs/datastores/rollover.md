---
title: "Rollover"
metaKeys: "Rollover, transitioning, time, Frame Reference Date, Data Store, Setting, Measure Columns, Enabled, Data Warehouse, Is Cyclic, Update from Source, Reload, Calculations"
folderOnly: "false"
pageIndex: 9
---

Rollover is the process of transitioning forward in time from one period to another. Executing a Rollover usually involves moving data from one period over to another and updating the [Time Frame](timeframe.md) Reference Date. The process may also contain updating or refreshing data from source systems and performing calculations.

To enable Rollover for a [Data Store](../datastores.md) or Setting, you first need to set up the [Time Frame](timeframe.md) and add [Time Frame Measure Columns](timeframemeasurecolumns.md) to the repository schema.

Once the Time Frame is set up, you need to go to the Rollover section in the Feature tab to enable Rollover for the repository by checking **«Is Rollover Enabled»**.
<br/>


### Rollover Columns

Specifies which columns to roll over new periods. You need to specify which columns to roll over, because you would normally not want all Time Frame Measure columns to roll over. As an example, you would probably not execute rollovers for columns containing Actuals, but rather refresh data for these columns from the Data Warehouse when transitioning to a new period.
<br/>

### Is Cyclic

Specifies that the rollover should be cyclic, meaning data from columns leaving the Time Frame window will loop back and reappear from the tail of the window. For example, if you are running a 12 months continuous forecast, enabling cyclic rollover will copy data from January of the current year to January next year, giving you a decent starting value for that period.
<br/>

### Update from Source

When setting up Rollover for Data Stores, specifies whether to update data from the data sources after a Rollover. Updating the Data Store is done after the Rollover has completed and the Time Frame has been updated, but prior to executing any post-update Rollover Calculations.
*	**Don’t update data (default)**

 The standard rollover is executed. The Data Store does not update from the source.

*	**Update data**

 Executes the rollover, then updates the Data Store according to the **Data Update Configuration** before executing any post-update Rollover Calculations.

*	**Reload data**

 Executes the rollover, the reloads data to the columns bound to the data source(s) in the schema configuration. 
 
> [!NOTE]
> that any rollover columns bound to the data sources will also be reloaded. Being a rollover column does not prevent reloading data for the column if this setting is applied.
<br/>

### Rollover Calculations

Specifies column calculations to run before and after the Rollover.
To set up a column calculation, add a column to the Rollover Calculations list and enter the **SQL** expression for calculating the value. The expression supports **directives**. 

A calculation can run before and after the Rollover. If you want a calculation to run both before and after the Rollover, you need to add the column twice and enable one to run after the Rollover. Post-rollover calculations will run after a Data Store update.

<br/>

### Videos
* [Data Stores](../../videos/datastores.md)
* [Rollover Calculations](https://profitbasedocs.blob.core.windows.net/videos/DS%20-%20Rollover%20Calculations.mp4)