
# AccessControlService

## MacroExpansionProvider.AccessControlService

The AccessControlService provides an API against a small subset of the InVision access control system.
<br/>

## Methods:

>**IsMemberOfAccessGroupAsync**

``Task<bool> IsMemberOfAccessGroupAsync(string identityId, string accessGroupName)``
<br/>

>**HasObjectAccessAsync**

``Task<bool> HasObjectAccessAsync(string identityId, string objectId)``

<br/>

>**HasWorkbookAccessAsync**

``Task<bool> HasWorkbookAccessAsync(string identityId, string workbookName)``

<br/>

>**HasWorkbookPageAccessAsync**

``Task<bool> HasWorkbookPageAccessAsync(string identityId, string workbookName, string pageName)``

<br/>

**Example:**

This example shows how to check whether the current user is a member of the “Admins” Access Group. 

> [!NOTE]
> that we’re using Context.GetUserUniqueId() to get the id of the current user.


```
namespace Local;
    
using System.Threading.Tasks;
using Profitbase.Invision.Scripting.Dynamic;

public class MyMacros : MacroExpansionProvider
{            
    public async Task<string> GetQuery(string input)
    {
        var userIsAdmin = await this.AccessControlService.IsMemberOfAccessGroupAsync(this.Context.GetUserUniqueId(), "Admins");
        if(userIsAdmin)
        {
            return "IPAddress, CertificateRevocationDate, MachineName";
        }
        else
        {
            return "MachineName";
        }             
    }
}
```



<br/>

