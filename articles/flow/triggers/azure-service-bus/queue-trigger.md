# Azure Service Bus Queue trigger

Configures the flow to automatically run by checking periodically for new messages in an [Azure Service Bus Queue](https://learn.microsoft.com/en-us/azure/service-bus-messaging/service-bus-queues-topics-subscriptions#queues).

![topic](https://profitbasedocs.blob.core.windows.net/flowimages/queue-trigger.png)

## Properties

| Name           | Type     | Description                                      |
|----------------|----------|--------------------------------------------------|
| Title          |  Optional | A descriptive label for the trigger configuration.|
| Connection     | Required | Azure Service Bus connection string used to authenticate and connect to the service. |
| Polling frequency| Required | Interval or schedule for how often the trigger checks for new messages in the topic. |
| Output data type | Optional | Specifies the format of the trigger's output data (e.g., JSON, XML). |
| Output variable name | Required | Name of the variable where the trigger’s output data will be stored. |
| Disabled       | Optional | Boolean value indicating whether the trigger is disabled (true/false). |
| Description    | Optional | Additional notes or comments about the trigger's purpose or configuration.  |

