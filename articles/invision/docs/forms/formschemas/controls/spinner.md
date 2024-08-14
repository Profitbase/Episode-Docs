# Spinner

![Spinner](https://profitbasedocs.blob.core.windows.net/images/FormSchema_Spinner.PNG)
<br/>

Inherits from [Text Control](textcontrol.md).

**Property:**

`Text`

Use the Text property to display your content next to the spinner.  

<br/>

**Example**

```xml
<Spinner  Row="2" Name="spinner" Text="Processing task..." TextPosition="left"/>
```

This example shows how to call a function and activate the Spinner when the Button is being clicked.

```xml
<Form>
  <Style>
  	<Css><![CDATA[
  		.spinner{
  			//color: pink;
  			margin: 10px;
  		}
  		.button{
  			margin: 10px;
  			width: 150px;
  		}
  	]]></Css>
    <Layouts>
      <Grid Name="grid" Rows="auto auto auto 1fr" Columns="auto auto 1fr" />
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
  	<Function Name="StopSpinner"><![CDATA[
  		controls.spinner.hide();
  	]]>
  	</Function>
  	<Function Name="StartSpinner"><![CDATA[
  		controls.spinner.show();
  	]]>
  	</Function>
  </Functions>
  <EventHandlers>
  	<FormEventHandler On="Init"><![CDATA[
  		controls.spinner.hide();
  	]]>
  	</FormEventHandler>
  </EventHandlers>
  <UI Grid="grid" >
  	<Button Row="1" Column="1" CssClass="button" Text="Start spinner" Click="StartSpinner"/>
  	<Button Row="1" Column="2" CssClass="button" Text="Stop spinner" Click="StopSpinner"/>
  	<Spinner  Row="2" Name="spinner" Text="Processing task..." TextPosition="left"/>
  </UI>
</Form>Name=""
```

<br/>


## Videos

- [Form Schemas](../../../../videos/formschemas.md)

<!--- [Controls - RichTextEditor]()-->
