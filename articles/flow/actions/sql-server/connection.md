# SQL Server connection

When adding a SQL Server action requiering an connection, select an **existing connection** or create a new one.

## Properties

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

### Properties for Microsoft Entra Service Principal authentication

| Name                |  Type    | Description                                                          |
|---------------------|----------|----------------------------------------------------------------------|
| Server name         | Required | The name of the SQL Server. This can be the server name, IP address, or a named instance. |
| Database name       | Required | Defines the specific database on the SQL Server to which the connection is made.|
| Client Id           | Required | The Client ID of the Azure AD service principal (also known as an app registration). |
| Client secret       | Required | The client secret (application secret) associated with the service principal in Azure AD. |

### User Connection String

| Name                | Type     | Description                                                          |
|---------------------|----------|----------------------------------------------------------------------|
| Connecion String    | Required | A full connection string that can be used to establish an Sql Server connection.  |


<br/>

Note: A [Dynamic Connection](./create-connection.md) can replace the default connection described here.