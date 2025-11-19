# ChatMessageInfo

Represents a Microsoft Teams chat message in Flow.

## Properties

```TypeScript
type ChatMessageInfo = {
    // The ID of the chat message
    id: string,
    
    // The ID of the chat that the message was sent to
    chatId: string
    
    // The chat message
    body: ChatMessageBody
}

type ChatMessageBody = {
    // The text message content of the chat
    content: string,
    
    // The format of the content. Valid values are 'HTML' and 'Text'    
    contentType: string
}

```