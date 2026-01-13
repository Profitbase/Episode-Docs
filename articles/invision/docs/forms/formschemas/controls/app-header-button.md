# App header button

Inherits from [Control](control.md).  

The `App header button` component is **only** intended to be used when creating a Workbook Toolbar Form that is placed in the Workbook header bar.  
The use case is for this component is to create a Workbook header toolbar that you can reuse in multiple Workbooks.

![img](/images/invision/form-schema-app-header-buttons.png)

## Properties

| Name                | Description                            |
|---------------------|----------------------------------------|
| Click               | Specifies the name of the Function to call when the user clicks the button. |
| Disabled            | Use the Disabled property to disable a control or set it to read-only. Note that you cannot use both a Binding AND the control APIs at the same time to set the disabled state of a control. If the Disabled property of a control has a Binding, using the control.Disable() or control.Enable() APIs will not work (binding will win). The disabled property support data binding or an explicit value (true, false). |
| Image               | Specifies the image to display. The value can be a named image, an image in your web assets library (@images/my-image-name.png), or a URL. |
| Hotkey              | Specifies the hotkey for the control, for example `Alt + B`. |

<br/>

### Example

This example shows how to create a Workbook header toolbar using the App header button. Note how the `AppHeaderButton` components are placed in a Grid with `Gap="4px"` to make the layout similar to the built-in system toolbar.

```xml
<Form>
  <Style>
    <Layouts>
      <Grid Name="grid" Rows="auto auto 1fr" Columns="1fr" />
    </Layouts>
  </Style>
  <Texts />
  <Data>
    <Models />
    <Lists />
    <SetModels />
    <Dimensions />
  </Data>
  <Functions>
  	<Function Name="OnClick">
  		alert('Clicked');
  	</Function>
  </Functions>
  	<EventHandlers />
  <UI Grid="grid">
  	<Grid Columns="1fr auto auto" Gap="4px">
  		<AppHeaderButton Column="2" Image="camera" Click="OnClick" Disabled="true"/>
  		<AppHeaderButton Column="3" Image="add" Click="OnClick"/>
  	</Grid>
  </UI>
</Form>
```
