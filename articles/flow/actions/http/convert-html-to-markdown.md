# Convert HTML to Markdown

Returns [Markdown](https://en.wikipedia.org/wiki/Markdown) text from a HTML document (page).


![img](../../../../images/flow/convert-HTML-to-markdown.png)

**Example** ![img](../../../../images/strz.jpg)  
This Flow reads a [website sitemap](get-sitemap.md), downloads the HTML of each page, converts HTML to Markdown, [splits the cleaned content](../ai/split-text.md), [generates embeddings](../azure-openai/generate-embedding.md), and stores them in SQL Server. It enables powerful semantic search across web content fetched via HTML.

<br/>

## Returns

This action returns a string/text in markdown format.

<br/>

## Properties

| Name                 | Type     | Description                                                                                                   |
| -------------------- | -------- | ------------------------------------------------------------------------------------------------------------- |
| Title                | Optional |   The title of the action.                    |
| File Data            | Required | Specifies the source of the HTML text, which can either be a string, a Stream or a Byte Array.                |
| Result variable name | Required | The name of the variable in which the result will be stored.  |
| Description          | Optional | Additional notes or comments about the action or configuration. |

<br/>

