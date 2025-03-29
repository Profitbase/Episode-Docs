# Entra ID integration

To record who adds or edits comments (change tracking), the Writeback Comments visual requires permissions to access information about the logged on user. To do this, the visual uses the Microsoft Entra ID API provided by Power BI. The first time the visual requests this information, the user is asked to consent to the visual accessing this information through a consent flow provided by Microsoft.

To prevent having all users go through this consent flow, you can ask a Microsoft Entra ID administrator in your organization to enter the following url in a browser and consent on behalf of the organization.

```
https://login.microsoftonline.com/common/adminconsent?client_id=5f804a63-f38e-402a-833b-73ab3f892380&redirect_uri=https%3A%2F%2Fprofitbase-powerbi-visuals-writeback-table
```

After having completed the consent flow, they should see the following Entreprise App registration in Microsoft Entra ID.
![img](/images/powerbi/writeback-comments/enterprise-app-registration.png)

<br/>

> [!NOTE]
> This only applies if Change tracking is enabled by the visual (**Not** set to `None`)  
> ![img](/images/powerbi/writeback-comments/configuration-change-tracking.png)
