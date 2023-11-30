# LoadOptions

<br/>

```
LoadOptions(condition : boolean);
```

<br/>

## LoadOptions(expression : Eaze expression)

**LoadOptions(…)** is used for specifying whether the items of Dropdown Form Elements should be (re)loaded when the LoadData Action is executed.

If **LoadOptions(...)** is not specified, the items collection is just loaded the first time LoadData is called. For subsequent calls to LoadData, only the selected value is loaded.

You should use LoadOptions() when the items collection needs to be refreshed from the server, for example, if the (filter) context changes, and a different set of items should be selectable. 

**LoadOptions(...)** can optionally evaluate an Eaze expression, specifying whether the items should be reloaded or not. Use an expression if the items should be reloaded conditionally based on the value of a variable, computation, or filter state. 

<br/>

### Example 
>
```
LoadOptions(); // evaluates to true
LoadOptions(BooleanValue); // evaluates to the value held by the «BooleanValue» variable.
```
