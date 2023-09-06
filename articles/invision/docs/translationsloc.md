---
title: "Translations / Localization"
metaKeys: "Translations, Localization, for business modules and custom UI elements, Solution database, ItemID, Type, LangID, LangText, Updating, Resetting cache"
folderOnly: "false"
pageIndex: 25
---

### Translations for business modules and custom UI elements

Translations for business module components and custom UI elements are maintained in the **Solution database -> pbSimLangText** table.

The important columns are **ItemID**, **Type**, **LangID** and **LangText**.

**ItemID** contains the resource id of the text to be translated. When using the Localize-directive, an ItemID is passed as the argument.

For Settings and captions for Setting Columns, you do not need to use the Localize-directive to display language-specific texts. If there is an ItemID matching the column name or Setting name, the LangText will be displayed to the user unless the Name property of the Settings contains a value, or the Caption or Caption Expression of the column contains a value.

The **Type** column must contain a value if the ItemID is a value that should be translated on the client and not on the server. This is typically UI elements such as context menu items, filter line options in data grids, and other resources where the translated text is not resolved during a server callback.

For custom UI elements, such as Custom Context Menu Items, the value of the column should be **$AppUIResource**.

### Translations for platform managed UI elements

Translations for platform managed UI elements are maintained in the Solution database -> **pbSYS_LangText** and **pbSYS_MessageText** tables.

To add support for a new language, copy the rows in the table and change the LangID value.  
Make sure to first add the LangID to pbNameDefinitions in the Solution database, and pbLanguage in the pbAppFramework database.

### Updating / Resetting cache

For performance reasons, the contents of pbSimLangText is cached after the first request. Since the contents of the table is maintained outside InVision, you need to manually invalidate the cache to indicate that the caches refreshed from the database.

When pbSimLangText has been edited, you need to reset the cache by opening the Solution, go to the **Localization**-tab in the main screen, and press "**Reset Cache**".
<br/>

### See Also

- [How to's](translationsloc/howto.md)

<br/>

### Videos

- [Translations / Localization](../videos/localization.md)
