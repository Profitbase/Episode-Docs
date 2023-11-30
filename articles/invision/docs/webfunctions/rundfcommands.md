
# Run Data Flow Commands from Web Functions

## DataFlowService

To run Data Flow commands against the InVision database from Web Functions, use the DataFlowService.

<br/>


**Two new supported API's:**

>`GetRunningDataFlowsAsync()`

<br/>

**Example**


```
    public sealed class DataFlowGetRunning : WebFunction
    {
        public async Task<IActionResult> Run(HttpRequest request)
        { 
            var res = await this.DataFlowService.GetRunningDataFlowsAsync();
            return Ok(JsonSerializer.Serialize(res));
        }
    }
```


<br/>

>`StopDataFlowAsync("<task-id>")`

<br/>

**Example**

```
    public sealed class DataFlowStop : WebFunction
    {
        public async Task<IActionResult> Run(HttpRequest request)
        { 
            var taskId = GetRequestQueryString(request, "taskId");
            await this.DataFlowService.StopDataFlowAsync(taskId);
            return Ok();
        }
    }
```

