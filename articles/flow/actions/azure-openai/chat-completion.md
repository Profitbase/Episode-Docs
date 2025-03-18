# Chat completion

Returns the response from a chat completion model given a user prompt.

## Properties  

| Name                     | Type      | Description                                             |  
|--------------------------|-----------|---------------------------------------------------------|  
| Title                    | Optional  | The title of the flowchart (set to "Azure OpenAI Chat completion"). |  
| Connection               | Required  | Defines the connection to Azure OpenAI.                 |  
| Deployment name          | Required  | Specifies the deployment name for the model.            |  
| User prompt              | Required  | The input prompt given by the user.                     |  
| System prompt            | Optional  | The system-level instruction for the model.             |  
| History                  | Optional  | Context or past messages to include in the conversation. |  
| Temperature              | Optional  | Controls randomness of responses.                       |  
| Max completion tokens    | Optional  | Limits the number of tokens in the response.            |  
| Result variable name     | Optional  | Stores the output of the AI response (set to "response"). |  
| Description              | Optional  | Additional details or notes about this setup.           |  

