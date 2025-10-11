# Connection

To connect to Hypergene Portfolio you need to specify your `login credentials` (username + password) and `Portfolio ID`.  
Optionally, you can also specify the `Domain` if you are not hosted in the standard Portfolio cloud environment.

## Properties
| Name            | Type             | Description                      |
|-----------------|------------------|----------------------------------|
| Portfolio ID    | Required         | The Portfolio ID to connect to.  |
| Domain          | Optional         | Specify the domain if you are not hosted in the standard Portfolio cloud environment. The default value is 'hub'. |
| User name       | Required         | The user name to authenticate with.    |
| Password        | Required         | The password to authenticate with.     |

## Description
If you are familiar with the Portfolio API, defining a connection will make Flow connect to the API v2 endpoint at `https://hub.thinking1.com/{portfolio-id}/api/v2` using the provided credentials for authentication.  
If you specify a custom `Domain`, the address will be `https://{domain}.thinking1.com/{portfolio-id}/api/v2`.