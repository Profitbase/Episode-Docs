# Poll

Use this API to poll a long-running Flow for completion, and get log items while the Flow is running.  

```http
api/v1/tenants/{tenantId}/workspaces/{workspaceId}/flows/{flowId}/diagnostics/executions/{jobId}/poll?logItemId={logItemId}
```

#### Parameters

| Parameter   |  Description         |
|-------------|----------------------|
| jobId       | The job id returned from the [submit](submit-long-running.md) response |
| logItemId   | The largest logItemId in the logItems collection returned from the response object described below. Set this value to 0 on the first request. |


#### Response
```json

{
    "executionState": FlowExecutionState (number),
    "logItems": [
        {
            "flowId": "string",
            "jobId": "string",
            "nodeId": "string",
            "data": "string",
            "type": LogType (number),
            "logTimeStamp": "string",
            "logItemId": number
        }
    ]
}

```

**FlowExecutionState**  

| Value    | Description      |
|----------|------------------|
| 0        | Submitted        |
| 1        | Running          |
| 2        | Completed ok      |
| 3        | Completed with warning |
| 4        | Failed           |


**LogType**  

| Value | Description      |
|-------|------------------|
| 1     | Debug            |
| 2     | Information      |
| 3     | Success          |
| 4     | Warning          |
| 5     | Error            |

