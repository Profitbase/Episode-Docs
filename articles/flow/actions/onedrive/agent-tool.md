# OneDrive Agent Tool

Defines a OneDrive Tool that enables the [Tools AI Agent](../agents/tools-ai-agent.md) to access OneDrive on behalf of a user.

## Properties

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Title            | Optional  | The title of the tool.                                 |
| Connection       | Required  | The connection to the OneDrive account. Setting up a connection requires a Microsoft `Work or School account`    |
| Capabilities     | Optional | Specifies what actions the tool is allowed to perform. [See details below](#capabilities). |


## Capabilities

AI agents operate autonomously by reasoning about which actions to perform in order to complete a task. Given a set of tools, you may want to restrict agents from performing potentially harmful tasks or limit the number of available tools to improve their accuracy.  

The `Capabilities` property specifies what the agent is allowed to do.

| Name                    | Description                              |
|-------------------------|------------------------------------------|
| List files and folders  | Specifies whether the tool is allowed to list files and folders in OneDrive. |
| Read (download) files   | Specifies whether the tool is allowed to read files in OneDrive. |
| Write (upload) files    | Specifies whether the tool is allowed write (upload) files to OneDrive. |
| Delete files            | Specifies whether the tool is allowed delete files from a OneDrive. |
