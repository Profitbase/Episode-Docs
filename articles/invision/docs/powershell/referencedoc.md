---
title: "References"
metaKeys: ""
pageIndex: 2
---



### PowerShell Package and Module References
<br/>

You can add **Modules** and **Packages** as references to a script definition, to include code libraries in PS scripts.  
When you execute a script, references will be installed if necessary, and be ready for use in the user part of the script.
<br/>

**Modules:**  
These are high-level installation of packages from Microsoft’s PSGallery (https://www.powershellgallery.com/). **Invision** implements Install-Module and Import-Module commands for referenced Modules.
<br/>

**Packages:**  
These are low-level and use e.g. the default NuGet as a provider for code packages. 
You can configure providers in the app config file. **InVision** implements Install-Package command if necessary for referenced Packages.
<br/>

**UI:**  
References are added from the **PS Script Editor** in Invision designer.

<br/>

![Reference Documentation](https://profitbasedocs.blob.core.windows.net/images/powershell1.png "Reference Documentation")

<br/>

Source modes has 3 options:

-	References list - already referenced Modules and Packages,
-	Search PowerShell Module Gallery,
-	Search Packages.

Search modes show an edit field for search text. * is added to the end.


<br/>

![Reference Documentation](https://profitbasedocs.blob.core.windows.net/images/powershell2.png "Reference Documentation")

<br/>

When items are returned from the *search*, images show the state as:

- **‘Arrow down’** for reference in the open solution,
- **‘Green check’** for already referenced in this script.

The right section of the page displays details, version selection, and available commands.

<br/>

![Reference Documentation](https://profitbasedocs.blob.core.windows.net/images/powershell3.png "Reference Documentation")

<br/>

Commands are:

**Add**  
Adds a new reference with the selected/default version.

**Update**  
Updates existing references version.

**Remove**  
Delete reference.

