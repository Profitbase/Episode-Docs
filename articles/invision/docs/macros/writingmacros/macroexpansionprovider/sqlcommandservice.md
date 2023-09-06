---
title: "SqlCommandService"
metaKeys: "Writing macros, Accessing arguments, Function , Non-function macros, Expansion, MacroExpansionProvider API, SqlCommandService, ObjectModel "
pageIndex: 3
---




### MacroExpansionProvider.SqlCommandService

The SqlCommandService provides an API to execute arbitrary sql commands. (Examples further down).
<br/>

**Methods:**

``Task<T> ExecuteScalarAsync<T>(string connectionString, string query, params SqlParameter[] sqlParameters)``
>Executes a query and returns the first column of the first row on the result of the query.

``Task<IEnumerable<string>> GetColumnNamesAsync(string connectionString, string dbObjectName)``
>Gets the name of all of the columns in the database object.




<br/>

>**Examples**
>
>The following example shows how the Context, SqlCommandService and ObjectModel API can be used to create a macro (SelectList) that returns a collection of columns that can be used as the select list of a query.
>
>
    namespace Local
    {
        using System; 
        using System.Collections.Generic;
        using System.Threading.Tasks;
        using System.Data.SqlClient;
        using System.Linq;
        using Profitbase.Invision.Scripting.Dynamic;
        public class MyMacros : MacroExpansionProvider
        {           
            public async Task<string> SelectList()
            {
                var customerMetadataStorage = this.ObjectModel.ForObject("Customer Metadata").Storage();
                var connectionString = await customerMetadataStorage.GetConnectionStringAsync();
                var customerMetadataTableName = await customerMetadataStorage.GetDbObjectNameAsync();
                var customerCategory = await this.SqlCommandService.ExecuteScalarAsync<int>(connectionString,  
                $"SELECT CustomerCategory FROM {customerMetadataTableName} WHERE CustomerID = @customerId", 
                new SqlParameter("@customerId", this.Context.Arguments.GetValue("@CustomerID")));
                if(customerCategory == 1)
                {
                    return string.Join(",", (await this.ObjectModel.ForObject("Customer Sales")  
                    .Storage().GetColumnNamesAsync()).Where(c => c.Contains("Cat1")));
                }
                else
                {
                    return string.Join(",", (await this.ObjectModel.ForObject("Customer Sales")  
                    .Storage().GetColumnNamesAsync()).Where(c => !c.Contains("Cat1")));
                }
            }
        }
    }

