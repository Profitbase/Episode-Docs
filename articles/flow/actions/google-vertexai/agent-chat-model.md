# Chat model

This defines a Google Vertex AI chat model that an AI Agent — such as the Tools AI Agent — can use to understand context, interpret user input, and decide which actions to take. By providing this model, the agent gains the ability to reason, plan, and respond intelligently based on the conversation and available tools.


## Properties

| Name                  | Type      | Description |
|-----------------------|-----------|-------------|
| Title                 | Optional  | The title of the model. |
| Connection            | Required  | Defines the [connection](vertexai-connection.md) to **OpenAI**. |
| Model Id       | Required  |	The identifier of the model to be used, such as gemini-2.5-pro, gemini-2.0-flash-lite-001, etc. This determines the capabilities and cost of the model. |
| Temperature       | Optional  |Temperature in models controls the randomness and creativity of the generated responses. Lower temperatures (e.g., 0.2) produce more focused, predictable text, ideal for tasks that require precision. Higher temperatures (e.g., 1.5) increase creativity and variability, but may risk generating less coherent or relevant content, making it important to adjust based on your desired outcome. |
| Max Tokens | Optional | Sets a limit on the number of tokens (words, characters, or pieces of text) in the model’s response. |
| Result variable name | Optional | The name of the variable in which the result will be stored. |
| Description       | Optional  | Additional details or notes. |

<br/>