# Microsoft Fabric Connection

Because Microsoft Fabric only allows authenticated requests, you need to create a connection before you can make any API calls.  
The Microsoft Fabric Connection is used by the [Microsoft Fabric REST API](./rest-api-request.md) action to automatically authenticate when calling the [Microsoft Fabric REST API](https://learn.microsoft.com/en-us/rest/api/fabric/articles/).


### 1. Create a Microsoft Entra ID App (Service Princpial)  
You first need to create a Microsoft Entra ID App by following [these instructions](https://learn.microsoft.com/en-us/rest/api/fabric/articles/get-started/create-entra-app). The Entra ID App, also knows as a "Service Principal", is the entity that will be granted permissions to call one or more Fabric APIs. You can think of the Entra ID App as a (service) user.  

### 2. Grant permissions to the the Entra ID App (Service Principal)
When the Entra ID App (also known as a "Service Principal") has been created, the next thing you need to do is grant it access to the service(s) and resources in Fabric that you want to access throught the Fabric API.  

1. In your Entra ID App, go to **Manage** -> **API Permissions**.  
2. Press **Add Permissions** and select **Power BI Service**. (This is currently the only valid option, but Microsoft might change this in the future.)
![img](/images/flow/microsoft-fabric-connection-sp-api-permissions.png)  
<br/>  
  
3. At the top, choose **Application permissions** and select **Tenant.Read.All** and **Tenant.ReadWrite.All**. 
![img](/images/flow/microsoft-fabric-connection-sp-app-permissions.png)  
<br/>  
  
4. Next, you need to grant Admin consent for your organization.  
![img](/images/flow/microsoft-fabric-connection-sp-admin-consent.png)  
<br/>  
  
5. Go the the Power BI Admin portal and ensure that **Service principals can use Fabric APIs** is enabled.  
![img](/images/flow/microsoft-fabric-connection-sp-powerbi-api.png)  
<br/>  

6. (Optional) If you want to grant access to a Power BI Workspace, select the Workspace, press **Manage access** and add the Service Principal to the list of users / groups.  
![img](/images/flow/microsoft-fabric-connection-sp-powerbi-workspace-access.png)  