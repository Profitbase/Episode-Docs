# For each app registration

Lists each app registration to a Microsoft Entra ID tenant.

![Example Flow](../../../../images/flow/entra-id-invite-guest-user-example.png)

**Example** ![img](../../../../images/strz.jpg)  
This flow is called from an HTTP trigger and invites a guest user to a Microsoft Entra ID tenant. It also sends a customized email message instead of using the default invitation message. 

## Properties

| Name                     | Type     | Description                                                                 |
|--------------------------|----------|-----------------------------------------------------------------------------|
| Title                    | Optional | The title of the action.                                                    |
| Connection               | Required | The [Microsoft Entra ID connection](./connecting-to-entra-id.md) to the tenant. The app registration/service principal used for the connection must have (at minimum) the delegated or application permission **Application.Read.All** to list app registrations. (Broader permissions such as Application.ReadWrite.All or Directory.Read.All also work but are not required.) |
| Prefix filter            | Optional | Prefix filter for app registrations **Note!** The prefix is case sensitive. |
| App registration variable name     | Required | The name of the variable that stores the response from the Entra ID API (e.g., AppId). |
| Disabled  | Optional | Boolean value indicating whether the action is disabled (true/false).  |
| Description              | Optional | Additional details or notes about the action.                               |

## Returns (optional)

Returns an `EntraIdAppRegistration` object with the following properties set.

| Name               | Description                                                                          |
|--------------------|--------------------------------------------------------------------------------------|
| Id                 | The application object ID (Application ObjectId).                                    |
| DisplayName        | The display name of the app registration.                                            |
| AppId              | The application (client) ID (ClientId) used for authentication.                      |
| ServicePrincipalId | The corresponding service principal object ID (if created in the tenant).            |