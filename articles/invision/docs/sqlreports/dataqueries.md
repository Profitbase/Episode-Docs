---
title: "Data Queries"
metaKeys: "Data Queries, SQL Directives, standard, Declare, Object, Id, Values, Custom Parameters "
folderOnly: "false"
pageIndex: 3
---



Data Queries are scripts used for loading and saving data. Data Queries are written using standard T-SQL queries which can be extended using **SQL Directives** to enable a dynamic behavior relative to the Solution and execution context. Before a Data Query is executed, InVision scans for SQL directives and changes the query accordingly. 

When creating Data Queries, you can access any SQL data source by providing the connection string. When accessing InVision resources, you do not need to specify a connection string.
<br/>

### SQL Directives

SQL directives are instructions added to standard SQL expressions which are executed by InVision before sending the query to the database. Before SQL queries are executed, InVision scans for SQL directives and changes the queries accordingly. SQL directives are required when filter values or parameters are passed during execution time and when you want to refer to Solution database objects without hard coding the table or column names. 
<br/>

**Standard directives**

``@Declare_FilterAlias(<Filter name>[,alias])``
>
>Specifies that a query uses a filter, and that filter values passed to the execution of the query will change the data set returned.
>
>The @Declare_FilterAlias statement(s) must be added at the very top of the query.

``@Object_Name(alias)``
>
>Returns the database table name that the filter is pointing to. 
>The alias parameter refers to the alias specified by the filter declaration. 

``@Id_Column(alias)``
>
>Returns the column name of the column specified as the ID column of a filter. The alias parameter refers to the alias specified by the filter declaration. It is recommended to use this function instead of hard coding the column name in the query because it allows you to change the filter configuration without breaking the query.

``@Values_Equal(alias[,mapTo])``
>
>@Values_Equal is used for dynamically creating a comparison statement in the query using the ‘IN’ operator to compare the values passed as the filtering values to the filter id column or optionally to the column specified as argument number two. 
>
>**Note** *that you cannot use the **mapTo** parameter if the filter is set up to use Filter Mode **Filter by Hierarchy** and the dimension has more than one level.*

>**Example**
>
>Suppose you have declared the Product filter in a query. The ID column of the Products filter is ProductID. The user selects two products from the Product filter, "P-001" and "P-002" and then executes the query.
>
>This example shows how the WHERE clause is constructed based on the filter values passed during execution.
>
    @Declare_FilterAlias(Products,p)
    SELECT s.ProductID,s.Qty,… 
    FROM @Object[ProductsInStore].DbObjectName s
    JOIN @Object_Name(p) p ON s.ProductID = p.[@Id_Column(p)]
    WHERE @Values_Equal(p)
    //The actual SQL query executed, given the table name formProductsInStore is  
    //ProductsInStore_xyz and the table used by the Products filter is Products_xyz,  
    //will be this one;
    Compiled query
    SELECT s.ProductID, s.Qty
    FROM ProductsInStore_xyz s
    JOIN Products_xyz p ON s.ProductID = p.[ProductID]
    WHERE (p.ProductID IN('P-001', 'P-002'))
    //Using the mapTo version of the directive will produce the following WHERE clauses:
    WHERE @Values_Equal(p,s.ProductID) => WHERE (s.ProductID IN('P-001','P-002'))


``@Values_NotEqual(alias[,mapTo])``
>
>The same as @Values_Equal(…), except it's being compared for inequality instead of equality.

``@Values_GreaterThan(alias[,mapTo,AND | OR})``
>
>@Values_GreaterThan is used for dynamically creating a comparison statement in the query using the ‘``>``’  (greater than) operator to compare the values passed as the filtering values to the filter id column or optionally to the column specified as argument number two. If more than one filter value is passed, the OR operator is applied for each comparison unless AND is passed as argument number 3.
>
>**Note** *that you cannot use the **mapTo** parameter if the filter is set up to use Filter Mode **Filter by Hierarchy** and the dimension has more than one level.*

>**Example**
>
>Suppose you have declared the Product filter in a query. The ID column of the Products filter is ProductID. The user selects two products from the Product filter, "P-001" and "P-002" and then executes the query.
>
>This example shows how the WHERE clause is constructed based on the filter values passed during execution.
>
    @Declare_FilterAlias(Products,p)
    SELECT s.ProductID,s.Qty,… 
    FROM @Object[ProductsInStore].DbObjectName s
    JOIN @Object_Name(p) p ON s.ProductID = p.[@Id_Column(p)]
    WHERE @Values_GreaterThan(p)
    //The actual SQL query executed, given the table name for  
    //ProductsInStore is ProductsInStore_xyz and the table used by the  
    //Products filter is Products_xyz, will be this one;
    Compiled query
    SELECT s.ProductID, s.Qty
    FROM ProductsInStore_xyz s
    JOIN Products_xyz p ON s.ProductID = p.[ProductID]
    WHERE (p.ProductID > 'P-001' OR p.ProductID > 'P-002')
    //Using the mapTo version of the directive will produce the following WHERE clauses:
    WHERE @Values_GreaterThan(p,s.ProductID) =>  
    WHERE (s.ProductID > 'P-001' OR s.ProductID > 'P-002')
    WHERE @Values_GreaterThan(p,null, AND) =>  
    WHERE (p.ProductID > 'P-001' AND s.ProductID > 'P-002')
    WHERE @Values_GreaterThan(p,s.ProductID, AND) =>  
    WHERE (s.ProductID > 'P-001' AND s.ProductID > 'P-002')


``@Values_GreaterThanOrEqual(alias[,mapTo,AND | OR])``
>
>Similar to the @Values_GreatherThan, except that comparison operator is ‘``>=``’ (greater than or equal)

``@Values_LessThan(alias[,mapTo,AND | OR])``
>
>Similar to the @Values_GreatherThan, except that comparison operator is ‘<’ (less than)
>@Values_LessThanOrEqual(alias[,mapTo,AND | OR])
>Similar to the @Values_GreatherThan, except that comparison operator is ‘<=’ (less than or equal)

### Custom Parameters

You can add custom parameters directly to queries which enables filtering without using SQL directives. 

>**Example**
>
>This example shows a query using a custom parameter, @ItemID, in the  
WHERE clause
>
    SELECT *  
    FROM @Object[MyTable].DbObjectName
    WHERE ItemID = @ItemID


To pass values to custom parameters, you need to use the [SetParamValue(…)]() directive when executing the query from the Workbook context.

<br/>

#### Videos

- [Table View](../../videos/tableview.md)
- [Table View - Declaring Filter](https://profitbasedocs.blob.core.windows.net/videos/Table%20View%20-%20Declaring%20Filter.mp4)

<br/>