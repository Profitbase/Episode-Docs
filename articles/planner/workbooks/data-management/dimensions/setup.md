---
title: "Setup"
metaKeys: ""
folderOnly: "false"
pageIndex: 6
---
# Overview - Import from / export to external source

Setup that controls how dimensional data is imported from and/or exported to external sources and targets.

![](https://profitbasedocs.blob.core.windows.net/enduserhelp/images/DimensionSetup.JPG)

### Column Descriptions

- **Dimension**<br/>
The dimension in question. Readonly.
- **(Import) Enabled**<br/>
Check if import from dimension is enabled, uncheck if not. Mandatory.
- **Type of source**<br/>
The default and preferred external source for dimensional data is a parent/child type source. For compatibility reasons, a fixed wide source is also supported. It is highly recommended to use a parent/child source. Mandatory. Select from drop down list.
- **Object Name**<br/>
The target to which external data will be imported. Readonly.
- **Overwrite user edits**<br/>
Check if local edits made to dimension members (directly in the dimension editor) should be overwritten on import, uncheck if not. Mandatory.
- **Import empty values**<br/>
Check if empty values are allowed to be imported, uncheck if not. Mandatory.
- **(Export) Enabled**<br/>
Check if export of dimensional data is to be enabled, uncheck if not. Mandatory.
- **Comment**<br/>
Free text comment. Optional.
