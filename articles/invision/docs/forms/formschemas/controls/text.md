
# Text

Inherits from [Text Control](textcontrol.md).

<br/>

Displays text that you can either specify explicitly or bind the Text property to a Model.

<br/>

![btn](https://profitbasedocs.blob.core.windows.net/images/headings2.png)




**Example**



This shows how the text can be set explicitly using the Text property.

```xml
    <Text Row="4" Column="1" Text="My Favorite Customer" />
```

<br/>

This shows how the Text property can be data bound to a Model property.

```xml
    <Text Row="5" Column="2" Text="{Binding Path:CustomerFormTable.CustomerName}" />
```

<br/>

![btn](https://profitbasedocs.blob.core.windows.net/images/headings3.png)

<br/>

This example shows how to enable localization by using the TextCode property. The Text property provides the fallback text if the text code could not be translated into the current user language.

```xml
    <Text CssClass="margin-top-5" Row="4" Column="1" Text="Year" TextCode="C_Year" />
```

<br/>



## Videos

- [Form Schemas](../../../../videos/formschemas.md)

- [Controls - Basics](https://profitbasedocs.blob.core.windows.net/videos/Form%20Schema%20-%20Input%20Element.mp4)
