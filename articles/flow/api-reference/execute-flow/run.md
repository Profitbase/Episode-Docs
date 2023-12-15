# Run

Runs a Flow and returns the response object defined by the Flow definition.
The maximum allowed execution time is `300 seconds (5 minutes)`. If the Flow needs longer than 5 minutes to complete, use the [Submit](submit-long-running.md) API instead.

```http
[POST] api/v1/tenants/{tenantId}/workspaces/{workspaceId}/flows/{flowId}/run?env={env}
```

View the [execution endpoints](../../flows/execution-endpoints.md) of the Flow to find the exact address to use.

#### Parameters

This API can be called with a JSON or binary payload as the `HTTP body`. Use the [HTTP Trigger](../../triggers/http-trigger.md) do define how the input is deserialized in the Flow.

| Parameter      | Description            |
|----------------|------------------------|
| env            | `Development`, `Test` or `Production` <br/> OR <br/> `0` (Development), `1` (Test), `2` (Production) |

#### Response

**Body**  
The API may return a `JSON object` or a binary file ([FileContentResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.filecontentresult)) depending on how the Flow is configured. If the Flow is not configured to return any data, the returned value is `null`.

**Headers**  
`flow-job-id`: The id of the job. You can use this value to get the log for the run if you need to. 