# Execution endpoints (HTTP endpoints)

A Flow can be executed as an HTTP API, which makes it easy to integrate into custom apps or scripts. This applies to all Flows except the ones with an [MCP tool trigger](../triggers/mcp/mcp-tool-trigger.md).  
In the Designer, you can find the available API endpoints of a Flow in the `Resources -> Flow Properties` window, or you can add an [HTTP trigger](../triggers/http-trigger.md) to the Flow and get them from the `Property panel` with the trigger selected.

> [!NOTE]
> To run a Flow by its HTTP endpoint, you must configure at least one [API key](../tenants/api-keys.md) at the tenant level.  

## Running Flows from 3rd party apps
[This article](running-flows/from-third-party-app.md) describes how to run Flow from 3rd party apps.