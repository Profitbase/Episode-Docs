# Authentication using Microsoft Azure Active Directory
<br/>

## Configure your Microsoft Entra ID Application

1. Log on to your Azure Active Directory management portal
2. In the Portal, select your Entra ID instance.  
3. Select “App registrations”, and “New registrations”
<br/>

![Permissions and Authentication](https://profitbasedocs.blob.core.windows.net/images/upa2.png "Permissions and Authentication")

<br/>


## Web Client

Create an application that represents the Web Client, and configure:
<br/>


![Permissions and Authentication](https://profitbasedocs.blob.core.windows.net/images/upa3.png "Permissions and Authentication")
<br/>

### Application (client) ID  
This id is automatically generated for you, and you will need this later when configuring the InVision web site.

### Directory (tenant) ID  
This is “you”, and you will need this id when configuring the InVision web site.
<br/>

*“Authentication”* 

**Redirect URI**  
Add the redirect URI(s) (as type “Web”) that represents the physical address(es) for your app to which Microsoft Entra ID sends security tokens for authenticated identities. 

**Implicit grant**  
Check for both “Access tokens” and “ID tokens”.
<br/>
 

*“Certificates & secrets”*

**Keys**  
Select and create a “New client secret”. 

**Make a copy of the secret/key**   
because once you leave the configuration page, you will no longer be able to see it 
anymore. You need this value later when configuring the InVision web site.
<br/>

![Permissions and Authentication](https://profitbasedocs.blob.core.windows.net/images/upa4.png "Permissions and Authentication")

<br/>

*“API Permissions”*

**Microsoft Graph**  
Enable identities to Sign in and read identity profile is mandatory to authenticate identities, add:

*	User.Read as **Delegated** permission

To enable access to administrate identities, add additional permissions:

*	*User.ReadWrite.All* as **Application** permission

*	*Directory.ReadWrite.All* as **Application** permission

To enable access to Administrate groups, add additional permission:

*	*Group.ReadWrite.All* as **Application** permission

Make sure to Grant consent (grant admin consent for Default Directory).



> [!NOTE]
> To enable access to reset a identities password, the Web Client/API in addition has to be assigned the role. 

*	“User administrator”



> [!NOTE]
> Enforcement of permissions in Azure Portal are delayed, wait sufficiently to have permissions applied.
<br/>


*Expose an API*

**Application ID URI**  
You will need to set this to be able to add a “Scope”.

**Scope**  
Add a scope to expose the api.
<br/>


![Permissions and Authentication](https://profitbasedocs.blob.core.windows.net/images/upa5.png "Permissions and Authentication")
<br/>

*Manifest*

Some parameters are not set correctly during setup and configuration, and needs to be modified in the manifest file:

``"accessTokenAcceptedVersion"``

``"allowPublicClient"`` 

``"groupMembershipClaims"``
<br/>

Change:
* **accessTokenAcceptedVersion** to **null**,  
* **allowPublicClient** to **false**,  
* **groupMembershipClaims** to **All**:
<br/>

![Permissions and Authentication](https://profitbasedocs.blob.core.windows.net/images/upa6.png "Permissions and Authentication")

<br/>


## Designer
   
Create an application that represents the Designer, and configure.

**Application (client) ID**  
This id is automatically generated for you, and you will need this later when configuring the InVision Designer.

**Directory (tenant) ID**  
This is your tenant id, and you will need this id when configuring the InVision Designer.

<br/>

*“Authentication”*

**Redirect URI**  
Add the redirect URI(s) (as type “Public client (mobile & desktop)”) that represents the physical address(es) for your app to which Microsoft Entra ID sends security tokens for authenticated identities. 

**Implicit grant**  
Check for “ID tokens”.
<br/>

*“API Permissions”*

**Microsoft Graph**  
Enable identities to Sign in and read identity profile is mandatory to authenticate identities, add:

* User.Read as **Delegated** permission
  
To enable access to to “Your-webclient-app”, add the exposed permissions from “Your-webclient-app” as Delegated permission:
<br/>

![Permissions and Authentication](https://profitbasedocs.blob.core.windows.net/images/upa7.png "Permissions and Authentication")
<br/>

Make sure to **Grant consent**  (grant admin consent for Default Directory).
<br/>

![Permissions and Authentication](https://profitbasedocs.blob.core.windows.net/images/upa8.png "Permissions and Authentication")

<br/>


### Configure the Client and Designer Web Site

1.	Go the the **IdentityConfig** folder in the **Client install** folder and open **identityconfig.json** for editing.

2.	In the openIdConnect section, set the following properties.

*	**clientId**  
Copy the Client ID value from the Microsoft Entra ID Application Configuration.

*	**authority**  
Microsoft Entra ID instance + Tenant ID, for example https://login.microsoftonline.com/profitbase.no.

*	**redirectUri**  
The physical address of the web application, for example https://myserver/invision. This value must one of the Reply Url's configured in the Microsoft Entra ID Application Configuration (step 4e above).

*	**clientSecret**  
One of the keys from the Microsoft Entra ID Application Configuration (step 4c above).

*	**tenant**  
Your tenant id. You find your Tenant Id in the Overview screen of your App Registration.

*	Edit the **claimsTransformation** section.

3.	Go back into the Client install folder and rename the Web.config-file to something else, for example Original_Web.config.

4.	**Rename OpenIDConnect_Web.config** to **Web.config**. Copy the `<connectionString>` element (and its contents) from the original Web.config-file into the new Web.config-file (replace the existing `<connectionString>` element).

5.	Make sure the **auth:idp** appSetting is set to **AzureAD**.

<br/>

## Videos


* [Installation and Setup](../../../videos/gettingstarted/installation.md)
* [Access Control](../../../videos/accesscontrol.md)
* [Create Azure App Registration](https://profitbasedocs.blob.core.windows.net/videos/Installation%20and%20Setup%20-%20Create%20Azure%20App%20Registration.mp4)
* [Setup Azure Service Bus](https://profitbasedocs.blob.core.windows.net/videos/Installation%20and%20Setup%20-%20Setup%20Azure%20Service%20Bus.mp4)
* [InVision Service with Azure Active Directory Authentication](https://profitbasedocs.blob.core.windows.net/videos/Installation%20and%20Setup%20-%20InVision%20Service%20with%20Azure%20Active%20Directory%20Authentication.mp4)
* [Create and Manage Microsoft Entra ID Identities and Access Groups](https://profitbasedocs.blob.core.windows.net/videos/Users%20and%20Permissions%20-%20Create%20and%20Manage%20Azure%20AD%20Users%20and%20User%20Groups.mp4)