
# Date Functions

 `DATE(year [,month,day,hours,min,sec, ms])`
 
 Creates a [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) object from the specified arguments. 
 
`DATEVALUE(year [,month,day,hours,min,sec, ms])`   	
Creates a [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) object from the specified arguments. 

`DATE(expression)`

Creates a [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) object by evaluating expression. 

`TODATE(expression[,input format])`

Converts a date string or number to a [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) object. If you do not specify the input format, the date string must be an ISO 8601 date string. 

**Example** 
```
TODATE("2001-01-01") returns a Date object representing January 1st, 2001
``` 
**Example** 
```
TODATE("20.12.2006", "DD.MM.YYYY") return a Date object representing Dec 20th 2006
```

`NOW()`

Returns the current [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date). 

`FORMATDATE(date : Date | string,format : string)` 	

Returns a string representation of a date using the specified format and the current locale. The formatting function supports [momentjs](https://momentjs.com/) formats. If the date passed to the function is a string and not a date object, the format of the string is expected to be ISO 8601.  

Other:

`TZUTC(date)`  
`TZLocal(date)` 
