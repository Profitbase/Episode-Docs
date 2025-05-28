# Generate embedding

Generates an embedding vector using an Azure AI (OpenAI or Foundry) embedding model.

Use this action when you want to generate an embedding vector to do manual vector operations (write your own queries) against databases like PostgreSQL or Azure SQL, for example vector search or inserting / updating vector records. 

![img](/images/flow/azure-openai-generate-embedding.png)  

**Example** ![img](../../../../images/strz.jpg)  
The example above illustrates part of a Flow that stores a document into SQL Server (used as a vector database). It uses the [Split text](../ai/split-text.md) action to split a large document into chunks. Then, for each chunk, we generate an embedding, and store the text chunk along with the embedding into SQL Server as a vector record.

<br/>

## Properties

| Name            | Type                   | Description                             |
|-----------------|------------------------|-----------------------------------------|
| Title           | Optional               | The title of the action.                |
| Connection      | Required               | Defines the [connection](azure-ai-connection.md) to an **Azure AI Foundry** resource. |
| Model           | Required               | Specifies the name of the deployed embedding model, which corresponds to the **Name** (not the model id) of the deployed embedding model in Azure Azure AI Foundry or the Azure portal. In [Azure AI Foundry](https://ai.azure.com), the deployment name can be found in the Deployments screen as shown [below](#model). <br/> **NOTE!** Make sure you select an `Embeddings` model (for example text-embedding-3-large), and not something else like _Chat completion_ or _Text to speech_.   |
| Dimensions      | Optional               | Some embedding models (like text-embedding-3-*) support configurable dimensionalities, for example 768 or 1536. Make sure you don't specify a dimensionality greater than the max value of the model.| 
| Input           | Required               | The (text) input that you want to generate an embedding for. |


## Returns
This action returns a [ReadOnlyMemory&lt;float&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.readonlymemory-1). 

>[!NOTE]
>When using `ReadOnlyMemory<float>` in database queries, you might have to manually convert it to other formats depending on which database engine you are targeting. For example, Azure SQL currently requires `ReadOnlyMemory<float>` to be converted to a string before it can be used in a query (because vector support in Azure SQL is currently in preview). However, we expect that once the VECTOR data type is GA, you will not have to do the manual conversion shown below.  


**Example**  
You can convert ReadOnlyMemory&lt;float&gt; to a string using a [Function](../built-in/function.md) action, and then use in in an Azure SQL query like shown below.

```csharp
public string ConvertToString(System.ReadOnlyMemory<float> embedding)
{
    return JsonSerializer.Serialize(embedding.ToArray());
}
```

```sql
-- @embedding is passed as parameter. 
-- Because vector support in Azure SQL is currently in preview, 
-- we need to explicitly cast the string to the vector data type. 
declare @emb VECTOR(1536) = cast(@embedding as vector(1536))
SELECT Text, VECTOR_DISTANCE('cosine', Vector, @emb) AS Score 
FROM VectorTable 
WHERE VECTOR_DISTANCE('cosine', Vector, @emb) < 0.7
```

<br/>

## Model
To find the Model deployment name, look in `Models + Endpoints` screen in [Azure AI Foundry](https://ai.azure.com).  

![img](/images/flow/azure-openai-aifoundry-embedding-models.png)
