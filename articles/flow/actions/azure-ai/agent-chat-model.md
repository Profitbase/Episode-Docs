# Azure AI chat model

Defines an Azure AI (OpenAI or Foundry) chat model that an AI Agent, for example the [Tools AI agent](../agents/tools-ai-agent.md), can use to reason about what to do.

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
| Connection            | Required  | Defines the [connection](azure-ai-connection.md) to **Azure AI Foundry** resource. |
| Model                 | Required  | Specifies the model deployment name, which corresponds to the **Name** (not the model id) of the deployed model in [Azure AI Foundry](https://ai.azure.com) See [below](#models--endpoints). |
| Temperature       | Optional  |Temperature in models controls the randomness and creativity of the generated responses. Lower temperatures (e.g., 0.2) produce more focused, predictable text, ideal for tasks that require precision. Higher temperatures (e.g., 1.5) increase creativity and variability, but may risk generating less coherent or relevant content, making it important to adjust based on your desired outcome. |
| Max Tokens | Optional | Sets a limit on the number of tokens (words, characters, or pieces of text) in the model’s response. |

<br/>

#### Models + Endpoints
To find the Model deployment name, look in `Models + Endpoints` screen in [Azure AI Foundry](https://ai.azure.com).  

![img](/images/flow/azure-ai-foundry-deploymentname.png)

<br/>

[!INCLUDE [](./__videos.md)]