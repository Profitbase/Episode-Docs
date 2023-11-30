
# Web Functions

Web Functions enables you to easily **write**, **test**, **host** and **execute** custom HTTP APIs (Web Services) in InVision. Typical use cases for Web Functions are:

- You need to call external Web Services, such as Azure Functions, Microsoft Cognitive Services, or any other 3rd party (web) APIs, and return the result to the InVision backend or a Workbook.

- You need to call external web services that require authentication.

- You create microservices to handle custom business logic in customer projects, and you want to call these services from Workbooks.

- You need to combine the execution of external web services and internal resources, such as SQL scripts.

Web Functions are written in **C#**.
<br/>

 
## Creating Web Functions
 
When you create a new Web Function, the default template will look like this:




    namespace Custom.WebFunctions 
    {   
        using System;  
        using System.Net;  
        using System.Text; 
        using System.Data;
        using System.Linq;
        using System.Dynamic;
        using System.Net.Http;
        using System.Collections.Generic;
        using System.Threading.Tasks;
        using Newtonsoft.Json;
        using Newtonsoft.Json.Linq;
        using Profitbase.Invision.WebFunctions; 

        public sealed class MyWebFunction : WebFunction
        {
            public async Task<IActionResult> Run(HttpRequest request)
            { 
                return await Task.FromResult(Ok()); 
            }
        }
    }

<br/>
As you can see, this is just a normal C# class with a single method **Run**, that accepts a single argument and returns a HTTP response. A Web Function must follow 3 simple rules, but besides that, you can do whatever you want: 


1. A Web Function must always **implement a public Run method**,
2. The Run method must **accept a single argument, the HttpRequest**,
3. The Run method must return a **IActionResult**.

A Web Function can inherit from the **WebFunction base class**. This gives you access to built-in APIs from InVision.

<br/> 






## See Also

- [Run WebFunctions from Workbooks](webfunctions/calling.md)
- [Run WebFunctions from Forms](webfunctions/run-from-forms.md)
- [Run PowerShell Scripts from Web Functions](webfunctions/runsqlscripts.md)
- [Run SQL Scripts from Web Functions](webfunctions/runsqlscripts.md)
- [Run SQL Commands from Web Functions](webfunctions/usesqlcommands.md)
- [Run Data Flow Commands from Web Functions](webfunctions/rundfcommands.md)
- [Testing](webfunctions/testing.md)