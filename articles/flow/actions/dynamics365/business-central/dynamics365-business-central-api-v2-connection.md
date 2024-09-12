# Dynamics 365 Business Central APIv2 Connection

Because Dynamics 365 Business Central only allows authenticated requests, you need to create a connection before you can make any API calls.

Profitbase Flow uses Microsoft Entra ID based authentication against the common API endpoint:  
`https://api.businesscentral.dynamics.com/v2.0/<environment name>/api/v2.0`

![img](/images/flow/dynamics365-bc-api-connection.png)

## Properties

| Name                         | Type     | Description                                                                                  |
| ---------------------------- | -------- | -------------------------------------------------------------------------------------------- |
| Tenant Id                    | Required | The Entra Tenant Id associated with the Dynamics 365 Business Central subscription           |
| Client Id                    | Required | The id of the Entra ID App which has been granted access to the Business Central API.        |
| Client secret                | Required | The client secret of the Entra ID App which has been granted access to Business Central API. |
| Business Central Environment | Required | The Business Central environment to target (Production, Sandbox, Text, etc)                  |

### 1. Create a Microsoft Entra ID App (Service Princpial)

You first need to create a Microsoft Entra ID App to [set up Entra ID based authentication](https://learn.microsoft.com/en-us/dynamics365/business-central/dev-itpro/developer/devenv-develop-connect-apps#set-up-microsoft-entra-id-based-authentication). The Entra ID App, also knows as a "Service Principal", is the entity that will be granted permissions to call one or more Business Central APIs. You can think of the Entra ID App as a (service) user.

### 2. Grant permissions to the the Entra ID App (Service Principal)

When the Entra ID App (also known as a "Service Principal") has been created, the next thing you need to do is grant it access to the service(s) and resources in Business Central that you want to access throught the Business Central API.

1. In your Entra ID App, go to **Manage** -> **API Permissions**.
2. Press **Add Permissions** and select **Dynamics 365 Business Central**.
   ![img](/images/flow/dynamics365-bc-api-connection-service-principal-add-permissions.png)  
   <br/>

3. At the top, choose **Application permissions** and select **API.ReadWrite.All** and **Automation.ReadWrite.All**.
   ![img](/images/flow/dynamics365-bc-api-connection-service-principal-select-permissions.png)  
   <br/>

4. Next, you need to grant Admin consent for your organization.  
   ![img](/images/flow/dynamics365-bc-api-connection-service-principal-grant-admin-consent.png)  
   <br/>

5. Go the the Dynamics 365 Business Central Admin portal and grant the service principal access.

   <br/>
