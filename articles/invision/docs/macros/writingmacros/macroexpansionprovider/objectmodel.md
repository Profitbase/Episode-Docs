---
title: "ObjectModel"
metaKeys: "Writing macros, Accessing arguments, Function , Non-function macros, Expansion, MacroExpansionProvider API, SqlCommandService, ObjectModel "
pageIndex: 4
---





### MacroExpansionProvider.ObjectModel

The ObjectModel API provides access to metatadata information about the objects in the solution, for example getting connection strings, database table names for materialized objects, column names in the materialized objects etc. (Examples further down).
<br/>

**Method:**

``IObjectModelReference Object(string solutionObjectName)``
>Returns an instance of a metadata providerservice for the specified solution object.

<br/>


**Method:**

``IDimensionReference Dimension(string dimensionName)``
>Returns an instance of a metdata provider service for the dimension with the specified name.


### IObjectModelReference
<br/>

**Method:**

``IObjectModelStorageService Storage()``
>Returns an instance of a service that provides information about the materialized storage object (database table) of a solution object.

<br/>

**Method:**

``IDimensionMetadataService Metadata()``
>Retuns an instance of a service that provides metadata information about the dimension.

<br/>






### IObjectModelStorageService

Provides APIs for accessing information about the materialized storage object (database table) of a solution object
<br/>

**Method:**

``Task<IEnumerable<string>> GetColumnNamesAsync(bool includeSystemColumns = false)``
>Returns the column names in the database tableof the solution object.

``Task<string> GetConnectionStringAsync()``
>Returns the connection string to the database table.

``Task<string> GetDbObjectNameAsync()``
>Returns the database object name (table, view) of the solution object.


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



### IDimensionMetadataService
<br/>

**Method:**

``Task<Hierarchy> GetHierarchyAsync(string? name = null)``
>Returns the hierarchy with the specified name. If no name is specified, the first hierarchy is returned.

<br/>

### Hierarchy
<br/>

**Methods**

``string GetIdColumn()``
>Returns the name of the leaf level column which contains the id of the dimension member

``string GetNameColumn(string? langId = null)``
>Returns the name of the leaf level column which contains the display name of the dimension member

``string GetIdColumn(int level)``
>Returns the name of the column at the specified level which contains the id of the dimension member

``string GetNameColumn(int level, string? langId = null)``
>Returns the name of the column at the specified level which contains the display name of the dimension member

<br/>

**Example**

The following example shows to use the dimension metadata API to create a SQL query which will return data from the leaf and level 1.
It will generate the following query:

```
SELECT  L1, L1_Name,ItemID, ItemID_Name_EN 
FROM Dim_MyDim_11062021094945 
```
<br/>

```
namespace Local
{
    using System; 
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Profitbase.Invision.Scripting.Dynamic;
    
    public class MyMacros : MacroExpansionProvider
    {    
        public async Task<string> CreateQuery()
        {
            var hierarhcy = await this.ObjectModel.Dimension("PCDim").Metadata().GetHierarchyAsync();
            var tableName = await this.ObjectModel.Dimension("PCDim").Storage().GetDbObjectNameAsync();
            
            var idColumnName = hierarhcy.GetIdColumn(1);
            var displayColumnName = hierarhcy.GetNameColumn(1);
            
            var leafIdColumnName = hierarhcy.GetIdColumn();
            var leafDisplayColumnName = hierarhcy.GetNameColumn(this.Context.LanguageCode);
            
            return $"SELECT {idColumnName}, {displayColumnName},{leafIdColumnName}, {leafDisplayColumnName} FROM {tableName}";
        }
    }
}
```

