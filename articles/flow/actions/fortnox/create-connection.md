# Create Fortnox connection


This action creates a connection for [Fortnox](https://www.fortnox.se/developer/authorization/get-access-token-using-client-credentials), and is intented for dynamically connecting to different subscriptions based on parameters or conditions during the execution of a Flow.   

A 'Dynamic Connection' will override the 'Connection' on flow execution.

If you store the credentials for the Fortnox outside Flow (for example in your own Azure SQL or PostgreSQL database), use this action to _dynamically_ create a connection. The connection returned from the action must then be used as the input to the `Dynamic connection` property of a Fortnox request action.



##  Properties

| Name              | Type        | Description                                            |
|-------------------|-------------|--------------------------------------------------------|
| Client ID         | Required    | A unique identifier for the client application.        |
| Client Secret     | Required    | A confidential key used to authenticate the client.    |
| Tenant ID         | Required    | The ID of the Tenant (database id)  |
| Scopes            | Required    | Select one or more [scope](https://www.fortnox.se/developer/guides-and-good-to-know/scopes) for use in requests |


