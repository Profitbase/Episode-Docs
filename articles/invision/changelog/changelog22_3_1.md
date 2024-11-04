
# InVision 2022.3 change log - part 1

<br/>

**2022.3** brings many new features and enhancements to our low-code platform. A major addition is the ability to define extensions for Packages. That enables Profitbase and partners to develop and distribute add-ons to products. You can also upgrade Packages in multiple Solutions in one go, making it much quicker to upgrade customers to new version of Planner, Risk and Consolidation.
<br/>

## New Features & fixes

<br/>

### Access Control

<br/>

#### SYS_ObjectPermissions

The new SYS_ObjectPermissions database view enables Solution Developers to write a SQL query to check if a user has access to a Workbook or Workbook Page. 

> [!NOTE]
> that the UserUID is the id of the user identity in the InVision access control system, usually a GUID. It is NOT the user name, for example, name@corp.com.


```
SELECT HasAccess FROM SYS_ObjectPermissions WHERE UserUID = 'user object id' AND ObjectID = 'workbook or workbook page id'
```

<br/>

#### New Access Control APIs in macros

You can now check if a user has access to Workbooks or Workbook Pages using C# macros. The main difference between using the SYS_ObjectPermissions and the macro APIs is that you can use the Workbook and Page names instead of the ids when querying for user access.

```
public async Task<string> GetQuery()
{
    var userHasAccess = await this.AccessControlService.HasWorkbookAccess(this.Context.GetUserUniqueId(), "Name of Workbook");
    // your code
}
```

[Read more here.](../docs/macros/writingmacros/macroexpansionprovider/accesscontrolservice.md)

<br/>

### PowerShell

<br/>

#### Isolation of PowerShell execution context

That fixes the assembly loading conflict between PowerShell modules using the same .NET assemblies or NuGet packages as the InVision platform.

<br/>

#### You no longer need to pass in pbRunContext to PowerShell APIs

You no longer need to pass in pbRunContext to Profitbase PowerShell APIs. The current APIs accepting pbRunContext will still work, but they will be removed in a future version. You should make it a priority to switch to using the new APIs.

<br/>

**Before:**

```
$bytes = [Profitbase.IO.FileStorage]::ReadAllBytes($PbRunContext, $storageName, $fileName)
```

**After:**

```
$bytes = [Profitbase.IO.FileStorage]::ReadAllBytes($storageName, $fileName)
```

<br/>

#### File Storage API

We have added PowerShell APIs for File Storage. The API enables you to get the file information, read and delete files from File Storages using PowerShell.

<br/>

```
# Get information about file(s) in the File Storage
$query = "DepartmentID = \"${departmentId}\" && Category = \"${catId}\""
$fileInfos = [Profitbase.IO.FileStorage]::GetFileInfos($storageName, $query)

foreach($fileInfo in $fileInfos)
{
       # Read a file
       $bytes = [Profitbase.IO.FileStorage]::ReadAllBytes($storageName, $fileInfo.FileName)
       Write-Output $fileInfo.FileName
       Write-Output $fileInfo.ContextJson
       Write-Output $fileInfo.MimeType
       Write-Output $fileInfo.FileReferenceId
}

# Delete a file
[Profitbase.IO.FileStorage]::DeleteFile($storageName, $fileName)
```

<br/>

### Packages

<br/>

#### Package Manager displays if a Package has dependencies with available upgrades

You can now easily spot if one of the installed Packages has dependencies with available upgrades. That usually happens when a dependency has a patch release.

<br/>

#### Package Extensions

We have added support for Package Extensions. That means that developers can create Packages which has the role of extending Products or Libraries. Installing an Extension requires that its dependencies are pre-installed before the extension can be installed. If an Extension extends more than one Product Package, at least one of the Product Packages must be pre-installed.

<br/>

#### Better overview of dependencies and extensions

Primarily it is a developer feature. We now provide a more detailed overview of dependencies and extensions in the Package Upgrade interface. This feature lists the dependency and extension hierarchy of a Package so you can detect possible version conflicts between packages.

<br/>

#### Upgrade Packages in multiple Solutions

When upgrading a Package, you can apply the upgrade to multiple Solutions at the same time. Earlier, upgrades would only be applied to Packages in Work Process Blueprint Solutions. You can now apply upgrades to Versioned Solutions that are in the Deployed or Open state.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/chlog223_1.png)

<br/>

#### Package documentation

We have added support for providing links to Package documentation and upgrade notes. Users can view the docs from the Package installation or upgrade screens.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/chlog223_2.png)

<br/>

### File Storage

<br/>

#### New events

The **Upload Completed** event is raised when a file has been uploaded. That enables processing a file immediately after it has been uploaded.

The **File Deleted** event is raised when a file has been deleted by the user. It is NOT raised if a file is deleted by the backend, for example, using PowerShell.

<br/>

#### Bug fix

Fixed bug where file dialog appears behind the dialog window.

<br/>

[More New Features & fixes in part two](changelog22_3_2.md)

<br/>

### See Also

- [Change Log 2024.4](changelog24_4.md)
- [Change Log 2024.3](changelog24_3.md)
- [Change Log 2024.2](changelog24_2.md)
- [Change Log 2024.1](changelog24_1.md)
- [Change Log 2023.7](changelog23_7.md)
- [Change Log 2023.6](changelog23_6.md)
- [Change Log 2023.5](changelog23_5.md)
- [Change Log 2023.4](changelog23_4.md)
- [Change Log 2023.3](changelog23_3.md)
- [Change Log 2023.2](changelog23_2.md)
- [Change Log 2023.1](changelog23_1.md)
- [Change Log 2022.5](changelog22_5.md)
- [Change Log 2022.4](changelog22_4.md)
- [Change Log 2022.3 pt 2](changelog22_3_2.md)
- [Change Log 2022.3 pt 1](changelog22_3_1.md)
- [Change Log 2022.2](changelog22_2.md)
- [Change Log 5.2](changelog52.md)
- [Change Log 5.1](changelog51.md)
- [Change Log 5.0](changelog5.md)
- [Change Log 4.1](changelog41.md)
- [Change Log 4.0](changelog40.md)
