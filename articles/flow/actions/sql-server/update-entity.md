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
> Each property name in the entity must exist in the target table. If the collation of the database is case sensitive, the properties and columns must match by caseing in addition to name.

