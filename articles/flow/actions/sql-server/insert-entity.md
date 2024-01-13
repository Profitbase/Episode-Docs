# Insert entity

Inserts a row to a SQL Server table using data from an entity.  

Logically, this action performs the following:

```sql
INSERT INTO tableName (Property1, Property2) VALUES(entity.Property2, enity.Property2)
```

> [!NOTE]
> Each property name in the entity must exist in the target table. If the collation of the database is case sensitive, the properties and columns must match by caseing in addition to name.
