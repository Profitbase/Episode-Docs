
# Standard Directives

## Custom Parameters @< Param >



Data Queries can be parameterized without filter linking. You can parameterize any part a custom SQL uery by adding **@< Param >** tags to it. A major difference between using filter directives and custom parameters to filter the returned data set from a query, is that you have to pass values to custom parameters, while it’s optional with filter directives. The reason for this is that InVision rewrites a query by injecting SQL fragments based on any filter directives, while a query with custom parameters is executed as is.  

In addition, you must use custom parameters in Form Element load and save scripts, because filter directives cannot execute in that context while ensuring a unique row is loaded or updated / inserted. 

A custom parameter is just a token added to a SQL expression.

>**Example**
>
        SELECT *  
        FROM MyTable  
        WHERE MyKey = @PKValue 

contains the custom parameter **@PKValue**. 

A value must be passed to @PKValue by using the SetParamValue function when invoking a request from a Workbook.

<!--outdated
### @CurrentUserName /OUTDATED

Returns the  user name of the currently logged in user. The token can be used in Data Queries invoked from a Workbook, and will be resolved at the server.

>**Example**
>
    SELECT table.X, table.Y
    FROM MyTable table
    WHERE table.UserID = '@CurrentUserName' -->

<br/>

## @CurrentUserUID

Returns the unique ID of the user account as registered in the user management system.
<br/>

## @CurrentUserFullName 

Returns the full name of the user (FirstName + LastName) as registered in the user management system.
<br/>

## @CurrentUserEmail 

This directive returns an Email of the user registered in the user management system.
<br/>

## @Language

Returns the language code specified for the currently logged in user. The token can be used in Data Queries invoked from a Workbook, and will be resolved at the server.
<br/>

## @LanguageTwoLetter

Returns the ISO 639-1 two letter language code for the currently logged in user. The token can be used in Data Queries invoked from a Workbook, and will be resolved at the server.
<br/>

## @LCID

Returns the Locale ID for the currently logged in user. The token can be used in Data Queries invoked from a Workbook, and will be resolved at the server.
http://msdn.microsoft.com/nb-no/goglobal/bb964664.aspx


<br/>

## @CurrentSolutionID

Returns the id of the Solution.

<br/>

## @CurrentWorkProcessVersionID

Returns the id of the Work Process Version that the Solution belongs to. 

> [!NOTE]
> This directive is only resolved if the object being executed is part of a Solution that belongs to a Work Process Version.

