# Break data out of silos using automatic dataflows and integrations

[Profitbase Flow](../../flow/flow.md) offers extensive support for connectors and data adapters across various systems, including databases, ERP systems, email, collaboration tools, cloud Storage, files and many more

As data is updated in disparate systems by users or applications, Profitbase Flow can pick up these changes and automatically take action to synchronize the data or apply changes to other systems.

This is achieved by building Flows that:

1) Connects to, and reads data from one or more **source systems** through APIs such as HTTP (REST), databases, mail, and messaging services like Teams, Azure Service Bus and RabbitMQ.
2) Applies business logic to the data as a series of transformations, calculations, filtering, enrichments, or validations.
3) Connects to the **target systems** and applies changes by adding, updating or deleting data.
4) Optionally, notifies other services or users through tools such as Teams, Slack, mail or messaging services (Azure Service Bus, RabbitMQ, Apache Kafka, etc)

<br/>

![img](/images/cfo-platform/Flow-system-integration-pipeline.svg)
