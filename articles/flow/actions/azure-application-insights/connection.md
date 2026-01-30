# Azure Application Insights Connection

When adding an Azure Application Insights action, select an [existing connection](../../workspaces/workspace-objects.md) or create a new one.

<br/>

## Connection properties

| Name | Description |
|-------|-------------|
| Name | A custom label for this connection. This name will appear when selecting the connection in a Flow action. |
| Connection string | The full connection string for Azure Application Insights. Includes instrumentation key, ingestion endpoint, and live endpoint. |

<br/>

## Connection String

Use a connection string to send telemetry from your apps and flows to Azure Application Insights. Connection strings define where telemetry is sent (ingestion endpoint) and which resource receives it.

- Typical format:
  `InstrumentationKey=<GUID>;IngestionEndpoint=https://<region>.in.applicationinsights.azure.com/;LiveEndpoint=https://<region>.live.applicationinsights.azure.com/`

1. Open your Application Insights resource in the [Azure Portal](https://portal.azure.com).
2. Copy the value from Connection string (usually under Overview or Properties).
