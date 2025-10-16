# Worksheet

<br/>

## Actions
<br/>

### Load Data
Use this action to load or refresh the table.

<br/>

### Save Data
Use this action to save all of the changes to the database.

<br/>

### Add Item
Use this action to add new row to the table.


<br/>

### ExecuteExpression
Executes one or more [instructions](../programmingmodel/instructions.md).


<br/>

### Unload Data
Unloads the data.

<br/>

### Validate Data
[Validates](../programmingmodel/instructions/validate.md) data. Run it if you want to run the Cell Validation rules before data is saved, and optionally prevent the save process for the particular Worksheet from executing if the validation fails.

```
Validate(terminateOnValidationFailed : boolean | Eaze expression)
```


<br/>

### Recalc
The Recalc action triggers the execution of the formulas script in the spreadsheet. You can call [SetDataModified(…)](../programmingmodel/instructions/setdatamodified.md) in Recalc actions.

<br/>


![calc](https://profitbasedocs.blob.core.windows.net/images/calculations.png)


<br/>

## Events
<br/>

### Data Modified
This event is raised when data in a table is modified. 
 
<br/>

### Cell Action Link Tapped
This event is raised when an action link cell in a table is clicked. The payload of the event is the name of the column that was clicked and the row object.

<br/>

### Custom Context Menu Action Executed
This event is raised when a (custom) Context Menu Action is clicked. The payload of the event is the name of the action that was clicked, the column and the row object that the cell belongs to.

### Extension Context Menu Action Executed
This event is raised when an Extension Context Menu Action is clicked. The payload of the event is the name of the action that was clicked, the column and the row object that the cell belongs to. 
The event handler will be preserved during Package upgrades, meaning customers / partners can use this feature to extend standard products like Planner with custom business logic.

<br/>

### Item Added
This event is raised when you add a new item to the table, for example, a new row. 

<br/>
