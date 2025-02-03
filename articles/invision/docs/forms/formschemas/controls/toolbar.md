# Toolbar

Inherits from [Control](control.md).

<br/>

![btn](https://profitbasedocs.blob.core.windows.net/images/toolbarfs.png)


<br/>

## Properties:

Inherits from [Control](control.md).

| Name         |  Description                        |
|--------------|-------------------------------------|
| Name  | The name of the toolbar |
| Borders      | Defines the visibility of borders (true/false values for different sides) |
| Spacing  | Specifies the spacing between toolbar items (e.g., normal, compact) |
| Size      |  Determines the size of the toolbar (e.g., small, medium, large)  |

## Events

| Name             | Event args      |  Description                        |
|------------------|-----------------|-------------------------------------|
| Clicked | Event args | Triggered when the toolbar button is clicked. |

<br/>

![btn](https://profitbasedocs.blob.core.windows.net/images/toolbarfs2.png)

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
    <Models>
    <Model Name="Button" Fields="Disabled">
    <LoadQuery><![CDATA[SELECT 1 AS Disabled]]></LoadQuery>
    </Model>
    </Models>
    <Lists />
    <SetModels />
    <Dimensions />
  </Data>
  <Functions>
  <Function Name="OnSave"><![CDATA[
  		console.log('Save');
  		controls.tbRefresh.Disable();
  		controls.tbMiau.Enable();
  ]]></Function>
  <Function Name="OnDelete"><![CDATA[
  		console.log('Delete');
  		controls.tbRefresh.Enable();
  ]]></Function>
  </Functions>
  <EventHandlers />
  <UI Grid="grid">
    <Toolbar  Spacing="normal" Size="small" Borders="false,false,true">
        <ToolbarButton Name="tbSave" Text="Save" Click="OnSave" Image="save"/>
        <ToolbarButton Name="tbRefresh" Text="Refresh" Click="OnRefresh" Image="refresh"/>
        <ToolbarButton Name="Delete" Text="Delete" Click="OnDelete" Image="delete"/>
        <ToolbarButton Name="Add" Text="Add" Click="OnAdd" Image="add"/>
        <ToolbarButton Name="Help" Text="Help" Click="OnHelp" Image="help"/>
        <ToolbarButton Name="Edit" Text="Edit" Click="OnEdit" Image="edit" Disabled="{Binding Path:Button.Disabled}"/>
        <ToolbarButton Name="Copy" Text="Copy" Click="OnCopy" Image="copy"/>
        <ToolbarButton Name="Camera" Text="Camera" Click="OnCamera"  Image="camera"/>
        <ToolbarButton Name="Upload" Text="Upload" Click="OnUpload" Image="upload"/>
        <ToolbarButton Name="Download" Text="Download" Click="OnDownload" Image="download"/>
        <ToolbarButton Name="Publish" Text="Publish" Click="OnPublish" Image="publish"/>
        <ToolbarButton Name="Vader" Text="Vader" Click="OnVader" Image="..."/>
        <ToolbarButton Name="db" Text="Dagbladet" Click="OnDb" Image="..."/>
        <ToolbarButton Name="tblMiau" Text="Miau" Image="Save" Disabled="true"/>
    </Toolbar>
</UI>

</Form>
```

<br/>



