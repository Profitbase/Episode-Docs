
# Language Settings


### End-User Client Language Settings

Language settings can be set by each user individually from the Options settings at the right side of the Workbook menu bar. When choosing a language, this setting will apply to all Workbooks that the user has access to. 
<br/>

## For on-premise installation

A default language for the entire web site can be specified by editing the appsettings.json file and adding or editing the "DefaultCulture" appSetting as shown in the example below.

If the user has not selected a language, and there is no default language specified in the appsettings.json file, the language code used for localization will be "EN" (English).
  
>**Example**
 ```
"Localization": {
    "DefaultCulture": "NO"
  }
``` 

<br/>

## See Also
[Translations](../translationsloc.md)