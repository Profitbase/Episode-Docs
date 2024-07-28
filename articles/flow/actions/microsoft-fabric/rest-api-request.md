# Microsoft Fabric REST API Request

The REST API Request action enables you to call [Microsoft Fabric REST APIs](https://learn.microsoft.com/en-us/rest/api/fabric/articles/using-fabric-apis) to automate Fabric processes, such as deploying, updating, or deleting objects, or running dataflows and pipelines.  

### Start by creating a Connection

The first thing you need to do is create a [Microsoft Fabric Connection](./microsoft-fabric-connection.md). Microsoft Fabric only allows authenticated requests, so you cannot make any calls to the API until this step is done.   
Depending on which Fabric service you want to use, you may also need to explicitly grant permissions to resources within the service itself. For example, if you want to access a Power BI resource, you need to go to the Power BI admin portal and grant the Service Principal (Entra ID App) access to the resources you want to access.

### Pagination  
Some Microsoft Fabric REST API breaks large data sets up into smaller chunks when delivering data to clients. [You can read more about this feature here](https://learn.microsoft.com/en-us/rest/api/fabric/articles/pagination). 

The `REST API Request action` handles pagination automatically for you, so you don't have to make multiple calls in order to get all records if the Fabric API splits the data set into multiple pages.  
Note that when you call an API that might return a paginated response, you are requierd to define the return type as [List&lt;T&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1) or a type **derived** from [List&lt;T&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1).