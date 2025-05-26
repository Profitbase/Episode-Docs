# May 2025 Update  


We are excited to release the first version of Flow with support for **AI workloads** powered by **Azure** and **OpenAI**! This AI-centered release focuses on:

- Accessing information in business documents through **semantic search**, **AI chat**, and **AI agents**
- Building document stores for **RAG (Retrieval-Augmented Generation)** and **semantic search**
- Creating **AI chat clients**
- Automating tasks with **AI agents**

<br/>

## Adobe PDF Services

Flow now integrates **Adobe PDF Services** to easily convert PDF files into:

- Word (.docx)
- Excel (.xlsx)
- PowerPoint (.pptx)
- RTF (.rtf)

> [!NOTE]
> PDF files need to be converted into machine-readable formats (e.g., Markdown) to be usable by LLMs. You can combine the Adobe PDF Services converter action with a Markdown converter action for optimal compatibility.

![img](../../../images/changelogs/Flow25_3_1.png)

<br/>

## AI Tools Agent

The **Tools AI Agent** allows for autonomous AI-powered automations. Example:

- Gather data from internal systems
- Compose a report
- Post the report to Microsoft Teams

> The LLM-powered "brain" decides which tools to use and how to execute the task.


[Read more here](../actions/agents/tools-ai-agent.md)

![img](../../../images/changelogs/Flow25_3_2.png)

<br/> 

## AI Agent Tools (May 2025 Update)

These tools help build AI-powered automations:

<br/>

### Azure Storage Blob Agent Tool

- Access Azure Blob Storage
- Read and write files

<br/>

### OneDrive Agent Tool

- Access OneDrive on behalf of a user
- List, read, upload, and delete files  

[Read more here](../actions/onedrive/agent-tool.md)

<br/>

### Outlook Agent Tool

- Send emails via Outlook  

[Read more here](../actions/microsoft-365-outlook/agent-tool.md)

<br/>

### Markdown Agent Tool

- Convert Word, PowerPoint, PDF, CSV, Excel to Markdown
- Useful for summarizing and interpreting documents


<br/>

## AI Chat – Azure OpenAI


### Chat Completion

- Returns a response from an Azure OpenAI chat model (LLM)
- Use case: Chat clients like ChatGPT, reasoning over documents

![img](../../../images/changelogs/Flow25_3_3.png)

<br/>

### Streaming Chat Completion

- Streams response as it's generated (ideal for chat backends)

![img](../../../images/changelogs/Flow25_3_4.png)

<br/>

### Generate Embedding

- Converts text to embedding vector for vector search or vector store (e.g., SQL Server, PostgreSQL)  

[Read more here](../actions/azure-openai/generate-embedding.md)

<br/>

### Chat Model

- Powers reasoning for tools like AI Agents  

[Read more here](../actions/azure-openai/agent-chat-model.md)

<br/>

### Text Embedder

- The Text embedder is a tool used by actions such as the [PostgreSQL Vector](../actions/postgresql/vector-search.md) search action to generate embedding vectors on demand. The action chooses when and if to use the tool.

The difference between the **Text embedder** tool and the **Generate embedding** action, is that the Text embedder tool is used by other actions *if they choose to*, while the Generate embedding action runs explicitly.


<br/>

## AI Chat – OpenAI

Same features as Azure OpenAI:

- **Chat completion**  
- **Streaming chat completion**  
- **Generate embedding**  
- **Chat model**  
- **Text embedder**  

[Read more here](../actions/openai/chat-completion.md)

<br/>

## AI Chat – Common


### Chat History Truncation Reducer

- Removes items from chat history before sending to the LLM
- Helps reduce token usage and improve accuracy

![img](../../../images/changelogs/Flow25_3_4.png)

## PostgreSQL

<br/>

### Search Vectors

Performs **vector search** against a PostgreSQL table:

- **Use cases:**
  - Semantic search
  - Recommendation systems
  - RAG pipelines

Example: Find semantically similar documents and provide them to the LLM alongside a user query.



## Markdown

A lightweight format ideal for LLM processing.

<br/>

### Supported Actions:


- **Convert URL to Markdown** – Extracts HTML content  
- **Convert HTML to Markdown** – Uses Microsoft MarkItDown  
- **Convert PDF to Markdown**  
- **Convert Excel to Markdown**  
- **Convert Word to Markdown**  
- **Convert PowerPoint to Markdown**  

[Read more here](#)



## GitHub

Read files and file metadata from GitHub repositories.

<br/>

### For Each Content Info

- Lists items in a repo (does not download files)  

[Read more here](#)

<br/>

### Read Content as Byte Array

- Reads files as binary  

[Read more here](#)

<br/>

### Read Contents as Stream

- Reads files as forward-only stream (better performance)  

[Read more here](#)

> **Note:** Use byte array if multiple reads are needed.



## HTML (Web Scraping Support)

<br/>

### For Each HTML Element

- Iterate over HTML elements during scraping  

[Read more here](#)

<br/>

### Replace Relative with Absolute URLs

- Useful for maintaining valid links in AI responses  

[Read more here](#)



## HTTP

<br/>

### Get Sitemap

- Retrieves sitemap from a URL for scraping  

[Read more here](#)



## Vector Data

<br/>

### Split Text

- Breaks large text into manageable semantic chunks
- Useful for embedding generation and vector storage



## Chat Completion Trigger

- Entry point for AI chat interactions
- Provides context property for custom logic and RAG  

[Read more here](#)



## JSON

<br/>

### JsonDataReader – Handle Arrays

- Supports arrays as raw strings for one-to-many relationships  

[Read more here](#)



## InVision

<br/>

### Refresh Table Artifacts

- Required if you modify tables using SQL or external APIs

> Not needed for built-in import APIs or UI updates  

[Read more here](#)



## CSV

<br/>

### Advanced Parameterization

- Support for customizable CSV import/export:
  - Row delimiter
  - Quote character
  - Thousand separator
  - Date format string

Useful for apps like Planner.



## Core

<br/>

### Streaming

- Stream results back to clients in real time
- Ideal for AI chat clients  

[Read more here](#)

<br/>

### Yield Break

- The `yield break` action signals termination of an iteration



**Stay tuned for more updates and innovations with Profitbase Flow!**



<br/>

### See Also



- [February 2025](changelog25_february.md)
- [December 2024](changelog24_december.md)
- [October 2024](changelog24_october.md)
- [September 2024](changelog24_september.md)
