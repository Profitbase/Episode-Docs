# Text embedder

Defines an openAI Text embedder

![img](/images/flow/openAI-text-embeder1.png)  

<!---**Example** ![img](../../../../images/strz.jpg)  
The example above illustrates part of a Flow that stores a document into SQL Server (used as a vector database). It uses the [Split text](../ai/split-text.md) action to split a large document into chunks. Then, for each chunk, we generate an embedding, and stores the text chunk along with the embedding into SQL Server as a vector record.--->

<br/>

## Properties

| Name            | Type                   | Description                             |
|-----------------|------------------------|-----------------------------------------|
| Title           | Optional               | The title of the action.                |
| Connection      | Required               | Defines the [connection](openai-connection.md) to **OpenAI**. |
| Embedding model | Required               | Name (id) of the chosen [Embedding Model](https://platform.openai.com/docs/models).|
| Description     | Optional  | Additional information or notes about the text embedder.     |


