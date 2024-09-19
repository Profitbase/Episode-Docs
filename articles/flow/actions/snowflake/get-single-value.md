# Get single value

Executes a query command in a Snowflake database which returns a single value.

![img](https://profitbasedocs.blob.core.windows.net/flowimages/get-single-value.png)


## Properties

| Name         | Data type       | Description                                       |
|--------------|-----------------|---------------------------------------------------|
| Title           |   Optional | The title or name of the command.    |
| Connection         | Required   | The SQL Server connection. |
|SQL expression and parameters   | Required      | The command to execute along with any parameters.   |
| Result variable name | Optional  | Name of the variable.  |
| Result variable type | Optional  | Type of the variable.  |
|Command timeout (sec) | Optional | The time limit for command execution before it times out. Default is 120 seconds.|
| Description   | Optional | Additional notes or comments about the action or configuration. |

## Example: How to use parameters

To use parameters in the query, declare and assign variables in the `Parameters` property.  
Then use the parameters in the query.

```sql

SELECT Display_Name FROM Snowflake.Account_Usage.Users WHERE USER_ID = :UserId

```

## Example: How to use variables in the command expression

To use Flow variables in a SQL query as part of the expression, you need to first [declare a variable](../built-in/declare-variable.md) as `Global` and [assign a value to the variable](../built-in/set-variable.md).  
Then, enclose the variable in curly brackets like with the `TableName` variable shown in the example below.

```sql
-- We have declared a Flow variable named TableName and assigned a value to it in a previous action.
SELECT Dispaly_Name FROM {TableName} WHERE USER_ID = :UserId
```

## Returns

Returns a .NET value of type as specified by `Result variable type`.
