# OpenAI Connection

Connecting to **OpenAI** in [Profitbase Flow](https://docs.profitbase.com/articles/flow/actions/openai/openai-connection.html) allows you to access powerful language and image models via the OpenAI API. You can use this connection to automate prompts, generate text, analyze content, or embed intelligent AI-powered actions into your workflows.

<br/>

## 🔧 Creating a New Connection

To create a connection to OpenAI:

1. Open a Flow action that requires an OpenAI connection.
2. Enable **Create new connection**.
3. Fill out the required connection fields.

<br/>

## Connection properties

| Name       | Description |
|-------------|-------------|
| Name    | A custom label for the connection. This name will be shown in dropdowns when selecting the connection in actions. |
| API Key | Your personal or organizational [OpenAI API key](https://platform.openai.com/account/api-keys). This key authorizes requests from Flow to OpenAI's endpoints. |

**Important:**  
- API keys can be created and managed in the [OpenAI dashboard](https://platform.openai.com/account/api-keys).  
- Keep your key private – it grants access to your OpenAI usage quota and billing.

<br/>

## Screenshot

![OpenAI Connection](https://docs.profitbase.com/images/flow/openai-connection1.png)

<br/>

## Testing and Usage

After setting up the connection:

1. Use it in any Flow action that supports OpenAI prompts (e.g., text completion, chat, embeddings).
2. The key must have access to the models you plan to use (e.g., GPT-4, GPT-3.5-turbo, DALL·E).
3. If your connection fails, verify the key and ensure your OpenAI organization allows API usage.

<br/>

## Related documentation

- [OpenAI API Reference](https://platform.openai.com/docs/api-reference/introduction)
- [Using OpenAI in Flow](https://docs.profitbase.com/articles/flow/actions/openai/text-completion.html)