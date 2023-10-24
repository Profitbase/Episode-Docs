
#### Difference between short-running and long-running Flows

A Flow can either be executed as short-running or long-running. 

Short-running and long-running Flows have the same capabilities, except that a short-running Flow can *return a result directly to the caller* while a long-running Flow must store its output somewhere else so it can be fetched manually after execution has completed. 

The other main difference is that short-running Flows have a maximum execution time, while long-running Flows do not. 

The **differences** between short-running and long-running Flows are listed below.

<br/>



| Feature                                                                              | Short-running             | Long-running |
|--------------------------------------------------------------------------------------|---------------------------|--------------|
| Max execution time                                                                   | 150 seconds (2,5 minutes) | No limit     |
| Can use the Return action to return a result directly to the caller                  | Yes                       | No           |
| Can use the Return HTTP File response action to return a file directly to the caller | Yes                       | No           |
| Requires polling for completion                                                      | No                        | Yes          |

