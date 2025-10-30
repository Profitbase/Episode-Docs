
# Event Handlers

There are two types of event handlers – FormEventHandler and DataChangeEventHandler.

**FormEventHandlers** is executed when a _form_ _event_ is raised, for example when data has been loaded or when the form has initialized.  
**DataChangedEventHandlers** are bound to fields in Models and executes when fields change.

Event handlers contains plain JavaScript, which is executed every time an event handler runs. In event handlers and functions, you can access the [Form Runtime](apis/formruntime.md) and [Control APIs](apis/controlproxyAPI.md) that lets you call methods on controls, do validation, do calculations, raise Workbook events and more.
<br/>

## FormEventHandler

FormEventHandlers contains JavaScript code, and you can access the [Form Runtime](apis/formruntime.md) and [Control APIs](apis.md) that lets you call methods on controls, do validation, do calculations, raise Workbook events and more.  
FormEventHandler is executed when a form event is raised. There are currently two form events.
<br/>

##### Init
The Init event runs after the first render of the Form Schema. Rendering happens the first time it appears on the screen and after data has been loaded.
```xml
<EventHandlers>
    <FormEventHandler On="Init">
        <![CDATA[
        // Your JavaScript goes here
        ]]
    </FormEventHandler>
</EventHandlers>
```
<br/>

**Example**

The following event handler runs when the Init event is raised.
```xml
<FormEventHandler On="Init">
    <![CDATA[
    controls.myInput.setIsEnabled(false);
    alert('Hello world');
    ]]
</FormEventHandler>
```
<br/>

##### DataLoaded
The DataLoaded event runs after data has been loaded, but before the initial render. If you need to manipulate the data before it is rendered the first time, you should use this event.

```xml
<EventHandlers>
    <FormEventHandler On="DataLoaded">
        <![CDATA[
        // Your JavaScript goes here
        ]]
    </FormEventHandler>
</EventHandlers>
```
<br/>

**Example**  
The following event handler runs when the DataLoaded event is raised.
```xml
<FormEventHandler On="DataLoaded">
    <![CDATA[
    this.models.Customer.Name = 'Customer 2';
    ]]
</FormEventHandler>
```

<br/>

##### AppIsReadOnlyChanged
This event is raised when the entire Workbook changes readonly mode. This typically happens when a Work Process Version transitions between the Open and Closed state.

```xml
<EventHandlers>
    <FormEventHandler On="AppIsReadOnlyChanged">
        <![CDATA[
        if(this.app.variables.isReadOnly){
            this.controls.button1.disable();
        }
        ]]
    </FormEventHandler>
</EventHandlers>
```

<br/>

**Unload**  
The Unload event is raised when the Form Schema is unloaded from the DOM. You can use this event to unsubscribe from events raised from DOM nodes outside the Form, or do other types of cleanup.
<br/>

**Example**
```xml
<EventHandlers>
    <FormEventHandler On="Unload">
        // unsubscribe events, cleanup, etc
        window.removeEventListener('click', ...); 
    </FormEventHandler>

</EventHandlers>
```

<br/>

## DataChangedEventHandler

DataChangedEventHandlers are bound to properties in Models, and executes when fields change. DataChangeEventHandlers can listen for changes to a specific property, or to all properties in a Model.
<br/>

```xml
<DataChangedEventHandler Value="{Binding Path:FormData.Bit}">
    <![CDATA[
    // Your JavaScript goes here
    // The following variables are available in the scope
    // $model, $modelName, $propertyName, $newValue, $oldValue);
    ]]
</DataChangedEventHandler>

```
<br/>

The DataChangeEventHandler has the following parameters, which can be accessed by your code.

<br/>

| Parameter     | Description                                                                       |
| ------------- | --------------------------------------------------------------------------------- |
| $model        | This is the model object that the event handler is listening for changes to.      |
| $modelName    | This is the name of the Model that the event handler is listening for changes to. |
| $propertyName | This is the name of the property in the model that changed.                       |
| $newValue     | This is the new value of the property being listened to.                          |
| $oldValue     | This is the old value of the property being listened to.                          |

---

<br/>

**Listening for changes**

To listen for changes, you need to set the Value property of the DataChangedEventHandler, and specify a binding to the property or properties of the Model that you want to monitor.

- To listen for changes to a specific property, use Value=”{Binding Path:ModelName.PropertyName}”.

- To listen for changes to any property of a model, use Value=”{Binding Path:ModelName.\*}”

<br/>

 **Example**  
This example show how a DataChangedEventHandler can listen for changes to the Name property of the customer Model. When Name changes, the code below is executed.

```xml
<DataChangedEventHandler Value="{Binding Path:Customer.Name}">
    <![CDATA[
    // call shared function
    var isValidName = this.isValidName($newValue);
    controls.Input1.setIsEnabled(isValidName);
    controls.Btn_Notify.setIsEnabled(isValidName);
    ]]
</DataChangedEventHandler>
```

<br/>

**Example**  
This example show how a DataChangedEventHandler can listen for changes to all properties of the Customer model. By examining the $propertyName, we determine which validation to run. ValidateName(…) and ValidateEmail(…) are functions defined in the Functions section.

```xml
<DataChangedEventHandler Value="{Binding Path:Customer.*}">
    <![CDATA[
    // The following variables are available in the scope of a DataChangedEventHandler
    // $model, $modelName, $propertyName, $newValue, $oldValue);
    if($propertyName === "Name"){
        functions.ValidateName($newValue);
    }
    else if($propertyName === "Email"){
        functions.ValidateEmail($newValue);
    }
    ]]
</DataChangedEventHandler>
```