# Submit

Submits a long-running Flow for execution, and returns a job id that can be used for polling for completion.  
```http
[POST] api/v1/tenants/{tenantId}/workspaces/{workspaceId}/flows/{flowId}/submit?env={env}&api_key={apikey}
```

View the [execution endpoints](../../flows/execution-endpoints.md) of the Flow to find the exact address to use.

#### Parameters

This API can be called with a JSON or binary payload as the `HTTP body`. Use the [HTTP Trigger](../../triggers/http-trigger.md) do define how the input is deserialized in the Flow.

| Parameter      | Description            |
|----------------|------------------------|
| env            | `Development`, `Test` or `Production` <br/> OR <br/> `0` (Development), `1` (Test), `2` (Production) |
| api_key        | An API key with the `Execute` policy  |

#### Headers

| Header      | Description               |
|-------------|---------------------------|
| x-api-key   | An API key with the `Execute` policy  |

>[!NOTE]
> When executing a Flow using this API, you must include the API key in either the query string OR the header, but not both.

#### Response
```json
{
    "jobId": "string"
}
```

Use the [Poll](poll.md) API to poll for completion and get the execution log while the Flow is running.