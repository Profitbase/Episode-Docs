---
title: "Text Functions"
metaKeys: "Text functions, CONCAT, SUBSTRING, input, string, start, number, SPLIT, LEFT, LEN, LOWER, REPLACE, RIGHT, REPLACE, TOSTRING, TOSTRING, value, formatString, TRIM, UPPER, TONUMBER, NEWLINE "
pageIndex: 19
---

``CONCAT(…t:string)``
>Concatenates a comma separated list of strings. 
>
>**Example**
```
CONCAT("a","b","c") will return the string "abc"
```

``SUBSTRING(input : string, start : number[, length : number)``
>Returns a substring of the input string. 
>
>**Example**
```
SUBSTRING("Hello", 1) returns the string "ello"  
SUBSTRING("Hello", 1,2) returns the string "el"
```

``SPLIT(input : string, delimiter : string)``
>Returns an array of strings that contains the substrings of the input strings that are delimited by the delimiter argument. 
>
>**Example**
```
SPLIT("Hi, everyone", ",")returns ["Hi", "everyone"]
```

``LOWER``
>Converts all characters in a string to lower case.

``UPPER``

>Converts all characters in a string to upper case.    

``TOSTRING(value)``

>Converts a value to a string, for example the number 100.123 is converted to the string "100.123".

``TOSTRING(value,formatString)``

>Similar to the Excel TEXT-function, converts a value to a string using the specified format.  
When the value is a number, valid format strings are those supported by the numeraljs formatting library – http://numeraljs.com.  
When the value is a Date, valid format strings are those supported by the momentjs formatting library – http://momentjs.com.
>
>**Example** 
>
```
TOSTRING(DATE(2016,1,1), "YYYYMMDD") will returns "20160101"
```

``TRIM``

>Removes leading and trailing whitespace charachters from a string.


``TONUMBER``

>Converts a string to a number. If the string cannot be converted to a number, null is returned.

``NEWLINE``

>Returns the newline character.

Other: 

``LEFT``
``LEN`` 
``REPLACE`` 
``RIGHT``  