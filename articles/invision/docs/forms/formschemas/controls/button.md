# Button

Inherits from [Text Control](textcontrol.md).

<br/>

![btn](https://profitbasedocs.blob.core.windows.net/images/btnUI.png)

<br/>

**Property:**

<br/>

`Click`

Specifies the name of the Function to call when the user clicks the button.

### Example

```xml
<Button Name="Button1" Text="Click me" Click="ShowAlert"/>
```

This example shows how to call a function when the button is clicked, passing an argument.

```xml
<Button Name="Button1" Text="Click me" Click="ShowAlert('My message')"/>
```

<br/>

`Disabled`

Use the Disabled property to disable a control or set it to read-only.  
The disabled property support data binding or an explicit value (true, false).

Valid values for the **Disabled** property:

- True
- False
- {Binding}

You cannot use both a Binding AND the control APIs at the same time to set the disabled state of a control.  
If the Disabled property of a control has a Binding, using the control.Disable() or control.Enable() APIs will not work (binding will win).

### Example

```xml
<Button Disabled="{Binding Path:Customer.NotActive}"/>
or
<Button Disabled="true"/>
```

<br/>

`Type`

Specifies the default look of the button. Valid values are "Default", "Primary", "Secondary", "Confirm", and "Link".

<br/>

`Hotkey`

Specifies the hotkey for the control.

### Example

```xml
<Button Hotkey="Alt + B" Name="Button1" Text="Click me" Row="1" ColumnSpan="2" Click="ShowAlert('My Message')"/>
```

<br/>

### Example

This example shows how to programmatically activate (select) a tab when a button is clicked.

![activateTab](https://profitbasedocs.blob.core.windows.net/images/activateTab.png)

```xml
  <Functions>
  <Function Name="ChangeTab" Parameters="tabname">
    <![CDATA[
      console.log('Changing tab to: ' + tabname);
      controls.tc.activateTab(tabname);
    ]]>
  </Function>
</Functions>

<EventHandlers>
</EventHandlers>

<UI Grid="grid">
  <Grid RowDefinitions="Auto, *">
    <!-- TabControl -->
    <Grid Row="2">
      <TabControl Name="tc" SelectedTab="One">
        <Tab Name="One" Header="Customers">
          <Grid>
            <Label Text="Manage customer data and view customer details." />
          </Grid>
        </Tab>
        <Tab Name="Two" Header="Budget">
          <Grid>
            <Label Text="Track your budget allocations, expenses, and forecasts." />
          </Grid>
        </Tab>
        <Tab Name="Three" Header="Employees">
          <Grid>
            <Label Text="Overview of employee details and management." />
          </Grid>
        </Tab>
        <Tab Name="Four" Header="Inventory">
          <Grid>
            <Label Text="Inventory management and stock levels." />
          </Grid>
        </Tab>
        <Tab Name="Five" Header="Reports">
          <Grid>
            <Label Text="Generate and view financial and operational reports." />
          </Grid>
        </Tab>
      </TabControl>
    </Grid>
    <!--  Button -->
    <Grid Row="1">
      <Grid Margin="20,10,20,10">
        <Button Text="Go to Inventory" Click="ChangeTab('Four')" />
      </Grid>
    </Grid>
  </Grid>
</UI>

```

<br/>

## Videos

- [Form Schemas](../../../../videos/formschemas.md)

- [Controls - Basics](https://profitbasedocs.blob.core.windows.net/videos/Form%20Schema%20-%20Input%20Element.mp4)
