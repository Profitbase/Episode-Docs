# Convert a Word file to Markdown

[Markdown](https://en.wikipedia.org/wiki/Markdown) is a lightweight text format. It can be used to provide knowledge to an AI chat through RAG (Retrieval-Augmented Generation).


<br/>

## Returns

This action returns a string containing the Markdown text format.

<br/>

## Properties

| Name                 | Type     | Description                                                                                                   |
| -------------------- | -------- | ------------------------------------------------------------------------------------------------------------- |
| Title                | Optional |   The title of the action.                    |
| File Data            | Required | Specifies the source of the Word file, which can either be a Stream or a Byte Array.                          |
| Result variable name | Required | The name of the Markdown variable returned from the action. |
| Description          | Optional | Additional notes or comments about the action or configuration. |

<br/>
