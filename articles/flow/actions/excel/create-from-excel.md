# Create markdown from a Excel file

[Markdown](https://en.wikipedia.org/wiki/Markdown) is a simplified text format. 
It can be used to feed an AI chat with knowledge through RAG (Retrieval-Augmented Generation).


<br/>

## Returns

This action returns a string with the markdown.

<br/>

## Properties

| Name                 | Type     | Description                                                                                                   |
| -------------------- | -------- | ------------------------------------------------------------------------------------------------------------- |
| Title                | Required |                                                                                                               |
| File Data            | Required | Specifies the source of the Excel file, which can either be a Stream or a Byte Array.                         |
| Result variable name | Required | The name of the Markdown variable returned from the action. |
| Description          | Optional | Additional notes or comments about the action or configuration. |

<br/>
