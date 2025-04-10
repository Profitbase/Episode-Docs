# Outlook Agent Tool

Defines an Outlook Tool that enables the [Tools AI Agent](../agents/tools-ai-agent.md) to access Outlook on behalf of a user.

| Name             | Type      |Description                                             |
|------------------|-----------|--------------------------------------------------------|
| Title            | Optional  | The title of the tool.                                 |
| Connection    | Required | A [Microsoft 365 Outlook connection](./outlook-connection.md) which grants Profitbase Flow access to the email account. |
| Capabilities     | Optional | Specifies what actions the tool is allowed to perform. [See details below](#capabilities). |


## Capabilities

AI agents operate autonomously by reasoning about which actions to perform in order to complete a task. Given a set of tools, you may want to restrict agents from performing potentially harmful tasks or limit the number of available tools to improve their accuracy.  

The `Capabilities` property specifies what the agent is allowed to do.

| Name                    | Description                              |
|-------------------------|------------------------------------------|
| Send email              | Specifies whether the tool is allowed to send emails. |
