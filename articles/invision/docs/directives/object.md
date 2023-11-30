
# Object Directives

**@Object[name[,object type]].< property > directives**

Gets the value of the specified property for the Solution object. If the Solution contains more than one item with the same name, the object type must be specified. If the addressing is still ambiguous, the call to the directive fails. 

**Object types**

This is the list of valid object types that can be used in a @Object[name,object type] directive.


* Dimension
* Fact
* DataStore
* Setting
* DataFlow
* StoreGroup
* Script
* View
* Workflow

<br/>


**@Object[name[,object type]].TimeFrameDateExpr**

Returns the Time Frame Date for a Data Store, Data Store Group or Setting as a SQL expression.

*	**Returns**  
CAST(< yyyyMMdd > AS DateTime)


>**Example**
>
>This example shows the resulting SQL query from a directives enchanged source SQL query.  
>Suppose the Time Frame Reference Date is 2014.01.01 and the db table name of the Invoice Data Store is "Invoice_123", InVision will change the source query before execution as follows;
>
 ```
 SELECT *  
 FROM @Object[Invoices].DbObjectName  
 WHERE SalesDate > = @Objec[Invoices].TimeFrameDateExpr
 ```
>
 ```
 SELECT *  
 FROM Invoices_123  
 WHERE SalesDate > CAST('20140101' as datetime)
 ```

<br/>


**@Object[name[,object type]].ConnectionString**

Gets the connection string to the database containing the specified Solution Object (dimension, Fact, Data Store, Setting or View).

>**Example**
>
```
@Object[Sales].ConnectionString  
// returns the database connection string for the Solution object 'Sales'.
```


<br/>


**@Object[name[,object type]].Id**

Gets the metadata id of the Solution object. All Solution Objects are uniquely identified by metadata ids, not the display names. When executing system tasks, InVision expects the metadata id of the objects to be passed as arguments, so you can use this directive to make InVision resolve the Id for you by specifying the name of the Solution Object. 

>**Example**
>
 ```
 @Object[Sales].Id  
 // returns the metadata if of the Solution Object 'Sales'.
 ```


<br/>


**@Object[name[,object type]].DbObjectName**

Gets the actual database object name of a Solution Object (applicable to Dimensions, Facts, Data Stores, Settings and Views).

You can use this directive in SQL queries and argument lists whenever you need to get the database name of a Solution Object.

>**Example**
>
>Suppose the table name of "Sales" is "Sales_123"
>
 ```
 SELECT *  
 FROM @Object[Sales].DbObjectName
 ```
>
 >is converted to
>
 ```
 SELECT *  
 FROM Sales_123
 ```


<br/>



**@Object[name[,object type]].Lookup[ < Row Key Expression > ][ValueColumn]**

Gets the value of a column by specifying the row key expression.
Using this feature, you can create repositories which can be queried by other components of the Solution.

**Row Key Expression**

The Row Key Expression defines the key used for searching the repository. 
The Row Key Expression can be defined with or without curly brackets ( "{" and "}" ). You can skip the curly brackets if all the search columns are character based. If you are searching using a numeric or date column, you need to use curly brackets.

* **Searching character based columns**
  
Searching a single column:  
``@Object[<Name>].Lookup[KeyID:KeyValue][ValueColumn]``

Searching multiple columns:  
``@Object[<Name>].Lookup[KeyID:KeyValue, KeyID2:KeyValue2,...][ValueColumn]``



>**Example**
>
>This example shows how to use a Setting table as a Solution registry for common settings, and query the table in order to perform some task, which in this case is to execute a stored procedure. 
>
>*SlnRegistry (registry)*
>
>| Key                    	| Value                        	|
|------------------------	|------------------------------	|
| ActivePeriod           	| 20140101                     	|
| Update External System 	| proc_UpdateExtSysAndSendMail 	|
>
```
EXEC @Object[SlnRegistry].Lookup[**Key**:Update External System][**Value**]
```
>
>translates to
>
```
EXEC proc_UpdateExtSysAndSendMail
```


*	**Searching characther and non characther based columns**

Searching a single column:  
``@Object[<name>].Lookup[{ KeyID,KeyValue }][ValueColumn]``

Searching multiple columns:  
``@Object[<name>].Lookup[{ KeyID:KeyValue, KeyID2:KeyValue2,... }][ValueColumn]`` 

When the columns used in the search criteria are not charachter based (nvarchar, varchar, etc), the Row Key Expression must be defined as a JSON object. 

>**Examples**
>
>The AccountID column has a charachter based data type. 
```
@Object[<name>].Lookup[{ "AccountID":"2000" }][AccountName]
```
>
>The Amount column has a numeric data type.
```
@Object[<name>].Lookup[{ "Amount":2000 }][AccountName]
```
>
>The BitField column is of data type bit.
```
@Object[<name>].Lookup[{ "BitField":true }][BitFieldValue]
```


<br/>

**@Object[name[,object type]].Column[name].TimeFrameDateExpr**

Gets the prepared SQL expression that calculates the date of a Time Frame column. 	


*	**Returns**  
``DATEADD(<datepart>,<number>,CAST(<yyyyMMdd>) AS DateTime)``

<br/>

**@Object[name[,object type]].Column[name].TimeFrameDateStr**

Gets the date of a Time Frame column represented as a string.


*	**Returns**  
String on the format yyyyMMdd 

<br/>

**@Object[name[,object type]].Column[name].TimeFrameDateTime**

Gets the date of a Time Frame column as a .NET ``DateTime`` object.


*	**Returns**  
.NET ``System.DateTime`` object

<br/>

**@Object[name[,object type].Alias**

Gets the alias used for a database object in a SQL query generated by the system. Works similarly to ``@Context.ObjectAlias``, except that it returns the alias for every non-primary table which is part of the generated query. 

<br/>

**@Object[name[,object type]].DataSet**

Gets the Data Set Name of the object. Only applicable to Workflows.
