# Track events and data, and raise alerts when action is needed

Organizations can use [Profitbase Flow](../../flow/flow.md) and [Profitbase InVision](../../invision/invision.md) to monitor, analyze and make data-driven decisions through live integrations with APIs, services, and databases. Business rules engines built using Flow will process information, update target systems and reports, and notify the right people, enabling timely and appropriate actions to be taken.

[Profitbase Flow](../../flow/flow.md) is used for building data integrations and business rules engines, while [Profitbase InVision](../../invision/invision.md) enables building data models and user interfaces. Profitbase Flow and InVision are fully integrated, and offers a seamless experience for building business process automation solutions.

### Example - Monitoring production line data
Rather than requiring workers to constantly sift through reports to check if tasks are on track and operations are within acceptable limits, we aim to notify them only when action is truly needed. This approach allows employees to focus on value-adding tasks instead of spending time analyzing Power BI reports.

In this example, we'll set up a Flow that automatically monitors production line data and sends email notifications when orders are at risk of missing delivery dates.

We'll assume that all relevant data is stored in a central repository or data platform (e.g., Microsoft Fabric, Snowflake, Databricks), as this is common for organizations that centralize operational data for analysis and reporting. If you don't have such a system in place, you can also use Profitbase to manage your operational data effectively.

A typical Flow for implementing this will do the following:

1) **Run on a schedule:** Use a a [Schedule trigger](../../flow/triggers/schedule-trigger.md) to make the Flow run automatically on a schedule, for example hourly or nightly. 
2) **Fetch production data:**  Execute a SQL query against the database that [returns the relevant production data](../../flow/actions/sql-server/get-entities.md), including the backlog, progress, estimated production time and delivery dates of items.
3) **Analyze the production data:** Use a [Function](../../flow/actions/built-in/function.md) for running the business logic for analyzing which production items are in danger of missing milestones or delivery dates. This typically involves calculating the remaining time until completion for each item, and flagging the items in danger of going overdue. Often, this data is already in the database, so step 4 is not always necessary.
4) **Update the database:** Write back the results of our analysis to the database so it can be displayed in reports.  
5) **Notify users:** Based on our analysis, notify users if action needs to be taken. We'll do this by sending an email with link(s) to relevant reports. 
