---
title: "Statistical Functions"
metaKeys: "Statistical functions, AVERAGE, AVERAGEA, COUNT, COUNTA, COUNTBLANK, MAX, MAXA, expression, boolean, string, MIN, MINA, STDEV, STDEVA, STDEVP, STDEVPA, VAR, VARA, VARP, VARPA "
pageIndex: 17
---

``AVERAGE(…x : number | <expression>)`` 

>Returns the average of the numbers passed to the function. Only numbers and arrays of numbers are processed.

``AVERAGEA(…x : number | <expression>)``

>Returns the average of the numbers passed to the function. Numbers, arrays of numbers and values representing numbers (such as true, false and string representation of numbers) are processed.

``COUNT(…x: number | <expression>)`` 

>Counts the number of numeric values passed to the function. Only numbers and arrays of numbers are processed. 
>
>**Example** 
```
COUNT(1,2,"test") returns 2 
COUNT(ARRAY(1,2,3)) returns 3
```

``COUNTA(…x : number | <expression>)``

>Counts the number of logical values passed to the function. Numbers, arrays of numbers and values representing numbers (such as true, false and string representation of numbers) are processed. 
>
>**Example** 
```
COUNTA(1,2,"3") returns 3 
COUNTA(1,2,"x") returns 3 
COUNTA(1,2,null) returns 2 
COUNTA(ARRAY(1,2,3,4,true,"")) returns 6
```

``COUNTBLANK(…x:number | <expression>)``

>Counts the number of null-values passed to the function. 
>
>**Example** 
```
COUNTBLANK(null) returns 1 
COUNTBLANK(ARRAY(1,null,1,null)) returns 2
```

``MAX(…x : number | <expression>)``

>Returns the max value of the numeric values passed to the function. Only numbers and arrays of numbers are processed. 
>
>**Example** 
```
MAX(1,4,3,true,null) returns 4 
``` 

``MAXA(…x : number | <expression>`` 

>Returns the max value of the numbers or numeric representations of the values passed to the function. 
>
>**Example**
```
 MAXA(false,null) returns 0 
 MAXA(0,true) returns 1 
 ```

Other:


 ```MIN```
```MINA```
```STDEV```
```STDEVA```
```STDEVP```
```STDEVPA```
```VAR```
```VARA```
```VARP```
```VARPA```