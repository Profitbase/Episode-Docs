
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

```xml
<Functions>
  <Function Name="ChangeTab" Parameters="args">
    <![CDATA[
      console.log(args);
      controls.tc.activateTab(args.tabname);
    ]]>
  </Function>
</Functions>

<EventHandlers>
  <FormEventHandler On="Init">
    <![CDATA[
      //controls.tc.activateTab('Three');
    ]]>
  </FormEventHandler>
</EventHandlers>

<UI Grid="grid">
  <TabControl Name="tc" SelectedTab="Two">
    <Tab Name="One" Header="One">
      <Grid>
        <Label Text="One" />
      </Grid>
    </Tab>
    <Tab Name="Two" Header="Two">
      <Grid>
        <Label Text="Two" />
      </Grid>
    </Tab>
    <Tab Name="Three" Header="Three">
      <Grid>
        <Label Text="Three" />
      </Grid>
    </Tab>
    <Tab Name="Four" Header="Four">
      <Grid>
        <Label Text="Four" />
      </Grid>
    </Tab>
    <Tab Name="Five" Header="Five">
      <Grid>
        <Label Text="Five" />
      </Grid>
    </Tab>
  </TabControl>
</UI>

```

<br/>


## See Also

- [More about TabControl](../../../workbooks/components/uielements/tabcontrol.md)

<br/>

## Videos

- [Subscreens in Tabs](../../../../videos/workbooks.md)
