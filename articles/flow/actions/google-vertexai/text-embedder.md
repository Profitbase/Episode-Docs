# Text embedder

Defines an openAI Text embedder

https://cloud.google.com/vertex-ai/generative-ai/docs/embeddings/get-text-embeddings

## Properties

| Name            | Type                   | Description                             |
|-----------------|------------------------|-----------------------------------------|
| Title           | Optional               | The title of the action.                |
| Connection      | Required               | Defines the [connection](vertexai-connection.md) to **VertexAI**. |
| Embedding model | Required               | Name (id) of the chosen [Embedding Model](https://cloud.google.com/vertex-ai/generative-ai/docs/embeddings/get-text-embeddings#google-models).|
| Description     | Optional  | Additional information or notes about the text embedder.     |


