---
title: "Work Process Versions"
metaKeys: "work process versions, work process configuration, Package, blueprint, Version, Tasks and Workbooks, Deployed, Administrators, Translations, Workbook Menu, user"
pageIndex: 3
---

### Content

You cannot directly edit the content of a Version. The Content tab simply displays the content copied from the Work Process blueprint when the Version is deployed. If you want to change the contents of a Version, you need to change the blueprint of the Work Process before the Version has been deployed.
<br/>

### Properties

In addition to the Name and Description property which is provided by the system, Versions may have additional properties coming from the Package(s) defined in the Work Process blueprint. The properties are used by Package authors to provide configuration options used by business logic in Packages, such as the start date and a number of planning periods, whether or not to do a rollover to the next period, and so on.
Version properties can be edited as long as a Version is in the Draft status, but cannot be changed after a Version has been deployed.
<br/>

### Status

A Work Process Version can have one of the following states:

1. **Draft** - The Version only exists on the drawing board. No identities can do any work.
2. **Deployed** - The Version has been created. Work Process Administrators can access the Workbooks from the Workbook Menu and the homepage.
3. **Open** - The Version is open for input for any user with access to the Workbooks.
4. **Closed** - Identities with access can open Workbooks, but they cannot edit data.

After a Version has been deployed, you can change its status to Open or Closed.
An Open Version can at any point in time be set to Closed, and vice versa. 

 
> [!NOTE]
> It's entirely up to the Work Process administrator to pick a suitable time to switch states.
<br/>

### Translations

You can specify a translation for the name of the Work Process Version for each language defined in the system.
The translated name will appear in the Workbook Menu and on the homepage.
<br/>

### Deleting Versions

Versions take up storage space and should be deleted when they are no longer in use.
If you do not delete versions, you will run out of available storage, and will not be able to create new versions unless you move to a higher pricing tier.


### Videos

* [Work Process](../../videos/workprocess.md)
* [Work Process - Versions](https://profitbasedocs.blob.core.windows.net/videos/Work%20Process%20Versions.mp4)
