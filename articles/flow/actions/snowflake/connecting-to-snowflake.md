# Connecting to Snowflake

To use Snowflake actions in **Profitbase Flow**, you must either select an existing connection or create a new one.

[Ref: Logging in to Snowflake documentation](https://docs.snowflake.com/en/user-guide/connecting)  
[Detailed connection string options](https://github.com/snowflakedb/snowflake-connector-net/blob/master/doc/Connecting.md)

<br/>

## Connection properties

A Snowflake connection consists of the following fields:

| Property           | Description |
|---------------------|-------------|
| Connection Name     | The name of the connection. |
| Connection Type    (optional)  | Choose between a custom connection string (see below) or the default connection type. |
| Account             | Full account name, including any segments that identify the region and cloud platform where the account is hosted. |
| Username            | The username for the connection. |
| Password            | The password for the connection. |
| Host               (optional)  | The hostname for your account in the format: `<ACCOUNT>.snowflakecomputing.com`. |
| Workspace          (optional)  | The workspace name. |
| Database            (optional) | The database name. |
| Schema             (optional)  | The schema name. |
| Connection Timeout  (optional) | Timeout duration for the connection in seconds. |

<br/>

## Custom connection string

A **custom connection string** can be used instead of filling individual fields.  
This string overrides all standard connection settings except for the **username** and **password**, which are strongly recommended to be stored in protected fields rather than embedded directly into the connection string.

<br/>

## Sample connection

![Snowflake connection](../../../../images/flow/action-snowflake-connection.png)

<br/>

## Notes

- Ensure the account name and region match the Snowflake deployment.
- If using a custom string, validate the connection before saving.
- Sensitive values like passwords should not be placed directly in the connection string for security reasons.

<br/>

## Related resources

- [Snowflake User Guide – Connecting](https://docs.snowflake.com/en/user-guide/connecting)
- [Snowflake .NET Connector – Connection string format](https://github.com/snowflakedb/snowflake-connector-net/blob/master/doc/Connecting.md)