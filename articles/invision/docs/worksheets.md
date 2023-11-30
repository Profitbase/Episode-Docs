
# Worksheets

The contents of [Data Stores](datastores.md) are edited using Worksheets, which have an Excel-like look and feel. You would normally have just one Worksheet per Data Store, but you can have as many as you like. As long as any primary key columns of the Data Store is bound to the Worksheet, the other columns are optional.

A Worksheet is always associated with just one Data Store, and once it has been created, **you cannot change the binding**.

You can however, include data from other sources such as tables, views, stores, dimensions or fact tables to make calculations and save that value to the connected datastore.

A Worksheet must be added to a Workbook to make it available to an end-user. Once a Worksheet had been added to a Workbook, [identities](accesscontrol/identities.md) can view, edit, and save data to the datastore through this worksheet.

The contents of the Worksheet displayed to a user can be restricted by defining permissions for dimensions used for filtering, the static filter on the Worksheet component of a [Workbook](workbooks.md), or by specifying a dynamic filter when loading data in a Workbook context.
<br/>

## Creating a Worksheet

To create a Worksheet, right-click a Data Store in the Solution Explorer and select "New Worksheet". The newly created Worksheet will be bound to the Data Store, from which you can add columns and [dimensions](dimensions.md) when designing the layout of the sheet.
<br/>

## Adding columns

Columns can be added to a Worksheet by drag and drop and droping from the toolbox, or pressing the «Add Many» button of the Columns list in the Worksheet designer.

When creating a Worksheet, all key columns of the Data Store must be added to the Worksheet and the Worksheet must be configured in a way that ensures that all key columns are assigned values before data is saved to the database. If you do not want to show the key columns to the user, set the IsHidden property of each column to "True".

In many cases, you would want to hide ID-columns and rather show a descriptive text or value instead. For example, suppose you have a Worksheet containing employees, you’d rather see the employee name (maybe combined with an id) than just the employee id in your Worksheet.

To do this, you need Dimensions bound to your Data Store. The dimensions contain the member ids and properties, such as names, descriptions, etc. To display one of these properties in the Worksheet in addition to the id of the entity, drag the property (column) you want to display from a dimension in the Dimensions-section of the Worksheet designer Toolbox.
Referring to our employee-example, you would add and bind the Employee dimension to your Data Store and add the Employee_Name column from the Dimension to the Worksheet.

When a dimension property column is used in a Worksheet, the Id-column can be edited by enabling the property column as a Dropdown editor column. When editing using a DrodDown column, the Id-column should be read-only, since editing the Id-column will not update the value in the Dropdown/property column.

<br/>

## See Also

- [How to's](worksheets/howto.md)
- [Calculations](worksheets/calculations.md)
- [Cell Validation](worksheets/cellvalidation.md)
- [Column Captions](worksheets/colcaptions.md)
- [Conditional Read Only State](worksheets/conditcellreadonly.md)
- [Custom Querry](worksheets/customquery.md)
- [Custom Rows](worksheets/customrows.md)
- [Column Properties](worksheets/columnproperties.md)
- [Filters](worksheets/filters.md)
- [On Save](worksheets/onsave.md)
- [Row Styling](worksheets/rowstyling.md)
- [Stacked Column Headers](worksheets/stackedcolhead.md)
- [Worksheet Properties](worksheets/wproperties.md)

<br/>

## Videos

- [Worksheets](../videos/worksheet.md)
