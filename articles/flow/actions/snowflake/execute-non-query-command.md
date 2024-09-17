# Execute Command

Executes a SQL command in a Snowflake database, and returns the number of rows affected by the query.

> [!NOTE]
> This action does not return the result of the executed query. It simply return the number of rows affected by the query.

## Properties

| Name                      | Data type | Description                                                                       |
| ------------------------- | --------- | --------------------------------------------------------------------------------- |
| Title                     | Optional  | The title or name of the command.                                                 |
| Connection                | Required  | The SQL Server connection.                                                        |
| Expression and parameters | Required  | The command to execute along with any parameters.                                 |
| Result variable name      | Optional  | The name of the variable containing the number of rows affected.                  |
| Command timeout (sec)     | Optional  | The time limit for command execution before it times out. Default is 120 seconds. |
| Description               | Optional  | Additional notes or comments about the action or configuration.                   |

## Example: How to use parameters

## Example: How to use Flow variables in the command expression

## Returns

[Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32) The number of rows affected.
