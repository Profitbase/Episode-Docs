---
title: "Script"
metaKeys: "Script, Execute, Actions, Executing scripts, Parameterized execution, Script return values, "
folderOnly: "false"
pageIndex: 16
---

 

To execute Script from a [Workbook](../../workbooks.md), it needs to be added to a page. A script does not have a user interface, so you would normally add all scripts to a hidden page. 

<br/>

### Actions

*	**Execute**  
Executes the script. Any arguments are passed by calling SetParamValue(…) one or many times (one for each argument to pass)

<br/>

### Executing scripts

To execute a Script, you need to call the Execute Action of the Script when an event is raised, for example from a button or context menu. When calling the Execute Action, it will wait until the script has finished executing. 

<br/>

### Parameterized execution

Arguments are passed to a Script using the SetParamValue instruction in the Execute Action handler.

<br/>

**Example**
>
>This example shows a Script with a @ProductID parameter. To execute the Script from a Workbook, you need to pass a product id as an argument, or else the execution of the Script will fail.
>
        UPDATE @Object[Sales].DbObjectName
        SET Amount = 0 
        WHERE ProductID = @ProductID
>
>To pass a product id as an argument, you need to call the SetParamValue function in the Execute Action of the Script. The following expression will pass the value of the ProductID variable to the @ProductID parameter.
>
        SetParamValue(«@ProductID»,ProductID);


<br/>

### Script return values

If you have enabled the Script to return data, the first row of the result set returned by the query is serialized an object and assigned to a variable with the same as the Script Workbook part. Starting with version 2.2.3, if your query returns multiple rows, you can access the entire collection of rows as an array through the ALL_ROWS property on the object assigned to the variable.

<br/>

**Example**
>
>This example shows how to access the properties of an object returned from a Script. 
>
        SELECT 10 AS ProductID, ‘B’ AS ProductCode
>
>The name of the Script in the Workbook is set to "GetProductInfo".
>After the Script has completed, the ProductID property will be 10, and ProductCode will be «B». 
>
>To access the product id and product code returned from the query, use the following syntax: 
>
        @Var[GetProductInfo].ProductID
>
>and 
>
        @Var[GetProductInfo].ProductCode


<br/>


**Example**
>
>Suppose you have a script with the following query returning multiple rows
>
        SELECT x, y, z  
        FROM MyTable
>
>The name of the script in the Workbook is set to "ProjectProperties"
>
>To access the entire list of rows, use the following syntax:
>
        @Var[ProjectProperties].ALL_ROWS
>
>Getting the entire collection of rows returned by a script is useful in cases where you want to use a data set in client-side computation using a JavaScript function/library, for example in a Worksheet formula. ALL_ROWS is a standard JavaScript array.
>
        @MyComputedValue = my.computationLib.calculate(Qty, Pressure, @Var[ProjectProperties].ALL_ROWS);
>
>*Note! This feature is available starting with version 2.2.3*


<br/>

### See Also
* [More about Scripts](../../../docs/sqlscripts.md)

<br/>

### Videos

* [Scripts](../../../videos/sqlscripts.md)