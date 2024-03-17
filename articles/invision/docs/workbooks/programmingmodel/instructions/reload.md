
# Reload

## ReloadDropdownItems

<br/>

```
ReloadDropDownItems(reload : boolean | Eaze expression)
```
<br/>

ReloadDropDownItems(…) is used for specifying that the contents of Dropdown column editors in Worksheets should be reloaded when the LoadData Action is executed.
Unless ReloadDropDownItems(…) is specified, the contents of the Dropdown column editors is just loaded the first time LoadData is called. 

For subsequent calls to LoadData, only the grid contents is loaded.

ReloadDropDownItems(…) optionally accepts an argument specifying if the contents of Dropdown column editors should be reloaded or not. Use this argument if the data should be reloaded conditionally, based on the value of a variable (must be a Boolean value).


**Example**

Evaluates to true.  
```javascript
ReloadDropDownItems();
```

Evaluates to the value held by the «BooleanValue» variable.  
```javascript
ReloadDropDownItems(BooleanValue);
``` 

Evaluates to true if variable X equals "Yes" and if the "Departments" filter has a selected value.  
```javascript
ReloadDropDownItems(_x == "Yes" && IsFilterSet("Filters", "Department"));
```

## ReloadLayout

```javascript
ReloadLayout(value : boolean | Eaze expression)
```

<br/>

ReloadLayout(…) specifies whether to reload the layout of Reports, Worksheets or Settings from the server. 
Column properties such as headings, initial visibility state and initial read only states are computed on the server based on server side data. 

By default, the layout information is only loaded the first time LoadData is called. To reload the component layout (not just the data), you need to call the ReloadLayout function in the LoadData Action. 

ReloadLayout(…) optionally accepts an argument specifying whether the layout should be reloaded or not. Use this argument if the layout should be reloaded conditionally, based on the value of a variable or an expression (both must evaluate to a boolean value (true / false)) 
