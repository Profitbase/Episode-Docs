# Foreach web search result 

Iterates over each search result returned by a **Tavily web search**.  
This action creates a loop that exposes a `searchResult` variable containing properties of each item in the results array.

Use this action when you need to process each result individually—for example, logging items, enriching data, or performing conditional logic.

![img]()


**Example** ![img](../../../../images/strz.jpg)  
This flow ..



<br/>

## Properties

| Name                | Type       | Description |
|---------------------|------------|-------------|
| Title           | Optional   | The title of the action. |
| Connection      | Required   | Tavily connection used for executing the query. |
| Query           | Required   | The text-based search query used to retrieve results. |
| Max results     | Optional   | Limits how many results to retrieve and iterate through. |
| Max content length | Optional | Maximum amount of page content to fetch per result. |
| Extract full content | Optional | When checked, the tool attempts to retrieve full page content. |
| Request timeout (seconds) | Optional | Timeout for the search request. Default is 30 seconds. |
| Result loop variable name | Optional | Name of the loop variable (default: `searchResult`). |
| Description     | Optional   | A description displayed in the designer. |

<br/>

## Exposed variables

During each loop iteration, the following variable is available:

| Variable name | Type | Description |
|---------------|------|-------------|
| `searchResult` | `TavilyWebSearchResult` | Contains metadata such as title, URL, snippet, and scraped content (if enabled). |

<br/>

## Notes

- This action should be used **after** a web search tool or within a Flow where the same query is used repeatedly.  
- Use this loop to apply filtering, enrichment, transformation, or evaluation logic on each search result.  
- When combined with AI actions, you can create advanced reasoning chains where the LLM evaluates each result individually.

