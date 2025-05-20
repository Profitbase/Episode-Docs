# Text embedder

Defines an openAI Text embedder

![img](/images/flow/openAI-text-embeder1.png)  

**Example** ![img](../../../../images/strz.jpg)  
This flow processes a user's chat question by first receiving it through a [Chat completion](../../triggers/ai/chat-completion-trigger.md) trigger, then converting it into a vector using a **text embedder**, performing a [Vector search](../postgresql/vector-search.md) in a postgreSQL database for relevant context, and finally passing the user input and retrieved context to OpenAI [Chat completion](chat-completion.md), which generates a response that is returned to the client via the [Return](../built-in/return.md) node.
<br/>

## Properties

| Name            | Type                   | Description                             |
|-----------------|------------------------|-----------------------------------------|
| Title           | Optional               | The title of the action.                |
| Connection      | Required               | Defines the [connection](openai-connection.md) to **OpenAI**. |
| Embedding model | Required               | Name (id) of the chosen [Embedding Model](https://platform.openai.com/docs/models).|
| Description     | Optional  | Additional information or notes about the text embedder.     |


