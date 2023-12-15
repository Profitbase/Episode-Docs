# Get single value

Executes a SQL command in a SQL Server database which returns a single value.

## Example: How to use parameters

To use parameters in the query, declare and assign variables in the `SQL parameters` property.  
Then use the parameters in the query.

```sql

SELECT * FROM Users WHERE UserId = @UserId

```


## Example: How to use variables in the command expression

To use a variable in a SQL query as part of the expression, you need to first [declare a variable](../built-in/declare-variable.md) as `Global` and [assign a value to the variable](../built-in/set-variable.md).

```sql
SELECT * FROM {TableName}
```


## Returns

Returns a .NET value of type as specified by `Result variable type`.