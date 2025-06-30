# Tools AI Agent

Defines an AI Agent that can use tools to perform actions, for example fetching data or calling APIs.

The example below shows an agent that reads all Word documents in a OneDrive folder, summarizes them, and emails the summaries along with the original documents as attachments. The following prompts are used:  

**System prompt**  
```txt
You are an agent that will use the tools provided to you to perform the tasks requested by the user.  
If you cannot perform the task, stop without any retries.
```

**User prompt**  
```txt
From OneDrive, get all Word (.docx) documents in the 'Work' folder.
For each document, get the file and create a summary.
Send an email from luke.skywalker@rebellion.com to darth.vader@empire.com that contains all the summaries.  
Use the subject: 'Summary'.
Include all the Word documents as attachments to the email.
```

![img](/images/flow/tools-agent-example1.png)

<br/>

## Properties
| Name            | Type         | Description                         |
|-----------------|--------------|-------------------------------------|
| System prompt   | Required     | The instruction given at the start of a conversation that sets the behavior, tone, and goals for the agent. It acts like a guide or personality primer, telling the chat model how it should respond (e.g., formal vs. casual), what role it should play (e.g., teacher, assistant, coder) and optionally what stategy you want it to prefer for decision making.  |
| User prompt     | Required     | This is the actual task that the agent is given, for example "Summarize all Word documents in my OneDrive folder named 'Work', and send the summarization to my-email@corp.com."  |
| Chat model      | Required     | The chat model accepts a set of instructions, reasons about _how_ to solve the task and utilizes tools to achive the final outcome. |
| Tools           | Required     | One or more tools that the agent to use to perform the tasks identified by the chat model. Tools the agent can use includes: <br/> [Azure Blob Storage Agent Tool](../azure-blob-storage/agent-tool.md) <br/> [OneDrive Agent Tool](../onedrive/agent-tool.md) <br/> [Outlook Agent Tool](../microsoft-365-outlook/agent-tool.md) <br/> [Markdown Agent Tool](../markdown/agent-tool.md)<br/>[MCP client tool](../mcp/mcp-client-tool.md)  | 
| Memory          | Optional     |          |

### Choosing a chat model
When choosing a chat model, it is important to choose a chat model that is capable of using tools. Not all chat models can use tools, and there's currently no official list of which chat models supports tool calling. You simply have to read the documentation for each LLM to determine whether tool / function calling is supported. A list of known LLMs with tool/function calling capabilities includes (but not limited to):  
- OpenAI models: gpt-4,gpt-4o, gpt-4o-mini
- Mistral AI models
- Anthropic models: Claude 3.x Sonnet, Clause 3 Opus
- Meta Llama 2 and 3 models
- Google Gemini models


### Choosing Tools
When building AI agents, it's best practice to keep their area of responsibility as narrow as possible. While this may seem counterintuitive to the concept of agents, giving an agent too many tools to choose from can negatively affect its accuracy when making decisions and selecting tools. It also increases token usage, and consequently, cost.  

