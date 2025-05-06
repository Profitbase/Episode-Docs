# Replace relative URLs

Replaces relative URLs in an HTML document or element with absolute URLs.

A typical use case for this action is storing information from a website (such as an internal knowledge base) in a vector database used for RAG by an AI chat. Links to topics are often stored as URLs relative to the original site. However, when an LLM replies with information from the RAG lookup, the response is no longer in the context of the original website, so relative links may be broken.

![img](/images/flow/html-replace-relative-urls.png)

## Properties

| Name          | Type                  | Description                            |
|---------------|-----------------------|----------------------------------------|
| HTML content  | Required              | A [string](https://learn.microsoft.com/en-us/dotnet/api/system.string), [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream) or `byte array` contining a HTML document of HTML fragment. |
| Base URL      | Required              | The base url of the web site which serves the HTML document. |
| Result variable name | Required       | The name of the variable that contains the output from this action. |

## Returns

Returns the HTML input as a [string](https://learn.microsoft.com/en-us/dotnet/api/system.), with relative URLs replaced by absolute URLs.