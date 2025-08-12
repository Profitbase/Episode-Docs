

# Streaming chat completion

The **Streaming chat completion** action streams the response from an [Azure AI Foundry](https://ai.azure.com/) chat model one message at a time, until the response is complete.

You will typically use this action to build backends for chat clients.

![img](/images/flow/azure-openai-streaming-chat-completion.png)

**Example** ![img](../../../../images/strz.jpg)  
The example above shows a Flow that provides chat completions to a chat client. We're using [PostgreSQL vector search](../postgresql/vector-search.md) to enable RAG, and SQL Server to store and retrieve the chat history so that users can ask follow-up questions.

<br/>

## Properties

| Name                  | Type      | Description |
|-----------------------|-----------|-------------|
| Title             | Optional  | The title of the action. |
| Connection        | Required  | Defines the [connection](azure-ai-connection.md) to an **Azure AI Foundry** resource. |
| Model             | Required  | Specifies the model deployment name, which corresponds to the **Name** (not the model id) of the deployed model in [Azure AI Foundry](https://ai.azure.com) ([see below](#model)). In the Azure Portal, the deployment name can be found under **Resource Management** > **Model Deployments**. |
| User Prompt       | Required  | The input message from the user, which the model processes to generate a response. |
| System Prompt     | Optional  | A system-level instruction that guides the model’s behavior and response style. |
| History           | Optional  | A record of past interactions that provides context to the conversation, helping the model maintain continuity. |
| Context           | Optional  | Typically used for RAG, and provides additional information or domain-specific knowledge to the chat model so it can make more accurate responses. The input can be a string (text) or a vector search result, such as the result from the [PostgreSQL Vector Search](../postgresql/vector-search.md) action. |
| Prompt template   | Optional  | Defines the structure of the prompt sent to the model. The system replaces the placeholders @@context and @@userPrompt with the relevant information. |
| Temperature       | Optional  |Temperature in models controls the randomness and creativity of the generated responses. Lower temperatures (e.g., 0.2) produce more focused, predictable text, ideal for tasks that require precision. Higher temperatures (e.g., 1.5) increase creativity and variability, but may risk generating less coherent or relevant content, making it important to adjust based on your desired outcome.  The default is 0.7 if nothing is defined by the user.|
| Max Completion Tokens | Optional | Sets a limit on the number of tokens (words, characters, or pieces of text) in the model’s response. |
| Result Variable Name | Optional | Stores the generated AI response. Default: "response". |
| Description       | Optional  | Additional details or notes regarding the chat completion setup. |

<br/>

#### Model
To find the Model deployment name, look in `Models + Endpoints` screen in [Azure AI Foundry](https://ai.azure.com).    

![img](/images/flow/azure-ai-foundry-deploymentname.png)

<br/>

[!INCLUDE [](./__videos.md)]