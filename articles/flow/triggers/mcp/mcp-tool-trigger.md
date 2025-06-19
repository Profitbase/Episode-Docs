# MCP tool trigger

The `MCP tool trigger` exposes a Flow as a tool compatible with [MCP (Model Context Protocol)](https://modelcontextprotocol.io), making it accessible to LLMs.  
This means that, by adding the `MCP tool trigger` to a Flow, you enable AI agents to autonomously run Flows to complete tasks. 

![img](/images/flow/mcp-tool-trigger.png)  

**Example** ![img](../../../../images/strz.jpg)  
The example above illustrates a Flow that can be called by an AI agent because it has an `MCP tool trigger`. The AI agent runs the Flow as a tool through an MCP client and passes in information about the order to be placed.

<br/>

## Properties

| Name        | Type             | Description                               |
|-------------|------------------|-------------------------------------------|
| Title       | Optional         | A human-readable title for the tool that can be displayed to users. Note that it's up to the _MCP client_ to choose whether to display the title, or just the `Tool name`.    |
| Tool name   | Required         | The name of the tool exposed to the AI model. It is important to choose a clear, concise and descriptive name, making it easier for the AI model to reason about whether to use the tool or not. |
| Parameters  | Optional         | Specifies the arguments that the AI model must pass to the Flow. Make sure to use good parameter names to make it easier for the AI model to reason about which data to pass to the tool.  |
| Annotations | Optional         | **NOTE!** Annotations are hints about the tool. It is up to MCP clients whether to use them or not.<br/><br/>**Destructive**<br/>Specifies whether the tool may perform destructive updates to its environment. <br/><br/> **Idempotent**<br/>Specifies whether calling the tool repeatedly with the same arguments will have no additional effect on its environment.<br/><br/> **Read-only**<br/>Specifies whether this tool does not modify its environment. Read-only tools do not have side effects beyond computational resource usage. They don't create, update, or delete data in any system.<br/><br/> **Open world**<br/>Specifies whether this tool may interact with an "open world" of external entities. If true, the tool may interact with an unpredictable or dynamic set of entities, like web search.|
| Default arguments | Optional        | Specifies default arguments that is used when testing the Flow, or if no data is passed to the Flow from an AI model.  |
| Output variable name | Required     | Specifies the name of the object returned from the trigger, which represents the data passed to the Flow from the AI model, for example `customerInfo` or `projectInfo`. |

<br/>

## Returns
The MCP tool trigger returns (outputs) the object defined by its `Parameters` property (if any).