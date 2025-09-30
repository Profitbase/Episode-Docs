# For each user

Lists each user in a Microsoft Entra ID tenant.

![Example Flow](../../../../images/flow/entra-id-invite-guest-user-example.png)

**Example** ![img](../../../../images/strz.jpg)  
This flow is called from an HTTP trigger and invites a guest user to a Microsoft Entra ID tenant. It also sends a customized email message instead of using the default invitation message. 

## Properties

| Name                     | Type     | Description                                                                 |
|--------------------------|----------|-----------------------------------------------------------------------------|
| Title                    | Optional | The title of the action.                                                    |
| Connection               | Required | The [Microsoft Entra ID connection](./connecting-to-entra-id.md) to the tenant. The app registration/service principal must have (at minimum) **User.Read.All** to list users (Directory.Read.All or higher privileges also work but are not required). |
| User variable name       | Required | The name of the variable that stores the response from the Entra ID API (e.g., Mail). |
| Disabled  | Optional | Boolean value indicating whether the action is disabled (true/false).  |
| Description              | Optional | Additional details or notes about the action.                               |

## Returns (optional)

Returns an EntraIdUser object with the following properties.

| Name            | Description |
|---------------------|-------------|
| ObjectId            | The Object (user) ID. |
| UserPrincipalName   | The UPN (e.g., alice@contoso.com). |
| UserType            | User classification (Member or Guest). |
| FirstName           | Given name. |
| LastName            | Surname. |
| DisplayName         | Full display name. |
| Email               | Preferred email. |
| MobilePhone         | Mobile phone number. |
| CompanyName         | Company / organization name (if set). |
| Department          | Department name (if set). |
| EmployeeId          | Internal employee identifier (if present). |
| EmployeeType        | Employee type classification (e.g., Contractor, Employee). |
| EmployeeHireDate    | Hire date (if exposed/licensed). |
| EmployeeLeaveDateTime | Planned or actual leave/end date (if set). To read this property the User-LifeCycleInfo.Read.All permission is required. |
| ManagerId | ObjectId of the user's manager (the directory object representing their manager). Will be null unless the Microsoft Graph request expands the manager relationship (e.g. add `$expand=manager($select=id)` in the user query). |
| Country             | Country/region value (ISO or free-form). |
| AccountEnabled      | Indicates whether the account is enabled. |
| CreatedDateTime     | When the user object was created in Entra ID. |