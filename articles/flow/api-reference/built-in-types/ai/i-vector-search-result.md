# IVectorSearchResult

Represents a result returned from a vector search.

## Properties
| Name           | Description                               |
|----------------|-------------------------------------------|
| PromptTemplate | The prompt template (if any) specified by the developer. |

## Methods

| Name           | Description                               |
|----------------|-------------------------------------------|
| ToPrompt()     | Returns the search result formatted as a an AI prompt. If a prompt template is defined, the template is used to format the prompt. |