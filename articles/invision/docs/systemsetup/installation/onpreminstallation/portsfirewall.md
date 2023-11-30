
# Ports and Firewall Settings


## Default ports
<br/>


> [!NOTE]
> The port numbers are incremented for each installed instance. The actual port used when installing an instance, is displayed in the Installation Manager. 
<br/>

| Port Number | Description                                                                                                                                                                                     |
| :---------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 12311       | Used by the Data Flow **Dispatcher service** to accept job requests from the Data Flow Task Worker. (For example if the Worker invokes a Batch or Data Flow activity that requires load balancing). |
| 12310       | Used by the Data Flow Task **Worker service** to accept job requests from the Data Flow Task Manager                                                                                                |
| 12312       | Data Flow Scheduler                                                                                                                                                                             |

<br/>

## Firewall settings

The following table describes the application services requiring internet access.
<br/>


| External endpoint                    | Port | Service Description                   |
| ------------------------------------ | ---- | ------------------------------------- |
| https://store.profitbase.com/api/v1/ | 443  | Download business modules             |
| https://download.profitbase.com      | 443  | Download new versions of the software |
| \*.servicebus.windows.net            | 5671 | Azure Service Bus endpoint (AMQP)     |
| \*.servicebus.windows.net            | 5672 | Azure Service Bus endpoint (AMQP)     |



<br/>

## Videos 
* [Installation](../../../../videos/gettingstarted/installation.md)