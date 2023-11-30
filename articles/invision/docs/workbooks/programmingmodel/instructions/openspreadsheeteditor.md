# OpenSpreadsheetEditor(...)

<br/>


```
OpenSpreadsheetEditor(objectId : string [, width : number | string, height : number | string])
```

<br/>

Opens a Setting table for editing in a stand-alone dialog window when called from an ExecuteExpression action.

The width and height parameters are optional and accepts a number or string representing a size on the form 100, "100px", "100" or "50%".
<br/>

**Example**

The following statement opens a Setting table with Object Id "xyz123" for editing in a dialog window. The dialog size will default to 60% of the browser window width and height.
```
OpenSpreadsheetEditor("xyz123");
```

<br/>

The following example shows two statements that opens a Setting table with Object Id "xyz123" for editing in a dialog window. The dialog width will be 600px and the height will be 400px.
```
OpenSpreadsheetEditor("xyz123", 600, 400);
```
or
```
OpenSpreadsheetEditor("xyz123", "600px", "400px");
``` 
<br/>

The following statement opens a Setting table with Object Id "xyz123" for editing in a dialog window. The dialog width and height will be 70% x 40% of the browser window width and height.
```
OpenSpreadsheetEditor("xyz123", "70%", "40%");
```



