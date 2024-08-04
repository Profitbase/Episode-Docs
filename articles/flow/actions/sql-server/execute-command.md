# Execute command

Executes a SQL command in a SQL Server database, and returns the number of rows affected by the query.

> [!NOTE]
> This action does not return the result of the executed query. It simply return the number of rows affected by the query.

## Example: How to use parameters

To use parameters in the query, declare and assign variables in the `SQL parameters` property.  
Then use the parameters in the query.

```sql

UPDATE Users SET [Name] = @Name WHERE UserId = @UserId

```

## Example: How to use Flow variables in the command expression

To use Flow variables in a SQL query as part of the expression, you need to first [declare a variable](../built-in/declare-variable.md) as `Global` and [assign a value to the variable](../built-in/set-variable.md).  
Then, enclose the variable in curly brackets like with the `TableName` variable shown in the example below.

```sql
-- We have declared a Flow variable named TableName and assigned a value to it in a previous action.
UPDATE {TableName} SET [Name] = @Name WHERE UserId = @UserId
```

## Returns

[Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32) The number of rows affected.
