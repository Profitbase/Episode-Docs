
# Data Update Configuration

![img](https://profitbasedocs.blob.core.windows.net/images/dataupdate.png)

<br/>

The Data Update Configuration is used for setting up which columns should be updated from the data source(s) during an update process, and if rows that don’t exist in the Data Store should be imported as well.

<br/>

## Properties:
<br/>

**Keys**  
Specify the (logical) key(s) used for determining which rows to update and optionally insert from the source.

**Values**  
Specify the columns to update.  
**Import new rows from source**  
Enable this option to import rows that do not already exist in the Data Store. For rows being imported, the binding configuration of the Data Store is used, while the column list in the Data Update Configuration is ignored. 
 
**Update existing rows**  
Updates existing rows with new values from the data source(s). Only the columns listed in the columns list are updated.