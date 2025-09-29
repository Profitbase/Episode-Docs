
# On-premise Installation

## Installation on Application Server

1. Make sure **.NET 4.8** is installed on the application server.
2. Set up an **Azure Service Bus subscription**.

    a) Ensure that port **443**, **5671** and **5672** are open on the application server to enable communication with Microsoft Azure (\*.servicebus.windows.net).

    b) Set up an Azure Service Bus **Topic**.

    - In the **Shared Access Policy**, enable **Manage**, **Send** and **Listen**

    - From the topic, copy the **Primary Connection String**. You will need it later when running the installation. It should be on the form _Endpoint=sb://yoursubscription.servicebus.windows.net/;SharedAccessKeyName=SendListen;SharedAccessKey=YOUR_KEY=;EntityPath=YOUR_TOPIC_

3. Make sure Powershell version v5.1 or higher is installed.

4. Make sure ASP.Net Core Hosting Bundle is installed.

5. Install **Profitbase Installation Manager 5.x.x.x.** If it does not already exist on the app server, you can download it from [here](https://download.profitbase.com/Installer/).

> [!NOTE]
> Update Profitbase Installation Manager
> Always make sure you have the latest Installation Manager before upgrading.

6. Run **Profitbase Installation Manager** to install the software and database (see instructions below). During the installation, you need to provide the **Azure Service Bus connection string** and **topic** from step **2b**.  

## Using Profitbase Installation Manager

### About

Profitbase Installation Manager installs InVision instances into sub folders of its own installation path. Already installed instances are upgraded using Profitbase Installation Manager.
The default installation path for the installation manager is

'''dos
C:\Program Files (x86)\Profitbase Installation Manager
'''

InVision instances will be installed in

```dos
[Installation Manager path]\InVision\[instance]
```

## Setting up a new InVision instance

1. Start the **Profitbase Installation Manager**

2. In the **Install new Instance** tab, press **Download and Install**

3. Configure the instance by configuring the following settings (see details below)

   - **Instance Name**
   - **Website Name**
   - **Domain**
   - **Database Server**
   - **Service User**
   - **Service User Password**
   - **Azure Service Bus connection string**
   - **Azure Service Bus topic**

4. Provide the **Azure Service Bus connection string** and **topic**. You can find the topic at the end of the Azure Service Bus connection string.

5. Press **Validate input**

6. Press **Install**  

## Instance settings

During the installation process, you need to configure the following settings:

**Instance Name**  
>The name of the InVision instance. The instance name must be unique within the organization. The instance name affects:
>
- The web site urls (for example http://mydomain.com/instancename)
- The name of the InVision database

**Website Name**  
>The IIS web site that the InVision web application will be created in. You can usually just use Default Web Site (which is the default value)

**Website domain**  
>The domain for the web site. This value should match the domain specified for the web site you have selected above.

**Database server**  
>The SQL Server instance name that the InVision database should be deployed to. The installer will deploy one database pr instance. The database will be named "pbInvision\_[instanceName]"

**Service user**  
>The name of the domain user that should run the AppPool and Windows Services (Data Flow Task Manager and Data Flow Task Worker). The Service user account requires special permissions. See the “Service User Accounts” section below.

**Service user password**  
>The password for the service user account.

**Azure Service Bus connection string**  
>On the form  

```json
Endpoint=sb://yoursubscription.servicebus.windows.net/;SharedAccessKeyName=SendListen;SharedAccessKey=YOUR_KEY=;EntityPath=YOUR_TOPIC
```

**Azure Service Bus Topic**  
>The name of the topic. Get it from the EntityPath token of the connection string.

## Default ports

> [!NOTE]
> The port numbers are incremented for each installed instance. The actual port used when installing an instance, is displayed in the Installation Manager.  

| Port Number | Description |
| :---------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 12311       | Used by the Data Flow **Dispatcher service** to accept job requests from the Data Flow Task Worker. (For example if the Worker invokes a Batch or Data Flow activity that requires load balancing). |
| 12310       | Used by the Data Flow Task **Worker service** to accept job requests from the Data Flow Task Manager                                                                                                |
| 12312       | Data Flow Scheduler                                                                                                                                                                             |

## Firewall settings

The following table describes the application services requiring internet access.  

| External endpoint                    | Port | Service Description                   |
| ------------------------------------ | ---- | ------------------------------------- |
| https://store.profitbase.com/api/v1/ | 443  | Download business modules             |
| https://download.profitbase.com      | 443  | Download new versions of the software |
| \*.servicebus.windows.net            | 443 | Command control traffic to Azure Service Bus  |
| \*.servicebus.windows.net            | 5671 | Azure Service Bus endpoint (AMQP)     |
| \*.servicebus.windows.net            | 5672 | Azure Service Bus endpoint (AMQP)     |

## Offline Install

- Make sure you download the latest version of Profitbase Installation Manager.
- Download the proper version of InVision from the URL below.

### Offline URLs

#### Profitbase Installation Manager

- Latest version of Profitbase Installation Manager
https://store.profitbase.com/api/v5/installationmanager/download/latest
- Information about the latest version
https://store.profitbase.com/api/v5/installationmanager/latest
- Get a list of all available versions
https://store.profitbase.com/api/v5/installationmanager/versions
- To get a specific version of Profitbase Installation Manager
https://store.profitbase.com/api/v5/installationmanager/{blobName}

### InVision

- Download latest version of InVision
https://store.profitbase.com/api/v5/systems/invision/download/latest
- Information about the latest version
https://store.profitbase.com/api/v5/systems/invision/current

## See Also

- [Ports and Firewall Settings](onpreminstallation/portsfirewall.md)  

- [Service User Accounts](onpreminstallation/serviceuseraccounts.md)  
  
- [System Requirements](../systemrequirements.md)

## Videos

- [Installation](../../../videos/gettingstarted/installation.md)
- [Upgrading of  the InVision Instance](https://profitbasedocs.blob.core.windows.net/videos/Installation%20and%20Setup%20-%20upgrading%20of%20%20the%20InVision%20instance.mp4)
