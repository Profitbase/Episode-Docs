---
title: "Data Bindings API"
metaKeys: "Data Bindings API, getBindings(model) : { updateTarget: () => void, targetName: string }[], array of bindings, specified model, Get bindings "
pageIndex: 3
---

You can use the Data Binding API to manually force a data transfer from the binding source to the binding target, effectively triggering a re-render of the data-bound UI element.

<br/>

#### Get bindings

`getBindings(model) : { updateTarget: () => void, targetName: string }[]`

Gets an array of bindings associated with the specified model.

<br/>

**Example**

The example below shows how to retrieve a list of all bindings associated with the Customers list. It then forces each binding target (UI element) to update unless it's named "bar".

```
      <Function Name="foo">
          for(let binding of this.dataBindings.getBindings(this.lists.Customers)){
                   if(binding.targetName !== 'bar'){
                           binding.updateTarget();
                   }
          }
      </Function>
```

<br/>

**Complete Example**

The example below shows a sample implementation of how to use the Data Bindings API together with the _ItemsSourceFilter_ option to ensure that a user cannot select the same customer from two dropdown controls at the same time.

Notice that both dropdowns are data-bound to the same source (Customers) and that both are using the _ItemsSourceFilter_ to choose a subset of customers to render.

```
<Form>
  <Style>
    <Css><![CDATA[
.label{
    margin-top:10px;
}

.input{
    margin-top:3px;
}]]></Css>
    <Layouts>
      <Grid Name="ui-root" Rows="auto auto auto auto auto auto 1fr" Columns="150px 1fr" />
    </Layouts>
  </Style>
  <Texts />
  <Data>
    <Models/>
      <Model Name="CustomerInfo" Source="@Object[CustomerInfo].DbObjectName" Fields="ID,Name" />
      <Model Name="CustomerInfo2" Source="@Object[CustomerInfo].DbObjectName" Fields="ID,Name" />
    </Models>
    <Lists>
        <List Name="Customers" Source="@Object[Customers].DbObjectName" Fields="ID,Name"/>
    </Lists>
    <SetModels />
    <Dimensions />
  </Data>
  <Functions>
      <Function Name="onItemSelected" Parameters="selectedItem, controlName">
          if(!selectedItem){
              // The user deselected / cleared the selected item from the dropdown
              delete this.selections[controlName];
          }else{
               // The user changed the selected item in the dropdown
               this.selections[controlName] = selectedItem.ID;
          }

          // Get all the bindings associated with the Customers list,
          // and update all except the one that is associated with the control that triggered the change
          for(let binding of this.dataBindings.getBindings(this.lists.Customers)){
              if(binding.targetName !== controlName){
                  binding.updateTarget();
              }
          }
      </Function>
      <Function Name="Filter" Parameters="items, controlName">
          // This function is called every time a dropdown render, to determine
         // which items to show in the dropdown menu
          if(!this.selections){
             return items;
          }

          let notSelectableItems = [];
          for(let p of Object.keys(this.selections).filter(f => f !== controlName)){
              notSelectableItems.push(this.selections[p]);
          }

          return items.filter(f => notSelectableItems.indexOf(f.ID) == -1);
      </Function>
  </Functions>
  <EventHandlers>
      <FormEventHandler On="Init">
          // Create a variable to store the state of each dropdown control.
          // We will use it in the Filter function to determine which items to show
          this.selections = {};
      </FormEventHandler>
  </EventHandlers>
  <UI Grid="ui-root">
    <Label Row="1" Column="1" CssClass="label" Text="ID" />
    <Dropdown Name="dd1" Row="2" ItemsSource="Customers" ItemsSourceFilter="Filter($Data, $Ctrl.Id)" DisplayMember="Name" ValueMember="ID" SelectedValue="{Binding Path:CustomersInfo.ID}" ItemSelected="onItemSelected($Data, $Ctrl.Id)"/>

    <Label Row="3" Column="1" CssClass="label" Text="ID2" />
    <Dropdown Name="dd2" Row="4" ItemsSource="Customers" ItemsSourceFilter="Filter($Data, $Ctrl.Id)" DisplayMember="Name" ValueMember="ID" SelectedValue="{Binding Path:CustomersInfo2.ID}" ItemSelected="onItemSelected($Data, $Ctrl.Id)"/>
  </UI>
</Form>
```

<br/>
