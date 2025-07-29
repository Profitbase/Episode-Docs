# June 2025 Update

The June 2025 release expands the toolbox for building **AI-powered automations** by introducing support for the **[Model Context Protocol (MCP)](https://modelcontextprotocol.io/docs/getting-started/intro)**, **SQL Server and Azure SQL** vector stores, and extended **Adobe PDF Services** APIs. This update builds on the AI foundation introduced in May and strengthens Flow’s capabilities for building agentic workflows with deeper integration into enterprise data and systems.

<br/>

## Model Context Protocol (MCP)

You can now build and integrate **AI agents** using the **Model Context Protocol (MCP)**. MCP is an open standard that defines how large language models (LLMs) interact with tools, systems, and data sources—transforming them from passive chat interfaces into active agents capable of taking actions.

With Flow, MCP enables:

- Building AI agents directly in Flow using internal and external tools
- Using Flow-based tools from external AI agents, including Microsoft 365 Copilot
- Context-aware, multi-step AI workflows integrated into business processes

### MCP client tool

- Allows AI agents in Flow to interact with external systems via MCP servers
- Combine 1st-party and 3rd-party MCP tools in one agent

[Read more here](../actions/agents/mcp-client-tool.md)

![img](../../../images/changelogs/Flow25_4_1.png)

<br/>

### MCP tool trigger

- Exposes a Flow as an MCP-compatible AI tool
- Enables LLMs to invoke entire Flows as tools within agentic workflows

[Read more here](../actions/agents/mcp-tool-trigger.md)

![img](../../../images/changelogs/Flow25_4_2.png)

<br/>

## Adobe PDF Services

Flow now includes extended support for **Adobe PDF Services**, including new actions for extracting structured content and converting files to and from PDF format. These features streamline workflows involving document ingestion and processing.

### Extract PDF content

- Extracts content as:
  - Byte array
  - Stream
  - JSON
  - Document tree (object model)
- Use case: Processing invoice or order PDFs received via email and routing data into ERP systems

[Read more here](../actions/pdf/extract-content.md)

![img](../../../images/changelogs/Flow25_4_3.png)

<br/>

### Convert to PDF

- Convert Word, Excel, PowerPoint, or image files to PDF
- Ideal for automating report or document generation for sharing with external stakeholders

[Read more here](../actions/pdf/convert-to-pdf.md)

![img](../../../images/changelogs/Flow25_4_4.png)

<br/>

## PostgreSQL

### Save Vectors

- Automatically splits documents, generates embeddings, and stores them in PostgreSQL
- Updates existing entries on rerun for up-to-date vector stores

[Read more here](../actions/postgresql/save-vectors.md)

![img](../../../images/changelogs/Flow25_4_5.png)

<br/>

### Search Vectors – Metadata & Prompt Templates

- Return metadata with search results for use in LLM prompts
- Supports **custom prompt templates** to improve control over LLM behavior

[Read more here](../actions/postgresql/vector-search.md)

<br/>

### Insert or Update Row

- New action to insert or update rows in PostgreSQL without custom SQL

[Read more here](../actions/postgresql/insert-or-update.md)

<br/>

## SQL Server / Azure SQL

Flow now supports **SQL Server** and **Azure SQL Database** as **vector stores** for semantic search, enabling enterprise-grade retrieval workflows using existing infrastructure.

### Save Vectors

- Splits documents and stores vectorized chunks in SQL Server / Azure SQL
- Automatically updates vectors on rerun

[Read more here](../actions/sql/save-vectors.md)

![img](../../../images/changelogs/Flow25_4_6.png)

<br/>

### Search Vectors

- Enables semantic search with SQL input
- Used for **RAG** scenarios with internal documents

[Read more here](../actions/sql/vector-search.md)

<br/>

## Core

### Snowflake – Schema in Table Selector

- Table selector now includes schema to support cross-schema queries

<br/>

### Log Action

- New built-in `Log` action for inline logging
- No need for a separate Function action to log messages

[Read more here](../actions/built-in/log.md)

<br/>

### CSV – Date Format Picker

- Improved UI for selecting date formats during CSV import
- Supports common formats and custom strings

<br/>

## JSON

### JsonDataReader

- Now supports:
  - Random order schema mappings
  - Automatic numeric-to-string conversions
  - Improved error messaging with field-level context

[Read more about Get JSON DataReader](../actions/json/get-json-datareader.md)  
[Read more about the JsonDataReader API](../api-reference/jsondatareader.md)

<br/>

## Triggers

### Flow Trigger – Default Data

- Define default data payloads for development and fallback use

<br/>

## Run Flow

### Streaming Support

- Nested flows now support streaming data back to the parent as it becomes available

### Cross-Workspace Execution

- Run Flows in different Workspaces using parameters or explicit references

<br/>

## Extensions

### Log.AsILogger()

- API for logging from extension libraries such as Financials
- Helps communicate calculations, assumptions, and decisions in custom logic

<br/>

## See Also

- [May 2025](changelog25_may.md)
- [February 2025](changelog25_february.md)
- [December 2024](changelog24_december.md)
- [October 2024](changelog24_october.md)
- [September 2024](changelog24_september.md)
