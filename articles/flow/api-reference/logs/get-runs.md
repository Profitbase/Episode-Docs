# Get Runs

Returns a list of all runs for the specified Flow.  
To get the details for a run, use the [Get Run Log](get-run-log.md) API.

```http
[GET] corellia/api/v1/tenants/{tenantId}/workspaces/{workspaceId}/flows/{flowId}/diagnostics/executions?env={env}
```

#### Parameters
| Parameter      | Description            |
|----------------|------------------------|
| env            | `Development`, `Test` or `Production` <br/> OR <br/> `0` (Development), `1` (Test), `2` (Production) |

#### Response

Returns a collection of items. Use the [Get Run Log](get-run-log.md) API to get the log entries for a specific `jobId`.

```json
[
    {
        "jobId": "string",    
        "tenantId": "string",
        "workspaceId": "string",
        "flowId": "string",
        "environment": number (0 = Development, 1 = Test, 2 = Production),
        "message": "string",
        "state": number (0 = Submitted, 1 = Running, 2 = Completed ok, 3 = Completed with warning, 4 = Failed),
        "startTime": "string (UTC datetime)",
        "endTime": "string (UTC datetime)"
        
    }
]
```
 