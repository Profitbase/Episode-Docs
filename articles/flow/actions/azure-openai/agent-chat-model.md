# Azure OpenAI chat model

Defines an Azure OpenAI chat model that an AI Agent, for example the [Tools AI agent](../agents/tools-ai-agent.md), can use to reason about what to do.

## Properties

| Name                  | Type      | Description |
|-----------------------|-----------|-------------|
| Title                 | Optional  | The title of the action. |
| Connection            | Required  | Defines the [connection](azure-openai-connection.md) to **Azure OpenAI**. |
| Deployment Name       | Required  | Specifies the model deployment name, which corresponds to **name** (not the model id) of the deployed model in Azure Azure AI Foundry (can also be found in the Azure portal). In [Azure AI Foundry](https://ai.azure.com), the deployment name can be found in the Deployments screen as shown [below](#deployment-name).   |
| Temperature       | Optional  |Temperature in models controls the randomness and creativity of the generated responses. Lower temperatures (e.g., 0.2) produce more focused, predictable text, ideal for tasks that require precision. Higher temperatures (e.g., 1.5) increase creativity and variability, but may risk generating less coherent or relevant content, making it important to adjust based on your desired outcome. |
| Max Tokens | Optional | Sets a limit on the number of tokens (words, characters, or pieces of text) in the model’s response. |

<br/>

#### Deployment name
To find the Deployment name, look in the `Deployments` screen in [Azure AI Foundry](https://ai.azure.com).  

![img](/images/flow/azure-openai-deploymentname.png)