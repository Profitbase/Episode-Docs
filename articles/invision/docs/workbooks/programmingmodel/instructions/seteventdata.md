# SetEventData function

<br/>

```
SetEventData(eventData : any)
```
<br/>

We can call **SetEventData(…)** from the Raise Custom Event action in Subscreens. Calling SetEventData(…) let you explicitly set the event data passed to the event handler.
<br/>

## Example
Below we have a few examples of how to call SetEventData(…) to pass a custom object as the event data to event handlers.
<br/>

>@Event.Data.MyProp in event handler will be “MyValue”.

```
SetEventData({"MyProp": "MyValue"});
```
<br/>

>@Event.Data in event handler will be 123.

```
SetEventData(123);
```
<br/>

>@Event.Data in event handler will be whatever value _myVariable holds.

```
SetEventData(_myVariable);
```
<br/>

>@Event.Data in event handler will be the selected value of the Department filter.

```
SetEventData(Filters("Filters", "Department").SelectedValue.Id);
```
<br/>

>Suppose the event is raised on a (spreadsheet) cell action click event, where the clicked row has a DepartmentID property
@Event.Data.Code in event handler will be 42, @Event.Data.DepartmentID will be the department id of the row that was clicked.

```
SetEventData({"DepartmentID": @Event.Data.DepartmentID, "Code":42});
```
