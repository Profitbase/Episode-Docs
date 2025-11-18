# Anthropic Connection

Connecting to **Anthropic** in Profitbase Flow allows you to access Claude models through the Anthropic API. You can use this connection to automate prompts, generate text, analyze content, or embed AI-powered actions directly into your workflows.

<br/>

## Creating a New Connection

To create a connection to Anthropic:

1. Open a Flow action that requires an Anthropic connection.
2. Enable **Create new connection**.
3. Fill out the required connection fields.

<br/>

## Connection properties

| Name | Description |
|------|-------------|
| **Name** | A custom label for the connection. This name will appear in dropdowns when selecting the connection in actions. |
| **API Key** | Your unique Admin API key for authentication. [Anthropic API key](https://www.merge.dev/blog/anthropic-api-key). This key authorizes requests from Flow to Anthropic’s endpoints. |

**Important:**  
- API keys can be created and managed in the [Claude Console](https://platform.anthropic.com/account/api-keys).  
- Keep your key private, as it grants access to your Anthropic usage quota and billing.

<br/>

## Testing and Usage

After setting up the connection:

1. Use it in any Flow action that supports Anthropic prompts (e.g., chat completion, text generation, embeddings).  
2. The API key must have access to the Claude models you plan to use (e.g., Claude 3 Opus, Claude 3 Sonnet, Claude 3 Haiku).  
3. If the connection fails, verify the API key and ensure your Anthropic organization allows API access.

<br/>

## Related documentation

- [Anthropic API Reference](https://docs.claude.com/en/api/overview) 
- [API keys](https://docs.claude.com/en/api/admin-api/apikeys/get-api-key)
