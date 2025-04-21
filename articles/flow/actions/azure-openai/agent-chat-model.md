# Azure OpenAI chat model

Defines an Azure OpenAI chat model that an AI Agent, for example the [Tools AI agent](../agents/tools-ai-agent.md), can use to reason about what to do.

The example below illustrates using the [Tools AI Agent](../agents/tools-ai-agent.md) to retrieve a list of all blobs in an Azure Storage container and return the result as a JSON string. We then convert the returned JSON string to a business object containing the list of files so we can use later in the Flow.  
The Tools AI Agent uses the chat model to reason about how to perform the task given the tools provided to it. The [Azure Blob Storage Agent Tool](../azure-blob-storage/agent-tool.md)  supports reading information about blobs in an Azure Storage container, so the tool will be used by the agent to complete the task.  

The following prompts are used:  

**System prompt**  
```txt
You are an agent that will use the tools provided to you to perform the tasks requested by the user.  
If you cannot perform the task, stop without any retries.
```

**User prompt**  
```txt
List the names of all blobs found in the container.
Format the response as a JSON object on the following format:  

{
   "blobNames": []
}

Do NOT wrap the response in Markdown annotation.
```


![img](/images/flow/agent-chat-model.png)

<br/>


## Properties

| Name                  | Type      | Description |
|-----------------------|-----------|-------------|
| Title                 | Optional  | The title of the model. |
| Connection            | Required  | Defines the [connection](azure-openai-connection.md) to **Azure OpenAI**. |
| Deployment Name       | Required  | Specifies the model deployment name, which corresponds to **name** (not the model id) of the deployed model in Azure Azure AI Foundry (can also be found in the Azure portal). In [Azure AI Foundry](https://ai.azure.com), the deployment name can be found in the Deployments screen as shown [below](#deployment-name).   |
| Temperature       | Optional  |Temperature in models controls the randomness and creativity of the generated responses. Lower temperatures (e.g., 0.2) produce more focused, predictable text, ideal for tasks that require precision. Higher temperatures (e.g., 1.5) increase creativity and variability, but may risk generating less coherent or relevant content, making it important to adjust based on your desired outcome. |
| Max Tokens | Optional | Sets a limit on the number of tokens (words, characters, or pieces of text) in the model’s response. |

<br/>

#### Deployment name
To find the Deployment name, look in the `Deployments` screen in [Azure AI Foundry](https://ai.azure.com).  

![img](/images/flow/azure-openai-deploymentname.png)