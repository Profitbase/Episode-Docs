# Connecting to Snowflake

To use Snowflake actions in **Profitbase Flow**, you must either select an existing connection or create a new one.

[Ref: Logging in to Snowflake documentation](https://docs.snowflake.com/en/user-guide/connecting)  
[Detailed connection string options](https://github.com/snowflakedb/snowflake-connector-net/blob/master/doc/Connecting.md)

<br/>

## Connection Details

A Snowflake connection consists of the following fields:

| Property            | Type     | Description |
|---------------------|----------|-------------|
| Connection Name     | Required | The name of the connection. |
| Connection Type     | Optional | Choose between a custom connection string (see below) or the default connection type. |
| Account             | Required | Full account name, including any segments that identify the region and cloud platform where the account is hosted. |
| Username            | Required | The username for the connection. |
| Password            | Required | The password for the connection. |
| Host                | Optional | The hostname for your account in the format: `<ACCOUNT>.snowflakecomputing.com`. |
| Workspace           | Optional | The workspace name. |
| Database            | Optional | The database name. |
| Schema              | Optional | The schema name. |
| Connection Timeout  | Optional | Timeout duration for the connection in seconds. |

<br/>

## Custom Connection String

A **custom connection string** can be used instead of filling individual fields.  
This string overrides all standard connection settings except for the **username** and **password**, which are strongly recommended to be stored in protected fields rather than embedded directly into the connection string.

<br/>

## Sample Connection

![Snowflake connection](../../../../images/flow/action-snowflake-connection.png)

<br/>

## Notes

- Ensure the account name and region match the Snowflake deployment.
- If using a custom string, validate the connection before saving.
- Sensitive values like passwords should not be placed directly in the connection string for security reasons.

<br/>

## Related Resources

- [Snowflake User Guide – Connecting](https://docs.snowflake.com/en/user-guide/connecting)
- [Snowflake .NET Connector – Connection string format](https://github.com/snowflakedb/snowflake-connector-net/blob/master/doc/Connecting.md)