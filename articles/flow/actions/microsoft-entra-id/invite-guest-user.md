# Invite Guest User

Invites a guest user to a Microsoft Entra ID tenant, enabling them to access resources as an external user. This action leverages the Microsoft Entra ID API to send an invitation to the specified email address and redirect URL, optionally including a personalized message.

**Example**  
The example below illustrates how to invite a guest user to a Microsoft Entra ID tenant and capture the response for further processing in a Flow. 

![Example Flow](../../../../images/flow/entra-id-invite-guest-user-example.png)

## Properties

| Name                     | Type     | Description                                                                 |
|--------------------------|----------|-----------------------------------------------------------------------------|
| Title                    | Optional | The title of the action.                                                    |
| Connection               | Required | The [Microsoft Entra ID connection](./connecting-to-entra-id.md) to the tenant. |
| Email account            | Required | The email address of the user to be invited as a guest.                     |
| Redirect URL             | Optional | The URL to which the guest user is redirected after accepting the invitation. |
| First name               | Optional | The first name of the guest user (optional).                                |
| Last name                | Optional | The last name of the guest user (optional).                                 |
| Message body             | Optional | A custom message included in the invitation email.                          |
| Send invitation message  | Optional | Specifies whether to send an invitation email to the guest user (default: true). |
| Wait for user propagation  | Optional | Specifies whether to wait for the user to be propagated (default: true). |
| Entra ID user variable name     | Required | The name of the variable that stores the response from the Entra ID API (e.g., invitation ID). |
| Description              | Optional | Additional details or notes about the action.                               |

## Returns (optional)

Returns an EntraIdUser object with a single string property; OId.