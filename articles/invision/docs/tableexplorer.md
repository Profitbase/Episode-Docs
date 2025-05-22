# Table Explorer
The purpose of Table Explorer is to easily find one or more tables for a certain work area and start editing the table contents.

![pic](https://profitbasedocs.blob.core.windows.net/images/table_explorer_web_purpose.png)

<br/>

## Properties set on Table entity in the Listing-tab


| Name                      | Type     | Description |
|---------------------------|----------|-------------|
| Display in Table Explorer(s) | Optional | Toggles the visibility of the table in the Table Explorer(s). |
| Context                   | Optional | A filter property used to limit where the table appears. Enter one or more keywords, separated by semicolons (;). These keywords act as filters in relevant views or features. [Context and context filtering](./tableexplorer/howto/context.md) |
| Short Description         | Optional | Shown as a subtitle for the table in the Table Explorer. This text can be localized using the associated "Text code". |
| Tags                      | Required | At least one tag is required. Tags help categorize and filter tables. Each tag supports localization via the provided "Text code". A table can have multiple tags. |

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/table_listing_configuration.png)

<br/>
<br/>

## Place on a workbook page
The table explorer must be placed on a Workbook [Page](./workbooks/pages.md) and configured with the nesscary properties.

| Name                     | Type       | Description          |
|--------------------------|------------|-------------------|
| Context filter                 | Optional   | A filter property. Defines which tables should appear. If this is left blank, all tables in the solution will appear. [Context and context filtering](./tableexplorer/howto/context.md)            |

<br/>

![pic](https://profitbasedocs.blob.core.windows.net/images/table_explorer_workbook_page.png)

<br/>

Ensure to load tables into the component in the Workbook when needed.

![pic](https://profitbasedocs.blob.core.windows.net/images/table_explorer_workbook_interaction.png)

<br/>

## See Also

- [Context filtering](./tableexplorer/howto/context.md)

- [Search](./tableexplorer/howto/search.md)

- [Edit](./tableexplorer/howto/edit.md)
