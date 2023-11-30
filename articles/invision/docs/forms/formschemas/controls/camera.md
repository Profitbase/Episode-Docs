
# Camera

<br/>

Inherits from [Text Control](textcontrol.md).

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/camera1.png)

<br/>

**Property:**

<br/>

`ImageCaptured`

Specifies the name of the function to call when an image has been captured by the user. The argument to the function is the image data represented using the object URL format:

> _data:image/[image-format];base64, [base64 encoded value of image]_

**Example**

```
data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD//gA….
```

<br/>

`ShowIcon`

Specifies whether to display a camera icon on the camera button. The default value is true.
<br/>

**Example**

This example shows how to use the Camera control to take a picture and display the result using the Image control.

```xml
<Form>
  <Style>
    <Layouts>
      <Grid Name="grid" Rows="1fr" Columns="1fr" />
    </Layouts>
  </Style>
  <Functions>
      <Function Name="ImageCaptured" Parameters="imageData">
          this.ViewState.Image.src = imageData;
      </Function>
  </Functions>
  <EventHandlers>
      <FormEventHandler On="Init">
          this.addViewStateModel("Image", { src: undefined});
      </FormEventHandler>
  </EventHandlers>
  <UI Grid="grid">
      <Grid Rows="auto 1fr" Columns="120px 1fr">
          <Camera Row="1" Column="1" ImageCaptured="ImageCaptured" ShowIcon="true" Text="Take picture" />
          <Image Row="2" Column="1" ColumnSpan="2" Source="{Binding Path:ViewState.Image.src}"  />
      </Grid>
  </UI>
</Form>
```

<br/>

## Videos

- [Form Schemas](../../../../videos/formschemas.md)

- [Controls - Basics](https://profitbasedocs.blob.core.windows.net/videos/Form%20Schema%20-%20Input%20Element.mp4)
