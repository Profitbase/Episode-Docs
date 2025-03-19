

# Chat Completion

The **Chat Completion** returns the response from an [Azure OpenAI](https://learn.microsoft.com/en-us/azure/ai-services/openai/) chat model based on user input. 

## Properties

| Name                  | Type      | Description |
|-----------------------|-----------|-------------|
| Title             | Optional  | The title of the flowchart. Default: "Azure OpenAI Chat Completion". |
| Connection        | Required  | Defines the [connection](azure-openai-connection.md) to Azure OpenAI, ensuring communication with the API. |
| Deployment Name   | Required  | Specifies the model deployment name, which corresponds to the custom name chosen during model deployment in the Azure portal. Found under Resource Management > Model Deployments. |
| User Prompt       | Required  | The input message from the user, which the model processes to generate a response. |
| System Prompt     | Optional  | A system-level instruction that guides the model’s behavior and response style. |
| History           | Optional  | A record of past interactions that provides context to the conversation, helping the model maintain continuity. |
| Temperature       | Optional  | Controls the randomness of responses, influencing creativity and variability. See details below. |
| Max Completion Tokens | Optional | Sets a limit on the number of tokens (words, characters, or pieces of text) in the model’s response. |
| Result Variable Name | Optional | Stores the generated AI response. Default: "response". |
| Description       | Optional  | Additional details or notes regarding the chat completion setup. |

## Temperature

The **Temperature** setting influences how deterministic or creative the model’s responses are:

- **Low Temperature (e.g., 0.2)**: Generates more predictable and focused responses, making it ideal for tasks requiring accuracy, such as technical documentation or code generation.
- **Medium Temperature (e.g., 0.7)**: Strikes a balance between coherence and creativity, making it useful for applications like blog writing or interactive chatbots.
- **High Temperature (e.g., 1.5 and above)**: Increases randomness, encouraging more diverse and imaginative responses. However, excessively high values can result in incoherent or nonsensical text.

### Choosing the Right Temperature
- If **precision and reliability** are essential, keep the temperature low.
- If you need a balance between **creativity and accuracy**, a medium setting works best.
- If you prioritize **diverse and unexpected outputs**, a higher temperature is useful, but test for coherence.

By adjusting the temperature, you can fine-tune the model’s behavior to better suit your specific use case.

## Summary

The **Chat Completion** feature allows users to interact with an AI model in a structured way, leveraging various parameters to customize responses. By understanding and adjusting settings like deployment name, temperature, and token limits, users can optimize the model’s behavior for different applications.