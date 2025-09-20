# Invite Guest User

Invites a guest user to a Microsoft Entra ID tenant, enabling them to access resources as an external user. This action leverages the Microsoft Entra ID API to send an invitation to the specified email address, optionally including a personalized message and redirect URL.

![Invite Guest User Flow](../../../../images/flow/invite-guest-user-flow.png)

**Example**  
The example below illustrates how to invite a guest user to a Microsoft Entra ID tenant and capture the response for further processing in a Flow. Used actions:  
1. `Invite guest user`  
2. [Log response to console](../logging/log-to-console.md)  

![Example Flow](../../../../images/flow/invite-guest-user-example.png)

## Properties

| Name                     | Type     | Description                                                                 |
|--------------------------|----------|-----------------------------------------------------------------------------|
| Title                    | Optional | The title of the action.                                                    |
| Connection               | Required | The [Microsoft Entra ID connection](./connecting-to-entra-id.md) to the tenant. |
| Email account            | Required | The email address of the user to be invited as a guest.                     |
| First name               | Optional | The first name of the guest user (optional).                                |
| Last name                | Optional | The last name of the guest user (optional).                                 |
| Redirect URL             | Optional | The URL to which the guest user is redirected after accepting the invitation. |
| Message body             | Optional | A custom message included in the invitation email.                          |
| Send invitation message  | Optional | Specifies whether to send an invitation email to the guest user (default: true). |
| Entra ID user variable name     | Required | The name of the variable that stores the response from the Entra ID API (e.g., invitation ID). |
| Description              | Optional | Additional details or notes about the action.                               |

## Overview

The `Invite guest user` action is used to programmatically invite external users to collaborate within a Microsoft Entra ID tenant. It integrates with a configured Entra ID connection to authenticate and send the invitation. The action supports specifying user details (email, first name, last name), a custom redirect URL, and a message body for the invitation email. The response from the Entra ID API is stored in a user-defined variable for further use in the Flow.

To use this action, add the `Invite guest user` action to a Flowchart, select it, and configure its properties in the Property panel. Ensure a valid [Microsoft Entra ID connection](./connecting-to-entra-id.md) is set up in the workspace.

## Configuring a Microsoft Entra ID Connection

Before using the `Invite guest user` action, you must configure a Microsoft Entra ID connection to authenticate API requests.

1. Create a Microsoft Entra ID App (Service Principal) as described in the [Microsoft Entra ID documentation](https://learn.microsoft.com/en-us/entra/identity-platform/quickstart-register-app).
2. Grant the Service Principal the necessary permissions (e.g., `User.Invite.All`) to invite guest users.
3. In the Flow Designer, navigate to `Resources` -> `Workspace Objects`, and create a new Entra ID connection.
4. Provide the Tenant ID, Client ID, and Client Secret for the Entra ID App.
5. Assign this connection to the `Connection` property of the `Invite guest user` action.

![Entra ID Connection Setup](../../../../images/flow/entra-id-connection-setup.png)

## Editing an Existing Connection

To edit an existing Microsoft Entra ID connection:
1. Go to `Resources` -> `Workspace Objects` in the Flow Designer.
2. Locate the Entra ID connection and update its properties (e.g., Client Secret or Tenant ID).
3. Save the changes to apply them to all actions using this connection.

Read more about Workspace Objects [here](../../../workspaces/workspace-objects.md).

## Notes
- If the `Send invitation message` property is unchecked, no email is sent, but the guest user is still created in the Entra ID tenant.
- The `Return variable name` property defines the variable where the API response (e.g., invitation details) is stored. Ensure the name is alphanumeric or underscore for compatibility.
- The `Redirect URL` must be a valid URL if specified, as it directs the user to a specific page after accepting the invitation.
- The action is asynchronous, allowing it to integrate seamlessly into complex Flowcharts with execution in and out ports.