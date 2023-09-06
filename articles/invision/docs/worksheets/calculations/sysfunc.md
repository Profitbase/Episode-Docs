---
title: "System Functions"
metaKeys: "System Functions, ARRAY, NEWID, ENVIRONMENT, EVAL, expression, string, JsonParse, value, JsonStringify, text, ApiBase "
pageIndex: 18
---

``ARRAY(…args)``

>Creates an array of values. 
>
>**Example** 
```
ARRAY(1,4,"test")
```

``NEWID()``

>Creates a unique id with the length of 36 characters, on the form xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx.

``WINDOW()``

>Returns the browser window object. Replaced ``ENVIRONMENT()`` function.

``EVAL(expression : string)``

>Dynamically evaluates an expression and returns the value. The argument passed to EVAL can be a string or an expression returning a string. 
>
>**Example 2** 
```
EVAL("1 + 2") returns 3  
EVAL(CONCAT("1+", "2")) returns 3 
[if !supportLineBreakNewLine] [endif]
```
>
>**Example 2** 
>
>You can also use the **EVAL** function to execute formulas embedded in a data set. For example if the data set contains a Formula column with valid Eaze expressions, you can create dynamically executed expressions like this: 
```
@Total[] = EVAL(@Formula[]); So if the Formula column contains the expression  
@P01[] + @P02[], the expression will be equivalent to @Total[] = @P01[] + @P02[];
```

``JsonParse(value)``

>The **JsonParse(...)** function parses a **JSON** string, constructing the **JavaScript** value or object described by the string.

``JsonStringify(text)``

>The **JsonStringify(...)** function converts a **JavaScript** value to a **JSON** string.

``ApiBase()``

>Returns the base **url** of the InVision web api, for example http://server/invision. 
>
>**Example** 
>
>Using ApiBase() when calling the db REST api to set the image source of an Image Workbook component:
```
SetSrc(ApiBase()+ "/api/db/objects/AssetLib/FileName?q={ID==\"WarningImg\"}&asFile=true");
```
