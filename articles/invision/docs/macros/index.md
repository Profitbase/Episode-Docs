# Macros

You can use macros to dynamically modify SQL scripts at the time of execution.
This means you can define SQL scripts that dynamically change based on arguments passed to them, or based on the state of data or metadata in the system, at runtime.

```sql
    SELECT {{ColumnNames}} 
    FROM @Object[WebApp Basic Store,DataStore].DbObjectName 
    WHERE {{WhereClause}} AND {{FilterOnQuantity(10)}} 
    {{OrderByAsync()}}

```

* [Howto](./howto.md)
* [Usingmacros](./usingmacros.md)
* [Writingmacros](./writingmacros.md)

