# A2A AI agent

Defines an AI agent designed to perform tasks on behalf of a Client (orchestrator) agent. It uses the [A2A protocol](https://a2a-protocol.org/latest/) and is intended exclusively for Agent-to-Agent scenarios where requests are issued by a Client agent.

> [!NOTE]
> The AI agent node has no `Execution in` or `Execution out` ports, which means that when it’s used in a Flow, no other executable nodes can be included in that Flow.  

![img](/images/flow/a2a-ai-agent.png)

<br/>

## Properties

| Name           | Type          | Description                     |
|----------------|---------------|---------------------------------|
| Name           | Required      | A human-readable name for the agent. The name helps users and other agents in understanding its purpose. |
| Instructions   | Required      | Defines the behavior of the agent and rules it should follow. |
| Description    | Required      | A human-readable description of the agent, assisting users and other agents in understanding its purpose. |
| Skills         | Required      | The set of skills, or distinct capabilities, that the agent can perform. |