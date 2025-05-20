# Enable Entra ID API access

To enable change tracking, the Writeback Comments visual requires permissions to obtain information about the signed-in user. To achieve this, the visual uses the Microsoft Entra ID API provided by Power BI. 

> [!NOTE]
> If Change tracking is set to `None`, you can ignore this topic.  

<br/>

## 1) Enable AppSource Custom Visuals SSO (Required)
In your Fabric portal, go to the Admin section, search for `AppSource Custom Visuals SSO` and make sure it's enabled.

![img](/images/powerbi/writeback-comments/appsource-custom-visuals-sso.png)

<br/>

## 2) Grant Admin consent on behalf of the organization (Required)

A **Microsoft Entra ID administrator** in your organization (the customer) must grant consent on behalf of the organization by entering the url below in a browser and complete the consent flow. Make sure that the user that performs this task is [authorized to grant consent on behalf organization](https://learn.microsoft.com/en-us/entra/identity/enterprise-apps/grant-admin-consent).

```
https://login.microsoftonline.com/{your entra tenant id}/adminconsent?client_id=ccd28c52-6516-4634-9d08-cbac9b093b2c
```
<br/>

After having completed the consent flow, the following Entreprise App registration should be visible in Microsoft Entra ID.  

![img](/images/powerbi/writeback-comments/enterprise-app-registration.png)

<br/>

## 3) Ensure that client side auth is not turned off
When users browse to the Power BI report or dashboard, make sure that the URL does NOT contain `clientSideAuth=0`. If this query string is present, remove it from the URL and reload the page.

For example, if the URL looks like this:
```
https://app.powerbi.com/groups/me/reports/a9884a59-f95c-412c-a25a-33f6d637ab90/ed89b274487d142ae3b6?experience=power-bi&clientSideAuth=0
```

change it to 
```
https://app.powerbi.com/groups/me/reports/a9884a59-f95c-412c-a25a-33f6d637ab90/ed89b274487d142ae3b6?experience=power-bi
```



