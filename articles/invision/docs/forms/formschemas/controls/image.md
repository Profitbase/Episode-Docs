
# Image

<br/>

Inherits from [Control](control.md).

<br/>

![btn](https://profitbasedocs.blob.core.windows.net/images/picc.png)

<br/>

**Properties:**
<br/>

`Source`
The image source. This must be a URL or a binding to a URL.

**Example**

```xml
<Image Row="2" Column="1" Source="{Binding Path:Person.Photo}"/>

<Image Row="2" Column="1" Source="http://my/images/photo.jpg"/>
```

<br/>

`Click`
Specifies the name of the Function to call when the user clicks the image.

**Example**

```xml
<Image Name="Image1" Click="ImageClicked"/>
```

This example shows how to pass an argument to the function.

```xml
<Image Name="Image1" Click="ImageClicked('My image')"/>
```

<br/>

`Hotkey`

Specifies the hotkey for the control.

**Example**

```xml
<Input Hotkey="Alt+I"/>
```

<br/>

![img](https://profitbasedocs.blob.core.windows.net/images/hotkeys.png)

<br/>

`StopClickEventPropagation`

Stops the click event from propagating up the DOM tree.


```xml
<Image Name="Image1" Click="ImageClicked('My image')" stopClickEventPropagation="true"/>
```

<br/>

## Videos

- [Form Schemas](../../../../videos/formschemas.md)

- [Controls - Basics](https://profitbasedocs.blob.core.windows.net/videos/Form%20Schema%20-%20Input%20Element.mp4)
