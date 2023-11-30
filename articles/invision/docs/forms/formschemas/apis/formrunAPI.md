
# Form Runtime API

## Services

<br/>

`dataService`

​The dataService enables developers to save and reload specific data models in a Form Schema. This feature adds extra flexibility and more fine-grained control for loading and saving data because models can be saved and loaded individually and not just with the Load and Save Data actions of the Workbook component.

[Data Service API](dataserviceapi.md)

**Example**

```xml
  <Data>
    <Models>
        <Model Name="CustomerInfo" Source="@Object[FormUsingDataService_Table].DbObjectName" Fields="CustomerID,CustomerName,ProductID" Filter="CustomerID = @CustomerID" />
    </Models>
  </Data>
  <Functions>
      <Function Name="saveData" Async="true">
          await this.dataService.save(this.models.CustomerInfo);
      </Function>
      <Function Name="refreshData" Async="true">
          this.models.CustomerInfo = await this.dataService.reload(this.models.CustomerInfo, {CustomerID: this.models.CustomerInfo.CustomerID});

          // The CustomerID parameter can also be passed as a string
          // this.models.CustomerInfo = await this.dataService.reload(this.models.CustomerInfo, {"@CustomerID": this.models.CustomerInfo.CustomerID});
      </Function>
  </Functions>
```

<br/>

`webFunctions`

The webFunctions service enables developers to call Web Functions from directly Forms to run backend business logic.  
[Web Functions API](webfunctionsAPI.md)

**Example**

```xml
<Function Name="Calculate" Async="true"><![CDATA[
          const result = await this.webFunctions.execute("CalculateResult", {a: 100, b: 200});
          console.log('100 + 200 is ' + result);
      ]]>
</Function>
```

<br/>

`dataBindings`

The dataBindings service enables manually forcing data transfer from binding sources to binding targets, which will trigger data-bound controls to re-render. You only need to use this feature if you need to refresh the binding target(s) regardless of whether the binding source was modified or not.

An example of this is that you have multiple dropdowns data-bound to the same source, but you are using a filter function to show different subsets of the source in each dropdown. If you change the selection in one dropdown, you want the available options in the second dropdown to change.

[Data Bindings API](databindingsAPI.md)

<br/>

**Example**

```xml
  <Function Name="foo">
          for(let binding of this.dataBindings.getBindings(this.lists.Customers)){
                   if(binding.targetName !== 'bar'){
                           binding.updateTarget();
                   }
          }
      </Function>
```

<br/>

## Functions

All functions in the Form Runtime can be called through the **this** or **functions** reference. The coding language is JavaScript.

<br/>

`raiseCustomEvent(eventPayload : object)`  
`RaiseCustomEvent(eventPayload : object)`

Raises the Custom Event of the Form Schema with a payload, so that you can execute other Workbook Actions.
**Example:**

```js
this.raiseCustomEvent({ message: "Hello World " });
```

<br/>

`AddViewStateModel(modelName : string, data : object)`  
`addViewStateModel(modelName : string, data : object)`

In order for change notification (DataChangeEventHandler) to work, objects must be observable. By default, JavaScript objects are not observable, so you will not get notified when they are updated. Use the AddViewStateModel(…) function to create an observable JavaScript Object.

**Example**

```xml
<EventHandlers>
      <FormEventHandler On="Init">
          this.addViewStateModel("ButtonModel", {
              IsDisabled : true
          });
      </FormEventHandler>
      <DataChangedEventHandler Value="{Binding Path:*.*}">
          this.ViewState.ButtonModel.IsDisabled = !this.ViewState.ButtonModel.IsDisabled;
      </DataChangedEventHandler>
  </EventHandlers>
    //Bind to ViewState Model
<Button Disabled="{Binding Path:ViewState.ButtonModel.IsDisabled}"/>
```

<br/>

`isNumber(value : any)`  
`IsNumber(value : any)`

Checks if a value is a number.

<br/>

`isDate(value : any)`  
`IsDate(value : any)`

Checks if a value is a Date object.

<br/>

`startsWith(input : string, pattern : string, ignoreCase? : boolean = false)`  
`StartsWith(input : string, pattern : string, ignoreCase? : boolean = false)`

Checks if the input string starts with the pattern.

**Example**

```js
const startsWithA = this.startsWith('def', 'a', true); *startsWithA* is false.
```

<br/>

`endsWith(input : string, pattern : string, ignoreCase? : boolean = false)`  
`EndsWith(input : string, pattern : string, ignoreCase? : boolean = false)`

Checks if the input string ends with the pattern.

<br/>

`convertTo(value : any, toDataType : string)`  
`ConvertTo(value : any, toDataType : string)`

Tries to convert value to the specified data type. If the conversion failes, an error is thrown.

**Example**

```js
const num = this.convertTo("123", "number");
```

<br/>

Other:

`convertToDate(value : any, inputFormat? : string, throwOnNull? : boolean = false)`  
`ConvertToDate(value : any, inputFormat? : string, throwOnNull? : boolean = false)`

`round(num : number, decimals : number)`  
`Round(num : number, decimals : number)`

<br/>

## Properties

<br/>

`controls`  
`Controls`

Contains a dictionary of the UI controls in the Form Schema. Each control is wrapped in a **ControlProxy**, which provides an API to the underlying HTML Element. The controls can be referenced as properties by name. Controls without names cannot be accessed.

**Example**

```js
Controls.input1.Disable();
```

<br/>

`models`  
`Models`

Contains a dictionary of all models in the Form Schema. A model can be referenced as a property by its name.

**Example**

Given the Form Schema has a Person model, its field values can be accessed this way

```js
const fullName = Models.Person.FirstName + " " + Models.Person.LastName;
```

<br/>

`setModels`  
`SetModels`

Contains a dictionary of all Set Models in the Form Schema.

<br/>

`texts`  
`Texts`

<br/>

`lists`  
`Lists`

Contains a dictionary of all lists in the Form Schema. When you have Dropdown controls which should provide different options based on some state, you can create your own arrays in the Form Runtime and bind the dropdowns to them.

**Example**

This example show how a Dropdown control can be bound to a dynamically created collection in the Form Runtime. The collection, “MyCustomList”, is created dynamically in an event handler from the “Items” list. The ItemsSource property of the Dropdown control is bound to the custom collection, so the options available to the user can be changed dynamically based on some condition.

```xml
<Dropdown ItemsSource ="{Binding Path:MyCustomList}"
SelectedValue ="{BindingPath:FormData.Numeric}"
DisplayMember="ID"
ValueMember="Numeric"/>
this.MyCustomList = this.lists.Items.filter(function(item) {return item.Numeric >= 300;});
```

<br/>

`AppVariables`

Gives access to reading and writing Workbook variables.

**Example**

```js
models.Customer.ChangedBy = AppVariables.getValue("SYS").CurrentUserName;
```

<br/>

`Disabled`

Use the Disable property to disable a control or set it to read-only.  
The disabled property support data binding or an explicit value (true, false).

**Example**

```xml
<Button Disabled="{Binding Path:Customer.NotActive}"/>
or
<Button Disabled="true"/>
```

You cannot use both a Binding AND the control APIs at the same time to set the disabled state of a control.  
If the Disabled property of a control has a Binding, using the control.Disable() or control.Enable() APIs will not work (binding will win).

Valid values for the **Disabled** property:

- True
- False
- {Binding}

<br/>

## Custom models

If you need to maintain state for data that does not come from the database, you can create a custom model using the **addViewStateModel(...)** API.
This creates an in-memory object that you can use to store state which also supports data binding. You can access the custom model through the **ViewState** API.

```xml
<FormEventHandler On="Init">
      this.addViewStateModel("MyModel", {
         labelText : 'Hello world'
      });
</FormEventHandler>
```

**Example**

```xml

        <Form>
        <Style>
            <Layouts>
            <Grid Name="grid" Rows="auto auto 1fr" Columns="auto auto 1fr" />
            </Layouts>
        </Style>
        <Texts />
        <Data>
            <Models />
            <Lists />
            <SetModels />
        </Data>
        <Functions>
            <Function Name="UpdateLabelText">
                this.ViewState.MyModel.labelText = "Foo bar baz";
            </Function>
        </Functions>
        <EventHandlers>
            <FormEventHandler On="Init">
                this.addViewStateModel("MyModel", {
                    labelText : 'Hello world'
                });
            </FormEventHandler>
        </EventHandlers>
        <UI Grid="grid">
            <Label Text="{Binding Path:ViewState.MyModel.labelText}"/>
        </UI>
        </Form>
```
