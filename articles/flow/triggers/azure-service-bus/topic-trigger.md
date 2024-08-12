# Azure Service Bus Topic trigger

Configures the flow to automatically run by checking periodically for new messages in an [Azure Service Bus topic](https://learn.microsoft.com/en-us/azure/service-bus-messaging/service-bus-queues-topics-subscriptions#topics-and-subscriptions). 

![topic](https://profitbasedocs.blob.core.windows.net/flowimages/topic-trigger.png)



## Properties


| Name           | Type     | Description                                      |
|----------------|----------|--------------------------------------------------|
| Title          |          |                                                  |
| Connection     | Required | Connection name and string.                      |
| Subscribtion name| Optional | Name of the topic subscribtion.                |
| Polling frequency| Optional | Schedule configuration of the trigger.         |
| Output data type | Optional | Select the data type of the trigger output.    |
| Disabled       | Optional |                                                  |
| Data variable name | Optional |                                              |
| Description    | Optional |                                                  |

