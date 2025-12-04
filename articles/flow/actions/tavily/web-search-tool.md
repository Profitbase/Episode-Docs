# Web search tool | Tavily

Defines a Tavily **web search tool** that can be used by an AI Agent (Tools AI agent) or directly by an LLM as a callable tool.  
This action performs a web search and returns structured search results that can be passed to downstream Flow nodes.

![img]()


**Example** ![img](../../../../images/strz.jpg)  
This flow ..



<br/>

## Properties

| Name                | Type       | Description |
|---------------------|------------|-------------|
| Title           | Optional   | The title of the action. |
| Connection      | Required   | The Tavily connection used to authenticate and perform the search. |
| Max results     | Optional   | Limits the maximum number of search results returned. |
| Max content length | Optional | The maximum total content size that can be retrieved for each result. |
| Extract full content | Optional | If enabled, the tool attempts to scrape the full content of the referenced web pages. |
| Request timeout (seconds) | Optional | Timeout for executing the search request. Default is 30 seconds. |
| Result variable name | Optional | Name of the variable holding the result structure from the search tool. |
| Description     | Optional   | A description shown inside the designer. |

<br/>

## Returns

The action returns an object containing search metadata and a collection of search results.  
Type:  
`TavilyWebSearchResponse`

<br/>

## Usage notes

- Search and scraping may have limitations based on Tavily’s API capabilities.  
- When used inside a Tools AI agent, LLMs can autonomously call this tool when searching the web for relevant information.  
- Use **Extract full content** when you need page summaries or the body text for reasoning or RAG workflows.
