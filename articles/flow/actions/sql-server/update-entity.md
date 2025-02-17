# Update entity

Updates a table in SQL Server using data from an entity.  

At least one `Update key` is required. If you don't specify an Update key, the action will fail.  


Logically, this action performs the following:

```sql
UPDATE tableName
SET tableName.X = entity.X, tableName.Y = entity.Y
WHERE tableName.Key1 = entity.Key1 AND tableName.Key2 = entity.Key1
```

All properties in the `Update keys` configuration will be used in the WHERE clause to identify which row to update.  
All properties _NOT_ in the `Update keys` configuration will be used in the SET clause to identity which columns to update with data from the entity.  

> [!NOTE]
> Each property name in the entity must exist in the target table. If the database collation is case sensitive, the properties and columns must match by case in addition to name.



![img](https://profitbasedocs.blob.core.windows.net/flowimages/update-entity.png)

## Properties

| Name         | Type            | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title              | Optional        | A descriptive title for the action.               |
| Connection      | (Required) | The [SQL Server Connection](./connection.md).         |
| Dynamic connection | Optional | Use this option of you needs to use a connection from the [Create Connection](./create-connection.md) action. |
| Source   | Required | Select the entity to use in update. |
| Table name | Required  | Select or enter the table name to insert into. |
| Update key | Required  | Select the table columns to use for update keys.  |
| Result variable name | Optional  | Name of resulting list of entities variable  |
| Command timeout (sec) | Optional | The time limit for command execution before it times out. Default is 120 seconds.|
| Description   | Optional | Additional notes or comments about the action or configuration. |
