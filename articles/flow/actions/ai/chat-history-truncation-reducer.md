# Chat History Truncation Reducer

Defines a chat history reducer that trims the chat to meet a target message count, but only when the history exceeds a specified threshold.

## Properties 

| Name                    | Type      | Description                                           |
|-------------------------|-----------|-------------------------------------------------------|
| Title                   | Optional  | The name of the action or operation.                  |
| Target count            | Required  | The desired number of target/history messages after reduction           |
| Threshold count         | Optional  | The number of messages beyond the 'targetCount' that must be present in order to trigger reduction           |
| Description             | Optional  | A field to describe the action or its purpose.        |

</br>
