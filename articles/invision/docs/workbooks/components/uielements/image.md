

# Image
 
<br/>

![btn](https://profitbasedocs.blob.core.windows.net/images/picc.png)

<br/>



Displays an image in a Workbook. Use the LoadData action and call the [SetSrc(…)](../../programmingmodel/instructions/setsrc.md) function to specify the image source (url) dynamically, or set the **Source property** to specify a static or initial image source.

## Actions

* **LoadData**  
  Use this action to refresh the image displayed by calling the [SetSrc(…)](../../programmingmodel/instructions/setsrc.md) function. If you just want to display a static image, specify the url in the Source property of the component.


**Example**
>
>Call the following function in the LoadData action of the Image to change the image to display.
>
>"AssetLib" is a table in a Solution, having and "ID" and "FileName" column. In this example, FileName contains the path and name of the file.
Use the "asFile" query string parameter to specify that you want the API to server the actual file specified in the FileName column, not file name itself.  
>
>If "FileName" contained the actual file (binaries), you would not have to specify the "asFile" options.
>
>     SetSrc(ApiBase() + "/api/db/objects/AssetLib/FileName?q={ID == \"MyImg\"}&asFile=true");



## Videos

* [Styling - Using Custom Images](../../../../videos/themesandstyles.md)