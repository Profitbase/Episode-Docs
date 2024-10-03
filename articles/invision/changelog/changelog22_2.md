
# InVision 2022.2 change log

<br/>

This release of InVision mainly focuses on improvements to deploying and upgrading packages, and improvements to working with dimensions. It also contains a number of other fixes and improvements to existing features.

## New Features

<br/>

### Packages

<br/>

#### Upgrade packages in multiple (versioned) Solutions

We now support upgrading Packages in one or more versioned Solutions. Previously, only Packages in non-versioned Solutions were upgraded, but administrators are now given the option to upgrade Packages in versioned Solutions if the version status is either Deployed or Open. That means you can patch a version while it’s in production without creating a new version to get the fix.

<br/>

#### Support for floating dependency resolution

Support for floating dependency resolution of package dependencies means that package authors have greater control over which dependencies of a Package are installed or updated. All Packages have a major.minor.patch version, for example, 2.0.1.

Floating dependency resolution means that the dependency version can be defined as 2._._, which means “install the latest v2 release of the dependency”. Likewise, _._.\*, means “install the latest version of the dependency”.

As a package author, it means that, you can publish updates to dependencies without having to republish the main package but still have the latest dependencies installed when the main package is installed.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/chLog22_2.png)

Choose a dependency resolution rule to specify which version of the dependency is installed with the Package.

<br/>

#### Backups of Solutions are automatically deleted

Backups of Solutions taken during Package upgrades are now automatically deleted if the upgrade is successful. That automatically frees up disk space without any intervention from system administrators.

<br/>

#### Support for running post-upgrade Dataflow

This feature enables running a Dataflow after a Package has been upgraded.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/chLog22_2_2.png)

<br/>

### Dimension editor

<br/>

- Support for deleting all contents in a dimension. This is often useful when you import data to a dimension for the first time and you realize that your source data is incorrect, so you need to do a complete re-import.
- We added an extra “+” button to each dimension member, making it quicker to add multiple child members without having to use the context menu.
- Fixed issue [#517](https://support.profitbase.com/platform/invision-beta/-/issues/517). Create dimension member, change id and move a sub-hierarchy to its child collection.
- Fixed issue [#519](https://support.profitbase.com/platform/invision-beta/-/issues/519). Issue with drag/dropping to node while the node is being auto expanded by the system.

<br/>

### Dimension configuration

- Added support for running a Dataflow after a dimension has been published.
- Added support for running a Dataflow after a dimension has been published **to**.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/chLog22_2_3.png)

<br/>

### Work Process

<br/>

- During version deployment, dependencies between packages in the same Solution are used to determine the order of package deployment and enable custom packages/extensions to reference objects in Profitbase packages (such as Planner).

<br/>

### Workbook

<br/>

- Fixed issue [#442](https://support.profitbase.com/platform/invision-beta/-/issues/442) Copy/paste issue from spreadsheets in popups.
- Fixed dialog window resizing issue when an iframe is displayed.

<br/>

### Forms

<br/>

- Support for **async** DataChangedEventHandlers. This enables async code, such as network calls, to run when a data bound property is updated by the user.

<br/>

### Homepage

<br/>

- Fixed tile image max size so that oversized custom images align with the standard design.

<br/>

### Macros

<br/>

We added an API for access control so that Access Group membership of the currently active user can be obtained when running macros.
The **MacroExpansionProvier.AccessControlService** provides an API against a small subset of the InVision access control system.

<br/>

#### Methods

`Task<bool> IsMemberOfAccessGroupAsync(string identityId, string accessGroupName)`

<br/>

**Example**

This example shows how to check whether the current user is a member of the “Admins” Access Group. 

> [!NOTE]
>  We’re using Context.GetUserUniqueId() to get the id of the current user.
<br/>

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

#### Accessibility

- High contrast theme image picker is now working as expected, so you can easily pick images for your high contrast theme.
  <br/>

#### Misc

- Fix issue [#542](https://support.profitbase.com/platform/invision-beta/-/issues/542) Spreadsheet dropdown column object references were not dependency resolved the @Object[…] directive was used.
- Platform version, Build number and Package info (if applicable) is displayed in the Workbook Options dialog.
- Platform version, Server and Desktop Build number is displayed in the Desktop Application Status Bar.
- Build and platform version is displayed in error dialogs.

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/chLog22_2_4.png)

View the Platform, Build and optionally the Package version of the Workbook in the Options dialog.

<br/>

#### Platform

- InVision 2022.2 runs on .NET 6.
- All communication between application services is now using Azure Service Bus or RabbitMQ.
- Added support for **SYS_AccessGroups** SYS view. [Read more here](../docs/systemviews.md).

<br/>

#### Breaking changes

- Linked Fact and Dimensions (from Studio) is entirely removed from the platform (metadata and data is removed during the platform upgrade).
- OData feature is removed from the platform.
- The table pbSimSolutionLangText has been removed.

<br/>

### Installing InVision 2022.2

<br/>

To install InVision 2022.2 or upgrade to 2022.2, you need to use version **5.3 of the installation manager**.

<br/>

### Upgrading to InVision 2022.2

1. To upgrade to 2022.2, you need to use version **5.3 of the installation manager**.
2. Run the UpgradeDatastore.ps1 script:

3. **Download** the UpgradeDatastore file below.
4. **Rename** it to .zip and extract the content. (The blog platform does not allow uploading .ps1 of .zip files directly)
5. **Edit** the **UpgradeDatastore1.ps1** file
6. Change \$instanceToUpgrade to the name of the InVision instance you want to upgrade. If you have only one instance, or you want to upgrade all instances, set this value to **“All”**.
7. Change \$pathToDatastoreJson to the path where Datastore.json is located. This is usually **“C:\Program Files (x86)\Profitbase Installation Manager\Scripts\DataStore.json”**.
8. Change \$pathToInstanceTemplate to the path where instancetemplate.json is located. This is usually **“C:\Program Files (x86)\Profitbase Installation Manager\Scripts\instancetemplate.json”**.
9. **Run** UpgradeDatastore.ps1

<br/>

- [Here](https://profitbasedocs.blob.core.windows.net/documents/UpgradeDatastore-1.docx) you will find **pdf** with the **UpgradeDatastore-1**.

<br/>

### See Also

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
- [Change Log 2022.1](changelog22_1.md)
- [Change Log 5.2](changelog52.md)
- [Change Log 5.1](changelog51.md)
- [Change Log 5.0](changelog5.md)
- [Change Log 4.1](changelog41.md)
- [Change Log 4.0](changelog40.md)
