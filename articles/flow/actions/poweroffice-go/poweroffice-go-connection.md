# Connecting to PowerOffice Go

When adding a PowerOffice Go action, select an **existing connection** or create a new one.

## Connection details

A [PowerOffice Go connection](https://developer.poweroffice.net/documentation/authentication) consists of the following properties:

| Name                |  Type      | Description                                                         |
|-----------------------|----|-----------------------------------------------------------------------------|
| Connection Name                 | Required | Name of the connection object.                              |
| Client Id                          | Required    | A unique identifier for the client application.       |
| Client secret                      | Required    | A confidential key used to authenticate the client.   |
| Subscription Key                   | Optional    | An API key to access specific PowerOffice Go services.   |
| Use PowerOffice Go test environment | Optional    | Enables testing in a sandbox environment when checked. |

![img](../../../../images/flow/powerofficego-connection.png)



<br/>
Note: A [Dynamic Connection](./create-connection.md) can replace the default connection described here.