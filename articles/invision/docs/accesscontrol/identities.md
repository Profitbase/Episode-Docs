
# Identities

Access to resources, such as Workbooks, Data, and APIs are granted to Access Groups. Access Groups contains identity or group accounts from Windows AD or Microsoft Entra ID.

You can add or import your identities.

When you "add" identities, you connect to the identity provider that the system is set up to use (for example Windows or Microsoft Entra ID).

When you "import" identities, you can paste a list of identities (typically from an Excel file).
<br/>

## Add an Identity

Our example solution contains two workbooks, Admin and Budget. We are going to [create two access groups](accessgroups.md), Admin and Standard. Admin identity will have access to both workbooks and the full department hierarchy. Standard identity will only have access to the Budget Workbook and Norway in the department hierarchy. 

1.	Click on **“Access Control”** tab at the top,
2.	Select **“Edit”**,
3.	Click on the **“Add”** button to add a new Identity, 
4.	Use the search field to find yourself, 
5.	Click **“Ok”**,
6.	Click **“Save”**.

![Access](https://profitbasedocs.blob.core.windows.net/images/user1.png)  





<br/>

## See Also 
* [Access Groups](accessgroups.md)
* [Identities Editor](../workbooks/components/accesscontrol/identitymanagement.md)
<br/>

## Videos

* [Access Control](../../videos/accesscontrol.md)
* [Identities and Access Groups](https://profitbasedocs.blob.core.windows.net/videos/Users%20and%20Permissions%20-%20Users%20and%20User%20Groups.mp4)
