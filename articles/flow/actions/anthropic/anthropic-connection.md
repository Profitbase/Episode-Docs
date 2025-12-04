# Anthropic Connection

The connection is part of the configuration of [Anthropic](https://docs.claude.com/en/api/overview) actions and it is required in most cases.

<br/>

## Creating a New Connection

When adding an Anthropic action (such as Agent Model or Chat Completion), you can select an **existing Anthropic connection** or **create a new one**:

1. Click on an Anthropic action in order to open the Properties panel.
2. Click on the Connection field to select or create a connection. In the popup that shows up click on the **New  connection** button.
3. Fill out the required connection fields.

<br/>

## Properties

| Name | Description |
|------|-------------|
| Name | A custom label for the connection. This name will appear in dropdowns when selecting the connection in actions. |
| API Key | The Anthropic API key for authentication. [Anthropic API key](https://www.merge.dev/blog/anthropic-api-key). This key authorizes requests from Flow to Anthropic’s endpoints. |

**Important:**  
- API keys can be created and managed in the [Claude Console](https://platform.anthropic.com/account/api-keys).  
- Keep your key private, as it grants access to your Anthropic usage quota and billing.

<br/>

## Related documentation

- [Anthropic API Reference](https://docs.claude.com/en/api/overview) 
- [API keys](https://docs.claude.com/en/api/admin-api/apikeys/get-api-key)
