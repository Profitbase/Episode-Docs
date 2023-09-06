---
title: "Create Package Upgrade using Visual Studio"
metaKeys: "package upgrade"
folderOnly: "false"
pageIndex: 1
---

This topic describes how to create a Package Upgrade using Visual Studio.

### Project template and dotnet commands

<br/>

**Prerequisites:**

- Install the latest version of [Visual Studio 2019 or above](https://docs.microsoft.com/en-us/visualstudio/install/install-visual-studio?view=vs-2019)
- Make sure .NET 6 is installed

<br/>

### Install the Project Template

If this is the first time you create a Package Upgrade on your machine, you need to install the project template.

```
dotnet new -i Profitbase.Invision.PackageUpgrade.Project
```

<br/>

### Create the project

Use the following command to create a new project. Choose a suitable name for your project instead of 'MyPackageUpgrade'.

```
dotnet new Profitbase.Invision.PackageUpgrade.Project -n MyPackageUpgrade
```

You can also create the project directly from `File -> New -> Project` in Visual Studio

<br/>

### Implement the project

1. Open the .csproj-file using Visual Studio.
2. Follow the steps in the `README` file

<br/>
<br/>

**Note!**

> To show project templates that are installed using the CLI, the 'Show all .NET Core templates in the New project dialog' feature in Visual Studio must be enabled.
>
> Open the Options dialog, go to Tools -> Options. Then go to Environment -> Preview Features and select the preview feature named 'Show all .NET Core templates in the New project dialog'.



#### See Also

- [Step by Step Guide](create-package-upgrade-using-vs/upgrade-stepbystep.md)
