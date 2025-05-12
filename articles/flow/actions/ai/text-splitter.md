# Text splitter

Defines a Text splitter object that can be used in various AI-related nodes with a "Text splitter" port. 


## Properties

| Name                  | Type     | Description                                                                 |
|-----------------------|----------|-----------------------------------------------------------------------------|
| Name                 | Optional | The name of the action or operation.                                       |
| Splitter type         | Required | Allows selection of a splitting type. Read documentation below.  ![img](../../../../images/strz2.jpg)                         |
| Result variable name  | Optional | Contains the `TextSplitter` object created by this node.                   |
| Description           | Optional | User-defined explanation or context for the node’s purpose.                |


### Splitter type

**Required.** Allows selection of a splitting type (algorithm). Based on the selected type, a number of additional properties will be shown.

#### Recursive character
The text is split based on a given number of characters.

**Additional properties:**
- **Chunk size** – The number of characters to split after
- **Chunk overlap** – The number of common characters in two consecutive chunks

#### Token
The text is split based on a given number of tokens.

**Additional properties:**
- **Encoder name** – The encoder that will count the tokens
- **Max tokens** – The maximum number of tokens in a chunk
- **Chunk overlap** – The number of common tokens in two consecutive chunks

#### Markdown
The text (in markdown format) is split based on the markdown headers.

**Additional properties:**
- **Headers to split on** – The markdown headers to split on
- **Include header** – Denotes if the headers themselves should be included in the output



## Returns

**Text splitter** – Contains the `TextSplitter` object created by this node.
