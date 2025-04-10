# Azure Blob Storage Agent Tool

Defines an AI Tool that enables the [Tools AI Agent](../agents/tools-ai-agent.md) to access Azure Blob Storage to perform actions.

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Title            | Optional  |                                             |
| Connection       | Required  | The [Azure Blob container connection](./azure-blob-container-connection.md). The currently supported options are `SAS URI` and `Connection string + container name`.    |
| Dynamic connection | Optional   | A connection dynamically created using the [Create Azure Blob container connection](./create-azure-blob-container-connection.md) action.    |
| Capabilities     | Optional | Specifies what actions the tool is allowed to perform. [See details below](#capabilities). |


## Capabilities

AI agents operate autonomously by reasoning about which actions to perform in order to complete a task. Given a set of tools, you may want to restrict agents from performing potentially harmful tasks or limit the number of available tools to improve their accuracy.  

The `Capabilities` property specifies what the agent is allowed to do.

| Name                  | Description                              |
|-----------------------|------------------------------------------|
| List blobs            | Specifies whether the tool is allowed to list blobs in an Azure Blob container. |
| Read (download) blobs | Specifies whether the tool is allowed to read blobs from a container. |
| Write (upload) blobs  | Specifies whether the tool is allowed write (upload) blobs to a container. |
| Delete blobs          | Specifies whether the tool is allowed delete blobs from a container. |