# Convert

Converts between objects of different data types, for example string to number or date.
You should also use this action if you need to convert JSON, streams, byte arrays, collections or business objects / custom types.

![img](../../../../images/flow/convert.png)

**Example** ![img](../../../../images/strz.jpg)  
This flow illustrates using the [Tools AI Agent](../agents/tools-ai-agent.md) to retrieve a list of all blobs in an Azure Storage container and return the result as a JSON string. We then convert the returned JSON string to a business object containing the list of files so we can add it to the table.
</br>


## Properties

| Name                 | Type     | Description                                                                                          |
|----------------------|----------|------------------------------------------------------------------------------------------------------|
| Title                | Optional | The title or name of the action.                                                                     |
| Object to convert    | Required | The object (e.g. variable or expression) that should be converted.                                   |
| Type to convert to   | Required | The target data type the object should be converted into.                                            | 
| Result variable name | Optional | The name of the variable to store the converted value.                                               |
| Description          | Optional | Additional notes or comments about the action or configuration.                                      |



The Convert action supports the following conversions:

| From type               | To type                                 |
|-------------------------|-----------------------------------------|
| Any [built-in .NET Type](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types)  | Any [built-in .NET type](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types)                  |
| Custom type             | JSON                                    |
| Anonymous type          | Custom type                             |
| String                  | byte array (`byte[]`), encoding: UTF-8 (default), Base64, Unicode (UTF-16), BigEndianUnicode (UTF-16 BE)            |
| byte array (`byte[]`)   | String, encoding: UTF-8 (default), Base64, Unicode (UTF-16), BigEndianUnicode (UTF-16 BE)            |
| [Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream)                  | byte array (`byte[]`)                             |
| Object                  | JSON string encoded as UTF8 byte array  |
| String                  | [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable)                               |
| [IEnumerable<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)          | [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable)                               |
| String                  | Custom type                             |
| UTF8 JSON Stream        | Custom type                             |
| UTF8 JSON Stream        | .NET [built-in type](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types)  |
| UTF8 JSON string        | Custom type                             |
| UTF8 JSON string        | .NET [built-in type](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types) |
| [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable)               | [Supported collection types for deserialization](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/supported-collection-types)                          |



