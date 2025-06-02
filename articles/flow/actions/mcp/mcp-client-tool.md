# MCP client tool

Defines an MCP Client that enables an AI agent to use tools exposed by an MCP Server.

![img](/images/flow/mcp-client-tool.png)

**Example** ![img](../../../../images/strz.jpg)  
The example above illustrates a Flow that, on a schedule, runs an AI agent to check the production line status and notify supervisors if action needs to be taken. To query the Azure SQL–based production line system, the agent uses an Azure SQL MCP server, and then uses a Microsoft Teams MCP server to send notifications to users.
<br/>

## Properties

| Name       | Type           | Description                                |
|------------|----------------|--------------------------------------------|
| Connection | Required       | The [connection](./mcp-client-connection.md) to the MCP server.          |
| Tools      | Optional       | The tools to expose to the [Tools AI Agent](../agents/tools-ai-agent.md). If _no_ tools are selected, _all_ available tools from the MCP server is exposed to the agent.<br/> **NOTE!**<br/>LLMs (which act as the AI agent's brain) can get confused if too many tools are available. Try to keep the number of tools they can choose from as small as possible.  |
