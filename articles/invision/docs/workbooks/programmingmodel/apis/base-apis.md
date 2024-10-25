# Base APIs

## Core / Common
```javascript
/*
* Returns a new GUID
*/
this.app.lib.core.newId() : string

/*
* Returns true if value is a number, otherwise false
*/
this.app.lib.core.isNumber(value: any): boolean

/*
* Returns true if value is a number of is convertible to a number, otherwise false.
* For example, the string "123" is convertible to a number, and will return true if passed to the function.
*/
this.app.lib.core.isNumeric(value: any): boolean
```

## Date / time
```javascript
/*
* Converts the input value to a Date if possible, for example the string "2024-05-01" is converted to May 1st 2024.
* inputFormat is ISO 8601 (YYYY-MM-DD) if not specified.
*/
this.app.lib.dateTime.toDate(value: any, inputFormat?: string) : Date | null

/*
* Formats a string or date as a string given the provide format string.
*/
this.app.lib.dateTime.formatDate(value: any, format: string): string
```

## HTML
```javascript
/*
* Removes usafe HTML content from the input string to protect against XSS attacks.
*/
this.app.lib.html.sanitizeHtml(html: string): string
```