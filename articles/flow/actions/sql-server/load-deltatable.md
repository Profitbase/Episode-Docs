# Load DeltaTable

This action compares a source table with a target table and detects inserted, updated, and deleted rows. The differences are stored in a **DeltaTable** that contains the mapped columns and a row state column named `__rowState`. The [row state column](#row-state) indicates whether a row in the source table is inserted, updated or deleted relative to the target table. The DeltaTable can then be used to update the target table by applying only the changed rows.

<br>

![img](/images/flow/sql-server-load-deltatable.png)

**Example** ![img](../../../../images/strz.jpg)  

This flow example shows a process that loads a DeltaTable by comparing a source that, for example, is updated by an ERP system action against a target table. The content of the DeltaTable is then used to update a target using delete, update, and insert actions.

<br/>

## Properties

| Name         | Type            | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title        | Optional        | A descriptive title for the action.               |
| Connection   | Required        | The [SQL Server Connection](./connection.md).     |
| Dynamic connection | Optional  | Use this option if you need to use a connection created by the [Create Connection](./create-connection.md) action. |
| Source table name  | Required  | Source table name to load from. |
| Delta table name   | Required  | Delta table to fill with changes. Flow automatically creates this table. |
| Target table name  | Required  | Target table to compare against.|
| Column Settings    | Required  | List of columns to use in DeltaTable. See below for details. |
| Result variable name | Optional  | The name of the variable returning the number of rows in the DeltaSet table.  |
| Command timeout (sec) | Optional | The time limit for command execution before it times out. Default is 120 seconds.|
| Description   | Optional | Additional notes or comments about the action or configuration. |

<br/>

## Column Settings

![img](/images/flow/sql-server-load-deltatable-columns.png)

To use the columns from the Source Table, click on **Create from source table**. You can also define columns manually by using **Add**.
The columns defined in the list will be added to the **DeltaTable**.

<br/>

| Property   | Type            | Description     |
|------------|-----------------|-----------------|
| Name       | Required        | Name of the column to include. |
| SQL Type   | Required        | SQL Data Type name             |
| Compare by | Optional        | If the column is included in comparison between source and target. |
| Collation  | Optional        | If the collation is different between source and target, the collation is used in comparison and in DeltaTable. | 

<br/>

## Row State

The DeltaTable contains a column **__rowState** (of type tinyint). The column indicates which action to apply when updating the target table.

| Value  | Description |
|--------|-------------|
| 1 | Row should be **Deleted** from the target table. |
| 2 | Row should be **Inserted** to the target table.|
| 4 | Row should be **Updated** in the target table. |

<br/>

## How to use
The purpose of this action is to update a target table with changes from a source table using the minimum number of row operations (only rows that have been inserted, updated, or deleted are affected).

1) **Specify the source table.**  
This table is typically populated by another process, such as a data import from an ERP system. It represents the current state of the source system.  

2) **Specify the target table.**  
The target table represents the state of the target system. Flow uses this table together with the source table to determine the differences and populate the DeltaTable. 

3) **Specify the DeltaTable.**  
This table contains the differences between the source and target tables — which rows in the source have been inserted (new), updated, or deleted relative to the target table since the last synchronization.  

    Specify a table name that does not already exist in the database. Flow will take ownership of the table and create, update, or drop it as needed.  
    _The DeltaTable should not be relied upon by other systems._

4) **Configure the `Column settings` property**  
Specify which columns from the source should be included in the DeltaTable.
   * Add all columns that should be synchronized from source to target.
   * Select the column(s) used for comparison.

<br/>
    The correct choice depends on how the source system works. If the source system provides a logical key and a “last changed” timestamp column, you can use those for comparison (for example ProductID and LastUpdated).  
    For performance reasons, choose as few columns as possible while still ensuring that rows can be uniquely identified.  

5) **Keep the target table synchronized if the final destination is outside the database.**  
If you are using Flow to build a staging database, make sure that the target table is also kept in sync with the final destination. Otherwise, the DeltaTable may be calculated incorrectly the next time the Flow runs. 


<br/>

## Details / Notes

In order to compare source and target tables, each table will be scanned to detect differences. Large tables may affect overall performance of the operation.

<br/>

The following notes and recommendations apply:
- If unique keys or IDs (including combinations) exist, use them for comparison.
- If no columns are checked for **Compare by**, all columns are used for comparison.
- If no unique column combinations exist, the **DeltaTable** will only contain Deletes and Inserts. **Important:** Delete rows before inserting new rows.
- Avoid use of collation if possible; collation casting costs resources and increases time spent.
- If collation is not defiened, collstion differences is detected and handeled.