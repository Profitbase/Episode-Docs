### Extract data from nested field
JSON documents that you want to convert to a tabular format MUST contain the tabluar data at the root level, start and end with curly brackets (`{` and `}`), OR start and end with square brackets (`[` and `]`). If this is not the case, you must modify the JSON string before it's passed in. 
For example, if you have a JSON document like below where the data you want to convert to a tabular format is stored not at the document root level, you need to "drill into" the JSON document and extract the array (from the Finance property).
You can do that using a [Function](../built-in/function.md) that takes the JSON as input and returns a string using the following syntax:  

```csharp
private string GetData(string originalJsonDocument)
{
   return JsonDocument.Parse(originalJsonDocument).RootElement.GetProperty("Finance").GetRawText();
}
```

```json
{
   "Finance:" [
      {
         "EntityType": "Budget",
         "Amount": 100,
         "AccountID": 3020
      },
      {
         "EntityType": "Budget",
         "Amount": 200,
         "AccountID": 3010
      }
   ]
}
``` 