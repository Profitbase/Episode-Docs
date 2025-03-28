
# Using Macros in SQL Statements

You can put macros into any part of a SQL Script or Report query. Macros are not constraind to any particular part of SQL queries, for example WHERE clauses. You can even define your entire SQL query using just macros. 

To add a macro to a SQL query, use the **{{ and }}** tokens to indicate the beginning and end of a macro, for example **{{MyWhereClause(@ProductID)}}**, where **MyWhereClause** is a macro that takes one argument.
<br/>

#### Example

This example  shows how to dynamically generate a SQL query using macros. As you can see, we’re using both Function and Non-Function macros (macros that takes arguments, and those who don’t).

```sql
    SELECT {{ColumnNames}} 
    FROM @Object[WebApp Basic Store,DataStore].DbObjectName 
    WHERE {{WhereClause}} AND {{FilterOnQuantity(10)}} 
    {{OrderByAsync()}}

```

<br/>

There are 4 macros here – **ColumnNames**, **WhereClause**, **FilterOnQuantity** and **OrderByAsync**. ColumnNames and WhereClause are Non-Function macros (they do not have a parameter list), while FilterOnQuantity and OrderByAsync are function macros (they do have a parameter list). Non-function and Function macros does not differ in where they can be used, but how they can be used and how they are implemented.

The code below shows the core concepts of how these macros can be implemented.  
Notice how the method names of the Function macros match the names of macros in the SQL expression and that they return a string.  
Notice also that the expansions for the Non-Function macros are defined in the **RunAsync** method.

```csharp

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
            
            var columnNames = await ObjectModel.ForObject("WebApp Basic Store").Storage().GetColumnNamesAsync();
            
            list.Add(new Expansion("ColumnNames", string.Join(",", columnNames)));  
            // Expansion of the ColumnNames macro
            return list; 
        }
        
        // Expansion of the FilterOnQuery macro
        public string FilterOnQuantity(int num)
        {
            return $"Qty < {num}"; 
        }
        
        // Expansion of the OrderByAsync macro
        public Task<string> OrderByAsync()
        {
            return Task.FromResult("ORDER BY AccountID");
        }
    }
}

```