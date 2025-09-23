# Microsoft Entra ID Connection

This action establishes a connection to a Microsoft Entra ID tenant, enabling actions like [Invite guest user](./invite-guest-user.md) to interact with the Entra ID API for managing users and resources.

> [!NOTE]
> Before you can create a Microsoft Entra ID Connection, you need to create a **Microsoft Entra ID App** (also known as a `Service Principal`) and grant it access to the Entra ID API. Profitbase Flow will call the Entra ID API on behalf of the Service Principal, using its credentials.  
>  
> [Read about how to create a Service Principal here](https://learn.microsoft.com/en-us/entra/identity-platform/quickstart-register-app).

## Properties

| Name            | Type     | Description                                                                 |
|-----------------|----------|-----------------------------------------------------------------------------|
| Tenant ID       | Required | The Microsoft Entra Tenant ID associated with the Entra ID subscription. You can find it in the Azure portal where you created the Service Principal. |
| Client ID       | Required | The ID of the Entra ID App (Service Principal) that has been granted access to the Entra ID API. |
| Client Secret   | Required | The client secret of the Entra ID App used to authenticate with the Entra ID API. |

## Enable Microsoft Entra ID Authentication

To use this connection, you must first set up a Microsoft Entra ID App (Service Principal) and grant it the necessary permissions.

1. **Create a Microsoft Entra ID App (Service Principal)**  
   Follow the [Microsoft Entra ID documentation](https://learn.microsoft.com/en-us/entra/identity-platform/quickstart-register-app) to create a Service Principal.

2. **Grant Permissions to the Service Principal**  
   - In your Entra ID App, go to **Manage** -> **API Permissions**.
   - Click **Add Permissions** and select **Microsoft Graph**.
   - Choose **Application permissions** and select permissions like `User.Invite.All` for inviting guest users.
   - Grant **Admin consent** for your organization.
   - In the Entra ID admin portal, ensure the Service Principal has access to the tenant.

![Example app permissions](/images/flow/entra-id-invite-user-app-permissions.png)

## Example

The example below illustrates using the Microsoft Entra ID Connection to invite a guest user:
1. Configure a `Microsoft Entra ID Connection` in Workspace Objects.
2. Use the connection in the [Invite guest user](./invite-guest-user.md) action to send an invitation.

![Example Flow](/images/flow/entra-id-connection-example.png)
