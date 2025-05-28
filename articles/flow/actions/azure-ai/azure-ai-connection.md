# Connecting to Azure AI Foundry

**Azure AI connection** enables Flow actions to interact with [Azure AI Foundry](https://ai.azure.com/) resources, such as Large Language Models (LLMs).

## Connection Details

Azure AI Foundry connections have the following settings:

| Field          | Description                                                         |
|----------------|---------------------------------------------------------------------|
| **Name**       | Name of the connection.                                             |
| **API Key**    | The API key used for authentication.                                |
| **Endpoint**   | The endpoint URL for the Azure AI Foundry resource.<br/>**Note!** `OpenAI` and `Foundry` models have different Endpoint formats. See below for details. |

<br/>

## Creating a New Connection

To add an Azure AI action, select an **existing Azure AI connection** or create a new one.  

> [!IMPORTANT]
> Whether you want to use an `OpenAI` or `Foundry` model, you need to create the connections differently. See details below.

<br/>

## Create a connection to an Azure Foundry model

If you want to use a `Foundry` model, you can **reuse** the connection against **multiple** model deployments. 

1. In the Flowchart, click to select the action that you want to create a connection for.
2. Select **Connection** in the property panel.
2. Toggle **Create New Connection** on.
3. Fill in the required fields:
   - **Name**: Enter a unique name for this connection. Choose a name that makes it easy to understand what the connection is for.
   - **API Key**: Provide the API key associated with the deployed model.
   - **Endpoint**: Enter the full URL of the deployed model (e.g., `https://xx-m8on1111-eastus2.services.ai.azure.com/models`).

To find the API Key and Endpoint, go the the Azure AI Foundry portal and do the following:
1) Click `Models + Endpoints` 
2) Select the deployed model
3) In the SDK dropdown, select `Azure AI Inference SDK`.
4) Copy the Endpoint URL
5) Copy the (API) Key

![img](/images/flow/azure-ai-foundry-connection-standard.png)

<br/>

## Create a connection to an Azure OpenAI model

If you want to use an `OpenAI` model, you must create one connection **PR** model deployment, because the deployment name is part of the Endpoint.  

1. In the Flowchart, click to select the action that you want to create a connection for.
2. Select **Connection** in the property panel.
2. Toggle **Create New Connection** on.
3. Fill in the required fields:
   - **Name**: Enter a unique name for this connection. Choose a name that makes it easy to understand what the connection is for.
   - **API Key**: Provide the API key associated with the deployed model.
   - **Endpoint**: Enter the full URL of the deployed model (e.g., `https://sh-m8on2329-eastus2.cognitiveservices.azure.com/openai/deployments/gpt-4o-mini`). Note that the Endpoint contains the deployment name (gpt-4o-mini).

To find the API Key and Endpoint, go the the Azure AI Foundry portal and do the following:
1) Click `Models + Endpoints` 
2) Select the deployed model
3) In the SDK dropdown, select `Azure AI Inference SDK`.
4) Copy the Endpoint URL. Note that the deployment name is in the URL.
5) Copy the (API) Key

![img](/images/flow/azure-ai-foundry-connection-openai-model.png)