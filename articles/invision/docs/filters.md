---
title: "Filters"
metaKeys: "Filters, Properties, Creating, components,  Solution, by Hierarchy, Column,  "
folderOnly: "false"
pageIndex: 12
---

Filters are components used for setting the data context for Settings, [Worksheets](worksheets.md), [Reports](sqlreports.md), [Workflows](workflow.md), and [Data Flows](dataflows.md).

Once a Filter is defined, it can be used by all data context-aware components in a Solution by binding the Filter to a property of the component.

A Filter is defined as a reference to table resource ([Dimension](dimensions.md), Fact, Setting, [Data Store](datastores.md), or a [View](views.md)) and by a configuration describing how to read data from the [table](tables.md) resource.
<br/>

### Creating a Filter

Filters are contained in **Filter Collections** and can be created from Data Stores, Settings, Dimensions, and Views. To create a Filter, you first need a Filter Container. Filter Containers are added to the Solution from the Solution Explorer and can contain any number of Filters.

To create a Filter, open a Filter Container and drag a table resource from the Toolbox to the All Filters list. When the filter is created, it is given a default name. You need to make sure that the name of the filter is unique within the Solution (filters).

When using a Dimension as the table resource, you can choose between "Filter by Hierarchy" a "Filter by Column" as the Filter Mode (see description below). Non-dimension table resources only allow the "Filter By Column" Filter Mode.
<br/>

![Filter](https://profitbasedocs.blob.core.windows.net/images/filterscreating.png)
<br/>

### Filter Properties

<br/>

**Filter Name**

> When a filter is created, it is given a default name. You need to make sure that the name is unique within the Solution (filters).

<br/>

**Description**

> Description field for the filter. Only used for dev/doc purposes.

<br/>

**Filter Mode**

_Filter by Hierarchy_

> Only available for Dimension based filters. Specifies that the dimension hierarchy information is used to render the filter and to set the data context of the filter consumers (Worksheets, Reports, Settings, etc).

_Filter by Column_

> Available for any filter type. Specifies that a specific column is used for setting the data context of the filter consumers. Using this mode, the filter cannot be rendered as a tree structure even though the underlying resource is a Dimension.

_Custom Text Search Index_

> Enables text search when the filter rendering type is set to SearchBox in the Workbook filter configuration editor.  
> When enabling this property, you need to specify the Text Search Column property. The Text Search Column of the table resource should contain the text used for matching the user search criteria.

_Data Id Column_

> If the Filter Mode is Filter by Hierarchy, this property is automatically set and cannot be changed. When setting Filter Mode to **Filter by Column**, you need to specify which column in the table resource contains the values to filter by.

_Hierarchy_

> Available only for Dimension based filters, this property specifies which hierarchy to use when rendering and setting the data context for consumers of the filter.

_Order_

> Available for Dimension based filters. This property specifies whether to apply no sorting or sort by the id or display value.

- None - No order is applied

- Default – Uses the attribute sort type to determine whether to sort by Key or Name (display value)

- OrderById – Orders by the dimension attribute key of the level

- OrderByDescription – Orders by the dimension attribute display value of the level (takes the selected language into account)

_Description Column_

> Available only if Filter Mode is set to **Filter by Column**, this property specifies which column from the table resource to display when rendering the filter items.  
> If you enable _Localize Description_, InVision looks for a column named `<description column>_<languagecode>` (for example ProductID_Name_EN) and if found, will use the values from that column to display the filter items.

_Localize Description_

> Available only if Filter Mode is set to Filter by Column, this property specifies that InVision should look for a column named `<description column>_<languagecode>` (for example ProductID_Name_EN) and if found, will use the values from that column to display the filter items.

_Text Search Column_

> Available when the Custom Text Search Index is enabled, this property specifies the column of the table resource containing the text used for matching the user search criteria.

_Order By Clause_

> A SQL expression used as the ORDER BY clause to order the filter items displayed to the user. This option is only available for Flat filters. You need to type the actual Order By expression, not only the column name, for example, ORDER BY ItemID.

_Slice Expression_

> A SQL expression used in a WHERE clause to limit the filter items displayed to the user. If you use custom parameters in the slice expression, the following rules apply when the filter is used in a Workbook context:

1. You have to specify the parameter values in the LoadData action using the [SetParamValue(…)]() function.

2. On subsequent filter record requests to the database, the values resolved in the LoadData action are resent, except when the SetFilterValue action is invoked.

3. If you use the SetFilterValue action, you need to specify the parameter values using the [SetParamValue(…)]() function. Any values resolved during the LoadData action are ignored.

4. Auto Complete filters do not support custom parameters in the slice expression.

_Dynamic Slice Expressions_

> Sometimes you need to apply different types of business logic based on which level in hierarchical filters are expanded, for example, you need to filter on different attributes/columns based on which level is being expanded.

**@LoadLevel** – This system provided parameter specifies which level is being loaded (expanded)

> **Example**
>
> The following Slice Expression applies a specific business logic for level 1

    ProjectStatusID = CASE WHEN @LoadLevel = 1 THEN 'N' ELSE ProjectStatusID END

_Default Value Expression_

> A SQL snippet used in a WHERE clause to resolve the initially selected value of the filter when it’s rendered. If the Filter Mode is "Filter by Hierarchy" and there is a default member specified for the dimension as part of the Data Access permissions, the Data Access permission wins.

<br/>

### See Also


- [How to's](filters/howto.md)
- [Filtering Tables](tables/filters.md)
- [Filtering Worksheets](worksheets/filters.md)

### Videos

- [Filters](../videos/filters.md)
- [Creating and Using Flat Filters](https://profitbasedocs.blob.core.windows.net/videos/Filters%20-%20Creating%20and%20using%20flat%20filters.mp4)
- [Creating and Using Hierarchical Filters](https://profitbasedocs.blob.core.windows.net/videos/Filter%20-%20Creating%20and%20using%20hierarchical%20filters.mp4)
- [Default Selection and Slicing](https://profitbasedocs.blob.core.windows.net/videos/Filter-DefaultSelection%20and%20Slicing.mp4)
