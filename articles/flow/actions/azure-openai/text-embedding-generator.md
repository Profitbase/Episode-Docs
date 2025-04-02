# Azure OpenAI text embedding generator

Defines an Azure OpenAI text [embedding](https://learn.microsoft.com/en-us/azure/ai-services/openai/how-to/embeddings?utm_source=chatgpt.com&tabs=console) generator.


## Properties 

| Name                  | Type      | Description |
|-----------------------|-----------|-------------|
| Title                | Optional  | The title of the action. |
| Connection           | Required  | Defines the [connection](azure-openai-connection.md) to **Azure OpenAI**. |
| Deployment Name      | Required  | Specifies the model deployment name, which corresponds to the custom name chosen during model deployment in the Azure portal or in [Azure AI Foundry](https://ai.azure.com). In the Azure Portal, the deployment name can be found under **Resource Management** > **Model Deployments**. |
| Result variable name | Required  | Defines the variable name in which the result will be stored. |
| Description         | Optional  | A field to add additional details or notes about the action. |
