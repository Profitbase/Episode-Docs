### Choosing Tools
When building AI agents, it's best practice to keep their area of responsibility as narrow as possible. While this may seem counterintuitive to the concept of agents, giving an agent too many tools to choose from can negatively affect its accuracy when making decisions and selecting tools. It also increases token usage, and consequently, cost.  

<br/>

### Tools usage
You can choose between two modes for how the agent can use tools: `Tool calling` or `Code mode`.
The mode you should choose depends on the complexity of the task, cost considerations, and the amount of data involved.
Both options are discussed below.  

> [!NOTE]
> If you enable `Code mode` in the Tools usage property, be aware that not all AI models can use this mode reliably. In general, only more advanced models—such as GPT 5.2 or later, Claude Opus, and Sonnet 4.5 or later—produce consistent results.
> Smaller models, including the GPT 5 mini series, DeepSeek, and Kimi2 Thinking, currently do not support Code mode reliably. This may change over time, so it is recommended to test different models to see what works in practice.

#### Tool calling
In this mode, the AI agent uses traditional tool calling, where each tool is described to the LLM using a JSON schema. When the LLM reasons about what to do, it evaluates the available tools, selects the ones it needs, and calls them in sequence.  

If multiple tools are required to complete a task, they are invoked independently, one by one. When a tool returns data, the result is added to the context and included in all subsequent requests to the LLM. Depending on the number of tools and the amount of data returned, this can have a noticeable impact on cost and performance, as the LLM must process the full context on every request.     

Pros: 
- Smaller and cheaper models (such as GPT mini or DeepSeek) can be used for simpler tasks, reducing cost.

Cons:
- The number of tools an agent can reliably use is limited. A common rule of thumb is to keep the total below 20.  
- Data returned from tools is added to the LLM context and sent with every subsequent request, which can significantly increase token usage and cost.  
- Tool definitions are included in every request, even when most tools are not used, leading to unnecessary token consumption.  

#### Code mode
n this mode, the agent reasons about the task and inspects the APIs available through its tools to determine whether it can solve the task by writing and executing code.  

Instead of calling each tool individually, the agent generates a single piece of code that uses all required tools and then executes it. For complex, multi-step tasks, this means the agent only needs to discover the APIs, write the code, and run it — typically requiring only two or three calls rather than one per tool.  

Because the code is executed in isolation, data returned from intermediary tool calls is not added to the context. This significantly reduces token usage in scenarios where large amounts of intermediate data would otherwise be passed between steps.  

Pros:
- More predictable behavior when working with a large number of tools
- For complex, multi-step tasks that require passing data between tools, code mode generally performs better and consumes considerably fewer tokens  

Cons:  
- Only large models with strong reasoning and coding capabilities can be used in code mode


#### When to use Tool calling vs Code mode
There is no strict boundary between when tool calling or code mode is the better choice. However, the following guidelines can help:

Use tool calling when:  
- Only a small number of tools are available to the agent
- The tools do not pass large amounts of data between them (for example files, images, or data sets)
- The task does not require many tool calls

Use code mode when:
- A large number of tools are available, typically in more complex workflows
- The tools (may) need to exchange large amounts of data to reach the goal — for example when fetching and analysing the contents of files, images, or large data sets 
