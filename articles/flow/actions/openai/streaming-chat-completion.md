
# Streaming chat completion

Streams the response from a chat completion model, one message at a time.


 
## Properties

| Name                  | Type      | Description |
|-----------------------|-----------|-------------|
| Title                 | Optional  | The title of the action. |
| Connection            | Required  | Defines the [connection](openai-connection.md) to **OpenAI**. |
| Model id              | Required  | ID of the chosen [model](https://platform.openai.com/docs/models). |
| System prompt         | Optional  | A system-level instruction that guides the model’s behavior and response style. |
| User prompt           | Required  | The input message from the user, which the model processes to generate a response. |
| History               | Optional  | A record of past interactions that provides context to the conversation, helping the model maintain continuity. |
| Context               | Optional  | Additional context information to influence the response (if supported). |
| Temperature           | Optional  | Controls randomness/creativity of responses. Lower = more focused; higher = more creative. Default: 0.7. |
| Max completion tokens | Optional  | Sets a limit on the number of tokens in the model’s response. |
| Result variable name  | Optional  | Stores the generated AI response. Default: `response`. |
| Description           | Optional  | Additional details or notes regarding the chat completion setup. |

<br/>


