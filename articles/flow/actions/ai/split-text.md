# Split text

Split text into chunks.

![img](/images/flow/split-text.png)  

**Example** ![img](../../../../images/strz.jpg)  
The example above illustrates a Flow that stores a document in SQL Server. It uses the **Split text** action to divide a large document into smaller chunks. Then, for each chunk, an [embedding is generated](../azure-openai/generate-embedding.md), and the text chunk along with its corresponding embedding is stored in SQL Server as a vector record.

## Properties 

| Name                    | Type      | Description                                           |
|-------------------------|-----------|-------------------------------------------------------|
| Title                      | Optional  | The name of the action or operation.                                       |
| Input text                 | Required  | The text to split into chunks.                                             |
| Splitter type           | Required  |  Read documentation below.  ![img](../../../../images/strz2.jpg)               |
| Text chunk variable name   | Optional  | The variable name used to store the output chunks.                         |
| Description                | Optional  | A field to describe the action or its purpose.                             |

</br>

## Splitter type

</br>

**Splitter type - Recursive character text splitter:**

Splits text by characters into chunks of a specified size, optionally allowing overlap for better context retention.

**Additional properties:**

**Chunk size** - Maximum number of characters in each chunk.  
**Chunk overlap** - Number of overlapping characters between chunks.  

</br>

**Splitter type - Token text spiltter:**

Divides text based on token count using a chosen encoding, useful for models with token limits.

**Additional properties:**

**Encoding name** - The name of the token encoding to be used.               
**Max tokens** - The maximum number of tokens per chunk.                  
**Chunk overlap** - Number of overlapping tokens between chunks.             

</br>

**Splitter type - Markdown header text splitter:**

Breaks down documents at specific Markdown headers, ideal for structured texts like articles or reports.

**Additional properties:**

**Headers to split on** - Comma-separated list of Markdown headers to use as split points.   
**Include headers in output** - If enabled, includes the header text in each chunk.                



## Returns

Split text returns string **textChunk**.