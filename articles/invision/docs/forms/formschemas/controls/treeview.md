---
title: "TreeView"
metaKeys: "TreeView ,UI, Text Control, Controls,  Editable, Layout control, create sub layout containers, grids, form schema, child, nested"
pageIndex: 18
---

Inherits from [Control](control.md).

TreeView presents a hierarchical view of information, where each item can have zero or more children / subitems.

<br/>

![TreeView](https://profitbasedocs.blob.core.windows.net/images/TreeView1.png)

<br/>

**Properties**

`ItemsSource`

This is the collection of items displayed in the TreeView. The ItemSource can be a SetModel, List, or DimensionModel.

If the ItemsSource is a SetModel or List, you must set the ItemId and ParentItemId to specify the parent-child relationship between the items in the TreeView.

If the ItemsSource is a DimensionModel, you should NOT specify the ItemId, ParentItemId, or DisplayMember.

<br/>

`ItemId`

Specify the name of the field in the ItemSource that represents an item. If the ItemSource is a SetModel or List, you must set the ItemId.

If the ItemSource is a DimensionModel, this property is ignored.

<br/>

`ParentItemId`

Specifies the name of the field in the ItemSource that represents the parent of an item. If the ItemSource is a SetModel or List, you must set the ParentItemId.

If the ItemsSource is a DimensionModel, this property is ignored.

<br/>

`DisplayMember`

Specifies the name of the field in the ItemSource that should be displayed as the text of an item in the TreeView. If this field is not specified, the ItemId field is displayed in the tree.

If the ItemsSource is a DimensionModel, this property is ignored.

<br/>

`CanSelectItem`

The callback function which returns true or false, indicating whether an item in the TreeView can be selected by the user. The argument passed to the function is the data object from the ItemsSource displayed in the TreeView.

<br/>

`ItemSelected`

The function to call when an item in the TreeView is selected. The argument passed to the function is the data object from the ItemsSource displayed in the TreeView which is being clicked / selected by the user.

<br/>

`ItemTemplate`

Use ItemTemplate to specify the custom rendering of TreeView items, for example, if you want to render images or checkboxes.

<br/>

**Basic example using SetModel as ItemsSource**

The example below shows how to use a SetModel as a data source for a TreeView.  
The ItemID and ParentItemID fields from the source table specifies the parent/child relationship, and the ItemName specifies the label displayed for each node in the tree. They are mapped to the TreeView **ItemId**, **ParentItemId**, and **DisplayMember** properties, respectively.

In this case, they happen to have similar names, but that is coincidental. The fields from the data source could have been Foo, Bar, Baz, and you would have to map them to the TreeView properties the same way.

<br/>

![TreeView](https://profitbasedocs.blob.core.windows.net/images/TreeView2.png)

<br/>

```xml
<Form>
  <Style>
    <Layouts>
      <Grid Name="grid" Rows="1fr" Columns="1fr" />
    </Layouts>
    <Css>
        .border{
            border: 1px solid var(--theme-border-color);
        }
    </Css>
  </Style>
  <Data>
    <SetModels>
        <SetModel Name="TreeViewData" Source="Setting_HierarchicalTable_11022021184313" Fields="ItemID, ItemName, ParentItemID, SomeBool, VotingDisabled"/>
    </SetModels>
  </Data>
  <Functions>
      <Function Name="onItemSelected" Parameters="item">
          alert('You selected ' + item.ItemName);
      </Function>
      <Function Name="onItemClick" Parameters="item">
          alert('You clicked ' + item.ItemName);
      </Function>
      <Function Name="onCanSelectItem" Parameters="item">
          // Only allow selecting items which are children of items with Id 'Root'
          return item.ParentItemID === 'Root';
      </Function>
  </Functions>
  <EventHandlers/>
  <UI Grid="grid">
      <Grid Rows="1fr" Columns="1fr">
          <TreeView ItemsSource="{Binding Path:TreeViewData}" Row="1" Column="1"
              ItemId="ItemID"
              ParentItemId="ParentItemID"
              DisplayMember="ItemName"
              ItemSelected="onItemSelected"
              CanSelectItem="onCanSelectItem"
              CssClass="border"/>
      </Grid>
  </UI>
</Form>
```

<br/>

**Example using ItemTemplate**

The example below show how to use the ItemTemplate to provide a custom rendering of items in the TreeView.


> [!NOTE]
> The use of the special $Data argument passed when calling the onItemClick function in the Button Click event handler. The $Data argument represents the data object from the ItemsSource displayed by the clicked TreeView item.

The data context for bindings inside the ItemTemplate is the data object being rendered, meaning that **Binding Path:ItemName** binds the Text of the Label to the ItemName property of the data object rendered by the TreeView item. You need to bind to something outside the item, you need to use the full path of the property, including the model name, for example **{Binding Path:Models.Customer.Name}**

<br/>

![TreeView](https://profitbasedocs.blob.core.windows.net/images/TreeView3.png)

<br/>

```xml
<TreeView ItemsSource="{Binding Path:TreeViewData}" Row="1" Column="1"
              ItemId="ItemID"
              ParentItemId="ParentItemID"
              DisplayMember="ItemName"
              ItemSelected="onItemSelected"
              CanSelectItem="onCanSelectItem"
              CssClass="border">
              <ItemTemplate>
                  <Layout Grid="grid">
                      <Grid Columns="auto auto auto" Gap="4px">
                          <Input Type="checkbox" VerticalAlignment="center" Value="{Binding Path:SomeBool}" />
                          <Label Text="{Binding Path:ItemName}" VerticalAlignment="center" Column="2"/>
                          <Button Click="onItemClick($Data)" Text="Vote!" StopClickEventPropagation="true" Column="4" Type="Link" Disabled="{Binding Path:VotingDisabled}" />
                      </Grid>
                  </Layout>
              </ItemTemplate>
</TreeView>
```

<br/>

**Example using DimensionModel as ItemsSource**

When using a dimension as ItemsSource, you should **not** specify the ItemId, ParentItemId, and DisplayMember properties. The system will take care of rendering the TreeView correctly without any configuration as long as the ItemsSource is bound to a DimensionModel.

A DimensionModel must have a Name and a Source. The **Name** is the **name of the model**, that you bind to the TreeView.

The **Source** is the **name of the dimension** in your Solution. It is **NOT** the database table name of the dimension. Also, you cannot use the @Object[…].DbObjectName directive as Source.

**Note!** that you cannot use legacy Wide or Linked dimensions as sources for DimensionModels.

<br/>

![TreeView](https://profitbasedocs.blob.core.windows.net/images/TreeView4.png)

<br/>

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

### Videos

- [Form Schemas](../../../../videos/formschemas.md)

- [TreeView](https://profitbasedocs.blob.core.windows.net/videos/Form%20Schema%20-%20Control%20-%20TreeView.mp4)
