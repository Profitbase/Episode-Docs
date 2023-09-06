---
title: "Logical Functions"
metaKeys: "Logical functions, NOT, IF, true, false, COALESCE, FIRSTNOTNULL, ISNULL, ISNULLORZERO, ISNUMBER, ISNUMERIC, ISERROR, IFERROR, replacement, expression, ISNULLOREMPTYSTR, NZ "
pageIndex: 11
---

``TRUE()``

>Returns true. 

``FALSE()``

>Returns false.

``COALESCE(…args)``
>Returns the first argument that is not null.
>
>**Example** 
```
COALESCE(null,"a" ,2) returns a
```
 
``FIRSTNOTNULL(…args)``
>Same as COALESCE.

``ISNULL(<check-expression>,<replacement-expression>)``

>If check-expression is null, returns replacement-expression, otherwise check-expression is returned. 
>
>**Example** 
```
ISNULL(null,1) returns 1 ISNULL(10 * 1, 100) returns 10
```

``ISNULL(<check-expression>)``

>If check-expression is null, returns true, otherwise false. 
>
>**Example** 
```
ISNULL(null) returns true
```

``ISNULLORZERO(<check-expression>,<replacement-expression>)``

>If check-expression is null or 0, returns replacement-expression, otherwise check-expression is returned.

``ISNULLORZERO(<check_expression>)``

>If check-expression is NULL or 0, returns true, otherwise false. 
>
>**Example** 
```
ISNULLORZERO(null) returns true
```

``ISNUMBER(value)``

>Checks if the data type of value is a number data type. 
>
>**Example** 
```
ISNUMBER(1) returns true ISNUMBER("2") returns false
```

``ISNUMERIC(value)``

>Checks whether value is a number or can be converted to a number. 
>
>**Example** 
```
ISNUMERIC(1) returns true ISNUMERIC("2") returns true ISNUMERIC("a") returns false
```

``ISERROR(<expression>)``
>Returns true if evaluation of expression results in an error.

``IFERROR(<check-expression>,<replacement-expression>)``

>If check-expression results in an error, returns replacement-expression, otherwise check-expression is returned.

``ISNULLOREMPTYSTR(<expression>)``

>Returns true if expression is null or an empty string.
> 
>**Example** 
```
ISNULLOREMPTYSTR(null) returns true  
ISNULLOREMPTYSTR(@ProductID[AccountID == "A100" && MarketID == "NO-V"])
```

``NZ(<check-expression>)``

>If the check-expression is null or an empty string, returns 0, otherwise the check-expression is returned. 
>
>**Example** 
```
NZ(null) returns 0 NZ(1) returns 1 NZ(" ")returns 0
```

Other:

``NOT(<expression>)``
``IF(<condition>,<true-expression>,<false-expression>)``