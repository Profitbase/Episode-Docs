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

## Overview

The `Microsoft Entra ID Connection` action is used to configure a static connection to a Microsoft Entra ID tenant. This connection is required for actions that interact with the Entra ID API, such as [Invite guest user](./invite-guest-user.md), to perform operations like inviting external users to the tenant.

To create a Microsoft Entra ID Connection:
1. In the Flow Designer, navigate to `Resources` -> `Workspace Objects` and create a new Entra ID connection.
2. Provide the Tenant ID, Client ID, and Client Secret for the Entra ID App.
3. Save the connection and assign it to the `Connection` property of an Entra ID-related action, such as [Invite guest user](./invite-guest-user.md).

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

## Example

The example below illustrates using the Microsoft Entra ID Connection to invite a guest user:
1. Configure a `Microsoft Entra ID Connection` in Workspace Objects.
2. Use the connection in the [Invite guest user](./invite-guest-user.md) action to send an invitation.

![Example Flow](/images/flow/entra-id-connection-example.png)

## Configuring a Microsoft Entra ID Connection

Before using the `Invite guest user` action, you must configure a Microsoft Entra ID connection to authenticate API requests.

1. Create a Microsoft Entra ID App (Service Principal) as described in the [Microsoft Entra ID documentation](https://learn.microsoft.com/en-us/entra/identity-platform/quickstart-register-app).
2. Grant the Service Principal the necessary permissions (e.g., `User.Invite.All`) to invite guest users.
3. In the Flow Designer, navigate to `Resources` -> `Workspace Objects`, and create a new Entra ID connection.
4. Provide the Tenant ID, Client ID, and Client Secret for the Entra ID App.
5. Assign this connection to the `Connection` property of the `Invite guest user` action.

## Editing an Existing Connection

To edit an existing Microsoft Entra ID Connection:
1. Go to `Resources` -> `Workspace Objects` in the Flow Designer.
2. Locate the Entra ID connection and update its properties (e.g., Client Secret or Tenant ID).
3. Save the changes to apply them to all actions using this connection.

Read more about Workspace Objects [here](../../../workspaces/workspace-objects.md).

## Notes
- Ensure the Service Principal has the necessary permissions (e.g., `User.Invite.All` for inviting guest users) to perform the desired actions.
- The Tenant ID, Client ID, and Client Secret must be valid and correspond to a properly configured Entra ID App in the Azure portal.