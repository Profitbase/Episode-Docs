
# Directive(“directive expression”) : System.Object



**Directive(“directive expression”) : System.Object**

Use this function to execute a directive from a C# expression. This function evaluates the directive and returns the value as a System.Object data type.

>**Example**
>
```
(string)Directive("@Object[My Data Store].DbObjectName") == "Some Table Name"
```


**@Context.ObjectAlias**

@Context.ObjectAlias returns the alias assigned to the primary database objects of SQL queries generated by the system.

The system generates SQL queries based on configuration, and in order to be able to add custom SQL snippets to augment the generated queries, you need to ensure that you get the context right. @Context.ObjectAlias will return the alias assigned to the primary database object when a query is generated, and you should use this token in any custom SQL snippets to ensure there are no column reference ambigouities.

**Most commonly used for:**

*	**Store Item Binding Expression or Store Source Filter**  
Returns the alias of the table or subquery being the data source of a Data Store.

 >**Example:** 
 ```
 LEFT(@Context.ObjectAlias.DepartmentID,3) = 'ABC'
 ```

*	**Unpivot Transform Scope Column Value**  
Returns the alias of the table being the unpivot source.

*	**Store Source Unpivot Transform filter**  
Returns the alias of the table being the unpivot source.

*	**Core Set Custom Filter Expression**  
Returns the alias of the (Core Set Source) table that the filter is applied to.

*	**Worksheet Page Part fixed filter**  
Returns the alias of the Data Store database table in a system generated query (loading data).
```  
@Context.ObjectAlias.TransactionType = 'I'  
// will ensure that only rows from the DS having TransactionType = 'I'  are included in the result set.
```

*	**Setting Page Part dynamic filter**  
Similar to the Worksheet Page Part fixed filter, except the alias of the Setting table is returned.
