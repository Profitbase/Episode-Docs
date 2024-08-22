# Azure Service Bus Queue trigger

Configures the flow to automatically run by checking periodically for new messages in an [Azure Service Bus Queue](https://learn.microsoft.com/en-us/azure/service-bus-messaging/service-bus-queues-topics-subscriptions#queues).

![topic](https://profitbasedocs.blob.core.windows.net/flowimages/queue-trigger.png)



## Properties


| Name           | Type     | Description                                      |
|----------------|----------|--------------------------------------------------|
| Title          |          |                                                  |
| Connection     | Required | Connection name and string.                      |
| Polling frequency| Optional | Schedule configuration of the trigger.         |
| Output data type | Optional | Select the data type of the trigger output.    |
| Disabled       | Optional | Boolean value indicating whether the trigger is disabled (true/false). |
| Data variable name | Optional |                                              |
| Description    | Optional | Additional notes or comments about the trigger's purpose or configuration.  |

