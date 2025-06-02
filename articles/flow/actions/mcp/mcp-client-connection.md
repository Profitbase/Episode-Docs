# MCP client connection

The MCP client connection specifies how an MCP client (Flow) can connect to an MCP server. 

## Properties
| Name            | Type       | Description                            |
| ----------------|------------|----------------------------------------|
| Name            | Required   | The name of the connection.            |
| Transport type  | Required   | The transport type used by the client and server to communicate. <br/>The following types are currently supported:<br/> - SSE (Server-Sent Events)<br/> - Streamable HTTP. <br/><br/>By default, Flow will use the **AutoDetect** mode to try to automatically choose the correct transport type. If this fails, you need to specify the transport type manually. Refer to the documentation for MCP Server you are trying to connect to to learn which transport type to use. |
| Endpoint        | Required   | The address of the remote MCP server. Refer to the documentation for MCP Server you are trying to connect to to learn which endpoint to use.|
| Authentication type  | Optional   | The authentication type required by the remote MCP server. Refer to the documentation for MCP Server you are trying to connect to to learn which authentication type to use.| 