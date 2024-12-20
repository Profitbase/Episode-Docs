# Data integration and transformation

[Profitbase Flow](../../flow/flow.md) offers extensive support for connectors and data adapters across various systems, including databases, ERP systems, email, collaboration tools, cloud storage, files and many more

As data is updated in disparate systems by users or applications, Profitbase Flow can pick up these changes and automatically take action to synchronize the data or apply changes to other systems.

Flows that support this process typically does the following:

1) Connects to, and reads data from one or more **source systems** through APIs such as HTTP (REST), databases, mail, and messaging services like Teams, Azure Service Bus and RabbitMQ.
2) Applies business logic to the data as a series of transformations, calculations, filtering, enrichments, or validations.
3) Connects to the **target systems** and applies changes accordingly by adding, updating or deleting data.
4) Optionally, notifies other services or users through tools such as Teams, Slack, mail or messaging services (Azure Service Bus, RabbitMQ, Apache Kafka, etc)

<br/>

<img style="height:350px" src="../../../images/cfo-platform/Flow-system-integration-pipeline.svg" alt="data integration">

<br/>
<br/>

### Example - Connect your ERP system and data platform for reporting
Let's look at an example of how an integration between your ERP system and Microsoft Fabric data platform can be set up using Profitbase Flow. We'll set up an automatic integration that continually pulls the general ledger from Visma Business NXT and synchronizes it to Microsoft Fabric for reporing in Power BI.