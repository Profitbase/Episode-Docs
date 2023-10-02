---
title: "How to Configure Translation of Dimensions Name"
metaKeys: "How to configure translation of Dimension Name"
folderOnly: "false"
pageIndex: 3
---

### Link to the video

Under [this link](https://profitbasedocs.blob.core.windows.net/videos/Dim%20Translations%20Name.mp4) you will find video that shows how to configure translation of dimensions name.

### How to Configure Translation of Dimensions Name


1. Open the Dimension in the Designer,
2. Go to the Properties tab,
3. In the Name Expression field, provide either a text code that is registered in the Localization table, or use the ``@Object[...].Lookup[condition][ValueColumn]`` directive to use a custom table for translations.

<br/>


### Option 1 

>**Use text code translations.**


1. In the Name Expression field, add a text code, for example, Account:

![pic](https://profitbasedocs.blob.core.windows.net/images/TransDoc1.png)

<br/>


2.  Add a translation to the Custom Texts table in the Localization screen if it does not already exist:

![pic](https://profitbasedocs.blob.core.windows.net/images/TransDoc2.png)

<br/>



### Option 2 

>**Use the @Object[...].Lookup directive.**


1. Create a table to store the translations. For example, it can contain the columns Name, LangID and LangText.

![pic](https://profitbasedocs.blob.core.windows.net/images/TransDoc3.png)

<br/>


2.  In the Name Expression field, use the @Object[...].Lookup directive to specify the translation

For example

``@Object[Custom Translations].Lookup[{"Name": "PC Dim", "LangID": "@LanguageTwoLetter"}][LangText]``

The lookup will search the Name and LangID columns for the values matching the criteria ("PC Dim" and @Language), and then return the value found in the LangText column.


> [!NOTE]
>  that @**LanguageTwoLetter** is a special keyword recognized by the system, which has two-letter language code of the currently logged in user, for example, EN or NO.

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/TransDoc4.png)

<br/>