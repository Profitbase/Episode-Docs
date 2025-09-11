
# Define Package

When defining a Package, you should consider all the following points.
<br/>

1.	[Version](#1-version)
2. [Package Type](#2-package-type)
3. [Documentation](#3-define-package-documentation-link)
4.	[Post Deployment Action](#4-post-deployment-action)
5.	[Package data](#5-package-data)
6.	[Configuration options](#6-configuration-options)  
     - Package properties
     - Form
7.	[Work Process integration](#7-work-process-integration)  
   a.  [Data Flows](#7a)  
   b.  [Upgrade Scripts](#7b)
8.	[Dependencies](#8-dependencies)


<br/>


## 1. Version

If you want to make the Package deployable and upgradable, you need to bump the version before making an official release. To make an official release of the Package, press the “Create Package” button in the toolbar and choose “Release” as Deployment mode.

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/pack_version.png)

<br/>

## 2. Package Type

You should always specify the Package Type, making it easy for users to find and upgrade packages using the Package Management screen.  
Specifying the Package Type does not have any other impact than making it easier for users to find what they're looking for (Products or Libraries) when deploying or upgrading packages. 

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/packType1.png)

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/packType2.png)

<br/>

## 3. Define Package Documentation link

You can specify the Package Documentation link, making it easy for users to find useful informations.  

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/PackDoc%20(3).png)

<br/>

## 4. Post Deployment Action

If you need to run a Data Flow after a Package has been deployed to do some initialization or any other type of work, specify the Data Flow you want to run as the Post Deployment Action. The Data Flow will run as the last step of the deployment process.

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/package_postDepAct.png)

<br/>

## 5. Package Data

By default, only metadata configuration is included when exporting a Package using the Create Package button. This means that when the Package is deployed, it will not contain any information such as sample data, settings, assumptions, etc. To deploy data with the Package, you must add the relevant tables to the Package data list. This makes it much quicker for a customer to get started using your Package.

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/pack_data.png)

<br/>

## 6. Configuration options

The package may be configured using either 'Package properties' or a 'Form'.

You can configure the package with custom properties to handle values and logic. 'Package properties' is a simple option, and does not allow for much logic - to handle dynamic and complex logic, you will need to use a 'Form' to configure properties and logic.

- [Package Properties](./configuration-options/package-properties.md)
- [Form](./configuration-options/form.md)


![pic](https://profitbasedocs.blob.core.windows.net/images/package-configuration-options-form.png)


<br/>


## 7. Work Process Integration

<br/>

<a id="7a"></a>**7.a Work Process integration – Data Flows**


When a Package is used in Work Processes, such as budgeting and forecasting, you often need to run business logic when the Work Process Version transitions between states (Deployed, Open, Closed, Deleted). Under the Work Process tab, you can specify Data Flows to run after Work Process Versions containing this Package have entered the Deployed, Open, Closed, or Deleted state.

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/pack_wpInt.png)

<br/>



<a id="7b"></a>**7.b Work Process integration – Upgrade Scripts**

Because Work Process Versions are isolated from each other, you can have different versions of the same Package in different Work Process Versions. However, if you upgrade a Package to a new version, and you create a new Work Process Version containing the **new version** of the Package but want to pull in data from a Work Process Version using an **older version** of the Package, you may get in trouble because the old version is missing data that the new version of the Package requires.

To fix this issue, you must provide a set of SQL scripts which acts as adapters between old and newer versions of a Package.

To use this feature, do the following:

1. As a direct child of the Package, create a folder named UPDATE_SCRIPTS
2. In the UPDATE_SCRIPTS folder, create one or more SQL Scripts to execute. 


<br/>

The following applies for the scripts:

1. The scripts are executed after a Work Process Version containing the Package has been deployed. 
2. They are executed in the order they listed in the folder.
3. SQL parameters @FromVersion and @ToVersion are passed to the scripts when executed.  
   @FromVersion specifies the version of the Package in the source Work Process Version.  
   @ToVersion specifies the version of the current Package.



<br/>

## 8. Dependencies

If a Package is dependent upon another Package, you need to add the dependency to the “Package Dependencies” list. By defining dependencies, the system will automatically install or update dependencies when the Package itself is installed or updated to new versions. 


> [!NOTE]
>  You need to register immediate dependencies, meaning you don’t need to register dependencies of dependencies. When exporting the Package, the system will automatically examine all dependencies and their dependencies, recursively.


## Videos

* [Packages](../../../../videos/packages.md)
* [Define Package](https://profitbasedocs.blob.core.windows.net/videos/Packages%20-%20Define%20Package.mp4)
