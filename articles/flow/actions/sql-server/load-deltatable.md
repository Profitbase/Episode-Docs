# Load DeltaTable

This action compares a source table against a target table and detects differences. The differences are then stored in a **DeltaTable**. This table contains the mapped columns and a row state column. The values in the **row state column** indicate whether to use Insert, Update, or Delete when using the **DeltaTable** to update any target systems.

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
| Delta table name   | Required  | Delta table to fill with changes. |
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

The DeltaTable contains a column **__rowState** (of type tinyint). 

| Value  | Description |
|--------|-------------|
| 1 | Row to be **Deleted** |
| 2 | Row to be **Inserted** |
| 4 | Row to be **Updated** |

<br/>

## Details / Notes

In order to compare source and target tables, each table will be scanned once to detect differences. Large tables may affect overall performance of the SQL server.

<br/>

The following notes and recommendations apply:
- If unique keys or IDs (including combinations) exist, use them for comparison.
- If no columns are checked for **Compare by**, all columns are used for comparison.
- If no unique column combinations exist, the **DeltaTable** will only contain Deletes and Inserts. **Important:** Delete rows before inserting new rows.
- Avoid use of collation if possible; collation casting costs resources and increases time spent.
- If collation is not defiened, collstion differences is detected and handeled.