# Enable Entra ID API access

To enable change tracking, the Writeback Comments visual requires permissions to obtain information about the signed-in user. To achieve this, the visual uses the Microsoft Entra ID API provided by Power BI. 

> [!NOTE]
> If Change tracking is set to `None`, you can ignore this topic.  

<br/>

## 1) Enable AppSource Custom Visuals SSO (Required)
In your Fabric portal, go to the Admin section, search for `AppSource Custom Visuals SSO` and make sure it's enabled.

![img](/images/powerbi/writeback-comments/appsource-custom-visuals-sso.png)

<br/>

## 2) Grant Admin consent on behalf of the organization (Optional)

The first time the visual calls the Entra ID API, the user is presented with a UI (provided by Microsoft) that takes them through the consent flow. 

To avoid requiring all users go through this consent flow, you can ask a Microsoft Entra ID administrator in your organization to enter the following url in the browser and consent on behalf of the organization.

```
https://login.microsoftonline.com/common/adminconsent?client_id=5f804a63-f38e-402a-833b-73ab3f892380&redirect_uri=https%3A%2F%2Fprofitbase-powerbi-visuals-writeback-table
```

After having completed the consent flow, the following Entreprise App registration should be visible in Microsoft Entra ID.
![img](/images/powerbi/writeback-comments/enterprise-app-registration.png)

<br/>



