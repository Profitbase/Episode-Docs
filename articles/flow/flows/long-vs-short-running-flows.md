
#### Difference between short-running and long-running Flows

A Flow can either be executed as short-running or long-running. 

Short-running and long-running Flows have the same capabilities, except that a short-running Flow can *return a result directly to the caller* while a long-running Flow must store its output somewhere else so it can be fetched manually after execution has completed.  

Streaming Flows are short running Flows that continually streams data back to the client.

The **differences** between short-running, long-running and streaming Flows are listed below.

<br/>



| Feature                                                                              | Short-running             | Long-running | Streaming |
|--------------------------------------------------------------------------------------|---------------------------|--------------|------------|
| Max execution time                                                                   | 300 seconds (5 minutes)   | 2 hours      | 300 seconds (5 minutes) |
| Can use the [Return action](../actions/built-in/return.md) to return a result directly to the caller                  | Yes                       | No           | No |
| Can use the [Return HTTP File response action](../actions/http/return-file-http-response.md) to return a file directly to the caller | Yes                       | No           | No |
| Can use the [Yield return action](../actions//built-in/yield-return.md) to stream data back to the caller.  | No | No | Yes |
| Requires [polling](../api-reference/execute-flow/poll.md) for completion             | No                        | Yes          | No |


