# SetSrc function

<br/>

```
SetSrc(url : string)
```
This function sets the Image source of an Image Workbook component when called in its Load Data Action.
<br/>

## Example

"AssetLib" is a table in a Solution, having and "ID" and "FileName" column.

Use the "asFile" query string parameter to specify that you want the contents of the FileName column to be returned as a File Stream instead of a string.
If "FileName" contained the actual file (binaries), you would not have to specify the "asFile" options.

```
SetSrc(ApiBase() + "/api/db/objects/AssetLib/FileName?q={ID==\"WarningImg\"}&asFile=true");
```



