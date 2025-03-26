# Run streaming

Runs a Flow that asynchronously streams data back to the client.
The maximum allowed execution time is `300 seconds (5 minutes)`. 

```http
[POST] api/v1/tenants/{tenantId}/workspaces/{workspaceId}/flows/{flowId}/run-streaming?env={env}&api_key={apikey}
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

**Body**  
The API returns a stream back to the client, which can be read until the end of the stream. See example below for how to implement clients that can read a streaming API.

**Headers**  
`flow-job-id`: The id of the job. You can use this value to get the log for the run if you need to. 

<br/>
<br/>

### Example - Streaming clients

Below are sample implementations of streaming clients. You can also paste the Flow HTTP Endpoint into the browser and inspect the response in the `Network tab` (in developer tools), use the Thunder client VS Code extension, Postman or any other tool.

# [C#](#tab/csharp)

```csharp
public async Task RunStreamingAsync(string url)
{
    string url = "FLOW_HTTP_ENDPOINT (POST or GET)";
    using var client = new HttpClient();
    using var request = new HttpRequestMessage(HttpMethod.Post, url);
    using var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);

    response.EnsureSuccessStatusCode();

    await foreach (var item in ReadStreamAsync<object>(response.Content))
    {
        Console.Write(item);
    }    
}

private async IAsyncEnumerable<T> ReadStreamAsync<T>(HttpContent content)
{
    var stream = await content.ReadAsStreamAsync();
    await foreach (var item in JsonSerializer.DeserializeAsyncEnumerable<T>(stream))
    {
        if (item != null)
        {
            yield return item;
        }
    }
}
```

