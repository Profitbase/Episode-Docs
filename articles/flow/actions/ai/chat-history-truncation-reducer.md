# Chat History Truncation Reducer

Defines a chat history reducer that trims the conversation to a target number of messages, but only when the total exceeds a specified threshold.
If no threshold is set, the history is trimmed whenever it exceeds the target count.

## Properties 

| Name                    | Type      | Description                                           |
|-------------------------|-----------|-------------------------------------------------------|
| Title                   | Optional  | The name of the action or operation.                  |
| Target count            | Required  | The desired number of target/history messages after reduction           |
| Threshold count         | Optional  | The number of messages beyond the 'targetCount' that must be present in order to trigger reduction           |
| Description             | Optional  | A field to describe the action or its purpose.        |

</br>




## Purpose

The **Chat Completion History Reducer** is designed to manage and streamline chat memory for models by trimming older messages. This ensures the model operates within context limits while preserving the most relevant and recent messages.

Maintaining concise and contextually relevant history is crucial in large language models. As conversations grow, earlier exchanges may become less relevant or redundant. The reducer automatically trims the chat history when it exceeds a configured threshold, keeping interactions coherent and within memory budget.

The reducer helps:

- **Preserve important context** by keeping recent messages.
- **Avoid overload** from excessively long conversations.
- **Improve model performance** by maintaining clarity and relevance.

It’s particularly useful in long-running sessions or applications like customer service bots, AI companions, or collaborative coding assistants.

---

## History JSON Format

```json
{
  "title": "Trim Chat History",
  "targetCount": 20,
  "thresholdCount": 30,
  "description": "Trims the chat history when more than 30 messages exist, reducing it to 20."
}
