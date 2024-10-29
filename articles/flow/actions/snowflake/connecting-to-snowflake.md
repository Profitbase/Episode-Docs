# Connecting to Snowflake

[Ref. Logging in to Snowflake documentation.](https://docs.snowflake.com/en/user-guide/connecting )

When adding a Snowflake action, select an [existing connection](../../workspaces/workspace-objects.md) or create a new one. 


## Connection details

A Snowflake connection consists of the following fields:

| Name | Type | Description                                                                 |
|----------------------|-------------------|-----------------------------------------------------------------------------|
| Connection Name      | Required           | The name of the connection.                                                |
| Connection Type      | Optional           | Choose between a custom connection string (see below) or the Snowflake default connection type. |
| Account              | Required           | Full account name, including any segments that identify the region and cloud platform where the account is hosted. |
| Username             | Required           | The username for the connection.                                           |
| Password             | Required           | The password for the connection.                                           |
| Host                 | Optional           | The hostname for your account in the following format: <ACCOUNT>.snowflakecomputing.com. |
| Workspace            | Optional           | The workspace name.                                                        |
| Database             | Optional           | The database name.                                                         |
| Schema               | Optional           | The schema name.                                                           |
| Connection Timeout    | Optional           | The connection timeout in seconds.                                         |







[For a detailed documentation, click here](https://github.com/snowflakedb/snowflake-connector-net/blob/master/doc/Connecting.md).

## Sample connection 
![img](../../../../images/flow/action-snowflake-connection.png)

## Custom connection string

A custom connection string replaces all fields except for user name and password. It is recommended that these are placed in the protected fields and not in the connection string.
