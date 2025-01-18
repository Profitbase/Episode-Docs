# Save DeltaSet

Saves all changes in a DeltaSet to an Azure SQL or SQL Server table.  

A typical use case for this action is to save the changes made by users in the [Writeback Table](../../../PowerBI/writeback-table/overview.md) for Power BI. This action will save all changes made by the user in Power BI by eiter inserting, updating, or deleting rows in the SQL Server / Azure SQL target table.

## Properties
| Name         | Type      | Description                                 |
|--------------|-----------|---------------------------------------------|
| Title        | Optional  | A descriptive title of the action.          |
| Connection   | Required  | The connection to the SQL Server / Azure SQL database. |
| Table name   | Required  | The name of the table where data should be stored. If this is not the same table as the data is read from, make sure that the target table contains columns with names and data types matching those from the input source. |
| Save data options | Optional | For advanced scenarios (see below), use this option to override which columns to allow saving data to, and which columns to compare on for updates and deletes.  |  
| Command timeout | Optional | The time limit in seconds for command execution before it times out. Default is 120 seconds.|