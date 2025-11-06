# AI agent memory

This action stores and retrieves AI agent memory (conversation history) using SQL Server.

To enable ongoing conversations with an AI instead of starting fresh each time, you need to add memory to the agent. This allows it to recall previous exchanges when processing new requests. By remembering key details—like user preferences, goals, or past actions—the agent can personalize responses, avoid repetition, and maintain continuity. The result is more natural, efficient, and human-like interactions, where the AI can reason and adapt over time.  

![img](/images/flow/sql-server-agent-memory.png)
<p><em>Figure: This example shows an agent using 3 tools for working with salary information and calculating a forecast. The Agent memory tracks the conversation history, allowing users to have an ongoing conversation with the agent.</em></p>

<br/>

## Properties
| Name               | Type          | Description                  |
|--------------------|---------------|------------------------------|
| Connection         | Required      | The [SQL Server Connection](./connection.md). |
| Dynamic connection | Optional      | Use this option of you needs to use a connection from the [Create Connection](./create-connection.md) action. |
| Table              | Required      | The name of the table where the memory is stored. If the table does not exist in the database, it will be created automatically by Flow. If you want to use an existing table, see the [description below](#agent-memory-table-schema). |
| Command timeout (sec) | Optional   | The time limit for command execution before it times out. Default is 120 seconds. |

<br/>

## Returns
The action returns the conversation history to the AI agent, based on its Session ID.

<br/>

## Agent memory table schema

If you want to use an existing table to store the agent memory, it must have the following schema.

| Column name   | Data type         | Primary key | Nullable  |
|---------------|-------------------|-------------|-----------|
| SessionID     | varchar(36)       | No          | No        |
| Memory        | nvarchar(MAX)     | No          | Yes       |
| TS            | datetimeoffset(2) | No          | Yes       |


```sql
CREATE TABLE YOUR_TABLE_NAME (
    SessionId VARCHAR(36) NOT NULL,
    Memory NVARCHAR(MAX) NULL,
    TS DATETIMEOFFSET(2) DEFAULT GETUTCDATE() NULL
)
```
