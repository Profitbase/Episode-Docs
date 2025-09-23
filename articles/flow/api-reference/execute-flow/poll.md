# Poll

Use this API to poll a long-running Flow for completion, and get log items while the Flow is running.  

```http
[GET] corellia/api/v1/tenants/{tenantId}/workspaces/{workspaceId}/flows/{flowId}/diagnostics/executions/{jobId}/poll?logItemId={logItemId}
```

#### Parameters

| Parameter   |  Description         |
|-------------|----------------------|
| jobId       | The job id returned from the [submit](submit-long-running.md) response |
| logItemId   | The largest logItemId in the logItems collection returned from the response object described below. Set this value to 0 on the first request, then use the largest logItemId from the logItems collection described below on subsequent requests.  |


#### Response
```json

{
    "executionState": number (0 = Submitted, 1 = Running, 2 = Completed ok, 3 = Completed with warning, 4 = Failed),
    "logItems": [
        {
            "flowId": "string",
            "jobId": "string",
            "nodeId": "string",
            "data": "string",
            "type": number (1 = Debug, 2 = Information, 3 = Success, 4 = Warning, 5 = Error),
            "logTimeStamp": "string (UTC datetime)",
            "logItemId": number
        }
    ]
}

```
