
# System Requirements

Hardware should be scaled based on expected load. The figures below are general minimum requirements. It’s technically possible to run everything on one server (Application and Database), but not recommended for performance and stability reasons.


## Application Server / VM  

- Windows Server 2016 or higher
- .NET Framework 4.8 (If you need to install the Designer on the Application Server)
- [ASP.NET Core Runtime 8.x.x Windows Hosting Bundle](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- PowerShell 7

##### Minimum hardware requirements for application server

- IIS installed (see list of enabled features below)
- CPU: 4 Cores
- Memory: 8 GB
- Disk Space: 50 GB

<br/>

## SQL Server minimum requirements

- SQL Server 2022 Standard or higher
- CPU: 4 Cores (Faster is better)
- Memory: 16 GB
- Disk Space: 500 GB

- (For hybrid deployments: Azure SQL Database)

## Infrastructure

- Azure Service Bus subscription

<br/>

<br/>

## Client (End user)

- Microsoft Edge, Chrome, Firefox, Opera, Safari

<br/>

## Developer

- Windows 10, Windows Server 2016 or higher
- .NET Framework 4.8


## IIS Required Features
<br/>

**IIS Enabled Features**
![IIS](https://profitbasedocs.blob.core.windows.net/images/req1.jpg)
<br/>

![IIS](https://profitbasedocs.blob.core.windows.net/images/req2.jpg)

<br/>

## See Also  
* [System Description](systemrequirements/systemdescription.md)
  
<br/>