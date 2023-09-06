---
title: "Run PowerShell Scripts from Web Functions"
metaKeys: "How to run PowerShell scripts from Web Functions, PowerShellService, PowerShell"
pageIndex: 3
---

### Example

<br/>

```csharp
public sealed class MyWebFunction : WebFunction
{       
    public async Task<IActionResult> Run(HttpRequest request)
    {
         var jobItemId = GetRequestQueryString(request, "jobItemId");
         var jobId = GetRequestQueryString(request, "jobId");
         // be0c3835-f47d-4f03-bfa4-fa82aa48d751 is the Id of the PowerShell script.
         // You can get the id by right clicking the PowerShell script in the Solution Expolorer and click "Copy id to clipboard"
         await this.PowerShellService.ExecuteScriptAsync("be0c3835-f47d-4f03-bfa4-fa82aa48d751", new Dictionary<string,object>
         {
               {"jobId", jobId},
               {"jobItemId", jobItemId}
          });

          return Ok();
    }
}
```
