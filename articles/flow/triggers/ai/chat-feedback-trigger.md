# Chat feedback trigger
TBD


## Properties

| Name        | Type          | Description                     |
|-------------|---------------|---------------------------------|
| Title       | Optional      | A descriptive label for the trigger.    |
| Test data   | Optional      | A JSON string that can be in dev mode to test the Flow before it's called from the outside (for example InVision). The JSON must have format as described in [Test data](#test-data) below. |
| Output variable name | Required  | The name of the variable containing the `ChatCompletionFeedbackRequest` object. (See [Returns](#returns below))  |

### Test data  
The Test data property must have the following format:  
```json
{
   "sessionId": "some Id",
   "question": "a completion question",
   "completionText": "corresponding completion response text",
   "feedback": "up" or "down" or "none" 
}

```
<br/>

## Returns
The trigger outputs a `ChatCompletionFeedbackRequest` object with the following properties.  

| Property name  | Type    | Description              |
|----------------|---------|--------------------------|
| SessionId      | String  | The id of the chat session provided by the client.  |
| Question         | String  | The question asked by the user. |
| CompletionText        | String  | The completion text (reponse) that the feedback concerns. |
| Feedback | String | Has to be one of the values 'up', 'down' or 'none'*

* The purpose of the 'none' value on the Feedback prop is to indicate that previously set feedback has been revoked.

<br/>

## Description
TBD
