# Base APIs

## App

#### isReadOnly
Returns true if the app (Workbook) is in read-only mode. The app may be in in read-only mode for the following reasons:  
- The Workbook is in a closed Work Process version.

##### API Definition
```javascript
this.app.isReadOnly: boolean
```

#### Example
```javascript
if(this.app.isReadOnly){
    // Do something
}
```

<br/>

## Core

The Core API contains standard functions for working with primitive types such as strings and numbers.

#### newId()
Returns a new GUID  

##### API Definition
```javascript
this.app.lib.core.newId() : string
```
<br/>

#### isNumber(value)
Returns true if value is a number, otherwise false.  

#### isNumeric(value)  
Returns true if value is a number of is convertible to a number, otherwise false.  
For example, the string "123" is convertible to a number, and will return true if passed to the function.  

##### API Definition
```javascript
this.app.lib.core.isNumber(value: any): boolean
this.app.lib.core.isNumeric(value: any): boolean
```

#### Example

```javascript
const guid = this.app.lib.core.newId(); // Creates a new GUID
const isNumber = this.app.lib.core.isNumber(123); // Returns true
const isNumeric = this.app.lib.core.isNumeric("a"); // Returns false
```

<br/>
<br/>

## Date / time

The Date API contains functionality for working with date and time.

#### toDate(value, inputFormat)
Converts the input value to a Date if possible, for example the string "2024-05-01" is converted to May 1st 2024.  
inputFormat is ISO 8601 (YYYY-MM-DD) if not specified.

#### formatDate(value, format)
Formats a string or date as a string given the provided format string.

##### API Definitin
```javascript
this.app.lib.dateTime.toDate(value: any, inputFormat?: string) : Date | null
this.app.lib.dateTime.formatDate(value: any, format: string): string
```
<br/>

#### Example
```javascript
const myDate = this.app.lib.dateTime.toDate('2024-12-31'); // Returns December 31st 2024 as a Date object
const myDate = this.app.lib.dateTime.toDate('31.12.2024', 'DD.MM.YYYY'); // Tue Dec 31 2024 00:00:00 GMT+0100 (Central European Standard Time) as a Date object (if your're in the GMT +1 timezone)
const myDateAndTime = this.app.lib.dateTime.toDate('31.12.2024 12:06:15', 'DD.MM.YYYY HH:mm:ss'); // Returns Tue Dec 31 2024 12:06:15 GMT+0100 (Central European Standard Time) as a Date object

const formattedAsISO8601String = this.app.lib.dateTime.formatDate(myDateAndTime, 'YYYY-MM-DD'); // Returns the string '2024-12-31'
```
<br/>
<br/>

## HTML

The HTML API contains functions for working with HTML text.

#### sanitizeHtml(html)
Removes usafe HTML content from the input string to protect against XSS attacks.  

##### API Definition
```javascript
this.app.lib.html.sanitizeHtml(html: string): string
```

#### Example
```javascript
const myHtml = '<img src onerror="alert(document.cookie)">';
const sanitizedHtml = this.app.lib.html.sanitizeHtml(myHtml);
elememt.innerHTML = sanitizedHtml;
```