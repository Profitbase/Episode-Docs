# Insert entity

Inserts a row to a SQL Server table using data from an entity.  

Logically, this action performs the following:

```sql
INSERT INTO tableName (Property1, Property2) VALUES(entity.Property1, enity.Property2)
```

> [!NOTE]
> Each property name in the entity must exist in the target table. If the database collation is case sensitive, the properties and columns must match by case in addition to name.



## Properties

| Name         | Data type       | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title           |           |                        |
| Connection         | Required   | InVision SQL Server connection. |
| Entity | Raquired  |   |
| Table name | Required  |   |
| Result variable name | Required  | Name of the variable returning number of rows affected.   |
| Command timeout (sec) | Optional | Command timeout in seconds.|
| Description   |           |                  |
