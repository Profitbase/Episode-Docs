
# Basic Column Properties


| Name                        | Description                         |
|-----------------------------|-------------------------------------|
| Name                        | The name of the column in the data set. Use the name for addressing the column in formulas. The name must be unique within the column set. Setting Columns can provide a localized caption based on the Name property if the value is registed in pbSimLangText and there is no Caption or Caption Expression providing an override Caption value.|
| Display Order Expression    | An expression that returns an int to define the column's display order, overriding the default schema arrangement. |
| Store Column Binding        | Specifies the id of the Data Store column that the grid column is bound to.|
| Default value               | Specifies a default value to assign to the cell when a new row is added to the grid. |
| Order by                    | Specifies if the Worksheet data set should be ordered by the values of the column when loaded from the server. <br/> *Priority* must be greater than 0 to order the data set by the column. Priority also specifies the index of the column in the order by clause. <br/> *Sort Descending* specifies if the values of the column should be sorted in descending order instead of ascending.|
| Trim whitespace on save     | Specifies whether to remove leading and trailing whicespace characters from text column values when data is saved to the database. Dropdown or Ranked Input columns will only be trimmed if this property is set to True. Standard text input columns will be trimmed unless the value is explicitly set to False.| 
| Context Menu Actions        | Specifies custom context menu actions for the column. These are additions to the context menu actions provided by the system. |
| Extension Context Menu Actions | This property enables adding custom context menu actions to Worksheets that are deployed and upgraded through a Package. Extension Context Menu Actions are preserved during Package upgrades, meaning customers / partners can extend products such as Planner with custom business logic triggered via the context menu. See [notes](#note-about-extension-context-menu-actions) below. |
| Is Action Link Column       | Specifies whether the column should be an Action Link Column. The values of Action Link Columns are displayed as hyperlinks, and cannot be edited by the user. When clicked, an event is raised in the Workbook context containing information about the clicked row, action and column. |
| Format string               | Specifies the format string used to display the rendered value of the column. |
| Width type                  | Specifies how the column should be sized. |
| Width                       | Specifies the width if Width Type is set to Numeric. |
| Content Alignment           | Specifies the alignment of the cell values of the column. |
| Is Fixed                    | Specifies whether the column is fixed / pinned to the left side of the grid. |
| Conditional formatting      | Specifies styling and formatting rules for the column based on cell values. Due to performance reasons, we recommend specifying cell formatting using [Style Formulas](../calculations/cellnrowstylfunc.md), **SetRowStyle(…)** and **SetCellStyle(…)**, instead of the Conditional Formatting feature. |
| Summary function            | Specifies which summary function to apply the the column when the Summary Row feature of the data grid is enabled. Available functions are Default, Sum, Min, Max, Count, Average and None. For numeric columns, the default is Sum and for all other columns, the default is None. |

<br/>

#### Note about Extension Context Menu Actions 

> [!NOTE]
> Extension Context Menu Actions raise the [Extension Context Menu Action Executed](../../workbooks/components/table.md#extension-context-menu-action-executed) event, which is also preserved during Package upgrades.


<br/>

## Videos
* [Worksheet](../../../videos/worksheet.md)
* [Conditional Formatting](https://profitbasedocs.blob.core.windows.net/videos/Worksheet%20-%20Conditional%20Formating.mp4)