
# TabControl

Inherits from [Control](control.md).

<br/>

![btn](https://profitbasedocs.blob.core.windows.net/images/onTappedTab0.png)

<br/>

<br/>

## Properties:

<br/>

### Tab

A collection of tabs. See example below:

**Example**

```xml
<TabControl Row="5" ColumnSpan="2">
        <Tab Header="Customers" HeaderTextCode="LNG_Customers"
            HeaderExpression="Some C# expression">
            <Grid Rows="auto auto 1fr" Columns="auto auto 1fr">
                ...content
            </Grid>
        </Tab>
        <Tab Header="Employees" HeaderTextCode="LNG_Employees"
            HeaderExpression="Some C# expression">
            <Grid Rows="auto auto 1fr" Columns="auto auto 1fr">
               ...content
            </Grid>
        </Tab>
</TabControl>
```

<br/>

### SelectedTab

Defines which tab should be default.



**Example**

```xml
<TabControl Row="5" ColumnSpan="2" Name="Accounting" SelectedTab="Income">
        <Tab Name="Customers" Header="Customers" >
            <Grid Rows="auto auto 1fr" Columns="auto auto 1fr">
                ...content
            </Grid>
        </Tab>
        <Tab Name="Income" Header="Income" >
            <Grid Rows="auto auto 1fr" Columns="auto auto 1fr">
               ...content
            </Grid>
        </Tab>
</TabControl>
```

<br/>


### activateTab

The **activateTab("nameOfTab")** function provides a programmatic way to switch between tabs within the TabControl. By passing the nameOfTab as an argument, the function dynamically activates the specified tab, making it visible to the user. 

This method can be used in various scenarios such as [button](button.md) clicks, form initialization, or any custom event, allowing for seamless navigation and enhanced user interactions within multi-tabbed interfaces.



**Example**

In this example, after clicking the button you will be moved to the *Inventory* Tab.

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


## See Also

- [More about TabControl](../../../workbooks/components/uielements/tabcontrol.md)

<br/>

## Videos

- [Subscreens in Tabs](../../../../videos/workbooks.md)
