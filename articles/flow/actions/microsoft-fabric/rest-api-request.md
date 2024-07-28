# Microsoft Fabric REST API Request

The REST API Request action enables you to call [Microsoft Fabric REST APIs](https://learn.microsoft.com/en-us/rest/api/fabric/articles/using-fabric-apis) to automate Fabric processes, such as deploying, updating, or deleting objects, or running dataflows and pipelines.  

![img](/images/flow/microsoft-fabric-rest-api-request-action.png)  
<br/>

### Start by creating a Connection

The first thing you need to do is create a [Microsoft Fabric Connection](./microsoft-fabric-connection.md). Microsoft Fabric only allows authenticated requests, so you cannot make any calls to the API until this step is done.   
Depending on which Fabric service you want to use, you may also need to explicitly grant permissions to resources within the service itself. For example, if you want to access a Power BI resource, you need to go to the Power BI admin portal and grant the Service Principal (Entra ID App) access to the resources you want to access.

### Configuring the request


### Pagination  
Some Microsoft Fabric REST API breaks large data sets up into smaller chunks when delivering data to clients. [You can read more about this feature here](https://learn.microsoft.com/en-us/rest/api/fabric/articles/pagination). 

The `REST API Request action` handles pagination automatically for you, so you don't have to make multiple calls in order to get all records if the Fabric API splits the data set into multiple pages.  
Note that when you call an API that might return a paginated response, you are required to define the return type as [List&lt;T&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1) or a type **derived** from [List&lt;T&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1).

### Long running operations
When a Fabric API performs an operation that takes some time to complete, it may return before the operation is still being processed. If you want to wait for the completion of the operation before continuing execution of the Flow, you need to manually poll for the result by making repeated requests using an operation id and location returned from the first response. [Read more about Long running operations here](https://learn.microsoft.com/en-us/rest/api/fabric/articles/long-running-operation).  

When you call a long running API, you should define the return type so that it contains the following properties:
```
location: string
retryAfter: int
operationId: string
```

For example, if you call the [Create Item API](https://learn.microsoft.com/en-us/rest/api/fabric/core/items/create-item?tabs=HTTP), your result data type definition should look like this:  

```csharp
public class ItemCreatedResponse
{
    public string? OperationId {get; set;}
    public int? RetryAfter {get; set;}
    public string? Location {get; set;}

    public string? Id { get; set; }
    public string? DisplayName { get; set; }
    public string? Description { get; set; }
    public string? Type { get; set; }
    public string? WorkspaceId { get; set; }
}
```

If the item was created immediately, the OperationId and Location properties will be null, while the Id, DisplayName etc properties will have a value.  
If the item is being provisioned (meaning it is in the process of being created), you need to use the OperationId and Location to make repeated requests until the API responds with a null-value for the OperationId property.