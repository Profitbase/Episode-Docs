# Create PowerOffice Go Connection

This action creates a connection for  PowerOffice Go, and is intented for dynamically connecting to different subscriptions based on parameters or conditions during the execution of a Flow.   

A 'Dynamic Connection' will override the 'Connection' on flow execution.

If you store the credentials for the PowerOffice Go outside Flow (for example in your own Azure SQL or PostgreSQL database), use this action to _dynamically_ create a connection. The connection returned from the action must then be used as the input to the `Dynamic connection` property of a PowerOffice Go request action.


## Properties

| Name                |  Data Type   | Description                                                          |
|---------------------|--------------|----------------------------------------------------------------------|
| Client Id           | Required     | A unique identifier for the client application.        |
| Client secret       | Required     | A confidential key used to authenticate the client.    |
| Subscription Key    | Optional     | An API key to access specific PowerOffice services.    |
| Use Demo URLs       | Optional     | Enables testing in a sandbox environment when checked. |