---
title: "Function Macros"
metaKeys: "Writing macros, Accessing arguments, Function , Non-function macros, Expansion, MacroExpansionProvider API, SqlCommandService, ObjectModel "
pageIndex: 1
---


### Function macros

Function macros have the following characteristics:

*	They **must** be implemented as methods in a class that inherits from the MacroExpansionProvider base class

*	They **must** return a string or a Taskm *< string >*

*	They can have 0 or n parameters

*	They **must** be used on the form {{Macro()}} – **Note the open an closing parenthesis ()**

<br/> Because a Function macro can accept arguments, you can use it multiple places in the same query by providing different arguments to produce different expansions. 
<br/><br/>

>**Example**
>
>This example shows how to create a function macro which takes one argument.  
>You can use it in a SQL query like this: 
>
```
SELECT {{MyRowCount(30}} … which will produce SELECT TOP 30 …
```
>
        namespace Local
        {
            using System; 
            using System.Collections.Generic;
            using System.Threading.Tasks;
            using Profitbase.Invision.Scripting.Dynamic;
            public class MyMacros : MacroExpansionProvider
            {                
                public string MyRowCount(int num)
                {
                    return $"TOP {num}";
                }
            }
        }

<br/>

### Non-function macros

Non-function macros have the following characteristics:

*	They must be resolved in the RunAsync override method of a class that inherits from the MacroExpansionProvider base class

*	The RunAsync method returns a collection of **Expansion** objects. An Expansion object must contain the macro name and the expansion itself (the value that the macro produces)

<br/> Because Non-Function macros cannot accept arguments, they will always produce the same result, so you cannot use them multiple places in the same query unless you want the same SQL expression to be inserted at the different locations.
<br/>
<br/> 

>**Example**
>
>This example shows how to produce the expansions Non-function macros. Non-function macros cannot take any arguments, and they will always produce the same value for the same execution.
>
        namespace Local
        {
            using System; 
            using System.Collections.Generic;
            using System.Threading.Tasks;
            using Profitbase.Invision.Scripting.Dynamic;
            public class MacroRuntime : MacroExpansionProvider
            {
                public override async Task<IEnumerable<Expansion>> RunAsync()
                {
                    var list = new List<Expansion>();
                    list.Add(new Expansion("WhereClause", "Qty > 2"));  
                    // Expansion of the WhereClause macro 
                    var columnNames = await ObjectModel.ForObject("WebApp Basic Store")  
                    .Storage().GetColumnNamesAsync();
                    list.Add(new Expansion("ColumnNames", string.Join(",", columnNames))); 
                     // Expansion of the ColumnNames macro
                    return list; 
                }  
            }
        }



