# Publish Event

Publishes an event to [Azure Event Hub](https://learn.microsoft.com/en-us/azure/event-hubs/event-hubs-features).

![img](/images/flow/aeh-publish.png)

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Title			   |  Optional | A descriptive label for the action.					|
| Connection       | Required  | Azure Event Hub connection used to authenticate and connect to the service. |
| Content		   | Required  | Specifies the variable containing the data to be sent. |
| Partition		   | Optional  | Specifies the ID of the partition from which the event are read. |