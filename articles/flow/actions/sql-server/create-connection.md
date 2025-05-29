# Create Sql Server Connection

This action creates a connection for SQL Server, and is intented for dynamically connecting to different servers and databases based on parameters or conditions during the execution of a Flow.   

A 'Dynamic Connection' will override the 'Connection' on flow execution.

If you store the credentials for the SQL Server outside Flow (for example in your own Azure SQL or PostgreSQL database), use this action to _dynamically_ create a connection. The connection returned from the action must then be used as the input to the `Dynamic connection` property of other SQL Server actions.


## Connection details

### Connection type

A connection type (or authentication type) must be selected before entering other properties.
- SQL Server Authentication - default, sql server user name and password
- MS Entra Password - Authenticate with a Microsoft Entra identity's username and password
- Ms Entra Service Principal - Authenticate with a Microsoft Entra service principal, using its client ID and secret
- User Connection String - user provids his own connection string

### Properties for SQL Server and Microsoft Entra Password authentication

| Name                |  Type     | Description                                                          |
|---------------------|-----------|----------------------------------------------------------------------|
| Server name         | Required  | The name of the SQL Server. This can be the server name, IP address, or a named instance. |
| Database name       | Required  | Defines the specific database on the SQL Server to which the connection is made.|
| Username            | Required  | The username (or Entra Id/e-mail) used to authenticate the connection. |
| Password            | Required  | The password associated with the User to authenticate the connection. |
| Enable Multiple Active Result Sets | Required  | This setting allows a single database connection to run multiple queries at the same time, without waiting for one to finish before starting another.  [Read more](https://learn.microsoft.com/en-us/sql/connect/ado-net/sql/enable-multiple-active-result-sets?view=sql-server-ver16) |

### Properties for Microsoft Entra Service Principal authentication

| Name                |  Type    | Description                                                          |
|---------------------|----------|----------------------------------------------------------------------|
| Server name         | Required | The name of the SQL Server. This can be the server name, IP address, or a named instance. |
| Database name       | Required | Defines the specific database on the SQL Server to which the connection is made.|
| Client Id           | Required | The Client ID of the Azure AD service principal (also known as an app registration). |
| Client secret       | Required | The client secret (application secret) associated with the service principal in Azure AD. |
| Enable Multiple Active Result Sets | Required  | This setting allows a single database connection to run multiple queries at the same time, without waiting for one to finish before starting another.  [Read more](https://learn.microsoft.com/en-us/sql/connect/ado-net/sql/enable-multiple-active-result-sets?view=sql-server-ver16) |

### User Connection String

| Name                | Type     | Description                                                          |
|---------------------|----------|----------------------------------------------------------------------|
| Connecion String    | Required | A full connection string that can be used to establish an Sql Server connection.  |

