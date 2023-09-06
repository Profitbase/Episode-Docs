---
title: "Macros"
metaKeys: "Macros, dynamically create, execute SQL queries, combined with standard SQL"
folderOnly: "false"
pageIndex: 16
---

<br/>

#### Macros

Macros can be used in Reports and SQL Scripts to dynamically create and execute SQL queries at runtime without using SQL string concatenation to construct them and sp_executesql for execution. Macros are written in C#, which offers great flexibility in how and which macros you want to create.

The query below shows an example of how macros can be combined with standard SQL. The {{ and }} tokens specify the presence of a macro. The macro itself is called “MyRowCount”, and it takes 1 numeric argument.

    SELECT {{MyRowCount(100)}} *
    FROM [Store_WebAppBasicStore_05052015115318]

<br/>The macro implementation itself looks like this:

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

<br/>So in this simple case, the resulting SQL will be:

    SELECT TOP 100 *
    FROM [Store_WebAppBasicStore_05052015115318]

<br/>

#### See Also

- [Using Macros in SQL Statements](macros/usingmacros.md)
- [Writing Macros](macros/writingmacros.md)

#### Video
* [Macro Expansion](../videos/tableview.md)
* [Table View - Macro Expansion](https://profitbasedocs.blob.core.windows.net/videos/Table%20View%20-%20Macro%20Expansion.mp4)
