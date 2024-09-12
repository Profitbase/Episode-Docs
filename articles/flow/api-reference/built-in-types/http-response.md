# HttpResponse&lt;T$gt;

Contains information about a response from an HTTP API, including the received data.

## Properties

<!--prettier-ignore-->
| Name            | Data type                                                                 | Description                                                                                                |
| --------------- | --------------------------------------------------------------------------| ---------------------------------------------------------------------------------------------------------- |
| IsSuccess       | [bool](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)       | Specifies whether the Http Request return an HTTP success status code (Range 200-299).                     |
| StatusCode      | [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)        | The HTTP Status code of the request.                                                                       |
| Headers         | [Dictionary&lt;string,string&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2) | The response headers returned from the HTTP request.         |
| ContentTypeName | [String](https://learn.microsoft.com/en-us/dotnet/api/system.string)     | The content type of the response, for example `application/json`.                                           |
| Content         | T          | The data returned from the HTTP request. The data type is specified by the Flow developer, and Flow will automatically convert the raw HTTP response to an instance of T. |
