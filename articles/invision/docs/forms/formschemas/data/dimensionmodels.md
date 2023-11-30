
# Dimension Models

Dimension Models are data sources for controls that can display data in a hierarchical view, for example, the [TreeView](../controls/treeview.md) control.

Dimension Models are read-only and cannot be modified and saved back to the database.

<br/>

## Properties:

<br/>

`Name`  
The name of the model. The Name is required and used by controls to specify its data source.

<br/>

`Source`  
The **name** of the dimension. Unlike Lists, SetModels and Models, you cannot specify the database table name or use the @Object[…].DbObjectName directive to specify the source dimension.

<br/>

`AccessControl`[Optional]  
If you want to enable access control to dimensions displayed in Forms, use one of the following options:  
- None - No access control is applied. The user will see every dimension member. This is the default
- Standard - Users only see the dimension members that they have access to.
- Custom - The API returns every member of the dimension with a property describing the access level granted for each item. It is up to the solution developer to decide how to enforce access control when rendering the UI (for example hiding or making an item non-selectable).  

The default name of the access level property is 'AccessLevel'. If you want a different name, for example if you dimension has a custom property alrady called 'AccessLevel', use the `CustomAccessControlProperty` property to specify a different access level property name.

**AccessLevel values**:  
0 = User has no access to the dimension member  
1 = Read (Currently not supported. Reserved for future use)  
2 = Write  

<br/>

`CustomAccessControlProperty`[Optional]  
The default name of the property to programatically check for access level is 'AccessLevel'. If you want a different name, for example if you dimension has a custom property alrady called 'AccessLevel', use the `CustomAccessControlProperty` property to specify a different access level property name.


<br/>

**Example 1** 
```xml
<Form>
  <Style>
    <Layouts>
      <Grid Name="grid" Rows="1fr" Columns="1fr" />
    </Layouts>    
  </Style>
  <Texts />
  <Data>    
    <Dimensions>
        <DimensionModel Name="TreeViewData" Source="PCDim"/>
    </Dimensions>
  </Data>  
  <EventHandlers/>
  <UI Grid="grid">
      <Grid Rows="1fr" Columns="1fr">
          <TreeView ItemsSource="{Binding Path:TreeViewData}" Row="1" Column="1" />      
      </Grid>
  </UI>
</Form>
```

<br/>

**Example 2**  
This example shows how to use the AccessLevel property to prevent a user from selecting a tree item.  
The AccessControl property is set to Custom so that all users can see the entire dimension, but we prevent users from selecting members they don't have access to by checking that the AccessLevel is greater than 0 in the IsItemSelectable function.

```xml
<Form>
  <Style>
    <Layouts>
      <Grid Name="grid" Rows="1fr" Columns="1fr" />
    </Layouts>
  </Style>  
  <Data>    
    <Dimensions>
    	<DimensionModel Name="MyDim" AccessControl="Custom" Source="v2023.1 Dim"/>
    </Dimensions>
  </Data>
  <Functions>
  	<Function Name="IsItemSelectable" Parameters="data"><![CDATA[
  		return data.AccessLevel > 0;	
  	]]></Function>
  </Functions>
  <EventHandlers />
  <UI Grid="grid">
  	<Grid Rows="1fr" Columns="1fr">
  		<TreeView ItemsSource="{Binding Path:MyDim}" CanSelectItem="IsItemSelectable" Row="1" Column="1"/>
  	</Grid>  	
  </UI>
</Form>
```

<br/>

## Videos

* [Form Schemas](../../../../videos/formschemas.md)
