# Get Run log

Gets the log entries for a Flow Run.

```http
[GET] api/v1/tenants/{tenantId}/workspaces/{workspaceId}/flows/{flowId}/diagnostics/executions/{jobId}/log
```

#### Response

Returns a collection of log entries.

```json
[    
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
```
